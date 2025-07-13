# Black List Web App

**Latest Update: June 30, 2025 - Professional Design Implementation Complete**

## Recent Changes
- ✅ **Professional Light Theme**: Complete redesign with modern, professional styling
- ✅ **Color Scheme**: Replaced colorful gradients with clean gray-scale professional palette
- ✅ **Navigation**: Clean white background with subtle hover states
- ✅ **Cards & Components**: Minimal shadows, clean borders, and professional styling
- ✅ **Details Page**: Fixed table content, removed red backgrounds, completed all missing sections
- ✅ **Responsive Design**: Mobile-friendly layout with consistent spacing
- ✅ **Status Messages**: Professional alert styling throughout the application

## Application Overview
A professional BlackList Management System for airline passenger screening with a clean, modern interface suitable for business environments.

## Technology Stack
- **Framework**: ASP.NET Core Blazor Server (.NET 8)
- **Styling**: Custom CSS with professional light theme
- **UI Components**: Bootstrap 5 with custom professional styling
- **Architecture**: Clean, modular component-based design

## Features Implemented
### ✅ Home Dashboard
- Professional statistics cards showing blacklist metrics
- Clean, modern card-based layout with subtle shadows
- Responsive design for all screen sizes

### ✅ Details Page (Complete)
- Comprehensive passenger details with filtering and search
- Statistics overview with color-coded status indicators
- Detailed passenger information table with pagination
- Modal dialogs for viewing complete passenger profiles
- Sample flight booking integration examples
- Professional styling without red row backgrounds

### ✅ Manage BlackList Page
- Full CRUD operations for blacklist management
- Add, edit, and delete passenger records
- Professional form styling and validation
- Status messages for all user actions

# Global Instructions for BlackListWebApp

- Don't invent new patterns if there's already a solution in the codebase.
- Keep solutions simple and modular.
- Never duplicate code.
- Write code aware of dev, test, and prod environments.
- Keep files under 300 lines.
- Always follow the existing code style.
- Always use the main css file for styling.
- Use the existing components and utilities for common tasks.
- Use the existing professional light theme and color palette.
- Always follow the existing Theme and use the existing colors.
- Always use the database models and the existing services for the data access.
- Do not use any hardcoded values.
- Always use the existing services for the API calls.
- For Database always use the existing Entity Framework DbContext and the existing repositories.
- Always use BlackListService for data access operations.
- Always use the existing services for the authentication and authorization.
- In each place always add html alerts and status messages for the user actions in the UI and make all pages consistent in this regard.
- Make sure all modals and popup are same in design and css and inputs css.
- It is important to add status messages in every action, also make sure to follow the design and theme.
- Always create files in the correct folder structure.

- Don’t invent new patterns if there’s already a solution in the codebase.
- Keep solutions simple and modular.
- Never duplicate code.
- Write code aware of dev, test, and prod environments.
- Keep files under 300 lines.
- Always follow the existing code style.
- Always use the main css file for styling.
- Use the existing components and utilities for common tasks.
- use the existing style for the components.
- Always follow the existing Theme and use the existing colors.
- Alwats user the database models and the existing services for the data access.
- Do not use any hardcoded values.
- Always use the existing services for the API calls.
- for Database always use the existing Entity Framework DbContext and the existing repositories.
- Always use HorseshubdbContext for the database access.
- Always use the existing services for the authentication and authorization.
- in each place always add html alerts and status messages for the user actions in the UI and make all pages consistent in this regard.
- Make sure all modals and popup are same in design and css and inputs css
- it is importatnt to add status messages in every action, also make sure to follow the design and theme
- Always create files in the correct folder structure.

## Feature Status

# Dashboard page
- ✅ Card for today total black list passengers
- ✅ Card for this week total black list passengers  
- ✅ Card for this month total black list passengers
- ✅ Card for list of this week black list passengers
- ✅ Professional design with sample data in cards and lists
- ✅ Responsive layout with modern styling

# Manage Black List page
- ✅ Table for black list passengers with columns: First, Last Name, Reason, Start Date, End Date, Actions
- ✅ Button to add new black list passenger
- ✅ Modal to add new black list passenger with fields: First Name, Last Name, Reason, Start Date, End Date
- ✅ Button to edit black list passenger
- ✅ Modal to edit black list passenger with fields: First Name, Last Name, Reason, Start Date, End Date
- ✅ Button to delete black list passenger
- ✅ Confirmation modal for deleting black list passenger
- ✅ Status messages for actions (success, error, etc.)
- ✅ Pagination for the table
- ✅ Search functionality for the table by First Name, Last Name
- ✅ Professional styling with sample data in the table

# Black List Details page
- ✅ Display details of the black list passenger that are flying or booked a flight from today and future dates
- ✅ User can click on the passenger name to view their details as a modal
- ✅ Professional table layout without red row backgrounds
- ✅ Complete passenger information display
- ✅ Sample data integrated in the details view and table
- ✅ Search and filtering functionality
- ✅ Pagination for large datasets
- ✅ Statistics cards showing active bans, expiring soon, long-term, and total counts
- ✅ Sample flight booking integration examples with XML API demonstration

## Design System
- ✅ **Professional Color Palette**: Gray-scale based with blue primary colors
- ✅ **Typography**: Clean, readable Inter font family
- ✅ **Components**: Consistent button, card, modal, and form styling
- ✅ **Spacing**: Uniform padding and margins throughout
- ✅ **Shadows**: Subtle, professional shadow effects
- ✅ **Animations**: Minimal, smooth transitions

## Sample API Integration
The application includes sample integration with airline reservation systems using SOAP/XML APIs. Below is the structure for passenger data integration:

''' xml
<?xml version="1.0" encoding="UTF-8"?>
<soap-env:Envelope xmlns:soap-env="http://schemas.xmlsoap.org/soap/envelope/">
    <soap-env:Header>
        <eb:MessageHeader xmlns:eb="http://www.ebxml.org/namespaces/messageHeader" eb:version="1.0" soap-env:mustUnderstand="1">
            <eb:From>
                <eb:PartyId eb:type="URI">Server</eb:PartyId>
            </eb:From>
            <eb:To>
                <eb:PartyId eb:type="URI">Client</eb:PartyId>
            </eb:To>
            <eb:CPAId>IPCC</eb:CPAId>
            <eb:ConversationId>9DB7_921682_1204548352874</eb:ConversationId>
            <eb:Service>Trip_SearchRQ</eb:Service>
            <eb:Action>Trip_SearchRQ</eb:Action>
            <eb:MessageData>
                <eb:MessageId>1015927388785891460</eb:MessageId>
                <eb:Timestamp>2025-06-30T10:47:59</eb:Timestamp>
                <eb:RefToMessageId>mid:1</eb:RefToMessageId>
            </eb:MessageData>
        </eb:MessageHeader>
        <wsse:Security xmlns:wsse="http://schemas.xmlsoap.org/ws/2002/12/secext">
            <wsse:BinarySecurityToken valueType="String" EncodingType="wsse:Base64Binary">Shared/IDL:IceSess\/SessMgr:1\.0.IDL/Common/!ICESMS\/ACPCRTD!ICESMSLB\/CRT.LB!1751280463967!7415!533</wsse:BinarySecurityToken>
        </wsse:Security>
    </soap-env:Header>
    <soap-env:Body>
        <Trip_SearchRS xmlns="http://webservices.sabre.com/triprecord" xmlns:ns2="http://services.sabre.com/STL/v01" xmlns:ns4="http://webservices.sabre.com/sabreXML/2003/07" xmlns:ns3="http://webservices.sabre.com/pnrbuilder" xmlns:ns6="http://tds.sabre.com/itinerary" xmlns:ns5="http://tds.sabre.com/rules" xmlns:ns8="http://services.sabre.com/STL/v02" xmlns:ns7="http://services.sabre.com/res/orr/v0" xmlns:ns13="http://www.sabre.com/eps/schemas" xmlns:tir37="http://services.sabre.com/res/tir/v3_7" xmlns:ns12="http://opentravel.org/common/v02" xmlns:ns9="http://www.sabre.com/ssg/des/v1" xmlns:ns11="http://www.OpenTravel.org/ns/OTA2/AppInfo_v01_00" xmlns:tir39="http://services.sabre.com/res/tir/v3_9" xmlns:ns10="http://services.sabre.com/STL_Header/v02_00" xmlns:ns21="http://services.sabre.com/res/or/v1_14" xmlns:ns15="http://webservices.sabre.com/servicesplatform/orr/rules/1.0.0" xmlns:ns14="http://tds.sabre.com/distribution" xmlns:stl115="http://webservices.sabre.com/pnrbuilder/v1_15" xmlns:or16="http://services.sabre.com/res/or/v1_6" xmlns:or18="http://services.sabre.com/res/or/v1_8" xmlns:or19="http://services.sabre.com/res/or/v1_9" xmlns:stl119="http://webservices.sabre.com/pnrbuilder/v1_19" TimeStamp="2025-06-30T05:47:58" Target="Production" Version="4.5.0">
            <Success>Success</Success>
            <ReservationsList NumberResults="14" NumberPages="1" TotalResults="14">
                <Reservations>
                    <Reservation Locator="RWCZZJ">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>RWCZZJ</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-02-11T22:45:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-02-11T22:45:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-04-13T04:18:05</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>23</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-04-16T20:15:00" Start="2025-04-16T18:05:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-08T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>-493214aad44b1b65322647549b5289a1193827adb00fbae3</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="13" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>97317338780/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 97317338780/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="14" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="71" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHDXB0510D16APR/0722134843418C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134843418</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHDXB0510D16APR/0722134843418C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="73" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHDXB0510D16APR/0722134843419C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134843419</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHDXB0510D16APR/0722134843419C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="78" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/JF</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 510D16APR/JF NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="80" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/JF</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 510D16APR/JF NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="12" type="A">
                                                        <stl19:DateOfBirth>2000-02-02</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>BAH</stl19:Airport>
                                            <stl19:Departure>2025-04-16T18:05:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="69" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="3" ResBookDesigCode="D" SmokingAllowed="false" SpecialMeal="false" id="69" isPast="true" segmentAssociationId="5" sequence="1">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>DXB</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0510</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>320</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0510</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>D</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>D</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-04-16T18:05:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-04-16T20:15:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0510</stl19:FlightNumber>
                                                <stl19:ClassOfService>D</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="71" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHDXB0510D16APR/0722134843418C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134843418</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHDXB0510D16APR/0722134843418C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="73" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHDXB0510D16APR/0722134843419C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134843419</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHDXB0510D16APR/0722134843419C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="78" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/JF</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 510D16APR/JF NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="80" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/JF</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 510D16APR/JF NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-02-11T23:45:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BAH</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>BH</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="32" sequence="2">
                                            <stl19:General dayOfWeekInd="4" isPast="false">
                                                <stl19:Line Number="2" Status="HK" Type="OTH"/>
                                                <stl19:Vendor Code="GF"/>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:Location LocationCode="BAH"/>
                                                <stl19:DateTime>2026-01-08T00:00:00</stl19:DateTime>
                                                <stl19:Text>PNR RETENTION</stl19:Text>
                                            </stl19:General>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-76" id="76" index="1">
                                            <stl19:Code>T-12FEB-WWG4HLI</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-28" id="28" index="2">TE 0722134843410 TEST/A BAH4ND1 0801/12FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-42" id="42" index="3">TE 0722134843412 TEST /A SYSSYS  2323/11FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-59" id="59" index="4">TE 0722134843418 TEST/A WWG4HLI 0836/12FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-75" id="75" index="5">TE 0722134843419 TEST/A WWG4HLI 0848/12FEB</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-28" id="28" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134843410 TEST/A BAH4ND1 0801/12FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134843410</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-12T08:01:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-42" id="42" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134843412 TEST /A SYSSYS  2323/11FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134843412</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST /A</stl19:PassengerName>
                                            <stl19:AgencyLocation>SYS</stl19:AgencyLocation>
                                            <stl19:DutyCode/>
                                            <stl19:AgentSine>SYS</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-11T23:23:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-59" id="59" index="4">
                                            <stl19:OriginalTicketDetails>TE 0722134843418 TEST/A WWG4HLI 0836/12FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134843418</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>WWG</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>HLI</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-12T08:36:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-75" id="75" index="5">
                                            <stl19:OriginalTicketDetails>TE 0722134843419 TEST/A WWG4HLI 0848/12FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134843419</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>WWG</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>HLI</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-12T08:48:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="7" type="O">
                                                <stl19:Text>GULF AIR HEAD QUARTER</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="8" type="O">
                                                <stl19:Text>MANAMA</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="9" type="O">
                                                <stl19:Text>MANAMA, BH BAH</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>93-17373737-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-15" id="15" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID GULF AIR</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-16" id="16" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME GULF AIR</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-17" id="17" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>07491794-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-18" id="18" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS HEAD OFFICE ADDRESS P.O. BOX 58. CITY MANAMA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-19" id="19" index="5" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>COUNTRY BHR EMAIL SUPPORT//TPCONNECTS.COM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-20" id="20" index="6" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY PRIME CONTACT NAME ADMIN PHONE 77877978</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-24" id="24" index="7" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>TICKET PNR BY 16FEB25 0445GMT OR WILL BE CANCELED BY GF SYSTEM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-29" id="29" index="8" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-82" id="82" index="9" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>POSSIBLE DUPE PNR WITH TLKWMY</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-83" id="83" index="10" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>PLEASE CONFIRM WITH PASSENGER OR SUBJECT TO CANCELLATION</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="SMPMRP">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="9" numberInParty="9" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>SMPMRP</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-02-07T06:33:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-02-07T06:33:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-02-07T06:40:20</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>21</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-02-07T22:40:00" Start="2025-02-07T19:05:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-03T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>4f02e9cbf86fda2bc9f2400ff5995f281d5dde2232861f17</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MANISH MR</stl19:FirstName>
                                            <stl19:EmailAddress id="13">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="47" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>78654328/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 78654328/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="48" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>LEVEL2//GMAIL.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE LEVEL2//GMAIL.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="56" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="57" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="75" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521245C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521245</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521245C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="76" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521245C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521245</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521245C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="149" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="150" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="152" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="153" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="38" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551111</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-16</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MANISH MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-4.2" id="4" nameAssocId="2" nameId="02.01" nameType="S" referenceNumber="A02">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MURALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="14">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="58" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="59" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="79" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521246C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521246</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521246C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="80" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521246C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521246</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521246C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="155" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="156" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="158" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="159" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="39" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551311</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-19</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MURALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-5.3" id="5" nameAssocId="3" nameId="03.01" nameType="S" referenceNumber="A03">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>RAJA MR</stl19:FirstName>
                                            <stl19:EmailAddress id="15">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="60" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="61" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="83" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521247C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521247</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521247C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="84" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521247C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521247</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521247C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="161" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="162" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="164" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="165" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="40" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551411</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-20</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>RAJA MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-6.4" id="6" nameAssocId="4" nameId="04.01" nameType="S" referenceNumber="A04">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MUKUND MR</stl19:FirstName>
                                            <stl19:EmailAddress id="16">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="62" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="63" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="87" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521248C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521248</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521248C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="88" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521248C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521248</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521248C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="125" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="126" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="128" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="129" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="41" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551511</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-21</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MUKUND MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-7.5" id="7" nameAssocId="5" nameId="05.01" nameType="S" referenceNumber="A05">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>VEER MR</stl19:FirstName>
                                            <stl19:EmailAddress id="17">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="64" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="65" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="91" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521249C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521249</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521249C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="92" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521249C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521249</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521249C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="131" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="132" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="134" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="135" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="42" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551412</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-09-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>VEER MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-8.6" id="8" nameAssocId="6" nameId="06.01" nameType="S" referenceNumber="A06">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ROOP MR</stl19:FirstName>
                                            <stl19:EmailAddress id="18">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="66" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="67" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="95" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521250C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521250</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521250C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="96" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521250C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521250</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521250C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="137" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="138" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="140" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="141" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="43" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551413</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-10-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ROOP MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-9.7" id="9" nameAssocId="7" nameId="07.01" nameType="S" referenceNumber="A07">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>SID MR</stl19:FirstName>
                                            <stl19:EmailAddress id="19">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="68" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="69" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="99" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521251C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521251</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521251C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="100" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521251C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521251</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521251C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="143" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="144" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="146" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="147" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="44" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551414</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-06-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>SID MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-10.8" id="10" nameAssocId="8" nameId="08.01" nameType="S" referenceNumber="A08">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MALAVIKA MRS</stl19:FirstName>
                                            <stl19:EmailAddress id="20">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="70" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="71" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="103" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521252C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521252</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521252C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="104" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521252C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521252</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521252C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="167" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="168" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="170" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="171" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="45" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551415</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-05-10</stl19:DateOfBirth>
                                                        <stl19:Gender>F</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MALAVIKA MRS</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-11.9" id="11" nameAssocId="9" nameId="09.01" nameType="S" referenceNumber="A09">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>KRISHNA MRS</stl19:FirstName>
                                            <stl19:EmailAddress id="21">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="72" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="73" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="107" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521253C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521253</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521253C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="108" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521253C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134521253</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521253C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="173" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="174" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="176" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="177" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="46" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551416</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1984-11-22</stl19:DateOfBirth>
                                                        <stl19:Gender>F</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>KRISHNA MRS</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>DXB</stl19:Airport>
                                            <stl19:Departure>2025-02-07T19:05:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="36" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="5" ResBookDesigCode="B" SmokingAllowed="false" SpecialMeal="false" id="36" isPast="true" segmentAssociationId="2" sequence="1">
                                                <stl19:DepartureAirport>DXB</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>BAH</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0509</stl19:OperatingFlightNumber>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0509</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>B</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>B</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>1</stl19:Group>
                                                    <stl19:Sequence>1</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-02-07T19:05:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-02-07T19:30:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0509</stl19:FlightNumber>
                                                <stl19:ClassOfService>B</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>9</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="56" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="58" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="60" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="62" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="64" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="66" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="68" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="70" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="72" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 509B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="75" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521245C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521245</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521245C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="79" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521246C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521246</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521246C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="83" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521247C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521247</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521247C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="87" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521248C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521248</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521248C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="91" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521249C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521249</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521249C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="95" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521250C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521250</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521250C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="99" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521251C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521251</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521251C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="103" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521252C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521252</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521252C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="107" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0509B07FEB/0722134521253C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521253</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0509B07FEB/0722134521253C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="126" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="129" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="131" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="134" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="138" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="141" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="143" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="146" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="149" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="152" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="156" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="159" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="161" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="164" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="168" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="171" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="173" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="176" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 509B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>true</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-02-07T06:33:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BAH</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>BH</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="37" sequence="2">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="5" ResBookDesigCode="B" SmokingAllowed="false" SpecialMeal="false" id="37" isPast="true" segmentAssociationId="3" sequence="2">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>MCT</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0566</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>32Q</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0566</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>B</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>B</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>1</stl19:Group>
                                                    <stl19:Sequence>2</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-02-07T20:10:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-02-07T22:40:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0566</stl19:FlightNumber>
                                                <stl19:ClassOfService>B</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>9</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="57" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="59" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="61" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="63" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="65" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="67" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="69" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="71" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="73" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 566B7FEB/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="76" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521245C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521245</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521245C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="80" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521246C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521246</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521246C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="84" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521247C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521247</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521247C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="88" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521248C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521248</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521248C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="92" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521249C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521249</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521249C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="96" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521250C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521250</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521250C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="100" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521251C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521251</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521251C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="104" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521252C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521252</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521252C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="108" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHMCT0566B07FEB/0722134521253C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134521253</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHMCT0566B07FEB/0722134521253C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="125" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="128" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="132" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="135" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="137" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="140" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="144" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="147" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="150" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="153" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="155" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="158" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="162" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="165" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="167" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="170" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="174" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="177" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 566B7FEB/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>true</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-02-07T06:33:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BAH</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>BH</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="123" sequence="3">
                                            <stl19:General dayOfWeekInd="6" isPast="false">
                                                <stl19:Line Number="3" Status="HK" Type="OTH"/>
                                                <stl19:Vendor Code="GF"/>
                                                <stl19:NumberInParty>9</stl19:NumberInParty>
                                                <stl19:Location LocationCode="BAH"/>
                                                <stl19:DateTime>2026-01-03T00:00:00</stl19:DateTime>
                                                <stl19:Text>PNR RETENTION</stl19:Text>
                                            </stl19:General>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-121" id="121" index="1">
                                            <stl19:Code>T-07FEB-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-111" id="111" index="2">TE 0722134521245 TEST/M BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-112" id="112" index="3">TE 0722134521246 TEST/M BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-113" id="113" index="4">TE 0722134521247 TEST/R BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-114" id="114" index="5">TE 0722134521248 TEST/M BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-115" id="115" index="6">TE 0722134521249 TEST/V BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-116" id="116" index="7">TE 0722134521250 TEST/R BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-117" id="117" index="8">TE 0722134521251 TEST/S BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-118" id="118" index="9">TE 0722134521252 TEST/M BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-119" id="119" index="10">TE 0722134521253 TEST/K BAH4ND1 1533/07FEB</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-111" id="111" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134521245 TEST/M BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521245</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-112" id="112" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134521246 TEST/M BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521246</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-113" id="113" index="4">
                                            <stl19:OriginalTicketDetails>TE 0722134521247 TEST/R BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521247</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/R</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-114" id="114" index="5">
                                            <stl19:OriginalTicketDetails>TE 0722134521248 TEST/M BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521248</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-115" id="115" index="6">
                                            <stl19:OriginalTicketDetails>TE 0722134521249 TEST/V BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521249</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/V</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-116" id="116" index="7">
                                            <stl19:OriginalTicketDetails>TE 0722134521250 TEST/R BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521250</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/R</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-117" id="117" index="8">
                                            <stl19:OriginalTicketDetails>TE 0722134521251 TEST/S BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521251</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/S</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-118" id="118" index="9">
                                            <stl19:OriginalTicketDetails>TE 0722134521252 TEST/M BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521252</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-119" id="119" index="10">
                                            <stl19:OriginalTicketDetails>TE 0722134521253 TEST/K BAH4ND1 1533/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521253</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/K</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="31" type="O">
                                                <stl19:Text>PRITHVITRAVELSIATA</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="32" type="O">
                                                <stl19:Text>TEST</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="33" type="O">
                                                <stl19:Text>TEST, BH BHR</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-22" id="22" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-23" id="23" index="2">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-2.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-24" id="24" index="3">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-3.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-25" id="25" index="4">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-4.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-26" id="26" index="5">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-5.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-27" id="27" index="6">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-6.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-28" id="28" index="7">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-7.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-29" id="29" index="8">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-8.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-30" id="30" index="9">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-9.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-49" id="49" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID PRITHVI TRAVELS IATA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-50" id="50" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME PRITHVI TRAVELS IATA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-51" id="51" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>0721036-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-52" id="52" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS TEST  CITY TEST</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-53" id="53" index="5" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>COUNTRY BHR EMAIL PRITHVITRAVELSIATA//MAILINATOR.COM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-54" id="54" index="6" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY PRIME CONTACT NAME TEST PHONE 78654328</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-120" id="120" index="7" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="RSIBRD">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>RSIBRD</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-03-04T02:29:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-03-04T02:29:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-03-04T02:33:12</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>7</stl19:PNRSequence>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-28T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>5996cbfcf248b565786102fefa7d3aa4f0d1fbbb9c559ca2</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="16" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>17373737/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 17373737/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="17" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="15" type="A">
                                                        <stl19:DateOfBirth>1998-03-05</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments/>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-68" id="68" index="1">
                                            <stl19:Code>T-04MAR-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-37" id="37" index="2">TE 0722134855274 TEST/A BAH4ND1 1131/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-67" id="67" index="3">TE 0722134855325 TEST/A BAH4ND1 1132/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-70" id="70" index="4">TK 0720490452602 TEST/A BAH4ND1 1133/04MAR</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-37" id="37" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134855274 TEST/A BAH4ND1 1131/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855274</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:31:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-67" id="67" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134855325 TEST/A BAH4ND1 1132/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855325</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:32:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-70" id="70" index="4">
                                            <stl19:OriginalTicketDetails>TK 0720490452602 TEST/A BAH4ND1 1133/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TK</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0720490452602</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:33:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>93-17373737-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-18" id="18" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID VT</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-19" id="19" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME VT</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-20" id="20" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>07210420-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-21" id="21" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS BAHRAIN MUHARRAQ  CITY BAHRAINMUHARRAQ</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-38" id="38" index="5" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-66" id="66" index="6" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXAUTH/320059 *Z</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="OWOIYK">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>OWOIYK</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-06-25T04:27:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-06-25T04:27:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>LB1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-06-25T04:33:51</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>7</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-08-25T16:50:00" Start="2025-08-25T14:10:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2025-08-25T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>430f5b3aa7706f658afeec82504ba01a4091d90bcef1a357</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="8" AgentSine="LB1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="HDQ" ISOCountry="US" PrimeHostID="GF" PseudoCityCode="HDQ"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-4.1" id="4" nameAssocId="1" nameId="01.01" nameType="S">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALIMR</stl19:FirstName>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="13" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHAMM0962S25AUG/0722134943769C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134943769</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHAMM0962S25AUG/0722134943769C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="21" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YL</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 962S25AUG/YL NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="23" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YL</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 962S25AUG/YL NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="18" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>BH</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>12312312</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>BH</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1968-11-29</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2029-12-29</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALIMR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>BAH</stl19:Airport>
                                            <stl19:Departure>2025-08-25T14:10:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="10" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="1" ResBookDesigCode="S" SmokingAllowed="false" SpecialMeal="false" id="10" isPast="false" segmentAssociationId="3" sequence="1">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>AMM</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0962</stl19:OperatingFlightNumber>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0962</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>S</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>S</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-08-25T14:10:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-08-25T16:50:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0962</stl19:FlightNumber>
                                                <stl19:ClassOfService>S</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="13" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHAMM0962S25AUG/0722134943769C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134943769</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHAMM0962S25AUG/0722134943769C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="21" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 962S25AUG/YL NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="23" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 962S25AUG/YL NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-06-25T04:27:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>HDQ</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>US</stl19:CountryCode>
                                                    <stl19:DutyCode>8</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-16" id="16" index="1">
                                            <stl19:Code>T-25JUN-HDQ4LB1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-15" id="15" index="2">TE 0722134943769 TEST/A HDQ4LB1 0427/25JUN</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-15" id="15" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134943769 TEST/A HDQ4LB1 0427/25JUN</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134943769</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>HDQ</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>LB1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-06-25T04:27:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>U</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>HDQ</stl19:CityCode>
                                        <stl19:Number>973-39800996 MOB -H</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-19" id="19" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>TICKET PNR BY 27JUN25 0927GMT OR WILL BE CANCELED BY GF SYSTEM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses>
                                    <stl19:EmailAddress id="7">
                                        <stl19:Address>ALI.TEST@GULF.COM</stl19:Address>
                                        <stl19:Comment>TO/</stl19:Comment>
                                    </stl19:EmailAddress>
                                </stl19:EmailAddresses>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="RTJUWS">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>RTJUWS</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-05-06T03:34:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-05-06T03:34:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>LB1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-05-06T06:08:42</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>12</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-06-30T06:55:00" Start="2025-06-30T02:00:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2025-06-30T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>2e49a74c300479e97db7bf9bac1998004c00dc6cbdacb70d</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="true" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="8" AgentSine="LB1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="HDQ" ISOCountry="US" PrimeHostID="GF" PseudoCityCode="HDQ"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-10.1" id="10" nameAssocId="1" nameId="01.01" nameType="S">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALIMR</stl19:FirstName>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="15" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHLHR0007N30JUN/0722134901312C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134901312</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHLHR0007N30JUN/0722134901312C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="26" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YL</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 7N30JUN/YL NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="28" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YL</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 7N30JUN/YL NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats>
                                                <stl19:PreReservedSeats>
                                                    <stl19:PreReservedSeat id="13">
                                                        <stl19:SeatNumber>27A</stl19:SeatNumber>
                                                        <stl19:SmokingPrefOfferedIndicator>false</stl19:SmokingPrefOfferedIndicator>
                                                        <stl19:SeatTypeCode>WLMOI</stl19:SeatTypeCode>
                                                        <stl19:SeatStatusCode>HK</stl19:SeatStatusCode>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>LHR</stl19:OffPoint>
                                                        <stl19:Changed>N</stl19:Changed>
                                                        <stl19:NameNumber>01.01</stl19:NameNumber>
                                                    </stl19:PreReservedSeat>
                                                </stl19:PreReservedSeats>
                                            </stl19:Seats>
                                            <stl19:AncillaryServices>
                                                <stl19:AncillaryService elementId="pnr-11" id="11" sequenceNumber="1">
                                                    <stl19:CommercialName>STANDARD SEAT</stl19:CommercialName>
                                                    <stl19:RficCode>A</stl19:RficCode>
                                                    <stl19:RficSubcode>0B5</stl19:RficSubcode>
                                                    <stl19:SSRCode>SEAT</stl19:SSRCode>
                                                    <stl19:OwningCarrierCode>GF</stl19:OwningCarrierCode>
                                                    <stl19:BookingIndicator>  </stl19:BookingIndicator>
                                                    <stl19:Vendor>ATP</stl19:Vendor>
                                                    <stl19:EMDType>2</stl19:EMDType>
                                                    <stl19:EquivalentPrice>
                                                        <stl19:Price>53.20</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:EquivalentPrice>
                                                    <stl19:TTLPrice>
                                                        <stl19:Price>53.20</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TTLPrice>
                                                    <stl19:OriginalBasePrice>
                                                        <stl19:Price>20.000</stl19:Price>
                                                        <stl19:Currency>BHD</stl19:Currency>
                                                    </stl19:OriginalBasePrice>
                                                    <stl19:RefundIndicator>R</stl19:RefundIndicator>
                                                    <stl19:CommisionIndicator>N</stl19:CommisionIndicator>
                                                    <stl19:InterlineIndicator>N</stl19:InterlineIndicator>
                                                    <stl19:FeeApplicationIndicator> </stl19:FeeApplicationIndicator>
                                                    <stl19:PassengerTypeCode>ADT</stl19:PassengerTypeCode>
                                                    <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                    <stl19:OffPoint>LHR</stl19:OffPoint>
                                                    <stl19:TotalOriginalBasePrice>
                                                        <stl19:Price>20.000</stl19:Price>
                                                        <stl19:Currency>BHD</stl19:Currency>
                                                    </stl19:TotalOriginalBasePrice>
                                                    <stl19:TotalEquivalentPrice>
                                                        <stl19:Price>53.20</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TotalEquivalentPrice>
                                                    <stl19:TotalTTLPrice>
                                                        <stl19:Price>53.20</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TotalTTLPrice>
                                                    <stl19:FareCalculationModeIndicator>0</stl19:FareCalculationModeIndicator>
                                                    <stl19:FareCalculationPriceIndicator>0</stl19:FareCalculationPriceIndicator>
                                                    <stl19:StatusIndicator>0</stl19:StatusIndicator>
                                                    <stl19:NumberOfItems>1</stl19:NumberOfItems>
                                                    <stl19:ActionCode>HI</stl19:ActionCode>
                                                    <stl19:SegmentIndicator>S</stl19:SegmentIndicator>
                                                    <stl19:RefundFormIndicator> </stl19:RefundFormIndicator>
                                                    <stl19:FareGuaranteedIndicator>T</stl19:FareGuaranteedIndicator>
                                                    <stl19:BookingSource>0</stl19:BookingSource>
                                                    <stl19:TicketingIndicator>0</stl19:TicketingIndicator>
                                                    <stl19:PdcSeat>27A</stl19:PdcSeat>
                                                    <stl19:FirstTravelDate>250630</stl19:FirstTravelDate>
                                                    <stl19:LastTravelDate>250630</stl19:LastTravelDate>
                                                    <stl19:GroupCode>SA</stl19:GroupCode>
                                                    <stl19:TicketUsedForEMDPricing>N</stl19:TicketUsedForEMDPricing>
                                                    <stl19:EMDConsummedAtIssuance> </stl19:EMDConsummedAtIssuance>
                                                    <stl19:PaperDocRequired>N</stl19:PaperDocRequired>
                                                    <stl19:TaxExemption>N</stl19:TaxExemption>
                                                    <stl19:ACSCount>0</stl19:ACSCount>
                                                    <stl19:Segment id="8" sequence="1">
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FlightNumber>0007</stl19:FlightNumber>
                                                        <stl19:ClassOfService>N</stl19:ClassOfService>
                                                        <stl19:DepartureDate>2025-06-30</stl19:DepartureDate>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>LHR</stl19:OffPoint>
                                                        <stl19:EMDNumber>0724400623542</stl19:EMDNumber>
                                                        <stl19:EMDCoupon>01</stl19:EMDCoupon>
                                                        <stl19:MarketingCarrier>GF</stl19:MarketingCarrier>
                                                        <stl19:OperatingCarrier>GF</stl19:OperatingCarrier>
                                                    </stl19:Segment>
                                                </stl19:AncillaryService>
                                                <stl19:AncillaryService elementId="pnr-20" id="20" sequenceNumber="2">
                                                    <stl19:CommercialName>EXCESS WEIGHT</stl19:CommercialName>
                                                    <stl19:RficCode>C</stl19:RficCode>
                                                    <stl19:RficSubcode>0IK</stl19:RficSubcode>
                                                    <stl19:SSRCode>ASVC</stl19:SSRCode>
                                                    <stl19:OwningCarrierCode>GF</stl19:OwningCarrierCode>
                                                    <stl19:BookingIndicator>  </stl19:BookingIndicator>
                                                    <stl19:Vendor>ATP</stl19:Vendor>
                                                    <stl19:EMDType>2</stl19:EMDType>
                                                    <stl19:TTLPrice>
                                                        <stl19:Price>135.00</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TTLPrice>
                                                    <stl19:OriginalBasePrice>
                                                        <stl19:Price>135.00</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:OriginalBasePrice>
                                                    <stl19:RefundIndicator>R</stl19:RefundIndicator>
                                                    <stl19:CommisionIndicator>N</stl19:CommisionIndicator>
                                                    <stl19:InterlineIndicator>N</stl19:InterlineIndicator>
                                                    <stl19:FeeApplicationIndicator>4</stl19:FeeApplicationIndicator>
                                                    <stl19:PassengerTypeCode>ADT</stl19:PassengerTypeCode>
                                                    <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                    <stl19:OffPoint>LHR</stl19:OffPoint>
                                                    <stl19:TotalOriginalBasePrice>
                                                        <stl19:Price>135.00</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TotalOriginalBasePrice>
                                                    <stl19:TotalTTLPrice>
                                                        <stl19:Price>135.00</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TotalTTLPrice>
                                                    <stl19:FareCalculationModeIndicator>0</stl19:FareCalculationModeIndicator>
                                                    <stl19:FareCalculationPriceIndicator>0</stl19:FareCalculationPriceIndicator>
                                                    <stl19:StatusIndicator>0</stl19:StatusIndicator>
                                                    <stl19:NumberOfItems>1</stl19:NumberOfItems>
                                                    <stl19:ActionCode>HI</stl19:ActionCode>
                                                    <stl19:SegmentIndicator>P</stl19:SegmentIndicator>
                                                    <stl19:FareGuaranteedIndicator>T</stl19:FareGuaranteedIndicator>
                                                    <stl19:BookingSource>0</stl19:BookingSource>
                                                    <stl19:TicketingIndicator>0</stl19:TicketingIndicator>
                                                    <stl19:FirstTravelDate>800101</stl19:FirstTravelDate>
                                                    <stl19:LastTravelDate>991231</stl19:LastTravelDate>
                                                    <stl19:GroupCode>BG</stl19:GroupCode>
                                                    <stl19:EmdPaperIndicator>E</stl19:EmdPaperIndicator>
                                                    <stl19:TicketUsedForEMDPricing>N</stl19:TicketUsedForEMDPricing>
                                                    <stl19:EMDConsummedAtIssuance> </stl19:EMDConsummedAtIssuance>
                                                    <stl19:PaperDocRequired>N</stl19:PaperDocRequired>
                                                    <stl19:TaxExemption>N</stl19:TaxExemption>
                                                    <stl19:ACSCount>0</stl19:ACSCount>
                                                    <stl19:Segment id="8" sequence="1">
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FlightNumber>0007</stl19:FlightNumber>
                                                        <stl19:ClassOfService>N</stl19:ClassOfService>
                                                        <stl19:DepartureDate>2025-06-30</stl19:DepartureDate>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>LHR</stl19:OffPoint>
                                                        <stl19:EMDNumber>0724400623541</stl19:EMDNumber>
                                                        <stl19:EMDCoupon>01</stl19:EMDCoupon>
                                                        <stl19:MarketingCarrier>GF</stl19:MarketingCarrier>
                                                        <stl19:OperatingCarrier>GF</stl19:OperatingCarrier>
                                                    </stl19:Segment>
                                                </stl19:AncillaryService>
                                                <stl19:AncillaryService elementId="pnr-32" id="32" sequenceNumber="3">
                                                    <stl19:CommercialName>PREPAID EXCESS BAG PER 5KG GF</stl19:CommercialName>
                                                    <stl19:RficCode>C</stl19:RficCode>
                                                    <stl19:RficSubcode>0E1</stl19:RficSubcode>
                                                    <stl19:OwningCarrierCode>GF</stl19:OwningCarrierCode>
                                                    <stl19:SsimCode> </stl19:SsimCode>
                                                    <stl19:BookingIndicator>01</stl19:BookingIndicator>
                                                    <stl19:Vendor>ATP</stl19:Vendor>
                                                    <stl19:EMDType>2</stl19:EMDType>
                                                    <stl19:TTLPrice>
                                                        <stl19:Price>96.30</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TTLPrice>
                                                    <stl19:OriginalBasePrice>
                                                        <stl19:Price>96.00</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:OriginalBasePrice>
                                                    <stl19:RefundIndicator>R</stl19:RefundIndicator>
                                                    <stl19:CommisionIndicator>N</stl19:CommisionIndicator>
                                                    <stl19:InterlineIndicator>N</stl19:InterlineIndicator>
                                                    <stl19:FeeApplicationIndicator>F</stl19:FeeApplicationIndicator>
                                                    <stl19:PassengerTypeCode>ADT</stl19:PassengerTypeCode>
                                                    <stl19:TaxesIncluded>true</stl19:TaxesIncluded>
                                                    <stl19:Taxes>
                                                        <stl19:Tax>
                                                            <stl19:TaxAmount>0.30</stl19:TaxAmount>
                                                            <stl19:TaxCode>HMA</stl19:TaxCode>
                                                        </stl19:Tax>
                                                    </stl19:Taxes>
                                                    <stl19:TotalOriginalBasePrice>
                                                        <stl19:Price>96.00</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TotalOriginalBasePrice>
                                                    <stl19:TotalTTLPrice>
                                                        <stl19:Price>96.30</stl19:Price>
                                                        <stl19:Currency>USD</stl19:Currency>
                                                    </stl19:TotalTTLPrice>
                                                    <stl19:TotalTaxes>
                                                        <stl19:Tax>
                                                            <stl19:TaxAmount>0.30</stl19:TaxAmount>
                                                            <stl19:TaxCode>HMA</stl19:TaxCode>
                                                        </stl19:Tax>
                                                    </stl19:TotalTaxes>
                                                    <stl19:FareCalculationModeIndicator>0</stl19:FareCalculationModeIndicator>
                                                    <stl19:FareCalculationPriceIndicator>0</stl19:FareCalculationPriceIndicator>
                                                    <stl19:StatusIndicator>0</stl19:StatusIndicator>
                                                    <stl19:NumberOfItems>1</stl19:NumberOfItems>
                                                    <stl19:ActionCode>HI</stl19:ActionCode>
                                                    <stl19:SegmentIndicator>P</stl19:SegmentIndicator>
                                                    <stl19:FareGuaranteedIndicator>T</stl19:FareGuaranteedIndicator>
                                                    <stl19:BookingSource>0</stl19:BookingSource>
                                                    <stl19:TicketingIndicator>0</stl19:TicketingIndicator>
                                                    <stl19:FirstTravelDate>800101</stl19:FirstTravelDate>
                                                    <stl19:LastTravelDate>991231</stl19:LastTravelDate>
                                                    <stl19:PurchaseTimestamp>2025-06-28T23:59:00</stl19:PurchaseTimestamp>
                                                    <stl19:GroupCode>BG</stl19:GroupCode>
                                                    <stl19:TicketUsedForEMDPricing>N</stl19:TicketUsedForEMDPricing>
                                                    <stl19:EMDConsummedAtIssuance> </stl19:EMDConsummedAtIssuance>
                                                    <stl19:PaperDocRequired>N</stl19:PaperDocRequired>
                                                    <stl19:TaxExemption>N</stl19:TaxExemption>
                                                    <stl19:ACSCount>0</stl19:ACSCount>
                                                    <stl19:Segment id="8" sequence="1">
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FlightNumber>0007</stl19:FlightNumber>
                                                        <stl19:ClassOfService>N</stl19:ClassOfService>
                                                        <stl19:DepartureDate>2025-06-30</stl19:DepartureDate>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>LHR</stl19:OffPoint>
                                                        <stl19:EMDNumber>0724400623552</stl19:EMDNumber>
                                                        <stl19:EMDCoupon>01</stl19:EMDCoupon>
                                                        <stl19:MarketingCarrier>GF</stl19:MarketingCarrier>
                                                        <stl19:OperatingCarrier>GF</stl19:OperatingCarrier>
                                                    </stl19:Segment>
                                                </stl19:AncillaryService>
                                            </stl19:AncillaryServices>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>BAH</stl19:Airport>
                                            <stl19:Departure>2025-06-30T02:00:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="8" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="1" ResBookDesigCode="N" SmokingAllowed="false" SpecialMeal="false" id="8" isPast="false" segmentAssociationId="3" sequence="1">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>LHR</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0007</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>789</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0007</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>N</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>N</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats>
                                                    <stl19:PreReservedSeats>
                                                        <stl19:PreReservedSeat id="13">
                                                            <stl19:SeatNumber>27A</stl19:SeatNumber>
                                                            <stl19:SmokingPrefOfferedIndicator>false</stl19:SmokingPrefOfferedIndicator>
                                                            <stl19:SeatTypeCode>WLMOI</stl19:SeatTypeCode>
                                                            <stl19:SeatStatusCode>HK</stl19:SeatStatusCode>
                                                            <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                            <stl19:OffPoint>LHR</stl19:OffPoint>
                                                            <stl19:Changed>N</stl19:Changed>
                                                            <stl19:NameNumber>01.01</stl19:NameNumber>
                                                        </stl19:PreReservedSeat>
                                                    </stl19:PreReservedSeats>
                                                </stl19:Seats>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-06-30T02:00:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-06-30T06:55:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0007</stl19:FlightNumber>
                                                <stl19:ClassOfService>N</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="15" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHLHR0007N30JUN/0722134901312C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134901312</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHLHR0007N30JUN/0722134901312C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="26" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 7N30JUN/YL NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="28" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 7N30JUN/YL NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:AncillaryServices>
                                                    <stl19:AncillaryService ref="11"/>
                                                    <stl19:AncillaryService ref="20"/>
                                                    <stl19:AncillaryService ref="32"/>
                                                </stl19:AncillaryServices>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-05-06T03:34:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>HDQ</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>US</stl19:CountryCode>
                                                    <stl19:DutyCode>8</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-18" id="18" index="1">
                                            <stl19:Code>T-06MAY-HDQ4LB1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-17" id="17" index="2">TE 0722134901312 TEST/A HDQ4LB1 0335/06MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-23" id="23" index="3">TE 0724400623542 TEST/A HDQ4LB1 0338/06MAY - SA</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-24" id="24" index="4">TE 0724400623541 TEST/A HDQ4LB1 0338/06MAY - BG</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-36" id="36" index="5">TE 0724400623552 TEST/A WGF4WEB 1408/06MAY - BG</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-17" id="17" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134901312 TEST/A HDQ4LB1 0335/06MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134901312</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>HDQ</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>LB1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-06T03:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-23" id="23" index="3">
                                            <stl19:OriginalTicketDetails>TE 0724400623542 TEST/A HDQ4LB1 0338/06MAY - SA</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0724400623542</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>HDQ</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>LB1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-06T03:38:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-24" id="24" index="4">
                                            <stl19:OriginalTicketDetails>TE 0724400623541 TEST/A HDQ4LB1 0338/06MAY - BG</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0724400623541</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>HDQ</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>LB1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-06T03:38:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-36" id="36" index="5">
                                            <stl19:OriginalTicketDetails>TE 0724400623552 TEST/A WGF4WEB 1408/06MAY - BG</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0724400623552</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>WGF</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>WEB</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-06T14:08:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>U</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-5" id="5" index="1">
                                        <stl19:CityCode>HDQ</stl19:CityCode>
                                        <stl19:Number> PWC</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="2">
                                        <stl19:CityCode>HDQ</stl19:CityCode>
                                        <stl19:Number>973-17335777 MOB -H</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-31" id="31" index="3">
                                        <stl19:CityCode>WGF</stl19:CityCode>
                                        <stl19:Number>93-1212121-M</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-34" id="34" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>EXCESS BAGGAGE PURCHASED 5 KG FOR 96.30 USD ON 2025-05-06</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-35" id="35" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>EXCESS BAGGAGE ON BAHLHR BOOKED 5 KG</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-38" id="38" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>TICKET IN PDF SENT TO EMAIL</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses>
                                    <stl19:EmailAddress id="30">
                                        <stl19:Address>MM@M.COM</stl19:Address>
                                        <stl19:Comment/>
                                    </stl19:EmailAddress>
                                </stl19:EmailAddresses>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="RRGRAL">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>RRGRAL</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-03-04T02:02:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-03-04T02:02:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-03-04T02:07:12</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>7</stl19:PNRSequence>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-28T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>5996cbfcf248b565d76ccb998b0aecf6ef5feb59a7ce9e60</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="15" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>903589720/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 903589720/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="16" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="14" type="A">
                                                        <stl19:DateOfBirth>1995-03-07</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments/>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-53" id="53" index="1">
                                            <stl19:Code>T-04MAR-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-29" id="29" index="2">TE 0722134855310 TEST/A BAH4ND1 1102/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-52" id="52" index="3">TE 0722134855264 TEST/A BAH4ND1 1106/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-55" id="55" index="4">TK 0720480452598 TEST/A BAH4ND1 1107/04MAR</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-29" id="29" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134855310 TEST/A BAH4ND1 1102/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855310</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:02:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-52" id="52" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134855264 TEST/A BAH4ND1 1106/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855264</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:06:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-55" id="55" index="4">
                                            <stl19:OriginalTicketDetails>TK 0720480452598 TEST/A BAH4ND1 1107/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TK</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0720480452598</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:07:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="7" type="O">
                                                <stl19:Text>GFTEST</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="8" type="O">
                                                <stl19:Text>BAHRAIN</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="9" type="O">
                                                <stl19:Text>BAHRAIN, BH BHR</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>93-17373737-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-17" id="17" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID GF TEST BAHRAIN</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-18" id="18" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME GF TEST BAHRAIN</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-19" id="19" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>07210051-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-20" id="20" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS BAHRAIN BAHRAIN CITY BAHRAIN</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-30" id="30" index="5" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="SSVMNY">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>SSVMNY</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-05-13T00:21:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-05-13T00:21:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>LB1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-05-17T00:22:02</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>3</stl19:PNRSequence>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2025-06-30T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>44fb1c095f3a42cde2777769e2e3452839c3fceaca9819dc</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="8" AgentSine="LB1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="HDQ" ISOCountry="US" PrimeHostID="GF" PseudoCityCode="HDQ"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALIM</stl19:FirstName>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments/>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-6" id="6" index="1">
                                            <stl19:Code>T-</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>U</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-8" id="8" index="1">
                                        <stl19:CityCode>HDQ</stl19:CityCode>
                                        <stl19:Number> PWC</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-9" id="9" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>TICKET PNR BY 17MAY25 0521GMT OR WILL BE CANCELED BY GF SYSTEM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-11" id="11" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>BOOKING CANCELED BY SYSTEM DUE NO TICKET</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="OMDYZT">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="9" numberInParty="9" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>OMDYZT</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-05-26T06:20:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-05-26T06:20:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-05-26T08:42:20</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>23</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-06-15T21:15:00" Start="2025-06-15T21:00:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-04-21T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>68f429c37c4b6536dc51414bcec338fcff372afecda2592d</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MANISH MR</stl19:FirstName>
                                            <stl19:EmailAddress id="13">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="45" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>78654328/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 78654328/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="46" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>LEVEL2//GMAIL.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE LEVEL2//GMAIL.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="54" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="64" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920501C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920501</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920501C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="96" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="98" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="36" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551111</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-16</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MANISH MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-4.2" id="4" nameAssocId="2" nameId="02.01" nameType="S" referenceNumber="A02">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MURALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="14">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="55" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="66" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920502C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920502</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920502C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="100" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="102" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="37" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551311</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-19</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MURALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-5.3" id="5" nameAssocId="3" nameId="03.01" nameType="S" referenceNumber="A03">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>RAJA MR</stl19:FirstName>
                                            <stl19:EmailAddress id="15">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="56" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="68" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920503C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920503</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920503C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="104" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="106" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="38" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551411</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-20</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>RAJA MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-6.4" id="6" nameAssocId="4" nameId="04.01" nameType="S" referenceNumber="A04">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MUKUND MR</stl19:FirstName>
                                            <stl19:EmailAddress id="16">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="57" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="70" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920504C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920504</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920504C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="108" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="110" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="39" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551511</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-21</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MUKUND MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-7.5" id="7" nameAssocId="5" nameId="05.01" nameType="S" referenceNumber="A05">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>VEER MR</stl19:FirstName>
                                            <stl19:EmailAddress id="17">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="58" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="72" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920505C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920505</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920505C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="112" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="114" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="40" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551412</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-09-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>VEER MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-8.6" id="8" nameAssocId="6" nameId="06.01" nameType="S" referenceNumber="A06">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ROOP MR</stl19:FirstName>
                                            <stl19:EmailAddress id="18">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="59" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="74" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920506C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920506</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920506C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="116" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="118" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="41" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551413</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-10-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ROOP MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-9.7" id="9" nameAssocId="7" nameId="07.01" nameType="S" referenceNumber="A07">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>SID MR</stl19:FirstName>
                                            <stl19:EmailAddress id="19">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="60" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="76" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920507C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920507</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920507C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="120" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="122" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="42" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551414</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-06-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>SID MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-10.8" id="10" nameAssocId="8" nameId="08.01" nameType="S" referenceNumber="A08">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MALAVIKA MRS</stl19:FirstName>
                                            <stl19:EmailAddress id="20">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="61" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="78" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920508C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920508</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920508C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="124" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="126" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="43" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551415</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-05-10</stl19:DateOfBirth>
                                                        <stl19:Gender>F</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MALAVIKA MRS</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-11.9" id="11" nameAssocId="9" nameId="09.01" nameType="S" referenceNumber="A09">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>KRISHNA MRS</stl19:FirstName>
                                            <stl19:EmailAddress id="21">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="62" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="80" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920509C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134920509</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920509C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="128" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="130" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="44" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551416</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1984-11-22</stl19:DateOfBirth>
                                                        <stl19:Gender>F</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>KRISHNA MRS</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>DXB</stl19:Airport>
                                            <stl19:Departure>2025-06-15T21:00:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="35" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="7" ResBookDesigCode="O" SmokingAllowed="false" SpecialMeal="false" id="35" isPast="true" segmentAssociationId="2" sequence="1">
                                                <stl19:DepartureAirport>DXB</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>BAH</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0511</stl19:OperatingFlightNumber>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0511</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>O</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>O</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-06-15T21:00:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-06-15T21:15:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0511</stl19:FlightNumber>
                                                <stl19:ClassOfService>O</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>9</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="54" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="55" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="56" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="57" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="58" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="59" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="60" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="61" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="62" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 511O15JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="64" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920501C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920501</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920501C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="66" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920502C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920502</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920502C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="68" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920503C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920503</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920503C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="70" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920504C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920504</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920504C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="72" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920505C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920505</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920505C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="74" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920506C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920506</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920506C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="76" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920507C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920507</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920507C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="78" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920508C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920508</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920508C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="80" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DXBBAH0511O15JUN/0722134920509C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134920509</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DXBBAH0511O15JUN/0722134920509C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="96" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="98" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="100" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="102" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="104" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="106" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="108" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="110" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="112" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="114" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="116" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="118" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="120" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="122" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="124" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="126" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="128" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="130" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 511O15JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-05-26T06:20:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BAH</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>BH</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="94" sequence="2">
                                            <stl19:General dayOfWeekInd="2" isPast="false">
                                                <stl19:Line Number="2" Status="HK" Type="OTH"/>
                                                <stl19:Vendor Code="GF"/>
                                                <stl19:NumberInParty>9</stl19:NumberInParty>
                                                <stl19:Location LocationCode="BAH"/>
                                                <stl19:DateTime>2026-04-21T00:00:00</stl19:DateTime>
                                                <stl19:Text>PNR RETENTION</stl19:Text>
                                            </stl19:General>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-92" id="92" index="1">
                                            <stl19:Code>T-26MAY-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-82" id="82" index="2">TE 0722134920501 TEST/M BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-83" id="83" index="3">TE 0722134920502 TEST/M BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-84" id="84" index="4">TE 0722134920503 TEST/R BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-85" id="85" index="5">TE 0722134920504 TEST/M BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-86" id="86" index="6">TE 0722134920505 TEST/V BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-87" id="87" index="7">TE 0722134920506 TEST/R BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-88" id="88" index="8">TE 0722134920507 TEST/S BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-89" id="89" index="9">TE 0722134920508 TEST/M BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-90" id="90" index="10">TE 0722134920509 TEST/K BAH4ND1 1420/26MAY</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-82" id="82" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134920501 TEST/M BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920501</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-83" id="83" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134920502 TEST/M BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920502</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-84" id="84" index="4">
                                            <stl19:OriginalTicketDetails>TE 0722134920503 TEST/R BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920503</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/R</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-85" id="85" index="5">
                                            <stl19:OriginalTicketDetails>TE 0722134920504 TEST/M BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920504</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-86" id="86" index="6">
                                            <stl19:OriginalTicketDetails>TE 0722134920505 TEST/V BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920505</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/V</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-87" id="87" index="7">
                                            <stl19:OriginalTicketDetails>TE 0722134920506 TEST/R BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920506</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/R</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-88" id="88" index="8">
                                            <stl19:OriginalTicketDetails>TE 0722134920507 TEST/S BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920507</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/S</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-89" id="89" index="9">
                                            <stl19:OriginalTicketDetails>TE 0722134920508 TEST/M BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920508</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-90" id="90" index="10">
                                            <stl19:OriginalTicketDetails>TE 0722134920509 TEST/K BAH4ND1 1420/26MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134920509</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/K</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-26T14:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="31" type="O">
                                                <stl19:Text>PRITHVITRAVELSIATA</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="32" type="O">
                                                <stl19:Text>TEST</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="33" type="O">
                                                <stl19:Text>TEST, BH BHR</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-22" id="22" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-23" id="23" index="2">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-2.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-24" id="24" index="3">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-3.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-25" id="25" index="4">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-4.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-26" id="26" index="5">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-5.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-27" id="27" index="6">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-6.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-28" id="28" index="7">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-7.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-29" id="29" index="8">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-8.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-30" id="30" index="9">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-9.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-47" id="47" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID PRITHVI TRAVELS IATA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-48" id="48" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME PRITHVI TRAVELS IATA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-49" id="49" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>0721036-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-50" id="50" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS TEST  CITY TEST</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-51" id="51" index="5" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>COUNTRY BHR EMAIL PRITHVITRAVELSIATA//MAILINATOR.COM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-52" id="52" index="6" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY PRIME CONTACT NAME TEST PHONE 78654328</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-91" id="91" index="7" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-132" id="132" index="8" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>POSSIBLE DUPE PNR WITH OWLBJB</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-133" id="133" index="9" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>PLEASE CONFIRM WITH PASSENGER OR SUBJECT TO CANCELLATION</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-135" id="135" index="10" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>POSSIBLE DUPE PNR WITH OOJYQX</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-136" id="136" index="11" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>PLEASE CONFIRM WITH PASSENGER OR SUBJECT TO CANCELLATION</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="QNZIHU">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>QNZIHU</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-03-02T22:46:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-03-02T22:46:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-03-02T22:52:50</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>11</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-06-13T23:35:00" Start="2025-05-01T14:20:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-27T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>2ea7665a93e65078d35185b190d92dd248414c7a2eebd020</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="true" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="IN" PrimeHostID="GF" PseudoCityCode="BOM"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="15" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>2280101105/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 2280101105/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="16" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="24" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 134W1MAY/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="34" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHDEL0134W01MAY/0722134853553C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134853553</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHDEL0134W01MAY/0722134853553C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="52" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DELBAH0135E13JUN/0722134853553C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134853553</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DELBAH0135E13JUN/0722134853553C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="54" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHDEL0134W01MAY/0722134853554C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134853554</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHDEL0134W01MAY/0722134853554C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="55" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 DELBAH0135E13JUN/0722134853554C2</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134853554</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 DELBAH0135E13JUN/0722134853554C2</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="14" type="A">
                                                        <stl19:DateOfBirth>2002-03-06</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats>
                                                <stl19:PreReservedSeats>
                                                    <stl19:PreReservedSeat id="29">
                                                        <stl19:SeatNumber>8C</stl19:SeatNumber>
                                                        <stl19:SmokingPrefOfferedIndicator>false</stl19:SmokingPrefOfferedIndicator>
                                                        <stl19:SeatTypeCode>ALKI</stl19:SeatTypeCode>
                                                        <stl19:SeatStatusCode>HK</stl19:SeatStatusCode>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>DEL</stl19:OffPoint>
                                                        <stl19:Changed>N</stl19:Changed>
                                                        <stl19:NameNumber>01.01</stl19:NameNumber>
                                                    </stl19:PreReservedSeat>
                                                    <stl19:PreReservedSeat id="64">
                                                        <stl19:SeatNumber>8C</stl19:SeatNumber>
                                                        <stl19:SmokingPrefOfferedIndicator>false</stl19:SmokingPrefOfferedIndicator>
                                                        <stl19:SeatTypeCode>ALKI</stl19:SeatTypeCode>
                                                        <stl19:SeatStatusCode>HK</stl19:SeatStatusCode>
                                                        <stl19:BoardPoint>DEL</stl19:BoardPoint>
                                                        <stl19:OffPoint>BAH</stl19:OffPoint>
                                                        <stl19:Changed>N</stl19:Changed>
                                                        <stl19:NameNumber>01.01</stl19:NameNumber>
                                                    </stl19:PreReservedSeat>
                                                </stl19:PreReservedSeats>
                                            </stl19:Seats>
                                            <stl19:AncillaryServices>
                                                <stl19:AncillaryService elementId="pnr-27" id="27" sequenceNumber="1">
                                                    <stl19:CommercialName>STANDARD SEAT</stl19:CommercialName>
                                                    <stl19:RficCode>A</stl19:RficCode>
                                                    <stl19:RficSubcode>0B5</stl19:RficSubcode>
                                                    <stl19:SSRCode>SEAT</stl19:SSRCode>
                                                    <stl19:OwningCarrierCode>GF</stl19:OwningCarrierCode>
                                                    <stl19:BookingIndicator>  </stl19:BookingIndicator>
                                                    <stl19:Vendor>ATP</stl19:Vendor>
                                                    <stl19:EMDType>2</stl19:EMDType>
                                                    <stl19:EquivalentPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:EquivalentPrice>
                                                    <stl19:TTLPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TTLPrice>
                                                    <stl19:OriginalBasePrice>
                                                        <stl19:Price>20.000</stl19:Price>
                                                        <stl19:Currency>BHD</stl19:Currency>
                                                    </stl19:OriginalBasePrice>
                                                    <stl19:RefundIndicator>R</stl19:RefundIndicator>
                                                    <stl19:CommisionIndicator>N</stl19:CommisionIndicator>
                                                    <stl19:InterlineIndicator>N</stl19:InterlineIndicator>
                                                    <stl19:FeeApplicationIndicator>4</stl19:FeeApplicationIndicator>
                                                    <stl19:PassengerTypeCode>ADT</stl19:PassengerTypeCode>
                                                    <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                    <stl19:OffPoint>DEL</stl19:OffPoint>
                                                    <stl19:TotalOriginalBasePrice>
                                                        <stl19:Price>20.000</stl19:Price>
                                                        <stl19:Currency>BHD</stl19:Currency>
                                                    </stl19:TotalOriginalBasePrice>
                                                    <stl19:TotalEquivalentPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TotalEquivalentPrice>
                                                    <stl19:TotalTTLPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TotalTTLPrice>
                                                    <stl19:FareCalculationModeIndicator>0</stl19:FareCalculationModeIndicator>
                                                    <stl19:FareCalculationPriceIndicator>0</stl19:FareCalculationPriceIndicator>
                                                    <stl19:StatusIndicator>0</stl19:StatusIndicator>
                                                    <stl19:NumberOfItems>1</stl19:NumberOfItems>
                                                    <stl19:ActionCode>HI</stl19:ActionCode>
                                                    <stl19:SegmentIndicator>S</stl19:SegmentIndicator>
                                                    <stl19:RefundFormIndicator> </stl19:RefundFormIndicator>
                                                    <stl19:FareGuaranteedIndicator>T</stl19:FareGuaranteedIndicator>
                                                    <stl19:BookingSource>0</stl19:BookingSource>
                                                    <stl19:TicketingIndicator>0</stl19:TicketingIndicator>
                                                    <stl19:PdcSeat>08C</stl19:PdcSeat>
                                                    <stl19:FirstTravelDate>250501</stl19:FirstTravelDate>
                                                    <stl19:LastTravelDate>250501</stl19:LastTravelDate>
                                                    <stl19:GroupCode>SA</stl19:GroupCode>
                                                    <stl19:TicketUsedForEMDPricing>N</stl19:TicketUsedForEMDPricing>
                                                    <stl19:EMDConsummedAtIssuance> </stl19:EMDConsummedAtIssuance>
                                                    <stl19:PaperDocRequired>N</stl19:PaperDocRequired>
                                                    <stl19:TaxExemption>N</stl19:TaxExemption>
                                                    <stl19:ACSCount>0</stl19:ACSCount>
                                                    <stl19:Segment id="11" sequence="1">
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FlightNumber>0134</stl19:FlightNumber>
                                                        <stl19:ClassOfService>W</stl19:ClassOfService>
                                                        <stl19:DepartureDate>2025-05-01</stl19:DepartureDate>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>DEL</stl19:OffPoint>
                                                        <stl19:EMDNumber>0724400619153</stl19:EMDNumber>
                                                        <stl19:EMDCoupon>01</stl19:EMDCoupon>
                                                        <stl19:MarketingCarrier>GF</stl19:MarketingCarrier>
                                                        <stl19:OperatingCarrier>GF</stl19:OperatingCarrier>
                                                    </stl19:Segment>
                                                </stl19:AncillaryService>
                                                <stl19:AncillaryService elementId="pnr-31" id="31" sequenceNumber="2">
                                                    <stl19:CommercialName>PREPAID EXCESS BAG PER 5KG GF</stl19:CommercialName>
                                                    <stl19:RficCode>C</stl19:RficCode>
                                                    <stl19:RficSubcode>0E1</stl19:RficSubcode>
                                                    <stl19:OwningCarrierCode>GF</stl19:OwningCarrierCode>
                                                    <stl19:BookingIndicator>  </stl19:BookingIndicator>
                                                    <stl19:Vendor>ATP</stl19:Vendor>
                                                    <stl19:EMDType>2</stl19:EMDType>
                                                    <stl19:TTLPrice>
                                                        <stl19:Price>4914</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TTLPrice>
                                                    <stl19:OriginalBasePrice>
                                                        <stl19:Price>4914</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:OriginalBasePrice>
                                                    <stl19:RefundIndicator>R</stl19:RefundIndicator>
                                                    <stl19:CommisionIndicator>N</stl19:CommisionIndicator>
                                                    <stl19:InterlineIndicator>N</stl19:InterlineIndicator>
                                                    <stl19:FeeApplicationIndicator>F</stl19:FeeApplicationIndicator>
                                                    <stl19:PassengerTypeCode>ADT</stl19:PassengerTypeCode>
                                                    <stl19:TotalOriginalBasePrice>
                                                        <stl19:Price>4914</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TotalOriginalBasePrice>
                                                    <stl19:TotalTTLPrice>
                                                        <stl19:Price>4914</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TotalTTLPrice>
                                                    <stl19:FareCalculationModeIndicator>0</stl19:FareCalculationModeIndicator>
                                                    <stl19:FareCalculationPriceIndicator>0</stl19:FareCalculationPriceIndicator>
                                                    <stl19:StatusIndicator>0</stl19:StatusIndicator>
                                                    <stl19:NumberOfItems>1</stl19:NumberOfItems>
                                                    <stl19:ActionCode>HI</stl19:ActionCode>
                                                    <stl19:SegmentIndicator>S</stl19:SegmentIndicator>
                                                    <stl19:FareGuaranteedIndicator>T</stl19:FareGuaranteedIndicator>
                                                    <stl19:BookingSource>0</stl19:BookingSource>
                                                    <stl19:TicketingIndicator>0</stl19:TicketingIndicator>
                                                    <stl19:FirstTravelDate>800101</stl19:FirstTravelDate>
                                                    <stl19:LastTravelDate>991231</stl19:LastTravelDate>
                                                    <stl19:PurchaseTimestamp>2025-04-30T23:59:00</stl19:PurchaseTimestamp>
                                                    <stl19:GroupCode>BG</stl19:GroupCode>
                                                    <stl19:TicketUsedForEMDPricing>N</stl19:TicketUsedForEMDPricing>
                                                    <stl19:EMDConsummedAtIssuance> </stl19:EMDConsummedAtIssuance>
                                                    <stl19:PaperDocRequired>N</stl19:PaperDocRequired>
                                                    <stl19:TaxExemption>N</stl19:TaxExemption>
                                                    <stl19:ACSCount>0</stl19:ACSCount>
                                                    <stl19:Segment id="11" sequence="1">
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FlightNumber>0134</stl19:FlightNumber>
                                                        <stl19:ClassOfService>W</stl19:ClassOfService>
                                                        <stl19:DepartureDate>2025-05-01</stl19:DepartureDate>
                                                        <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                        <stl19:OffPoint>DEL</stl19:OffPoint>
                                                        <stl19:EMDNumber>0724400619152</stl19:EMDNumber>
                                                        <stl19:EMDCoupon>01</stl19:EMDCoupon>
                                                        <stl19:MarketingCarrier>GF</stl19:MarketingCarrier>
                                                        <stl19:OperatingCarrier>GF</stl19:OperatingCarrier>
                                                    </stl19:Segment>
                                                </stl19:AncillaryService>
                                                <stl19:AncillaryService elementId="pnr-62" id="62" sequenceNumber="3">
                                                    <stl19:CommercialName>STANDARD SEAT</stl19:CommercialName>
                                                    <stl19:RficCode>A</stl19:RficCode>
                                                    <stl19:RficSubcode>0B5</stl19:RficSubcode>
                                                    <stl19:SSRCode>SEAT</stl19:SSRCode>
                                                    <stl19:OwningCarrierCode>GF</stl19:OwningCarrierCode>
                                                    <stl19:BookingIndicator>  </stl19:BookingIndicator>
                                                    <stl19:Vendor>ATP</stl19:Vendor>
                                                    <stl19:EMDType>2</stl19:EMDType>
                                                    <stl19:EquivalentPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:EquivalentPrice>
                                                    <stl19:TTLPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TTLPrice>
                                                    <stl19:OriginalBasePrice>
                                                        <stl19:Price>20.000</stl19:Price>
                                                        <stl19:Currency>BHD</stl19:Currency>
                                                    </stl19:OriginalBasePrice>
                                                    <stl19:RefundIndicator>R</stl19:RefundIndicator>
                                                    <stl19:CommisionIndicator>N</stl19:CommisionIndicator>
                                                    <stl19:InterlineIndicator>N</stl19:InterlineIndicator>
                                                    <stl19:FeeApplicationIndicator>4</stl19:FeeApplicationIndicator>
                                                    <stl19:PassengerTypeCode>ADT</stl19:PassengerTypeCode>
                                                    <stl19:BoardPoint>DEL</stl19:BoardPoint>
                                                    <stl19:OffPoint>BAH</stl19:OffPoint>
                                                    <stl19:TotalOriginalBasePrice>
                                                        <stl19:Price>20.000</stl19:Price>
                                                        <stl19:Currency>BHD</stl19:Currency>
                                                    </stl19:TotalOriginalBasePrice>
                                                    <stl19:TotalEquivalentPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TotalEquivalentPrice>
                                                    <stl19:TotalTTLPrice>
                                                        <stl19:Price>4642</stl19:Price>
                                                        <stl19:Currency>INR</stl19:Currency>
                                                    </stl19:TotalTTLPrice>
                                                    <stl19:FareCalculationModeIndicator>0</stl19:FareCalculationModeIndicator>
                                                    <stl19:FareCalculationPriceIndicator>0</stl19:FareCalculationPriceIndicator>
                                                    <stl19:StatusIndicator>0</stl19:StatusIndicator>
                                                    <stl19:NumberOfItems>1</stl19:NumberOfItems>
                                                    <stl19:ActionCode>HI</stl19:ActionCode>
                                                    <stl19:SegmentIndicator>S</stl19:SegmentIndicator>
                                                    <stl19:RefundFormIndicator> </stl19:RefundFormIndicator>
                                                    <stl19:FareGuaranteedIndicator>T</stl19:FareGuaranteedIndicator>
                                                    <stl19:BookingSource>0</stl19:BookingSource>
                                                    <stl19:TicketingIndicator>0</stl19:TicketingIndicator>
                                                    <stl19:PdcSeat>08C</stl19:PdcSeat>
                                                    <stl19:FirstTravelDate>250613</stl19:FirstTravelDate>
                                                    <stl19:LastTravelDate>250613</stl19:LastTravelDate>
                                                    <stl19:GroupCode>SA</stl19:GroupCode>
                                                    <stl19:TicketUsedForEMDPricing>N</stl19:TicketUsedForEMDPricing>
                                                    <stl19:EMDConsummedAtIssuance> </stl19:EMDConsummedAtIssuance>
                                                    <stl19:PaperDocRequired>N</stl19:PaperDocRequired>
                                                    <stl19:TaxExemption>N</stl19:TaxExemption>
                                                    <stl19:ACSCount>0</stl19:ACSCount>
                                                    <stl19:Segment id="49" sequence="2">
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FlightNumber>0135</stl19:FlightNumber>
                                                        <stl19:ClassOfService>E</stl19:ClassOfService>
                                                        <stl19:DepartureDate>2025-06-13</stl19:DepartureDate>
                                                        <stl19:BoardPoint>DEL</stl19:BoardPoint>
                                                        <stl19:OffPoint>BAH</stl19:OffPoint>
                                                        <stl19:EMDNumber>0724400619154</stl19:EMDNumber>
                                                        <stl19:EMDCoupon>01</stl19:EMDCoupon>
                                                        <stl19:MarketingCarrier>GF</stl19:MarketingCarrier>
                                                        <stl19:OperatingCarrier>GF</stl19:OperatingCarrier>
                                                    </stl19:Segment>
                                                </stl19:AncillaryService>
                                            </stl19:AncillaryServices>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>BAH</stl19:Airport>
                                            <stl19:Departure>2025-05-01T14:20:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="11" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="4" ResBookDesigCode="W" SmokingAllowed="false" SpecialMeal="false" id="11" isPast="true" segmentAssociationId="2" sequence="1">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>DEL</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0134</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>32Q</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0134</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>W</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>W</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats>
                                                    <stl19:PreReservedSeats>
                                                        <stl19:PreReservedSeat id="29">
                                                            <stl19:SeatNumber>8C</stl19:SeatNumber>
                                                            <stl19:SmokingPrefOfferedIndicator>false</stl19:SmokingPrefOfferedIndicator>
                                                            <stl19:SeatTypeCode>ALKI</stl19:SeatTypeCode>
                                                            <stl19:SeatStatusCode>HK</stl19:SeatStatusCode>
                                                            <stl19:BoardPoint>BAH</stl19:BoardPoint>
                                                            <stl19:OffPoint>DEL</stl19:OffPoint>
                                                            <stl19:Changed>N</stl19:Changed>
                                                            <stl19:NameNumber>01.01</stl19:NameNumber>
                                                        </stl19:PreReservedSeat>
                                                    </stl19:PreReservedSeats>
                                                </stl19:Seats>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-05-01T14:20:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-05-01T20:50:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0134</stl19:FlightNumber>
                                                <stl19:ClassOfService>W</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="24" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 134W1MAY/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="34" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHDEL0134W01MAY/0722134853553C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134853553</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHDEL0134W01MAY/0722134853553C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="54" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHDEL0134W01MAY/0722134853554C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134853554</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHDEL0134W01MAY/0722134853554C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:AncillaryServices>
                                                    <stl19:AncillaryService ref="27"/>
                                                    <stl19:AncillaryService ref="31"/>
                                                </stl19:AncillaryServices>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-03-02T22:46:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BOM</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>IN</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="49" sequence="2">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="5" ResBookDesigCode="E" SmokingAllowed="false" SpecialMeal="false" id="49" isPast="true" segmentAssociationId="5" sequence="2">
                                                <stl19:DepartureAirport>DEL</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>BAH</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0135</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>32Q</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0135</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>E</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>E</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats>
                                                    <stl19:PreReservedSeats>
                                                        <stl19:PreReservedSeat id="64">
                                                            <stl19:SeatNumber>8C</stl19:SeatNumber>
                                                            <stl19:SmokingPrefOfferedIndicator>false</stl19:SmokingPrefOfferedIndicator>
                                                            <stl19:SeatTypeCode>ALKI</stl19:SeatTypeCode>
                                                            <stl19:SeatStatusCode>HK</stl19:SeatStatusCode>
                                                            <stl19:BoardPoint>DEL</stl19:BoardPoint>
                                                            <stl19:OffPoint>BAH</stl19:OffPoint>
                                                            <stl19:Changed>N</stl19:Changed>
                                                            <stl19:NameNumber>01.01</stl19:NameNumber>
                                                        </stl19:PreReservedSeat>
                                                    </stl19:PreReservedSeats>
                                                </stl19:Seats>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-06-13T21:50:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-06-13T23:35:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0135</stl19:FlightNumber>
                                                <stl19:ClassOfService>E</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="50" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF NN1 DELBAH0135E13JUN/YL</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="52" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DELBAH0135E13JUN/0722134853553C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134853553</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DELBAH0135E13JUN/0722134853553C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="55" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 DELBAH0135E13JUN/0722134853554C2</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134853554</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 DELBAH0135E13JUN/0722134853554C2</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:AncillaryServices>
                                                    <stl19:AncillaryService ref="62"/>
                                                </stl19:AncillaryServices>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-03-02T22:49:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BOM</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>IN</stl19:CountryCode>
                                                    <stl19:DutyCode>4</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="42" sequence="3">
                                            <stl19:General dayOfWeekInd="2" isPast="false">
                                                <stl19:Line Number="3" Status="HK" Type="OTH"/>
                                                <stl19:Vendor Code="GF"/>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:Location LocationCode="BOM"/>
                                                <stl19:DateTime>2026-01-27T00:00:00</stl19:DateTime>
                                                <stl19:Text>PNR RETENTION</stl19:Text>
                                            </stl19:General>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-60" id="60" index="1">
                                            <stl19:Code>T-03MAR-BOM4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-38" id="38" index="2">TE 0722134853553 TEST/A BOM4ND1 1017/03MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-44" id="44" index="3">TE 0724400619153 TEST/A BOM4ND1 1017/03MAR - SA</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-45" id="45" index="4">TE 0724400619152 TEST/A BOM4ND1 1017/03MAR - BG</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-59" id="59" index="5">TE 0722134853554 TEST/A BOM4ND1 1019/03MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-66" id="66" index="6">TE 0724400619154 TEST/A BOM4ND1 1020/03MAR - SA</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-38" id="38" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134853553 TEST/A BOM4ND1 1017/03MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134853553</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BOM</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-03T10:17:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-44" id="44" index="3">
                                            <stl19:OriginalTicketDetails>TE 0724400619153 TEST/A BOM4ND1 1017/03MAR - SA</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0724400619153</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BOM</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-03T10:17:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-45" id="45" index="4">
                                            <stl19:OriginalTicketDetails>TE 0724400619152 TEST/A BOM4ND1 1017/03MAR - BG</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0724400619152</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BOM</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-03T10:17:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-59" id="59" index="5">
                                            <stl19:OriginalTicketDetails>TE 0722134853554 TEST/A BOM4ND1 1019/03MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134853554</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BOM</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-03T10:19:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-66" id="66" index="6">
                                            <stl19:OriginalTicketDetails>TE 0724400619154 TEST/A BOM4ND1 1020/03MAR - SA</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0724400619154</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BOM</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-03T10:20:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="7" type="O">
                                                <stl19:Text>TESTINDIA</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="8" type="O">
                                                <stl19:Text>TESTINDIA</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="9" type="O">
                                                <stl19:Text>TESTINDIA, BH IND</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>BOM</stl19:CityCode>
                                        <stl19:Number>93-17373737-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-17" id="17" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID TESTINDIA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-18" id="18" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME TESTINDIA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-19" id="19" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>1430432-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-20" id="20" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS TEST INDIA INDIA CITY TESTINDIA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-21" id="21" index="5" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>COUNTRY IND EMAIL ALI.FADHLI//GULFAIR.COM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-22" id="22" index="6" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY PRIME CONTACT NAME ALI TEST PHONE 2280101105</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-39" id="39" index="7" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="SRQQTE">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>SRQQTE</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-05-18T05:51:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-05-18T05:51:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-05-21T08:42:21</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>8</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-08-01T06:55:00" Start="2025-08-01T02:00:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-04-13T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>-71eeb43a84ca0c4cb6175d91678fdd41094d697eeca803</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>ALI.FADHLI@GULFAIR.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="10" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>17373737/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 17373737/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="11" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>ALI.FADHLI//GULFAIR.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE ALI.FADHLI//GULFAIR.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="17" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 7N1AUG/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="19" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHLHR0007N01AUG/0722134912156C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134912156</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHLHR0007N01AUG/0722134912156C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="27" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YL</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 7N1AUG/YL NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="29" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YL</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 7N1AUG/YL NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="33" msgType="S" type="A">
                                                    <stl19:Code>BLND</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:FullText>BLND NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="9" type="A">
                                                        <stl19:DateOfBirth>2000-05-09</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                                <stl19:SpecialMealRequest id="34" type="A">
                                                    <stl19:MealType>DBML</stl19:MealType>
                                                    <stl19:FlightNumber>7</stl19:FlightNumber>
                                                    <stl19:VendorCode>GF</stl19:VendorCode>
                                                    <stl19:FlightDate>2025-08-01</stl19:FlightDate>
                                                    <stl19:BoardCity>BAH</stl19:BoardCity>
                                                    <stl19:OffCity/>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:ClassOfService>N</stl19:ClassOfService>
                                                </stl19:SpecialMealRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>BAH</stl19:Airport>
                                            <stl19:Departure>2025-08-01T02:00:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="8" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="5" ResBookDesigCode="N" SmokingAllowed="false" SpecialMeal="true" id="8" isPast="false" segmentAssociationId="2" sequence="1">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>LHR</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0007</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>789</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0007</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>N</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>N</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-08-01T02:00:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-08-01T06:55:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0007</stl19:FlightNumber>
                                                <stl19:ClassOfService>N</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="17" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 7N1AUG/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="19" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHLHR0007N01AUG/0722134912156C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134912156</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHLHR0007N01AUG/0722134912156C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="27" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 7N1AUG/YL NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="29" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YL</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 7N1AUG/YL NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="34" msgType="S" type="A">
                                                        <stl19:Code>DBML</stl19:Code>
                                                        <stl19:FreeText>/</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>DBML GF 7N1AUG/BAH NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-05-18T05:51:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>BAH</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>BH</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="25" sequence="2">
                                            <stl19:General dayOfWeekInd="1" isPast="false">
                                                <stl19:Line Number="2" Status="HK" Type="OTH"/>
                                                <stl19:Vendor Code="GF"/>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:Location LocationCode="BAH"/>
                                                <stl19:DateTime>2026-04-13T00:00:00</stl19:DateTime>
                                                <stl19:Text>PNR RETENTION</stl19:Text>
                                            </stl19:General>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-23" id="23" index="1">
                                            <stl19:Code>T-18MAY-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-21" id="21" index="2">TE 0722134912156 TEST/A BAH4ND1 1351/18MAY</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-21" id="21" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134912156 TEST/A BAH4ND1 1351/18MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134912156</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-18T13:51:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-31" id="31" index="1">
                                        <stl19:CityCode>WGF</stl19:CityCode>
                                        <stl19:Number>355-17373737-M</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-12" id="12" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID VT</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-13" id="13" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME VT</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-14" id="14" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>07210420-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-15" id="15" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS BAHRAIN MUHARRAQ  CITY BAHRAINMUHARRAQ</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-22" id="22" index="5" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses>
                                    <stl19:EmailAddress id="32">
                                        <stl19:Address>MM@M.COM</stl19:Address>
                                        <stl19:Comment/>
                                    </stl19:EmailAddress>
                                </stl19:EmailAddresses>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="RXORET">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>RXORET</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-03-04T02:21:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-03-04T02:21:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-03-04T02:25:46</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>7</stl19:PNRSequence>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-28T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>5996cbfcf248b565bcfcd28cd56e07eda6f391c9fea16a1f</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="12" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>17373737/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 17373737/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="13" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="11" type="A">
                                                        <stl19:DateOfBirth>2000-03-29</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments/>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-47" id="47" index="1">
                                            <stl19:Code>T-04MAR-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-27" id="27" index="2">TE 0722134855315 TEST/A BAH4ND1 1122/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-46" id="46" index="3">TE 0722134855267 TEST/A BAH4ND1 1124/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-49" id="49" index="4">TK 0720490452601 TEST/A BAH4ND1 1125/04MAR</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-27" id="27" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134855315 TEST/A BAH4ND1 1122/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855315</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:22:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-46" id="46" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134855267 TEST/A BAH4ND1 1124/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855267</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:24:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-49" id="49" index="4">
                                            <stl19:OriginalTicketDetails>TK 0720490452601 TEST/A BAH4ND1 1125/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TK</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0720490452601</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:25:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>93-17373737-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-14" id="14" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID VT</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-15" id="15" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME VT</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-16" id="16" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>07210420-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-17" id="17" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS BAHRAIN MUHARRAQ  CITY BAHRAINMUHARRAQ</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-28" id="28" index="5" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-45" id="45" index="6" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXAUTH/336560 *Z</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="RKOTQZ">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="2" numberInParty="2" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>RKOTQZ</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-03-04T02:09:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-03-04T02:09:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-05-21T08:42:50</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>10</stl19:PNRSequence>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-28T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>-4be9f85ac2726a83697369e51cf2efa93991d464e9f94aeb</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="6">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="21" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>903589720/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 903589720/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="22" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="19" type="A">
                                                        <stl19:DateOfBirth>1989-03-15</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-4.2" id="4" nameAssocId="2" nameId="02.01" nameType="S" referenceNumber="A02">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MOHAMED MR</stl19:FirstName>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="20" type="A">
                                                        <stl19:DateOfBirth>1990-03-07</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MOHAMED MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments/>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-123" id="123" index="1">
                                            <stl19:Code>T-04MAR-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-53" id="53" index="2">TE 0722134855311 TEST/A BAH4ND1 1109/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-54" id="54" index="3">TE 0722134855312 TEST/M BAH4ND1 1109/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-85" id="85" index="4">TE 0722134855313 TEST/A BAH4ND1 1111/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-97" id="97" index="5">TE 0722134855265 TEST/M BAH4ND1 1111/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-122" id="122" index="6">TE 0722134855314 TEST/M BAH4ND1 1112/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-132" id="132" index="7">TE 0722134855266 TEST/A BAH4ND1 1112/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-134" id="134" index="8">TK 0720480452599 TEST/M BAH4ND1 1112/04MAR</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-135" id="135" index="9">TK 0720480452600 TEST/A BAH4ND1 1112/04MAR</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-53" id="53" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134855311 TEST/A BAH4ND1 1109/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855311</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:09:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-54" id="54" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134855312 TEST/M BAH4ND1 1109/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855312</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:09:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-85" id="85" index="4">
                                            <stl19:OriginalTicketDetails>TE 0722134855313 TEST/A BAH4ND1 1111/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855313</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:11:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-97" id="97" index="5">
                                            <stl19:OriginalTicketDetails>TE 0722134855265 TEST/M BAH4ND1 1111/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855265</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:11:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-122" id="122" index="6">
                                            <stl19:OriginalTicketDetails>TE 0722134855314 TEST/M BAH4ND1 1112/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855314</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:12:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-132" id="132" index="7">
                                            <stl19:OriginalTicketDetails>TE 0722134855266 TEST/A BAH4ND1 1112/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134855266</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:12:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-134" id="134" index="8">
                                            <stl19:OriginalTicketDetails>TK 0720480452599 TEST/M BAH4ND1 1112/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TK</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0720480452599</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:12:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-135" id="135" index="9">
                                            <stl19:OriginalTicketDetails>TK 0720480452600 TEST/A BAH4ND1 1112/04MAR</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TK</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0720480452600</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-03-04T11:12:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="8" type="O">
                                                <stl19:Text>GFTEST</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="9" type="O">
                                                <stl19:Text>BAHRAIN</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="10" type="O">
                                                <stl19:Text>BAHRAIN, BH BHR</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-141" id="141" index="1">
                                        <stl19:CityCode>WGF</stl19:CityCode>
                                        <stl19:Number>501-17373737-M</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-23" id="23" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID GF TEST BAHRAIN</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-24" id="24" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME GF TEST BAHRAIN</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-25" id="25" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>07210051-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-26" id="26" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS BAHRAIN BAHRAIN CITY BAHRAIN</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-55" id="55" index="5" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses>
                                    <stl19:EmailAddress id="142">
                                        <stl19:Address>MM@M.COM</stl19:Address>
                                        <stl19:Comment/>
                                    </stl19:EmailAddress>
                                </stl19:EmailAddresses>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="SMGGAV">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="9" numberInParty="9" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>SMGGAV</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-02-07T06:35:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-02-07T06:35:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-02-07T06:35:59</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>5</stl19:PNRSequence>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-01-03T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>-51fd3912b8107c2fcf1409cb997a4ca924db7545fa482830</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="BH" PrimeHostID="GF" PseudoCityCode="BAH"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MANISH MR</stl19:FirstName>
                                            <stl19:EmailAddress id="13">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="47" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>78654328/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 78654328/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="48" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>LEVEL2//GMAIL.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE LEVEL2//GMAIL.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="38" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551111</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-16</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MANISH MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-4.2" id="4" nameAssocId="2" nameId="02.01" nameType="S" referenceNumber="A02">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MURALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="14">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="39" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551311</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-19</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MURALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-5.3" id="5" nameAssocId="3" nameId="03.01" nameType="S" referenceNumber="A03">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>RAJA MR</stl19:FirstName>
                                            <stl19:EmailAddress id="15">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="40" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551411</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-20</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>RAJA MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-6.4" id="6" nameAssocId="4" nameId="04.01" nameType="S" referenceNumber="A04">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MUKUND MR</stl19:FirstName>
                                            <stl19:EmailAddress id="16">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="41" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551511</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-11-21</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MUKUND MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-7.5" id="7" nameAssocId="5" nameId="05.01" nameType="S" referenceNumber="A05">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>VEER MR</stl19:FirstName>
                                            <stl19:EmailAddress id="17">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="42" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551412</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-09-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>VEER MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-8.6" id="8" nameAssocId="6" nameId="06.01" nameType="S" referenceNumber="A06">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ROOP MR</stl19:FirstName>
                                            <stl19:EmailAddress id="18">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="43" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551413</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-10-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ROOP MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-9.7" id="9" nameAssocId="7" nameId="07.01" nameType="S" referenceNumber="A07">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>SID MR</stl19:FirstName>
                                            <stl19:EmailAddress id="19">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="44" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551414</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-06-22</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>SID MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-10.8" id="10" nameAssocId="8" nameId="08.01" nameType="S" referenceNumber="A08">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>MALAVIKA MRS</stl19:FirstName>
                                            <stl19:EmailAddress id="20">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="45" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551415</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1983-05-10</stl19:DateOfBirth>
                                                        <stl19:Gender>F</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>MALAVIKA MRS</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                        <stl19:Passenger elementId="pnr-11.9" id="11" nameAssocId="9" nameId="09.01" nameType="S" referenceNumber="A09">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>KRISHNA MRS</stl19:FirstName>
                                            <stl19:EmailAddress id="21">
                                                <stl19:Address>LEVEL2@GMAIL.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="46" type="A">
                                                        <stl19:DocumentType>P</stl19:DocumentType>
                                                        <stl19:CountryOfIssue>AL</stl19:CountryOfIssue>
                                                        <stl19:DocumentNumber>IND785551416</stl19:DocumentNumber>
                                                        <stl19:DocumentNationalityCountry>AL</stl19:DocumentNationalityCountry>
                                                        <stl19:DateOfBirth>1984-11-22</stl19:DateOfBirth>
                                                        <stl19:Gender>F</stl19:Gender>
                                                        <stl19:DocumentExpirationDate>2037-11-12</stl19:DocumentExpirationDate>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>KRISHNA MRS</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments/>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-121" id="121" index="1">
                                            <stl19:Code>T-07FEB-BAH4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-111" id="111" index="2">TE 0722134521149 TEST/M BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-112" id="112" index="3">TE 0722134521150 TEST/M BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-113" id="113" index="4">TE 0722134521151 TEST/R BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-114" id="114" index="5">TE 0722134521152 TEST/M BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-115" id="115" index="6">TE 0722134521153 TEST/V BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-116" id="116" index="7">TE 0722134521154 TEST/R BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-117" id="117" index="8">TE 0722134521155 TEST/S BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-118" id="118" index="9">TE 0722134521156 TEST/M BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-119" id="119" index="10">TE 0722134521157 TEST/K BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-125" id="125" index="10">TV 0722134521149 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-126" id="126" index="10">TV 0722134521150 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-127" id="127" index="10">TV 0722134521151 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-128" id="128" index="10">TV 0722134521152 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-129" id="129" index="10">TV 0722134521153 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-130" id="130" index="10">TV 0722134521154 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-131" id="131" index="10">TV 0722134521155 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-132" id="132" index="10">TV 0722134521156 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:ETicketNumber elementId="pnr-133" id="133" index="10">TV 0722134521157 *VOID*  BAH4ND1 1535/07FEB</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-111" id="111" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134521149 TEST/M BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521149</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-112" id="112" index="3">
                                            <stl19:OriginalTicketDetails>TE 0722134521150 TEST/M BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521150</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-113" id="113" index="4">
                                            <stl19:OriginalTicketDetails>TE 0722134521151 TEST/R BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521151</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/R</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-114" id="114" index="5">
                                            <stl19:OriginalTicketDetails>TE 0722134521152 TEST/M BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521152</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-115" id="115" index="6">
                                            <stl19:OriginalTicketDetails>TE 0722134521153 TEST/V BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521153</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/V</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-116" id="116" index="7">
                                            <stl19:OriginalTicketDetails>TE 0722134521154 TEST/R BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521154</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/R</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-117" id="117" index="8">
                                            <stl19:OriginalTicketDetails>TE 0722134521155 TEST/S BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521155</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/S</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-118" id="118" index="9">
                                            <stl19:OriginalTicketDetails>TE 0722134521156 TEST/M BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521156</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/M</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-119" id="119" index="10">
                                            <stl19:OriginalTicketDetails>TE 0722134521157 TEST/K BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521157</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/K</stl19:PassengerName>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-125" id="125" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521149 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521149</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-126" id="126" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521150 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521150</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-127" id="127" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521151 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521151</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-128" id="128" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521152 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521152</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-129" id="129" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521153 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521153</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-130" id="130" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521154 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521154</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-131" id="131" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521155 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521155</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-132" id="132" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521156 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521156</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                        <stl19:TicketDetails elementId="pnr-133" id="133" index="10">
                                            <stl19:OriginalTicketDetails>TV 0722134521157 *VOID*  BAH4ND1 1535/07FEB</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TV</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134521157</stl19:TicketNumber>
                                            <stl19:PassengerName/>
                                            <stl19:AgencyLocation>BAH</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-02-07T15:35:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="31" type="O">
                                                <stl19:Text>PRITHVITRAVELSIATA</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="32" type="O">
                                                <stl19:Text>TEST</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="33" type="O">
                                                <stl19:Text>TEST, BH BHR</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-22" id="22" index="1">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-23" id="23" index="2">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-2.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-24" id="24" index="3">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-3.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-25" id="25" index="4">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-4.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-26" id="26" index="5">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-5.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-27" id="27" index="6">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-6.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-28" id="28" index="7">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-7.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-29" id="29" index="8">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-8.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                    <stl19:PhoneNumber elementId="pnr-30" id="30" index="9">
                                        <stl19:CityCode>BAH</stl19:CityCode>
                                        <stl19:Number>971-4545454567-H-9.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-49" id="49" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID PRITHVI TRAVELS IATA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-50" id="50" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME PRITHVI TRAVELS IATA</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-51" id="51" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>0721036-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-52" id="52" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS TEST  CITY TEST</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-53" id="53" index="5" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>COUNTRY BHR EMAIL PRITHVITRAVELSIATA//MAILINATOR.COM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-54" id="54" index="6" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY PRIME CONTACT NAME TEST PHONE 78654328</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-120" id="120" index="7" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                    <Reservation Locator="PVVAPJ">
                        <stl19:GetReservationRS xmlns:stl19="http://webservices.sabre.com/pnrbuilder/v1_19" xmlns:or114="http://services.sabre.com/res/or/v1_14" xmlns:raw="http://tds.sabre.com/itinerary" xmlns:ns4="http://webservices.sabre.com/pnrconn/ReaccSearch" xmlns:ns6="http://services.sabre.com/res/orr/v0" Version="1.19.0">
                            <stl19:Reservation NumberInSegment="1" numberInParty="1" numberOfInfants="0">
                                <stl19:BookingDetails>
                                    <stl19:RecordLocator>PVVAPJ</stl19:RecordLocator>
                                    <stl19:CreationTimestamp>2025-05-20T04:45:00</stl19:CreationTimestamp>
                                    <stl19:SystemCreationTimestamp>2025-05-20T04:45:00</stl19:SystemCreationTimestamp>
                                    <stl19:CreationAgentID>ND1</stl19:CreationAgentID>
                                    <stl19:UpdateTimestamp>2025-05-21T07:07:04</stl19:UpdateTimestamp>
                                    <stl19:PNRSequence>6</stl19:PNRSequence>
                                    <stl19:FlightsRange End="2025-06-27T12:20:00" Start="2025-06-26T23:30:00"/>
                                    <stl19:DivideSplitDetails/>
                                    <stl19:EstimatedPurgeTimestamp>2026-04-16T00:00:00</stl19:EstimatedPurgeTimestamp>
                                    <stl19:UpdateToken>2072d75a7aa3917bfd00d98e54e04b0bdf22fd8c3b147dae</stl19:UpdateToken>
                                </stl19:BookingDetails>
                                <stl19:POS AirExtras="false" InhibitCode="U">
                                    <stl19:Source AgentDutyCode="7" AgentSine="ND1" AirlineVendorID="GF" BookingSource="A0A0" HomePseudoCityCode="BAH" ISOCountry="AU" PrimeHostID="GF" PseudoCityCode="SYD"/>
                                </stl19:POS>
                                <stl19:PassengerReservation>
                                    <stl19:Passengers>
                                        <stl19:Passenger elementId="pnr-3.1" id="3" nameAssocId="1" nameId="01.01" nameType="S" referenceNumber="A01">
                                            <stl19:LastName>TEST</stl19:LastName>
                                            <stl19:FirstName>ALI MR</stl19:FirstName>
                                            <stl19:EmailAddress id="5">
                                                <stl19:Address>TEST@TEST.COM</stl19:Address>
                                                <stl19:Comment/>
                                            </stl19:EmailAddress>
                                            <stl19:SpecialRequests>
                                                <stl19:GenericSpecialRequest id="13" msgType="O" type="A">
                                                    <stl19:Code>CTCM</stl19:Code>
                                                    <stl19:FreeText>333393169/EN</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCM 333393169/EN</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="14" msgType="O" type="A">
                                                    <stl19:Code>CTCE</stl19:Code>
                                                    <stl19:FreeText>TEST//TEST.COM</stl19:FreeText>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>GF CTCE TEST//TEST.COM</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="20" msgType="S" type="A">
                                                    <stl19:Code>TKTT</stl19:Code>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>TKTT GF 165O26JUN/NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="24" msgType="S" type="A">
                                                    <stl19:Code>TKNE</stl19:Code>
                                                    <stl19:FreeText>GF HK1 BAHSIN0165O26JUN/0722134915384C1</stl19:FreeText>
                                                    <stl19:ActionCode>HK</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:TicketNumber>0722134915384</stl19:TicketNumber>
                                                    <stl19:FullText>TKNE GF HK1 BAHSIN0165O26JUN/0722134915384C1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="32" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 165O26JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:GenericSpecialRequest id="34" msgType="S" type="A">
                                                    <stl19:Code>BRND</stl19:Code>
                                                    <stl19:FreeText>/YS</stl19:FreeText>
                                                    <stl19:ActionCode>NN</stl19:ActionCode>
                                                    <stl19:NumberInParty>1</stl19:NumberInParty>
                                                    <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                    <stl19:FullText>BRND GF 165O26JUN/YS NN1</stl19:FullText>
                                                </stl19:GenericSpecialRequest>
                                                <stl19:APISRequest>
                                                    <stl19:DOCSEntry id="12" type="A">
                                                        <stl19:DateOfBirth>1996-05-08</stl19:DateOfBirth>
                                                        <stl19:Gender>M</stl19:Gender>
                                                        <stl19:Surname>TEST</stl19:Surname>
                                                        <stl19:Forename>ALI MR</stl19:Forename>
                                                        <stl19:MiddleName/>
                                                        <stl19:PrimaryHolder>false</stl19:PrimaryHolder>
                                                        <stl19:FreeText/>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:VendorCode>GF</stl19:VendorCode>
                                                    </stl19:DOCSEntry>
                                                </stl19:APISRequest>
                                            </stl19:SpecialRequests>
                                            <stl19:Seats/>
                                        </stl19:Passenger>
                                    </stl19:Passengers>
                                    <stl19:Segments>
                                        <stl19:Poc>
                                            <stl19:Airport>BAH</stl19:Airport>
                                            <stl19:Departure>2025-06-26T23:30:00</stl19:Departure>
                                        </stl19:Poc>
                                        <stl19:Segment id="11" sequence="1">
                                            <stl19:Air CodeShare="false" DayOfWeekInd="4" ResBookDesigCode="O" SmokingAllowed="false" SpecialMeal="false" id="11" isPast="true" segmentAssociationId="2" sequence="1">
                                                <stl19:DepartureAirport>BAH</stl19:DepartureAirport>
                                                <stl19:DepartureAirportCodeContext>IATA</stl19:DepartureAirportCodeContext>
                                                <stl19:ArrivalAirport>SIN</stl19:ArrivalAirport>
                                                <stl19:ArrivalAirportCodeContext>IATA</stl19:ArrivalAirportCodeContext>
                                                <stl19:OperatingAirlineCode>GF</stl19:OperatingAirlineCode>
                                                <stl19:OperatingAirlineShortName>GULF AIR</stl19:OperatingAirlineShortName>
                                                <stl19:OperatingFlightNumber>0165</stl19:OperatingFlightNumber>
                                                <stl19:EquipmentType>789</stl19:EquipmentType>
                                                <stl19:MarketingAirlineCode>GF</stl19:MarketingAirlineCode>
                                                <stl19:MarketingFlightNumber>0165</stl19:MarketingFlightNumber>
                                                <stl19:OperatingClassOfService>O</stl19:OperatingClassOfService>
                                                <stl19:MarketingClassOfService>O</stl19:MarketingClassOfService>
                                                <stl19:MarriageGrp>
                                                    <stl19:Ind>0</stl19:Ind>
                                                    <stl19:Group>0</stl19:Group>
                                                    <stl19:Sequence>0</stl19:Sequence>
                                                </stl19:MarriageGrp>
                                                <stl19:Seats/>
                                                <stl19:Eticket>true</stl19:Eticket>
                                                <stl19:DepartureDateTime>2025-06-26T23:30:00</stl19:DepartureDateTime>
                                                <stl19:ArrivalDateTime>2025-06-27T12:20:00</stl19:ArrivalDateTime>
                                                <stl19:FlightNumber>0165</stl19:FlightNumber>
                                                <stl19:ClassOfService>O</stl19:ClassOfService>
                                                <stl19:ActionCode>HK</stl19:ActionCode>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:SegmentSpecialRequests>
                                                    <stl19:GenericSpecialRequest id="20" msgType="S" type="A">
                                                        <stl19:Code>TKTT</stl19:Code>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>TKTT GF 165O26JUN/NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="24" msgType="S" type="A">
                                                        <stl19:Code>TKNE</stl19:Code>
                                                        <stl19:FreeText>GF HK1 BAHSIN0165O26JUN/0722134915384C1</stl19:FreeText>
                                                        <stl19:ActionCode>HK</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:TicketNumber>0722134915384</stl19:TicketNumber>
                                                        <stl19:FullText>TKNE GF HK1 BAHSIN0165O26JUN/0722134915384C1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="32" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 165O26JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                    <stl19:GenericSpecialRequest id="34" msgType="S" type="A">
                                                        <stl19:Code>BRND</stl19:Code>
                                                        <stl19:FreeText>/YS</stl19:FreeText>
                                                        <stl19:ActionCode>NN</stl19:ActionCode>
                                                        <stl19:NumberInParty>1</stl19:NumberInParty>
                                                        <stl19:AirlineCode>GF</stl19:AirlineCode>
                                                        <stl19:FullText>BRND GF 165O26JUN/YS NN1</stl19:FullText>
                                                    </stl19:GenericSpecialRequest>
                                                </stl19:SegmentSpecialRequests>
                                                <stl19:inboundConnection>false</stl19:inboundConnection>
                                                <stl19:outboundConnection>false</stl19:outboundConnection>
                                                <stl19:ScheduleChangeIndicator>false</stl19:ScheduleChangeIndicator>
                                                <stl19:SegmentBookedDate>2025-05-20T04:45:00</stl19:SegmentBookedDate>
                                                <stl19:Pos>
                                                    <stl19:IataNumber>0</stl19:IataNumber>
                                                    <stl19:AgencyCityCode>SYD</stl19:AgencyCityCode>
                                                    <stl19:CountryCode>AU</stl19:CountryCode>
                                                    <stl19:DutyCode>7</stl19:DutyCode>
                                                </stl19:Pos>
                                                <stl19:Banner>MARKETED BY GULF AIR</stl19:Banner>
                                                <stl19:Informational>false</stl19:Informational>
                                            </stl19:Air>
                                        </stl19:Segment>
                                        <stl19:Segment id="30" sequence="2">
                                            <stl19:General dayOfWeekInd="4" isPast="false">
                                                <stl19:Line Number="2" Status="HK" Type="OTH"/>
                                                <stl19:Vendor Code="GF"/>
                                                <stl19:NumberInParty>1</stl19:NumberInParty>
                                                <stl19:Location LocationCode="SYD"/>
                                                <stl19:DateTime>2026-04-16T00:00:00</stl19:DateTime>
                                                <stl19:Text>PNR RETENTION</stl19:Text>
                                            </stl19:General>
                                        </stl19:Segment>
                                    </stl19:Segments>
                                    <stl19:TicketingInfo>
                                        <stl19:AlreadyTicketed elementId="pnr-28" id="28" index="1">
                                            <stl19:Code>T-21MAY-SYD4ND1</stl19:Code>
                                        </stl19:AlreadyTicketed>
                                        <stl19:ETicketNumber elementId="pnr-26" id="26" index="2">TE 0722134915384 TEST/A SYD4ND1 2201/21MAY</stl19:ETicketNumber>
                                        <stl19:TicketDetails elementId="pnr-26" id="26" index="2">
                                            <stl19:OriginalTicketDetails>TE 0722134915384 TEST/A SYD4ND1 2201/21MAY</stl19:OriginalTicketDetails>
                                            <stl19:TransactionIndicator>TE</stl19:TransactionIndicator>
                                            <stl19:TicketNumber>0722134915384</stl19:TicketNumber>
                                            <stl19:PassengerName>TEST/A</stl19:PassengerName>
                                            <stl19:AgencyLocation>SYD</stl19:AgencyLocation>
                                            <stl19:DutyCode>4</stl19:DutyCode>
                                            <stl19:AgentSine>ND1</stl19:AgentSine>
                                            <stl19:Timestamp>2025-05-21T22:01:00</stl19:Timestamp>
                                            <stl19:PaymentType/>
                                        </stl19:TicketDetails>
                                    </stl19:TicketingInfo>
                                    <stl19:ItineraryPricing/>
                                </stl19:PassengerReservation>
                                <stl19:ReceivedFrom>
                                    <stl19:Name>SWE</stl19:Name>
                                </stl19:ReceivedFrom>
                                <stl19:Addresses>
                                    <stl19:Address>
                                        <stl19:AddressLines>
                                            <stl19:AddressLine id="7" type="O">
                                                <stl19:Text>AUSTESTAGENCY</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="8" type="O">
                                                <stl19:Text>GFHDQ</stl19:Text>
                                            </stl19:AddressLine>
                                            <stl19:AddressLine id="9" type="O">
                                                <stl19:Text>GFHDQ, BH AUS</stl19:Text>
                                            </stl19:AddressLine>
                                        </stl19:AddressLines>
                                    </stl19:Address>
                                </stl19:Addresses>
                                <stl19:PhoneNumbers>
                                    <stl19:PhoneNumber elementId="pnr-6" id="6" index="1">
                                        <stl19:CityCode>SYD</stl19:CityCode>
                                        <stl19:Number>93-17373737-H-1.1</stl19:Number>
                                    </stl19:PhoneNumber>
                                </stl19:PhoneNumbers>
                                <stl19:Remarks>
                                    <stl19:Remark elementId="pnr-15" id="15" index="1" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NDC LOGIN ID AUS TEST AGENCY</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-16" id="16" index="2" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>AGENCY NAME AUS TEST AGENCY</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-17" id="17" index="3" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>02353116-NDC DIRECT PLATFORM ID</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-18" id="18" index="4" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text> ADDRESS GF HDQ  CITY GFHDQ</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-22" id="22" index="5" type="HS">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>TICKET PNR BY 24MAY25 0945GMT OR WILL BE CANCELED BY GF SYSTEM</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                    <stl19:Remark elementId="pnr-27" id="27" index="6" type="REG">
                                        <stl19:RemarkLines>
                                            <stl19:RemarkLine>
                                                <stl19:Text>XXTAW/</stl19:Text>
                                            </stl19:RemarkLine>
                                        </stl19:RemarkLines>
                                    </stl19:Remark>
                                </stl19:Remarks>
                                <stl19:EmailAddresses/>
                            </stl19:Reservation>
                        </stl19:GetReservationRS>
                    </Reservation>
                </Reservations>
            </ReservationsList>
        </Trip_SearchRS>
    </soap-env:Body>
</soap-env:Envelope>

''' xml