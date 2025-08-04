using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using Microsoft.Graph.Models;
// This new using statement is required for the V5 request body
using Microsoft.Graph.Users.Item.SendMail;
using Microsoft.Identity.Client;
using Microsoft.Kiota.Abstractions.Authentication; // Required for V5 authentication
using System.Threading.Tasks;

namespace BlackListWebApp.Services
{
    public class GraphEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly GraphServiceClient _graphClient;

        public GraphEmailService(IConfiguration configuration)
        {
            _configuration = configuration;

            // --- Client creation is now different in V5 ---
            var clientId = _configuration["AzureAd:ClientId"];
            var tenantId = _configuration["AzureAd:TenantId"];
            var clientSecret = _configuration["AzureAd:ClientSecret"];

            var confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithTenantId(tenantId)
                .WithClientSecret(clientSecret)
                .Build();

            var authProvider = new BaseBearerTokenAuthenticationProvider(
                new TokenProvider(confidentialClientApplication)
            );

            _graphClient = new GraphServiceClient(authProvider);
        }

        public async Task<string> GetBlacklistDetectionTemplate()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"EmailTemplates", "BlacklistDetectionBody.html");
            string templatePath = await File.ReadAllTextAsync(path);
            return templatePath;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string fullName, DateTime dateTime)
        {
            try
            {
                // Read the entire HTML template
                string emailBody = await GetBlacklistDetectionTemplate();
                // Replace placeholders with actual values
                emailBody = emailBody.Replace("#fullname", fullName)
                                    .Replace("#timestamp", dateTime.ToString("MMMM dd, yyyy"))
                                    .Replace("#current_year", DateTime.Now.Year.ToString());

                var fromAddress = _configuration["Mailbox:Address"];

                var message = new Message
                {
                    Subject = subject,
                    Body = new ItemBody
                    {
                        ContentType = BodyType.Html,
                        Content = emailBody
                    },
                    ToRecipients = new List<Recipient>
                    {
                        new Recipient { EmailAddress = new EmailAddress { Address = toEmail } }
                    }
                };

                // --- THIS IS THE CRITICAL CHANGE FOR SENDING MAIL in V5 ---
                // Create a request body object
                var requestBody = new SendMailPostRequestBody
                {
                    Message = message,
                    SaveToSentItems = true
                };

                // Call PostAsync on the SendMail property, passing the request body
                await _graphClient.Users[fromAddress]
                    .SendMail
                    .PostAsync(requestBody);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new InvalidOperationException("Failed to send email", ex);
            }

        }
    }

    // Helper class for the new V5 authentication model
    public class TokenProvider : IAccessTokenProvider
    {
        private readonly IConfidentialClientApplication _confidentialClientApplication;
        private readonly string[] _scopes = { "https://graph.microsoft.com/.default" };

        public TokenProvider(IConfidentialClientApplication confidentialClientApplication)
        {
            _confidentialClientApplication = confidentialClientApplication;
        }

        public async Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object> additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
        {
            var authResult = await _confidentialClientApplication
                .AcquireTokenForClient(_scopes)
                .ExecuteAsync(cancellationToken);

            return authResult.AccessToken;
        }

        public AllowedHostsValidator AllowedHostsValidator { get; } = new AllowedHostsValidator(new[] { "graph.microsoft.com" });
    }
}
