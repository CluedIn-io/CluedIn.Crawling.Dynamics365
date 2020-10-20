using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Dynamics365 Lead"; // TODO: Set value
            KeyPrefix = "dynamics365.Lead"; // TODO: Set value
            KeySeparator = ".";
            Grouping = EntityType.Person; // TODO: Check value

            AddGroup("Person Details", group =>
            {
                Accountid = group.Add(new VocabularyKey("accountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firma").WithDescription("\"Entydigt id for det firma, som kundeemnet er tilknyttet.\""));
                Address1Addresstypecode = group.Add(new VocabularyKey("address1Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Adressetype").WithDescription("Vælg den primære adressetype."));
                Address1City = group.Add(new VocabularyKey("address1City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - By").WithDescription("Angiv byen for den primære adresse."));
                Address1Composite = group.Add(new VocabularyKey("address1Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1").WithDescription("Viser den fulde primære adresse."));
                Address1Country = group.Add(new VocabularyKey("address1Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Landekode").WithDescription("Angiv landet eller området for den primære adresse."));
                Address1County = group.Add(new VocabularyKey("address1County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Region").WithDescription("Angiv regionen for den primære adresse."));
                Address1Fax = group.Add(new VocabularyKey("address1Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Fax").WithDescription("\"Angiv det faxnummer, der er tilknyttet den primære adresse.\""));
                Address1Latitude = group.Add(new VocabularyKey("address1Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Breddegrad").WithDescription("Angiv værdien for breddegraden for den primære adresse til brug ved kortlægning og andre programmer."));
                Address1Line1 = group.Add(new VocabularyKey("address1Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Linje 1").WithDescription("Angiv den første linje i den primære adresse."));
                Address1Line2 = group.Add(new VocabularyKey("address1Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Linje 2").WithDescription("Angiv den anden linje i den primære adresse."));
                Address1Line3 = group.Add(new VocabularyKey("address1Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Linje 3").WithDescription("Angiv den tredje linje i den primære adresse."));
                Address1Longitude = group.Add(new VocabularyKey("address1Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Længdegrad").WithDescription("Angiv værdien for længdegraden for den primære adresse til brug ved kortlægning og andre programmer."));
                Address1Name = group.Add(new VocabularyKey("address1Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Navn").WithDescription("\"Angiv et beskrivende navn til den primære adresse, f.eks. koncernhovedsæde.\""));
                Address1Postalcode = group.Add(new VocabularyKey("address1Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Postnummer").WithDescription("Angiv postnummeret for den primære adresse."));
                Address1Postofficebox = group.Add(new VocabularyKey("address1Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Postboksnummer").WithDescription("Angiv postboksnummeret for den primære adresse."));
                Address1Shippingmethodcode = group.Add(new VocabularyKey("address1Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address1Stateorprovince = group.Add(new VocabularyKey("address1Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Område").WithDescription("Angiv staten eller området for den primære adresse."));
                Address1Telephone1 = group.Add(new VocabularyKey("address1Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Telefon 1").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den primære adresse.\""));
                Address1Telephone2 = group.Add(new VocabularyKey("address1Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Telefon 2").WithDescription("\"Angiv et andet telefonnummer, der er tilknyttet den primære adresse.\""));
                Address1Telephone3 = group.Add(new VocabularyKey("address1Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Telefon 3").WithDescription("\"Angiv et tredje telefonnummer, der er tilknyttet den primære adresse.\""));
                Address1Upszone = group.Add(new VocabularyKey("address1Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: UPS-zone").WithDescription("\"Angiv UPS-zonen for den primære adresse for at sikre, at forsendelsesgebyrer beregnes korrekt, og at leverancer foretages prompte, hvis forsendelse sker med UPS.\""));
                Address2Addresstypecode = group.Add(new VocabularyKey("address2Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Adressetype").WithDescription("Vælg den sekundære adressetype."));
                Address2City = group.Add(new VocabularyKey("address2City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: By").WithDescription("Angiv byen for den sekundære adresse."));
                Address2Composite = group.Add(new VocabularyKey("address2Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2").WithDescription("Viser den fulde sekundære adresse."));
                Address2Country = group.Add(new VocabularyKey("address2Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Land/område").WithDescription("Angiv landet eller området for den sekundære adresse."));
                Address2County = group.Add(new VocabularyKey("address2County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Region").WithDescription("Angiv regionen for den sekundære adresse."));
                Address2Fax = group.Add(new VocabularyKey("address2Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Fax").WithDescription("\"Angiv det faxnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Latitude = group.Add(new VocabularyKey("address2Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Breddegrad").WithDescription("Angiv værdien for breddegraden for den sekundære adresse til brug ved kortlægning og andre programmer."));
                Address2Line1 = group.Add(new VocabularyKey("address2Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Gade 1").WithDescription("Angiv den første linje i den sekundære adresse."));
                Address2Line2 = group.Add(new VocabularyKey("address2Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Gade 2").WithDescription("Angiv den anden linje i den sekundære adresse."));
                Address2Line3 = group.Add(new VocabularyKey("address2Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Gade 3").WithDescription("Angiv den tredje linje i den sekundære adresse."));
                Address2Longitude = group.Add(new VocabularyKey("address2Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Længdegrad").WithDescription("Angiv værdien for længdegraden for den sekundære adresse til brug ved kortlægning og andre programmer."));
                Address2Name = group.Add(new VocabularyKey("address2Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Navn").WithDescription("\"Angiv et beskrivende navn til den sekundære adresse, f.eks. koncernhovedsæde.\""));
                Address2Postalcode = group.Add(new VocabularyKey("address2Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Postnummer").WithDescription("Angiv postnummeret for den sekundære adresse."));
                Address2Postofficebox = group.Add(new VocabularyKey("address2Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Postboksnummer").WithDescription("Angiv postboksnummeret for den sekundære adresse."));
                Address2Shippingmethodcode = group.Add(new VocabularyKey("address2Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address2Stateorprovince = group.Add(new VocabularyKey("address2Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Område").WithDescription("Angiv staten eller området for den sekundære adresse."));
                Address2Telephone1 = group.Add(new VocabularyKey("address2Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 1").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Telephone2 = group.Add(new VocabularyKey("address2Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 2").WithDescription("\"Angiv et andet telefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Telephone3 = group.Add(new VocabularyKey("address2Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 3").WithDescription("\"Angiv et tredje telefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Upszone = group.Add(new VocabularyKey("address2Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: UPS-zone").WithDescription("\"Angiv UPS-zonen for den sekundære adresse for at sikre, at forsendelsesgebyrer beregnes korrekt, og at leverancer foretages prompte, hvis forsendelse sker med UPS.\""));
                Budgetamount = group.Add(new VocabularyKey("budgetamount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Budgetbeløb").WithDescription("Oplysninger om budgetbeløbet for kundeemnets virksomhed eller organisation."));
                BudgetamountBase = group.Add(new VocabularyKey("budgetamountBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Budgetbeløb (basis)").WithDescription("Kundeemnets estimerede budget angivet i grundvaluta."));
                Budgetstatus = group.Add(new VocabularyKey("budgetstatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Budget").WithDescription("Oplysninger om budgetstatussen for kundeemnets virksomhed eller organisation."));
                Campaignid = group.Add(new VocabularyKey("campaignid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kildekampagne").WithDescription("campaign_leads"));
                Companyname = group.Add(new VocabularyKey("companyname", VocabularyKeyDataType.OrganizationName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsnavn").WithDescription("\"Angiv navnet på den virksomhed, der er tilknyttet kundeemnet. Dette bliver firmanavnet, når kundeemnet er kvalificeret og konverteret til en kundekonto.\""));
                Confirminterest = group.Add(new VocabularyKey("confirminterest", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bekræft interesse").WithDescription("\"Vælg, om kundeemnet har bekræftet sin interesse for dine tilbud. Dette er med til at fastlægge kvaliteten af kundeemnet.\""));
                Contactid = group.Add(new VocabularyKey("contactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontakt").WithDescription("\"Entydigt id for den kontaktperson, som kundeemnet er tilknyttet.\""));
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Viser, hvem der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet Dato").WithDescription("\"Viser dato og klokkeslæt for oprettelse af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics 365.\""));
                Customerid = group.Add(new VocabularyKey("customerid", VocabularyKeyDataType.Number, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Person_ID").WithDescription("\"Vælg kundekontoen eller -kontakten for at give et hurtigt link til flere kundeoplysninger som f.eks. kontooplysninger, aktiviteter og salgsmuligheder.$lead_customer_contacts\""));
                Customeridtype = group.Add(new VocabularyKey("customeridtype", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kundetype"));
                Decisionmaker = group.Add(new VocabularyKey("decisionmaker", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beslutningstager?").WithDescription("\"Vælg, om dine kommentarer indeholder oplysninger om, hvem der træffer købsbeslutningerne i kundeemnets virksomhed.\""));
                Description = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskrivelse").WithDescription("\"Angiv flere oplysninger for at beskrive kundeemnet, f.eks. et uddrag fra firmaets websted.\""));
                Donotbulkemail = group.Add(new VocabularyKey("donotbulkemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke e-mail-masseforsend.").WithDescription("\"Vælg, om kundeemnet accepterer masseforsendelser af e-mails, der sendes via marketingkampagner eller lynkampagner. Hvis Tillad ikke er valgt, kan kundeemnet tilføjes på marketinglisten, men er udelukket fra e-mailen.\""));
                Donotemail = group.Add(new VocabularyKey("donotemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke e-mails").WithDescription("\"Vælg, om kundeemnet tillader, at der sendes direct mail fra Microsoft Dynamics 365.\""));
                Donotfax = group.Add(new VocabularyKey("donotfax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke faxer").WithDescription("\"Vælg, om kundeemnet tillader faxer.\""));
                Donotphone = group.Add(new VocabularyKey("donotphone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke telefonopkald").WithDescription("\"Vælg, om kundeemnet tillader telefonopkald.\""));
                Donotpostalmail = group.Add(new VocabularyKey("donotpostalmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke post").WithDescription("\"Vælg, om kundeemnet tillader direct mail.\""));
                Donotsendmm = group.Add(new VocabularyKey("donotsendmm", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Marketingmateriale").WithDescription("\"Vælg, om kundeemnet accepterer marketingmateriale som f.eks. brochurer eller kataloger. Kundeemner, der har frameldt dette, kan udelukkes fra marketinginitiativer.\""));
                DynaExistingopportunity = group.Add(new VocabularyKey("dynaExistingopportunity", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Existing Opportunity"));
                DynaHenvisendekonsulent = group.Add(new VocabularyKey("dynaHenvisendekonsulent", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Henvisende konsulent").WithDescription("Den Konsulent som har henvist kundeemnet"));
                DynaKommentar = group.Add(new VocabularyKey("dynaKommentar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kommentar").WithDescription("Kommentar felt som benyttes til Leads som kommer fra Medlemsrådgivning"));
                DynaKursus = group.Add(new VocabularyKey("dynaKursus", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus"));
                DynaKursustype = group.Add(new VocabularyKey("dynaKursustype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Type"));
                DynaLastemail = group.Add(new VocabularyKey("dynaLastemail", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Last Email"));
                DynaLastemaildate = group.Add(new VocabularyKey("dynaLastemaildate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Last Email (Date)"));
                DynaLastphonecall = group.Add(new VocabularyKey("dynaLastphonecall", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Last Phone Call"));
                DynaLastphonecalldate = group.Add(new VocabularyKey("dynaLastphonecalldate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Last Phone Call (Date)"));
                DynaLinkedinprofil = group.Add(new VocabularyKey("dynaLinkedinprofil", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Linkedin profil").WithDescription("Url til Linkedin profil"));
                DynaNextcontact = group.Add(new VocabularyKey("dynaNextcontact", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Next Contact"));
                DynaProduktkategori = group.Add(new VocabularyKey("dynaProduktkategori", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Produktkategori").WithDescription("De produkter som en kundeemne kan omhandle. Benyttes til at segmentere kundeemnet"));
                DynaProduktkategoriInfoOutplacement = group.Add(new VocabularyKey("dynaProduktkategoriInfoOutplacement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Produktkategori info om LT/AG"));
                Emailaddress1 = group.Add(new VocabularyKey("emailaddress1", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne E-mail").WithDescription("Angiv kundeemnets primære e-mail-adresse."));
                Emailaddress2 = group.Add(new VocabularyKey("emailaddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailadresse 2").WithDescription("Angiv kundeemnets sekundære e-mail-adresse."));
                Emailaddress3 = group.Add(new VocabularyKey("emailaddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailadresse 3").WithDescription("Angiv en tredje e-mail-adresse til kundeemnet."));
                Entityimage = group.Add(new VocabularyKey("entityimage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Objektbillede").WithDescription("Viser postens standardbillede."));
                Entityimageid = group.Add(new VocabularyKey("entityimageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for objektbillede").WithDescription("Kun til intern brug."));
                Estimatedamount = group.Add(new VocabularyKey("estimatedamount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anslået værdi").WithDescription("\"Angiv værdien af den anslåede omsætning, som dette kundeemne genererer, til brug for salgsprognoser og -planlægning.\""));
                EstimatedamountBase = group.Add(new VocabularyKey("estimatedamountBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ansl. værdi (grund)").WithDescription("\"Viser feltet Ansl. værdi konverteret til systemets standardgrundvaluta. I beregningen bruges den valutakurs, der er angivet i området Valutaer.\""));
                Estimatedclosedate = group.Add(new VocabularyKey("estimatedclosedate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anslået lukkedato").WithDescription("\"Angiv den forventede lukkedato for kundeemnet, så salgsteamet kan planlægge opfølgningsmøder rettidigt i forhold til at flytte det potentielle emne til næste salgsfase.\""));
                Estimatedvalue = group.Add(new VocabularyKey("estimatedvalue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anslået værdi (frabedt)").WithDescription("\"Angiv en numerisk værdi for kundeemnets anslåede værdi, f.eks. et produktantal, hvis der ikke kan angives et omsætningsbeløb i feltet Anslået værdi. Denne kan bruges i forbindelse med salgsprognoser og -planlægning.\""));
                Evaluatefit = group.Add(new VocabularyKey("evaluatefit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluer overensstemmelse").WithDescription("\"Vælg, om overensstemmelsen mellem kundeemnets behov og dine tilbud er evalueret.\""));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("Viser omregningskursen for postens valuta. Valutakursen bruges til at konvertere alle pengefelter i posten fra den lokale valuta til systemets standardvaluta."));
                Fax = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fax").WithDescription("Angiv faxnummeret til den primære kontakt for kundeemnet."));
                Firstname = group.Add(new VocabularyKey("firstname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fornavn").WithDescription("\"Angiv fornavnet på den primære kontakt for kundeemnet for at sikre, at det potentielle emne tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Followemail = group.Add(new VocabularyKey("followemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Følg mailaktivitet").WithDescription("\"Oplysninger om, om det er tilladt at følge mailaktivitet som åbninger, visning af vedhæftede filer og klik på links for mails, der sendes til kundeemnet.\""));
                Fullname = group.Add(new VocabularyKey("fullname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn").WithDescription("\"Kombinerer og viser kundeemnets for- og efternavn, så det fulde navn kan vises i visninger og rapporter.\""));
                Industrycode = group.Add(new VocabularyKey("industrycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Branche").WithDescription("\"Vælg den primære branche, som kundeemnets forretning fokuserer på, til brug ved marketingsegmentering og demografiske analyser.\""));
                Initialcommunication = group.Add(new VocabularyKey("initialcommunication", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Indledende kommunikation").WithDescription("\"Vælg, om en person fra salgsteamet tidligere har kontaktet dette kundeemne.\""));
                Isautocreate = group.Add(new VocabularyKey("isautocreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet automatisk").WithDescription("\"Angiver, om kontakten blev oprettet automatisk, da en e-mail eller en aftale blev opgraderet.\""));
                Isprivate = group.Add(new VocabularyKey("isprivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Er privat").WithDescription("\"Angiver, om kundeemnet er privat eller synligt for hele organisationen.\""));
                Jobtitle = group.Add(new VocabularyKey("jobtitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Stilling").WithDescription("\"Angiv stillingen for den primære kontakt for dette kundeemne for at sikre, at det potentielle emne tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Lastname = group.Add(new VocabularyKey("lastname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Efternavn").WithDescription("\"Angiv efternavnet på den primære kontakt for kundeemnet for at sikre, at det potentielle emne tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Lastonholdtime = group.Add(new VocabularyKey("lastonholdtime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste tid i venteposition").WithDescription("Indeholder dato- og klokkeslætsstemplet for den seneste tid i venteposition."));
                Lastusedincampaign = group.Add(new VocabularyKey("lastusedincampaign", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidste kampagnedato").WithDescription("\"Viser den dato, hvor kundeemnet sidst blev inkluderet i en marketingkampagne eller lynkampagne.\""));
                Leadid = group.Add(new VocabularyKey("leadid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kundeemne").WithDescription("Entydigt id for kundeemnet."));
                Leadqualitycode = group.Add(new VocabularyKey("leadqualitycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Klassificering").WithDescription("Vælg en klassificeringsværdi for at angive kundeemnets potentiale for at blive kunde."));
                Leadsourcecode = group.Add(new VocabularyKey("leadsourcecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kanal").WithDescription("\"Vælg den primære marketingkilde, der fik kundeemnet til at kontakte dig.\""));
                Masterid = group.Add(new VocabularyKey("masterid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Master-id").WithDescription("lead_master_lead"));
                Merged = group.Add(new VocabularyKey("merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Flettet").WithDescription("\"Angiver, om kundeemnet er blevet flettet med et andet kundeemne.\""));
                Middlename = group.Add(new VocabularyKey("middlename", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mellemnavn").WithDescription("\"Angiv mellemnavnet eller initialerne på den primære kontakt for kundeemnet for at sikre, at det potentielle emne tituleres korrekt.\""));
                Mobilephone = group.Add(new VocabularyKey("mobilephone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne Telefon 1").WithDescription("Angiv mobiltelefonnummeret på den primære kontakt for kundeemnet."));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Viser, hvem der sidst opdaterede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("\"Viser dato og klokkeslæt for den seneste opdatering af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics 365.\""));
                MsdynGdproptout = group.Add(new VocabularyKey("msdynGdproptout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("GDPR-framelding").WithDescription("\"Beskriver, om kundeemnet er frameldt eller ej\""));
                Need = group.Add(new VocabularyKey("need", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Behov").WithDescription("\"Vælg, hvor stort behovet er for kundeemnets virksomhed.\""));
                NnLastupdated = group.Add(new VocabularyKey("nnLastupdated", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidste opdatering fra NN Markedsdata").WithDescription("Sidste opdatering fra NN Markedsdata"));
                NnLinks = group.Add(new VocabularyKey("nnLinks", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Internt link felt til NN MarkedsData - Kun til intern brug").WithDescription("Internt link felt til NN MarkedsData - Kun til intern brug"));
                NnTdcid = group.Add(new VocabularyKey("nnTdcid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("TDC ID").WithDescription("TDC ID"));
                NnUpdateprotected = group.Add(new VocabularyKey("nnUpdateprotected", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskyt mod automatiske opdateringer").WithDescription("Beskyt mod automatiske opdateringer"));
                Numberofemployees = group.Add(new VocabularyKey("numberofemployees", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal ansatte").WithDescription("\"Angiv antallet af medarbejdere, der arbejder i den virksomhed, der er tilknyttet kundeemnet, til brug for marketingsegmentering og demografiske analyser.\""));
                Onholdtime = group.Add(new VocabularyKey("onholdtime", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tid for i venteposition (minutter)").WithDescription("\"Viser, hvor længe posten var i venteposition i minutter.\""));
                Originatingcaseid = group.Add(new VocabularyKey("originatingcaseid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprindelig sag").WithDescription("OriginatingCase_Lead"));
                Pager = group.Add(new VocabularyKey("pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Personsøger").WithDescription("Angiv personsøgernummeret på den primære kontakt for kundeemnet."));
                Parentaccountid = group.Add(new VocabularyKey("parentaccountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overordnet firma for kundeemne").WithDescription("lead_parent_account"));
                Parentcontactid = group.Add(new VocabularyKey("parentcontactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overordnet kontakt for kundeemne").WithDescription("lead_parent_contact"));
                Participatesinworkflow = group.Add(new VocabularyKey("participatesinworkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager i arbejdsproces").WithDescription("\"Viser, om kundeemnet deltager i arbejdsprocesregler.\""));
                Preferredcontactmethodcode = group.Add(new VocabularyKey("preferredcontactmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken kontaktmetode").WithDescription("Vælg den foretrukne kontaktmetode."));
                Prioritycode = group.Add(new VocabularyKey("prioritycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Prioritet").WithDescription("\"Vælg prioriteten, så de foretrukne kunder eller kritiske problemer håndteres hurtigt.\""));
                Processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Proces").WithDescription("Viser processens id."));
                Purchaseprocess = group.Add(new VocabularyKey("purchaseprocess", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Købsproces").WithDescription("\"Vælg, om en enkeltperson eller et udvalg bliver involveret i købsprocessen for kundeemnet.\""));
                Purchasetimeframe = group.Add(new VocabularyKey("purchasetimeframe", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tidsramme for køb").WithDescription("\"Vælg, hvor lang tid kundeemnet sandsynligvis vil være om at foretage købet, så salgsteamet er orienteret.\""));
                Qualificationcomments = group.Add(new VocabularyKey("qualificationcomments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kommentarer til kvalificering").WithDescription("Angiv kommentarer til kundeemnets kvalificering eller score."));
                Qualifyingopportunityid = group.Add(new VocabularyKey("qualifyingopportunityid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kvalificeret salgsmulighed").WithDescription("lead_qualifying_opportunity"));
                Relatedobjectid = group.Add(new VocabularyKey("relatedobjectid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Relateret kampagnerespons").WithDescription("CampaignResponse_Lead"));
                Revenue = group.Add(new VocabularyKey("revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsomsætning").WithDescription("\"Angiv årsomsætningen for den virksomhed, der er tilknyttet kundeemnet, for at forstå det potentielle emnes forretning.\""));
                RevenueBase = group.Add(new VocabularyKey("revenueBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsomsætning (grund)").WithDescription("\"Viser feltet Årsomsætning konverteret til systemets standardgrundvaluta. I beregningen bruges den valutakurs, der er angivet i området Valutaer.\""));
                Salesstage = group.Add(new VocabularyKey("salesstage", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salgsfase").WithDescription("Vælg dette kundeemnes salgsfase for at gøre det nemmere for salgsteamet at konvertere dette kundeemne til en salgsmulighed."));
                Salesstagecode = group.Add(new VocabularyKey("salesstagecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salgsfasekode").WithDescription("\"Vælg salgsprocesfasen for kundeemnet for at fastlægge sandsynligheden for, at kundeemnet konverteres til en salgsmulighed.\""));
                Salutation = group.Add(new VocabularyKey("salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Titel").WithDescription("\"Angiv tituleringen af den primære kontakt for dette kundeemne for at sikre, at det potentielle emne tituleres korrekt i salgsopkald, e-mails og marketingkampagner.\""));
                SchedulefollowupProspect = group.Add(new VocabularyKey("schedulefollowupProspect", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Planlæg opfølgning (potentielt emne)").WithDescription("Angiv dato og klokkeslæt for det undersøgende opfølgningsmøde med kundeemnet."));
                SchedulefollowupQualify = group.Add(new VocabularyKey("schedulefollowupQualify", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Planlæg opfølgning (kvalificering)").WithDescription("Angiv dato og klokkeslæt for det opfølgende kvalificeringsmøde med kundeemnet."));
                Sic = group.Add(new VocabularyKey("sic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SIC-kode").WithDescription("\"Angiv SIC-koden (Standard Industrial Classification), der angiver kundeemnets primære branche, til brug for marketingsegmentering og demografiske analyser.\""));
                Slaid = group.Add(new VocabularyKey("slaid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SLA").WithDescription("manualsla_lead"));
                Slainvokedid = group.Add(new VocabularyKey("slainvokedid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Senest anvendte SLA").WithDescription("sla_lead"));
                Stageid = group.Add(new VocabularyKey("stageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Procestrin").WithDescription("processstage_lead"));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("\"Viser, om kundeemnet er åbent, kvalificeret eller diskvalificeret. Kvalificerede og diskvalificerede kundeemner er skrivebeskyttede og kan ikke redigeres, medmindre de genaktiveres.\""));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Vælg kundeemnets status."));
                Subject = group.Add(new VocabularyKey("subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne Fritekst").WithDescription("\"Angiv et emne eller beskrivende navn, f.eks. den forventede ordre, firmanavnet eller marketingkildelisten, for at identificere kundeemnet.\""));
                Telephone1 = group.Add(new VocabularyKey("telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne Telefon 4").WithDescription("Angiv arbejdstelefonnummeret på den primære kontakt for kundeemnet."));
                Telephone2 = group.Add(new VocabularyKey("telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne Telefon 2").WithDescription("Angiv det private telefonnummer på den primære kontakt for kundeemnet."));
                Telephone3 = group.Add(new VocabularyKey("telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne Telefon 3").WithDescription("Angiv et alternativt telefonnummer på den primære kontakt for kundeemnet."));
                Timespentbymeonemailandmeetings = group.Add(new VocabularyKey("timespentbymeonemailandmeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tidsforbrug for mig").WithDescription("Samlet tid jeg har brugt på mails (læsning og skrivning) samt møder i relation til kundeemneposten."));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Vælg den lokale valuta til posten for at sikre, at budgetter rapporteres i den korrekte valuta.\""));
                Traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gennemløbet sti").WithDescription("Kun til intern brug."));
                Websiteurl = group.Add(new VocabularyKey("websiteurl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Websted").WithDescription("\"Angiv webstedets URL-adresse for den virksomhed, der er tilknyttet dette kundeemne.\""));
            });
        }

        public VocabularyKey Accountid { get; private set; }
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
        public VocabularyKey Budgetamount { get; private set; }
        public VocabularyKey BudgetamountBase { get; private set; }
        public VocabularyKey Budgetstatus { get; private set; }
        public VocabularyKey Campaignid { get; private set; }
        public VocabularyKey Companyname { get; private set; }
        public VocabularyKey Confirminterest { get; private set; }
        public VocabularyKey Contactid { get; private set; }
        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey Customerid { get; private set; }
        public VocabularyKey Customeridtype { get; private set; }
        public VocabularyKey Decisionmaker { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Donotbulkemail { get; private set; }
        public VocabularyKey Donotemail { get; private set; }
        public VocabularyKey Donotfax { get; private set; }
        public VocabularyKey Donotphone { get; private set; }
        public VocabularyKey Donotpostalmail { get; private set; }
        public VocabularyKey Donotsendmm { get; private set; }
        public VocabularyKey DynaExistingopportunity { get; private set; }
        public VocabularyKey DynaHenvisendekonsulent { get; private set; }
        public VocabularyKey DynaKommentar { get; private set; }
        public VocabularyKey DynaKursus { get; private set; }
        public VocabularyKey DynaKursustype { get; private set; }
        public VocabularyKey DynaLastemail { get; private set; }
        public VocabularyKey DynaLastemaildate { get; private set; }
        public VocabularyKey DynaLastphonecall { get; private set; }
        public VocabularyKey DynaLastphonecalldate { get; private set; }
        public VocabularyKey DynaLinkedinprofil { get; private set; }
        public VocabularyKey DynaNextcontact { get; private set; }
        public VocabularyKey DynaProduktkategori { get; private set; }
        public VocabularyKey DynaProduktkategoriInfoOutplacement { get; private set; }
        public VocabularyKey Emailaddress1 { get; private set; }
        public VocabularyKey Emailaddress2 { get; private set; }
        public VocabularyKey Emailaddress3 { get; private set; }
        public VocabularyKey Entityimage { get; private set; }
        public VocabularyKey Entityimageid { get; private set; }
        public VocabularyKey Estimatedamount { get; private set; }
        public VocabularyKey EstimatedamountBase { get; private set; }
        public VocabularyKey Estimatedclosedate { get; private set; }
        public VocabularyKey Estimatedvalue { get; private set; }
        public VocabularyKey Evaluatefit { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Firstname { get; private set; }
        public VocabularyKey Followemail { get; private set; }
        public VocabularyKey Fullname { get; private set; }
        public VocabularyKey Industrycode { get; private set; }
        public VocabularyKey Initialcommunication { get; private set; }
        public VocabularyKey Isautocreate { get; private set; }
        public VocabularyKey Isprivate { get; private set; }
        public VocabularyKey Jobtitle { get; private set; }
        public VocabularyKey Lastname { get; private set; }
        public VocabularyKey Lastonholdtime { get; private set; }
        public VocabularyKey Lastusedincampaign { get; private set; }
        public VocabularyKey Leadid { get; private set; }
        public VocabularyKey Leadqualitycode { get; private set; }
        public VocabularyKey Leadsourcecode { get; private set; }
        public VocabularyKey Masterid { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey Middlename { get; private set; }
        public VocabularyKey Mobilephone { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey MsdynGdproptout { get; private set; }
        public VocabularyKey Need { get; private set; }
        public VocabularyKey NnLastupdated { get; private set; }
        public VocabularyKey NnLinks { get; private set; }
        public VocabularyKey NnTdcid { get; private set; }
        public VocabularyKey NnUpdateprotected { get; private set; }
        public VocabularyKey Numberofemployees { get; private set; }
        public VocabularyKey Onholdtime { get; private set; }
        public VocabularyKey Originatingcaseid { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey Parentaccountid { get; private set; }
        public VocabularyKey Parentcontactid { get; private set; }
        public VocabularyKey Participatesinworkflow { get; private set; }
        public VocabularyKey Preferredcontactmethodcode { get; private set; }
        public VocabularyKey Prioritycode { get; private set; }
        public VocabularyKey Processid { get; private set; }
        public VocabularyKey Purchaseprocess { get; private set; }
        public VocabularyKey Purchasetimeframe { get; private set; }
        public VocabularyKey Qualificationcomments { get; private set; }
        public VocabularyKey Qualifyingopportunityid { get; private set; }
        public VocabularyKey Relatedobjectid { get; private set; }
        public VocabularyKey Revenue { get; private set; }
        public VocabularyKey RevenueBase { get; private set; }
        public VocabularyKey Salesstage { get; private set; }
        public VocabularyKey Salesstagecode { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey SchedulefollowupProspect { get; private set; }
        public VocabularyKey SchedulefollowupQualify { get; private set; }
        public VocabularyKey Sic { get; private set; }
        public VocabularyKey Slaid { get; private set; }
        public VocabularyKey Slainvokedid { get; private set; }
        public VocabularyKey Stageid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Timespentbymeonemailandmeetings { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
        public VocabularyKey Traversedpath { get; private set; }
        public VocabularyKey Websiteurl { get; private set; }
    }
}
