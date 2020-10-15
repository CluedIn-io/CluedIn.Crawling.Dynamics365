using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class SystemuserVocabulary : SimpleVocabulary
    {
        public SystemuserVocabulary()
        {
            VocabularyName = "Dynamics365 Systemuser"; // TODO: Set value
            KeyPrefix = "dynamics365.SystemUser"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Bruger"; // TODO: Check value

            AddGroup("Bruger Details", group =>
            {
                Accessmode = group.Add(new VocabularyKey("accessmode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adgangstilstand").WithDescription("Brugertype."));
                Activedirectoryguid = group.Add(new VocabularyKey("activedirectoryguid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Guid for Active Directory").WithDescription("Active Directory-objekt-GUID for systembrugeren."));
                Address1Addresstypecode = group.Add(new VocabularyKey("address1Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Adressetype").WithDescription("\"Adressetypen for adresse 1, f.eks. faktureringsadresse, forsendelsesadresse eller primær adresse.\""));
                Address1City = group.Add(new VocabularyKey("address1City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("By").WithDescription("Bynavn i adresse 1."));
                Address1Composite = group.Add(new VocabularyKey("address1Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse").WithDescription("Viser den fulde primære adresse."));
                Address1Country = group.Add(new VocabularyKey("address1Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Land/område").WithDescription("Lande-/områdenavn i adresse 1."));
                Address1County = group.Add(new VocabularyKey("address1County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Region").WithDescription("Region i adresse 1."));
                Address1Fax = group.Add(new VocabularyKey("address1Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Fax").WithDescription("Faxnummer til adresse 1."));
                Address1Latitude = group.Add(new VocabularyKey("address1Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Breddegrad").WithDescription("Breddegrad for adresse 1."));
                Address1Line1 = group.Add(new VocabularyKey("address1Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gade 1").WithDescription("Første linje til angivelse af oplysninger om adresse 1."));
                Address1Line2 = group.Add(new VocabularyKey("address1Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gade 2").WithDescription("Anden linje til angivelse af oplysninger om adresse 1."));
                Address1Line3 = group.Add(new VocabularyKey("address1Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gade 3").WithDescription("Tredje linje til angivelse af oplysninger om adresse 1."));
                Address1Longitude = group.Add(new VocabularyKey("address1Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Længdegrad").WithDescription("Længdegrad for adresse 1."));
                Address1Name = group.Add(new VocabularyKey("address1Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Navn").WithDescription("\"Det navn, der skal angives for adresse 1.\""));
                Address1Postalcode = group.Add(new VocabularyKey("address1Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Postnummer").WithDescription("Postnummer i adresse 1."));
                Address1Postofficebox = group.Add(new VocabularyKey("address1Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Postboksnummer").WithDescription("Postboksnummer i adresse 1."));
                Address1Shippingmethodcode = group.Add(new VocabularyKey("address1Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Forsendelsesmåde").WithDescription("Forsendelsesmåde for adresse 1."));
                Address1Stateorprovince = group.Add(new VocabularyKey("address1Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Område").WithDescription("Område i adresse 1."));
                Address1Telephone1 = group.Add(new VocabularyKey("address1Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær telefon").WithDescription("\"Første telefonnummer, der er tilknyttet adresse 1.\""));
                Address1Telephone2 = group.Add(new VocabularyKey("address1Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden telefon").WithDescription("\"Andet telefonnummer, der er tilknyttet adresse 1.\""));
                Address1Telephone3 = group.Add(new VocabularyKey("address1Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Personsøger").WithDescription("\"Tredje telefonnummer, der er tilknyttet adresse 1.\""));
                Address1Upszone = group.Add(new VocabularyKey("address1Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: UPS-zone").WithDescription("UPS-zone (United Parcel Service) for adresse 1."));
                Address2Addresstypecode = group.Add(new VocabularyKey("address2Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Adressetype").WithDescription("\"Adressetypen for adresse 2, f.eks. faktureringsadresse, forsendelsesadresse eller primær adresse.\""));
                Address2City = group.Add(new VocabularyKey("address2City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden by").WithDescription("Bynavn i adresse 2."));
                Address2Composite = group.Add(new VocabularyKey("address2Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden adresse").WithDescription("Viser den fulde sekundære adresse."));
                Address2Country = group.Add(new VocabularyKey("address2Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Andet land/område").WithDescription("Lande-/områdenavn i adresse 2."));
                Address2County = group.Add(new VocabularyKey("address2County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Region").WithDescription("Region i adresse 2."));
                Address2Fax = group.Add(new VocabularyKey("address2Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Fax").WithDescription("Faxnummer til adresse 2."));
                Address2Latitude = group.Add(new VocabularyKey("address2Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Breddegrad").WithDescription("Breddegrad for adresse 2."));
                Address2Line1 = group.Add(new VocabularyKey("address2Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden gade 1").WithDescription("Første linje til angivelse af oplysninger om adresse 2."));
                Address2Line2 = group.Add(new VocabularyKey("address2Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden gade 2").WithDescription("Anden linje til angivelse af oplysninger om adresse 2."));
                Address2Line3 = group.Add(new VocabularyKey("address2Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden gade 3").WithDescription("Tredje linje til angivelse af oplysninger om adresse 2."));
                Address2Longitude = group.Add(new VocabularyKey("address2Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Længdegrad").WithDescription("Længdegrad for adresse 2."));
                Address2Name = group.Add(new VocabularyKey("address2Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Navn").WithDescription("\"Det navn, der skal angives for adresse 2.\""));
                Address2Postalcode = group.Add(new VocabularyKey("address2Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Andet postnummer").WithDescription("Postnummer i adresse 2."));
                Address2Postofficebox = group.Add(new VocabularyKey("address2Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Postboksnummer").WithDescription("Postboksnummer i adresse 2."));
                Address2Shippingmethodcode = group.Add(new VocabularyKey("address2Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Forsendelsesmåde").WithDescription("Forsendelsesmåde for adresse 2."));
                Address2Stateorprovince = group.Add(new VocabularyKey("address2Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Andet område").WithDescription("Område i adresse 2."));
                Address2Telephone1 = group.Add(new VocabularyKey("address2Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 1").WithDescription("\"Første telefonnummer, der er tilknyttet adresse 2.\""));
                Address2Telephone2 = group.Add(new VocabularyKey("address2Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 2").WithDescription("\"Andet telefonnummer, der er tilknyttet adresse 2.\""));
                Address2Telephone3 = group.Add(new VocabularyKey("address2Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 3").WithDescription("\"Tredje telefonnummer, der er tilknyttet adresse 2.\""));
                Address2Upszone = group.Add(new VocabularyKey("address2Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: UPS-zone").WithDescription("UPS-zone (United Parcel Service) for adresse 2."));
                Applicationid = group.Add(new VocabularyKey("applicationid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Program-id").WithDescription("Id'et for programmet. Dette bruges til at få adgang til data i et andet program."));
                Applicationiduri = group.Add(new VocabularyKey("applicationiduri", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("URI for program-id").WithDescription("\"Den URI, der blev brugt som et entydigt logisk id for den eksterne app. Dette kan bruges til at validere programmet.\""));
                Azureactivedirectoryobjectid = group.Add(new VocabularyKey("azureactivedirectoryobjectid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Objekt-id for Azure AD").WithDescription("Dette er objekt-id'et for programmappen."));
                Businessunitid = group.Add(new VocabularyKey("businessunitid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Afdeling").WithDescription("\"Entydigt id for den afdeling, som brugeren er tilknyttet.\""));
                Calendarid = group.Add(new VocabularyKey("calendarid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kalender").WithDescription("\"Den regnskabskalender, der er tilknyttet brugeren.\""));
                Caltype = group.Add(new VocabularyKey("caltype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Licenstype").WithDescription("\"Den type licens, brugeren har.\""));
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede brugeren.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet").WithDescription("Dato og klokkeslæt for oprettelse af brugeren."));
                Defaultfilterspopulated = group.Add(new VocabularyKey("defaultfilterspopulated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standardfiltre er udfyldt").WithDescription("\"Angiver, om standardfiltrene i Outlook er blevet udfyldt.\""));
                Defaultmailbox = group.Add(new VocabularyKey("defaultmailbox", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Postkasse").WithDescription("\"Vælg den postkasse, der er tilknyttet denne bruger.\""));
                Defaultodbfoldername = group.Add(new VocabularyKey("defaultodbfoldername", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standard mappenavn for OneDrive for Business").WithDescription("Angiv et standardmappenavn for brugerens placering af OneDrive for Business."));
                Disabledreason = group.Add(new VocabularyKey("disabledreason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsag til deaktivering").WithDescription("Årsag til deaktivering af brugeren."));
                Displayinserviceviews = group.Add(new VocabularyKey("displayinserviceviews", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Vis i servicevisninger").WithDescription("\"Angiver, om brugeren skal vises i servicevisninger.\""));
                Domainname = group.Add(new VocabularyKey("domainname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Brugernavn").WithDescription("\"Det Active Directory-domæne, som brugeren er medlem af.\""));
                DynaInitialer = group.Add(new VocabularyKey("dynaInitialer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Initialer").WithDescription("Brukare initialer. Brukas til Outplacement Konsulenter."));
                Emailrouteraccessapproval = group.Add(new VocabularyKey("emailrouteraccessapproval", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status for primær e-mail-adresse").WithDescription("Viser statussen for den primære e-mail-adresse."));
                Employeeid = group.Add(new VocabularyKey("employeeid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Medarbejder").WithDescription("Brugerens medarbejder-id."));
                Entityimage = group.Add(new VocabularyKey("entityimage", VocabularyKeyDataType.Unknown, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Objektbillede").WithDescription("Viser postens standardbillede."));
                Entityimageid = group.Add(new VocabularyKey("entityimageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for objektbillede").WithDescription("Kun til intern brug."));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("\"Valutakurs for den valuta, der er tilknyttet systembrugeren, i forhold til grundvalutaen.\""));
                Firstname = group.Add(new VocabularyKey("firstname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fornavn").WithDescription("Brugerens fornavn."));
                Fullname = group.Add(new VocabularyKey("fullname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fulde navn").WithDescription("Brugerens fulde navn."));
                Governmentid = group.Add(new VocabularyKey("governmentid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statslig").WithDescription("Brugerens cpr.nr."));
                Homephone = group.Add(new VocabularyKey("homephone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon (privat)").WithDescription("Brugerens private telefonnummer."));
                Identityid = group.Add(new VocabularyKey("identityid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Entydigt brugeridentitets-id").WithDescription("Kun til intern brug."));
                Incomingemaildeliverymethod = group.Add(new VocabularyKey("incomingemaildeliverymethod", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Leveringsmetode for indgående e-mail").WithDescription("Leveringsmetode for indgående e-mail for brugeren."));
                Internalemailaddress = group.Add(new VocabularyKey("internalemailaddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær e-mail").WithDescription("Brugerens interne e-mail-adresse."));
                Invitestatuscode = group.Add(new VocabularyKey("invitestatuscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status for invitation").WithDescription("Status for brugerinvitation."));
                Isactivedirectoryuser = group.Add(new VocabularyKey("isactivedirectoryuser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Er Active Directory-bruger").WithDescription("\"Oplysninger, der angiver, om brugeren er en AD-bruger.\""));
                Isdisabled = group.Add(new VocabularyKey("isdisabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("\"Angiver, om brugeren er aktiveret.\""));
                Isemailaddressapprovedbyo365admin = group.Add(new VocabularyKey("isemailaddressapprovedbyo365admin", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status for O365-administrators godkendelse af e-mail-adresse").WithDescription("Viser status for O365-administratorens godkendelse af e-mail-adressen."));
                Isintegrationuser = group.Add(new VocabularyKey("isintegrationuser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Integrationsbrugertilstand").WithDescription("\"Kontrollér, om brugeren er en integrationsbruger.\""));
                Islicensed = group.Add(new VocabularyKey("islicensed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Brugerlicens").WithDescription("\"Angiver, om brugeren har licens.\""));
                Issyncwithdirectory = group.Add(new VocabularyKey("issyncwithdirectory", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bruger synkroniseret").WithDescription("\"Oplysninger om, hvorvidt brugeren og mappen er synkroniseret.\""));
                Jobtitle = group.Add(new VocabularyKey("jobtitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Stilling").WithDescription("Brugerens stillingsbetegnelse."));
                Lastname = group.Add(new VocabularyKey("lastname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Efternavn").WithDescription("Brugerens efternavn."));
                Latestupdatetime = group.Add(new VocabularyKey("latestupdatetime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste opdateringstidspunkt for bruger").WithDescription("Tidsstempel for den seneste opdatering til brugeren"));
                Middlename = group.Add(new VocabularyKey("middlename", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mellemnavn").WithDescription("Brugerens mellemnavn."));
                Mobilealertemail = group.Add(new VocabularyKey("mobilealertemail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mobil besked-e-mail").WithDescription("Brugerens e-mail-adresse til mobile beskeder."));
                Mobileofflineprofileid = group.Add(new VocabularyKey("mobileofflineprofileid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mobile Offline-profil").WithDescription("Elementer for en bestemt systembruger."));
                Mobilephone = group.Add(new VocabularyKey("mobilephone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mobiltelefon").WithDescription("Brugerens mobilnummer."));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der sidst ændrede brugeren.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("Dato og klokkeslæt for den seneste ændring af brugeren."));
                MsdynGdproptout = group.Add(new VocabularyKey("msdynGdproptout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("GDPR-framelding").WithDescription("\"Beskriver, om brugeren er frameldt eller ej\""));
                Nickname = group.Add(new VocabularyKey("nickname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kaldenavn").WithDescription("Brugerens kælenavn."));
                Organizationid = group.Add(new VocabularyKey("organizationid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Organisation").WithDescription("\"Entydigt id for den organisation, der er tilknyttet brugeren.\""));
                Outgoingemaildeliverymethod = group.Add(new VocabularyKey("outgoingemaildeliverymethod", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Leveringsmetode for udgående e-mail").WithDescription("Leveringsmetode for udgående e-mail for brugeren."));
                Parentsystemuserid = group.Add(new VocabularyKey("parentsystemuserid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Leder").WithDescription("Entydigt id for brugerens leder."));
                Passporthi = group.Add(new VocabularyKey("passporthi", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Passport Høj").WithDescription("Kun til intern brug."));
                Passportlo = group.Add(new VocabularyKey("passportlo", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Passport Lav").WithDescription("Kun til intern brug."));
                Personalemailaddress = group.Add(new VocabularyKey("personalemailaddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mail 2").WithDescription("Brugerens personlige e-mail-adresse."));
                Photourl = group.Add(new VocabularyKey("photourl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("URL-adresse på billede").WithDescription("\"URL-adresse til det websted, hvor der findes et billede af brugeren.\""));
                Positionid = group.Add(new VocabularyKey("positionid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Placering").WithDescription("Brugers placering i den hierarkiske sikkerhedsmodel."));
                Preferredaddresscode = group.Add(new VocabularyKey("preferredaddresscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket adresse").WithDescription("Brugerens foretrukne adresse."));
                Preferredemailcode = group.Add(new VocabularyKey("preferredemailcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken e-mail-adresse").WithDescription("Brugerens foretrukne e-mail-adresse."));
                Preferredphonecode = group.Add(new VocabularyKey("preferredphonecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket telefon").WithDescription("Brugerens foretrukne telefonnummer."));
                Processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Proces").WithDescription("Viser processens id."));
                PtmPeruserlicensingdocumentscorepack = group.Add(new VocabularyKey("ptmPeruserlicensingdocumentscorepack", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("perUserLicensingDocumentsCorePack"));
                PtmPeruserlicensingdocumentscorepackserver = group.Add(new VocabularyKey("ptmPeruserlicensingdocumentscorepackserver", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("perUserLicensingDocumentsCorePackServer"));
                Queueid = group.Add(new VocabularyKey("queueid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standardkø").WithDescription("Entydigt id for standardkøen for brugeren."));
                Salutation = group.Add(new VocabularyKey("salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Titel").WithDescription("\"Titulering, der skal bruges i korrespondance til brugeren.\""));
                Setupuser = group.Add(new VocabularyKey("setupuser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tilstand med begrænset adgang").WithDescription("\"Kontrollér, om brugeren er en installationsbruger.\""));
                Sharepointemailaddress = group.Add(new VocabularyKey("sharepointemailaddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SharePoint-mailadresse").WithDescription("SharePoint-mailadresse (arbejde)"));
                Siteid = group.Add(new VocabularyKey("siteid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sted").WithDescription("site_system_users"));
                Skills = group.Add(new VocabularyKey("skills", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Færdigheder").WithDescription("Brugerens færdigheder."));
                Stageid = group.Add(new VocabularyKey("stageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Procestrin").WithDescription("Viser fasens id."));
                Systemuserid = group.Add(new VocabularyKey("systemuserid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bruger").WithDescription("Entydigt id for brugeren."));
                Territoryid = group.Add(new VocabularyKey("territoryid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Distrikt").WithDescription("territory_system_users"));
                Title = group.Add(new VocabularyKey("title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Titel").WithDescription("Brugerens titel."));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Entydigt id for den valuta, der er tilknyttet systembrugeren.\""));
                Traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gennemløbet sti").WithDescription("Kun til intern brug."));
                Userlicensetype = group.Add(new VocabularyKey("userlicensetype", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Brugerlicenstype").WithDescription("Viser brugerlicenstypen."));
                Userpuid = group.Add(new VocabularyKey("userpuid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Brugers PUID").WithDescription("PUID-brugeroplysninger"));
                Windowsliveid = group.Add(new VocabularyKey("windowsliveid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Windows Live ID").WithDescription("Windows Live ID"));
                Yammeremailaddress = group.Add(new VocabularyKey("yammeremailaddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Yammer-mail").WithDescription("Brugerens login-mailadresse til Yammer."));
                Yammeruserid = group.Add(new VocabularyKey("yammeruserid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Yammer-bruger-id").WithDescription("Brugerens Yammer-id"));
            });
        }

        public VocabularyKey Accessmode { get; private set; }
        public VocabularyKey Activedirectoryguid { get; private set; }
        public VocabularyKey Address1Addresstypecode { get; private set; }
        public VocabularyKey Address1City { get; private set; }
        public VocabularyKey Address1Composite { get; private set; }
        public VocabularyKey Address1Country { get; private set; }
        public VocabularyKey Address1County { get; private set; }
        public VocabularyKey Address1Fax { get; private set; }
        public VocabularyKey Address1Latitude { get; private set; }
        public VocabularyKey Address1Line1 { get; private set; }
        public VocabularyKey Address1Line2 { get; private set; }
        public VocabularyKey Address1Line3 { get; private set; }
        public VocabularyKey Address1Longitude { get; private set; }
        public VocabularyKey Address1Name { get; private set; }
        public VocabularyKey Address1Postalcode { get; private set; }
        public VocabularyKey Address1Postofficebox { get; private set; }
        public VocabularyKey Address1Shippingmethodcode { get; private set; }
        public VocabularyKey Address1Stateorprovince { get; private set; }
        public VocabularyKey Address1Telephone1 { get; private set; }
        public VocabularyKey Address1Telephone2 { get; private set; }
        public VocabularyKey Address1Telephone3 { get; private set; }
        public VocabularyKey Address1Upszone { get; private set; }
        public VocabularyKey Address2Addresstypecode { get; private set; }
        public VocabularyKey Address2City { get; private set; }
        public VocabularyKey Address2Composite { get; private set; }
        public VocabularyKey Address2Country { get; private set; }
        public VocabularyKey Address2County { get; private set; }
        public VocabularyKey Address2Fax { get; private set; }
        public VocabularyKey Address2Latitude { get; private set; }
        public VocabularyKey Address2Line1 { get; private set; }
        public VocabularyKey Address2Line2 { get; private set; }
        public VocabularyKey Address2Line3 { get; private set; }
        public VocabularyKey Address2Longitude { get; private set; }
        public VocabularyKey Address2Name { get; private set; }
        public VocabularyKey Address2Postalcode { get; private set; }
        public VocabularyKey Address2Postofficebox { get; private set; }
        public VocabularyKey Address2Shippingmethodcode { get; private set; }
        public VocabularyKey Address2Stateorprovince { get; private set; }
        public VocabularyKey Address2Telephone1 { get; private set; }
        public VocabularyKey Address2Telephone2 { get; private set; }
        public VocabularyKey Address2Telephone3 { get; private set; }
        public VocabularyKey Address2Upszone { get; private set; }
        public VocabularyKey Applicationid { get; private set; }
        public VocabularyKey Applicationiduri { get; private set; }
        public VocabularyKey Azureactivedirectoryobjectid { get; private set; }
        public VocabularyKey Businessunitid { get; private set; }
        public VocabularyKey Calendarid { get; private set; }
        public VocabularyKey Caltype { get; private set; }
        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey Defaultfilterspopulated { get; private set; }
        public VocabularyKey Defaultmailbox { get; private set; }
        public VocabularyKey Defaultodbfoldername { get; private set; }
        public VocabularyKey Disabledreason { get; private set; }
        public VocabularyKey Displayinserviceviews { get; private set; }
        public VocabularyKey Domainname { get; private set; }
        public VocabularyKey DynaInitialer { get; private set; }
        public VocabularyKey Emailrouteraccessapproval { get; private set; }
        public VocabularyKey Employeeid { get; private set; }
        public VocabularyKey Entityimage { get; private set; }
        public VocabularyKey Entityimageid { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Firstname { get; private set; }
        public VocabularyKey Fullname { get; private set; }
        public VocabularyKey Governmentid { get; private set; }
        public VocabularyKey Homephone { get; private set; }
        public VocabularyKey Identityid { get; private set; }
        public VocabularyKey Incomingemaildeliverymethod { get; private set; }
        public VocabularyKey Internalemailaddress { get; private set; }
        public VocabularyKey Invitestatuscode { get; private set; }
        public VocabularyKey Isactivedirectoryuser { get; private set; }
        public VocabularyKey Isdisabled { get; private set; }
        public VocabularyKey Isemailaddressapprovedbyo365admin { get; private set; }
        public VocabularyKey Isintegrationuser { get; private set; }
        public VocabularyKey Islicensed { get; private set; }
        public VocabularyKey Issyncwithdirectory { get; private set; }
        public VocabularyKey Jobtitle { get; private set; }
        public VocabularyKey Lastname { get; private set; }
        public VocabularyKey Latestupdatetime { get; private set; }
        public VocabularyKey Middlename { get; private set; }
        public VocabularyKey Mobilealertemail { get; private set; }
        public VocabularyKey Mobileofflineprofileid { get; private set; }
        public VocabularyKey Mobilephone { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey MsdynGdproptout { get; private set; }
        public VocabularyKey Nickname { get; private set; }
        public VocabularyKey Organizationid { get; private set; }
        public VocabularyKey Outgoingemaildeliverymethod { get; private set; }
        public VocabularyKey Parentsystemuserid { get; private set; }
        public VocabularyKey Passporthi { get; private set; }
        public VocabularyKey Passportlo { get; private set; }
        public VocabularyKey Personalemailaddress { get; private set; }
        public VocabularyKey Photourl { get; private set; }
        public VocabularyKey Positionid { get; private set; }
        public VocabularyKey Preferredaddresscode { get; private set; }
        public VocabularyKey Preferredemailcode { get; private set; }
        public VocabularyKey Preferredphonecode { get; private set; }
        public VocabularyKey Processid { get; private set; }
        public VocabularyKey PtmPeruserlicensingdocumentscorepack { get; private set; }
        public VocabularyKey PtmPeruserlicensingdocumentscorepackserver { get; private set; }
        public VocabularyKey Queueid { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey Setupuser { get; private set; }
        public VocabularyKey Sharepointemailaddress { get; private set; }
        public VocabularyKey Siteid { get; private set; }
        public VocabularyKey Skills { get; private set; }
        public VocabularyKey Stageid { get; private set; }
        public VocabularyKey Systemuserid { get; private set; }
        public VocabularyKey Territoryid { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
        public VocabularyKey Traversedpath { get; private set; }
        public VocabularyKey Userlicensetype { get; private set; }
        public VocabularyKey Userpuid { get; private set; }
        public VocabularyKey Windowsliveid { get; private set; }
        public VocabularyKey Yammeremailaddress { get; private set; }
        public VocabularyKey Yammeruserid { get; private set; }
    }
}
