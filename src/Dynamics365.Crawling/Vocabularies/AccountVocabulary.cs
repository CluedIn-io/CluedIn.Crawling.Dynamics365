using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Dynamics365 Account";
            KeyPrefix = "dynamics365.Account"; 
            KeySeparator = ".";
            Grouping = EntityType.Organization;

            AddGroup("Organization Details", group =>
            {
                Accountcategorycode = group.Add(new VocabularyKey("accountcategorycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kategori").WithDescription("\"Vælg en kategori for at angive, om kundekontoen er standard eller foretrukket.\""));
                Accountclassificationcode = group.Add(new VocabularyKey("accountclassificationcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Klassificering").WithDescription("\"Vælg en klassifikationskode for at angive kundekontoens potentielle værdi baseret på forventet afkast, samarbejdsniveau, salgscyklussens længde eller andre kriterier.\""));
                Accountid = group.Add(new VocabularyKey("accountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firma").WithDescription("Entydigt id for firmaet."));
                Accountnumber = group.Add(new VocabularyKey("accountnumber", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhed_ID").WithDescription("Angiv et id-nummer eller en kode for firmaet for hurtigt at søge efter og identificere firmaet i systemvisninger."));
                Accountratingcode = group.Add(new VocabularyKey("accountratingcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firmaklassificering").WithDescription("Vælg en klassificering for at angive kundekontoens værdi."));
                Address1Addresstypecode = group.Add(new VocabularyKey("address1Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Adressetype").WithDescription("Vælg den primære adressetype."));
                Address1City = group.Add(new VocabularyKey("address1City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("By").WithDescription("Angiv byen for den primære adresse."));
                Address1Composite = group.Add(new VocabularyKey("address1Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse - Sammensat").WithDescription("Viser den fulde primære adresse."));
                Address1Country = group.Add(new VocabularyKey("address1Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Land/område").WithDescription("Angiv landet eller området for den primære adresse."));
                Address1County = group.Add(new VocabularyKey("address1County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Region").WithDescription("Angiv regionen for den primære adresse."));
                Address1Fax = group.Add(new VocabularyKey("address1Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Fax").WithDescription("\"Angiv det faxnummer, der er tilknyttet den primære adresse.\""));
                Address1Freighttermscode = group.Add(new VocabularyKey("address1Freighttermscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Fragtbetingelser").WithDescription("\"Vælg fragtbetingelser for den primære adresse for at sikre, at forsendelsesordrer behandles korrekt.\""));
                Address1Latitude = group.Add(new VocabularyKey("address1Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Breddegrad").WithDescription("Angiv værdien for breddegraden for den primære adresse til brug ved kortlægning og andre programmer."));
                Address1Line1 = group.Add(new VocabularyKey("address1Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse - Vejnavn").WithDescription("Angiv den første linje i den primære adresse."));
                Address1Line2 = group.Add(new VocabularyKey("address1Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Gade 2").WithDescription("Angiv den anden linje i den primære adresse."));
                Address1Line3 = group.Add(new VocabularyKey("address1Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Gade 3").WithDescription("Angiv den tredje linje i den primære adresse."));
                Address1Longitude = group.Add(new VocabularyKey("address1Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Længdegrad").WithDescription("Angiv værdien for længdegraden for den primære adresse til brug ved kortlægning og andre programmer."));
                Address1Name = group.Add(new VocabularyKey("address1Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Navn").WithDescription("\"Angiv et beskrivende navn til den primære adresse, f.eks. koncernhovedsæde.\""));
                Address1Postalcode = group.Add(new VocabularyKey("address1Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse - Postnummer").WithDescription("Angiv postnummeret for den primære adresse."));
                Address1Postofficebox = group.Add(new VocabularyKey("address1Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Postboksnummer").WithDescription("Angiv postboksnummeret for den primære adresse."));
                Address1Primarycontactname = group.Add(new VocabularyKey("address1Primarycontactname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn på primær kontaktperson").WithDescription("Angiv navnet på hovedkontakten på firmaets primære adresse."));
                Address1Shippingmethodcode = group.Add(new VocabularyKey("address1Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address1Stateorprovince = group.Add(new VocabularyKey("address1Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse - By").WithDescription("Angiv staten eller området for den primære adresse."));
                Address1Telephone1 = group.Add(new VocabularyKey("address1Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Hovednummer").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den primære adresse.\""));
                Address1Telephone2 = group.Add(new VocabularyKey("address1Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Telefon 2").WithDescription("\"Angiv et andet telefonnummer, der er tilknyttet den primære adresse.\""));
                Address1Telephone3 = group.Add(new VocabularyKey("address1Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Telefon 3").WithDescription("\"Angiv et tredje telefonnummer, der er tilknyttet den primære adresse.\""));
                Address1Upszone = group.Add(new VocabularyKey("address1Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: UPS-zone").WithDescription("\"Angiv UPS-zonen for den primære adresse for at sikre, at forsendelsesgebyrer beregnes korrekt, og at leverancer foretages prompte, hvis forsendelse sker med UPS.\""));
                Address2Addresstypecode = group.Add(new VocabularyKey("address2Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Adressetype").WithDescription("Vælg den sekundære adressetype."));
                Address2City = group.Add(new VocabularyKey("address2City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: By").WithDescription("Angiv byen for den sekundære adresse."));
                Address2Composite = group.Add(new VocabularyKey("address2Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2").WithDescription("Viser den fulde sekundære adresse."));
                Address2Country = group.Add(new VocabularyKey("address2Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Land/område").WithDescription("Angiv landet eller området for den sekundære adresse."));
                Address2County = group.Add(new VocabularyKey("address2County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Region").WithDescription("Angiv regionen for den sekundære adresse."));
                Address2Fax = group.Add(new VocabularyKey("address2Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Fax").WithDescription("\"Angiv det faxnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Freighttermscode = group.Add(new VocabularyKey("address2Freighttermscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Fragtbetingelser").WithDescription("\"Vælg fragtbetingelser for den sekundære adresse for at sikre, at forsendelsesordrer behandles korrekt.\""));
                Address2Latitude = group.Add(new VocabularyKey("address2Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Breddegrad").WithDescription("Angiv værdien for breddegraden for den sekundære adresse til brug ved kortlægning og andre programmer."));
                Address2Line1 = group.Add(new VocabularyKey("address2Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Gade 1").WithDescription("Angiv den første linje i den sekundære adresse."));
                Address2Line2 = group.Add(new VocabularyKey("address2Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Gade 2").WithDescription("Angiv den anden linje i den sekundære adresse."));
                Address2Line3 = group.Add(new VocabularyKey("address2Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Gade 3").WithDescription("Angiv den tredje linje i den sekundære adresse."));
                Address2Longitude = group.Add(new VocabularyKey("address2Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Længdegrad").WithDescription("Angiv værdien for længdegraden for den sekundære adresse til brug ved kortlægning og andre programmer."));
                Address2Name = group.Add(new VocabularyKey("address2Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Navn").WithDescription("\"Angiv et beskrivende navn til den sekundære adresse, f.eks. koncernhovedsæde.\""));
                Address2Postalcode = group.Add(new VocabularyKey("address2Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Postnummer").WithDescription("Angiv postnummeret for den sekundære adresse."));
                Address2Postofficebox = group.Add(new VocabularyKey("address2Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Postboksnummer").WithDescription("Angiv postboksnummeret for den sekundære adresse."));
                Address2Primarycontactname = group.Add(new VocabularyKey("address2Primarycontactname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn på sekundær kontaktperson").WithDescription("Angiv navnet på hovedkontakten på firmaets sekundære adresse."));
                Address2Shippingmethodcode = group.Add(new VocabularyKey("address2Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address2Stateorprovince = group.Add(new VocabularyKey("address2Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Område").WithDescription("Angiv staten eller området for den sekundære adresse."));
                Address2Telephone1 = group.Add(new VocabularyKey("address2Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 1").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Telephone2 = group.Add(new VocabularyKey("address2Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 2").WithDescription("\"Angiv et andet telefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Telephone3 = group.Add(new VocabularyKey("address2Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 3").WithDescription("\"Angiv et tredje telefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Upszone = group.Add(new VocabularyKey("address2Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: UPS-zone").WithDescription("\"Angiv UPS-zonen for den sekundære adresse for at sikre, at forsendelsesgebyrer beregnes korrekt, og at leverancer foretages prompte, hvis forsendelse sker med UPS.\""));
                Aging30 = group.Add(new VocabularyKey("aging30", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 30").WithDescription("Kun til systembrug."));
                Aging30Base = group.Add(new VocabularyKey("aging30Base", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 30 (grund)").WithDescription("Feltet Aldersfordeling 30 angivet i grundvaluta."));
                Aging60 = group.Add(new VocabularyKey("aging60", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 60").WithDescription("Kun til systembrug."));
                Aging60Base = group.Add(new VocabularyKey("aging60Base", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 60 (grund)").WithDescription("Feltet Aldersfordeling 60 angivet i grundvaluta."));
                Aging90 = group.Add(new VocabularyKey("aging90", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 90").WithDescription("Kun til systembrug."));
                Aging90Base = group.Add(new VocabularyKey("aging90Base", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 90 (grund)").WithDescription("Feltet Aldersfordeling 90 angivet i grundvaluta."));
                Businesstypecode = group.Add(new VocabularyKey("businesstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Forretningstype").WithDescription("Vælg den juridiske angivelse eller en anden forretningstype for firmaet i forbindelse med kontrakter eller rapportering."));
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Viser, hvem der har oprettet posten.\""));
                Createdbyexternalparty = group.Add(new VocabularyKey("createdbyexternalparty", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af (ekstern part)").WithDescription("\"Viser den eksterne part, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet Dato").WithDescription("\"Viser dato og klokkeslæt for oprettelse af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics 365.\""));
                Creditlimit = group.Add(new VocabularyKey("creditlimit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kreditgrænse").WithDescription("\"Angiv kreditgrænsen for firmaet. Dette er en nyttig reference, når du håndterer faktura- og regnskabsproblemer over for kunden.\""));
                CreditlimitBase = group.Add(new VocabularyKey("creditlimitBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kreditgrænse (grund)").WithDescription("Viser kreditgrænsen konverteret til systemets standardgrundvaluta i forbindelse med rapportering."));
                Creditonhold = group.Add(new VocabularyKey("creditonhold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kreditstop").WithDescription("\"Vælg, om firmaets kredit er sat i venteposition. Dette er en nyttig reference ved håndtering af faktura- og regnskabsproblemer over for kunden.\""));
                Customersizecode = group.Add(new VocabularyKey("customersizecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kundestørrelse").WithDescription("Vælg firmaets størrelseskategori eller størrelsesinterval i forbindelse med segmentering og rapportering."));
                Defaultpricelevelid = group.Add(new VocabularyKey("defaultpricelevelid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Prisliste").WithDescription("\"Vælg den standardprisliste, der er tilknyttet firmaet, for at sikre, at salgsmuligheder, tilbud og ordrer anvender de korrekte produktpriser for denne kunde.$price_level_accounts\""));
                Description = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturerings Info").WithDescription("\"Angiv flere oplysninger for at beskrive firmaet, f.eks. et uddrag fra firmaets websted.\""));
                Donotbulkemail = group.Add(new VocabularyKey("donotbulkemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke e-mail-masseforsend.").WithDescription("\"Vælg, om firmaet tillader masseforsendelser af e-mails via kampagner. Hvis Tillad ikke er valgt, kan firmaet tilføjes på marketinglister, men er udelukket fra e-mail.\""));
                Donotbulkpostalmail = group.Add(new VocabularyKey("donotbulkpostalmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke masseforsendelse").WithDescription("\"Vælg, om firmaet tillader masseforsendelser af almindelig post via marketingkampagner eller lynkampagner. Hvis Tillad ikke er valgt, kan firmaet tilføjes på marketinglisten, men er udelukket fra almindelig post.\""));
                Donotemail = group.Add(new VocabularyKey("donotemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke e-mails").WithDescription("\"Vælg, om firmaet tillader, at der sendes direct mail fra Microsoft Dynamics 365.\""));
                Donotfax = group.Add(new VocabularyKey("donotfax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke faxer").WithDescription("\"Vælg, om firmaet tillader faxer. Hvis Tillad ikke er valgt, udelukkes firmaet fra faxaktiviteter, der distribueres i marketingkampagner.\""));
                Donotphone = group.Add(new VocabularyKey("donotphone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke telefonopkald").WithDescription("\"Vælg, om firmaet tillader telefonopkald. Hvis Tillad ikke er valgt, udelukkes firmaet fra telefonopkaldsaktiviteter, der distribueres i marketingkampagner.\""));
                Donotpostalmail = group.Add(new VocabularyKey("donotpostalmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke post").WithDescription("\"Vælg, om firmaet tillader direct mail. Hvis Tillad ikke er valgt, udelukkes firmaet fra brevaktiviteter, der distribueres i marketingkampagner.\""));
                Donotsendmm = group.Add(new VocabularyKey("donotsendmm", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Marketingmatr.").WithDescription("\"Vælg, om firmaet accepterer marketingmateriale som f.eks. brochurer eller kataloger.\""));
                DynaAccountid = group.Add(new VocabularyKey("dynaAccountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær Debitor").WithDescription("Entydigt id for Debitor tilknyttet Firma."));
                DynaBlokerNedarvAfAdresseOplysninger = group.Add(new VocabularyKey("dynaBlokerNedarvAfAdresseOplysninger", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bloker nedarv af adresse oplysninger").WithDescription("\"Når der er flueben i dette felt, bliver Virksomheds adresse oplysningerne ikke kopiret/nedarvet til Fakturerings adressen.\""));
                DynaCoursecustomer = group.Add(new VocabularyKey("dynaCoursecustomer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor"));
                DynaCvrp = group.Add(new VocabularyKey("dynaCvrp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR-P"));
                DynaCvrse = group.Add(new VocabularyKey("dynaCvrse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR"));
                DynaCvrstatus = group.Add(new VocabularyKey("dynaCvrstatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR status"));
                DynaCvrstatuskode = group.Add(new VocabularyKey("dynaCvrstatuskode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR statuskode"));
                DynaDaarligbetaler = group.Add(new VocabularyKey("dynaDaarligbetaler", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tjek Debitor").WithDescription("\"Feltet tjek debitor bliver brugt til at oplyse KC om at en Kursusdeltager er en dårligbetaler, så de kan betale forud for kursusstart.\""));
                DynaDebitor = group.Add(new VocabularyKey("dynaDebitor", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Synkroniser med Navision"));
                DynaDebitorunderoprettelse = group.Add(new VocabularyKey("dynaDebitorunderoprettelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DebitorUnderOprettelse"));
                DynaEannummer = group.Add(new VocabularyKey("dynaEannummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("EAN-Nummer"));
                DynaEanpkrvet = group.Add(new VocabularyKey("dynaEanpkrvet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("EAN påkrævet"));
                DynaEtableringsaar = group.Add(new VocabularyKey("dynaEtableringsaar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Etableringsdato"));
                DynaFaktureringsemail = group.Add(new VocabularyKey("dynaFaktureringsemail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("FaktureringsEmail").WithDescription("Den email som skal benyttes til at sende emails til et firm/debitor"));
                DynaGodkendtinav = group.Add(new VocabularyKey("dynaGodkendtinav", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Godkendt i NAV"));
                DynaHovedselskab = group.Add(new VocabularyKey("dynaHovedselskab", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Hovedselskab"));
                DynaKobteydelser = group.Add(new VocabularyKey("dynaKobteydelser", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Købte Ydelser"));
                DynaKobteydelserBase = group.Add(new VocabularyKey("dynaKobteydelserBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Købte Ydelser (grund)").WithDescription("Værdi af Købte Ydelser i grundvaluta."));
                DynaKobteydelserDate = group.Add(new VocabularyKey("dynaKobteydelserDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Købte Ydelser (Senest opdateret den)").WithDescription("Tidspunkt for seneste opdatering af akkumuleringsfeltet Købte Ydelser."));
                DynaKobteydelserState = group.Add(new VocabularyKey("dynaKobteydelserState", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Købte Ydelser (tilstand)").WithDescription("Tilstand for akkumuleringsfeltet Købte Ydelser."));
                DynaKoncernomstaening = group.Add(new VocabularyKey("dynaKoncernomstaening", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Koncernomsætning"));
                DynaLandid = group.Add(new VocabularyKey("dynaLandid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse - Landekode").WithDescription("Entydigt id for Land tilknyttet Medlem/Medie."));
                DynaModerselskab = group.Add(new VocabularyKey("dynaModerselskab", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Moderselskab"));
                DynaNavid = group.Add(new VocabularyKey("dynaNavid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("NAV ID"));
                DynaNavtemplateid = group.Add(new VocabularyKey("dynaNavtemplateid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor Opsætning").WithDescription("Entydigt id for Nav Skabelon tilknyttet Firma."));
                DynaNumberofemployeesbranch = group.Add(new VocabularyKey("dynaNumberofemployeesbranch", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal ansatte i filial"));
                DynaOldid = group.Add(new VocabularyKey("dynaOldid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OLDID"));
                DynaOprettelsesmailsendt = group.Add(new VocabularyKey("dynaOprettelsesmailsendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettelsesmail sendt"));
                DynaPopkrvet = group.Add(new VocabularyKey("dynaPopkrvet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("PO Påkrævet"));
                DynaRammeaftale = group.Add(new VocabularyKey("dynaRammeaftale", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Rammeaftale").WithDescription("Indiklere om firmaet har en ramme aftale med lederne i forbindelse med salg af varer"));
                DynaRammeslutdato = group.Add(new VocabularyKey("dynaRammeslutdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Slutdato"));
                DynaRammestartdato = group.Add(new VocabularyKey("dynaRammestartdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Startdato"));
                DynaSegmentKundeaktivitet = group.Add(new VocabularyKey("dynaSegmentKundeaktivitet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kunde aktivitet").WithDescription("\"Status på om kunden har eller har haft en aktivitet i form af Telefonopkald, møde, email eller salgsmulighed de sidste X antal dage\""));
                DynaSegmentKundestatus = group.Add(new VocabularyKey("dynaSegmentKundestatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kunde status").WithDescription("\"Aktiv kunde: Kursus deltagelse aktivitet de sidste 24 mdr. Potentiel kunde: Kursus deltagelse aktivitet senest imellem 24-72 mdr. Passiv kunde: ingen aktiviteter nogensinde.\""));
                DynaSegmentVirksomhedsstoerrelse = group.Add(new VocabularyKey("dynaSegmentVirksomhedsstoerrelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomheds størrelse").WithDescription("\"Dette felt bruges til scribe, som opdatere feltet ud fra antal ansatte (NN markedsdata)\""));
                DynaTotalamount = group.Add(new VocabularyKey("dynaTotalamount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Omsætning"));
                DynaUpdatetricker = group.Add(new VocabularyKey("dynaUpdatetricker", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Update tricker"));
                DynaVirksomhedsform = group.Add(new VocabularyKey("dynaVirksomhedsform", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsform"));
                Emailaddress1 = group.Add(new VocabularyKey("emailaddress1", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("E-mail").WithDescription("Angiv firmaets primære e-mail-adresse."));
                Emailaddress2 = group.Add(new VocabularyKey("emailaddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailadresse 2").WithDescription("Angiv firmaets sekundære e-mail-adresse."));
                Emailaddress3 = group.Add(new VocabularyKey("emailaddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailadresse 3").WithDescription("Angiv firmaets alternative e-mail-adresse."));
                Entityimage = group.Add(new VocabularyKey("entityimage", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standardbillede").WithDescription("Viser postens standardbillede."));
                Entityimageid = group.Add(new VocabularyKey("entityimageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for objektbillede").WithDescription("Kun til intern brug."));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("Viser omregningskursen for postens valuta. Valutakursen bruges til at konvertere alle pengefelter i posten fra den lokale valuta til systemets standardvaluta."));
                Fax = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fax").WithDescription("Angiv firmaets faxnummer."));
                Followemail = group.Add(new VocabularyKey("followemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Følg mailaktivitet").WithDescription("\"Oplysninger om, hvorvidt følgende mailaktivitet som åbninger, visning af vedhæftede filer og klik på links skal tillades for mails, der sendes til firmaet.\""));
                Ftpsiteurl = group.Add(new VocabularyKey("ftpsiteurl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("FTP-sted").WithDescription("\"Angiv URL-adressen til firmaets FTP-websted, for at brugerne kan få adgang til data og dele dokumenter.\""));
                Industrycode = group.Add(new VocabularyKey("industrycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Branche").WithDescription("Vælg firmaets primære branche til brug ved marketingsegmentering og demografiske analyser."));
                Lastonholdtime = group.Add(new VocabularyKey("lastonholdtime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste tid i venteposition").WithDescription("Indeholder dato- og klokkeslætsstemplet for den seneste tid for I venteposition."));
                Lastusedincampaign = group.Add(new VocabularyKey("lastusedincampaign", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste dato i kampagnen").WithDescription("\"Viser den dato, hvor firmaet sidst var inkluderet i en marketingkampagne eller lynkampagne.\""));
                Marketcap = group.Add(new VocabularyKey("marketcap", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Markedskapitalisering").WithDescription("Angiv firmaets markedskapitalisering for at identificere firmaets egenkapital. Bruges som indikator i analyser af det økonomiske resultat."));
                MarketcapBase = group.Add(new VocabularyKey("marketcapBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Markedskapitalisering (grund)").WithDescription("Viser markedskapitaliseringen konverteret til systemets standardgrundvaluta."));
                Marketingonly = group.Add(new VocabularyKey("marketingonly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kun marketing").WithDescription("\"Angiver, om det kun er til marketingbrug\""));
                Masterid = group.Add(new VocabularyKey("masterid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Master-id").WithDescription("\"Viser det hovedfirma, som firmaet er blevet flettet med.\""));
                Merged = group.Add(new VocabularyKey("merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Flettet").WithDescription("\"Viser, om firmaet er blevet flettet med et andet firma.\""));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Viser, hvem der sidst har opdateret posten.\""));
                Modifiedbyexternalparty = group.Add(new VocabularyKey("modifiedbyexternalparty", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af (ekstern part)").WithDescription("\"Viser den eksterne part, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("\"Viser dato og klokkeslæt for den seneste opdatering af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics 365.\""));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firmanavn").WithDescription("Angiv firma- eller forretningsnavnet."));
                NewCompanysize = group.Add(new VocabularyKey("newCompanysize", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firmastørrelse"));
                NnLastupdated = group.Add(new VocabularyKey("nnLastupdated", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Last update from NN Markedsdata").WithDescription("Sidste opdatering fra NN Markedsdata"));
                NnLinks = group.Add(new VocabularyKey("nnLinks", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("NN Markedsdata_id").WithDescription("Internt link-felt for NN Markedsdata - kun til intern brug"));
                NnPrimarytradecode = group.Add(new VocabularyKey("nnPrimarytradecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primære branchekodenavn").WithDescription("Primære branchekode"));
                NnPrimarytradecodeno = group.Add(new VocabularyKey("nnPrimarytradecodeno", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primære branchekode #").WithDescription("Primære branchekode #"));
                NnTdcid = group.Add(new VocabularyKey("nnTdcid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("TDC ID").WithDescription("TDC ID"));
                NnUpdateprotected = group.Add(new VocabularyKey("nnUpdateprotected", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskyt mod automatiske opdateringer").WithDescription("Beskyt mod automatiske opdateringer"));
                Numberofemployees = group.Add(new VocabularyKey("numberofemployees", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal ansatte").WithDescription("\"Angiv antallet af medarbejdere, der arbejder i firmaet, til brug ved marketingsegmentering og demografiske analyser.\""));
                Onholdtime = group.Add(new VocabularyKey("onholdtime", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tid for I venteposition (minutter)").WithDescription("\"Viser, hvor længe posten var i venteposition i minutter.\""));
                Opendeals = group.Add(new VocabularyKey("opendeals", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Åbne handler").WithDescription("Antal åbne salgsmuligheder i forhold til et firma og dets underordnede firmaer."));
                OpendealsDate = group.Add(new VocabularyKey("opendealsDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Åbne handler (tidspunkt for seneste opdatering)").WithDescription("Dato/klokkeslæt for OpenDeals."));
                OpendealsState = group.Add(new VocabularyKey("opendealsState", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OpenDeals (tilstand)").WithDescription("Tilstand for OpenDeals."));
                Openrevenue = group.Add(new VocabularyKey("openrevenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Åben omsætning").WithDescription("Summen af åben omsætning i forhold til et firma og dets underordnede firmaer."));
                OpenrevenueBase = group.Add(new VocabularyKey("openrevenueBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Åben omsætning (basis)").WithDescription("Summen af åben omsætning i forhold til et firma og dets underordnede firmaer."));
                OpenrevenueDate = group.Add(new VocabularyKey("openrevenueDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Åben omsætning (tidspunkt for seneste opdatering)").WithDescription("Dato/klokkeslæt for Åben omsætning."));
                OpenrevenueState = group.Add(new VocabularyKey("openrevenueState", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Åben tilstand (tilstand)").WithDescription("Tilstand for åben omsætning."));
                Originatingleadid = group.Add(new VocabularyKey("originatingleadid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kilde til kundeemne").WithDescription("\"Viser det kundeemne, som firmaet er oprettet ud fra, hvis firmaet blev oprettet ved konvertering af et kundeemne i Microsoft Dynamics 365. Dette bruges til at relatere firmaet til data i det oprindelige kundeemne til brug ved rapportering og analyser.$account_originating_lead\""));
                Parentaccountid = group.Add(new VocabularyKey("parentaccountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overordnet firma").WithDescription("\"Vælg det overordnede firma, der er tilknyttet dette firma, for at vise overordnede og underordnede forretninger i rapportering og analyser.\""));
                Participatesinworkflow = group.Add(new VocabularyKey("participatesinworkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager i arbejdsproces").WithDescription("Kun til systembrug. Ældre Microsoft Dynamics CRM 3.0-arbejdsprocesdata."));
                Paymenttermscode = group.Add(new VocabularyKey("paymenttermscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bet.betingelser").WithDescription("\"Vælg betalingsbetingelserne for at angive, hvornår kunden skal betale det samlede beløb.\""));
                Preferredappointmentdaycode = group.Add(new VocabularyKey("preferredappointmentdaycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket dag").WithDescription("Vælg den foretrukne ugedag til serviceaftaler."));
                Preferredappointmenttimecode = group.Add(new VocabularyKey("preferredappointmenttimecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket klokkeslæt").WithDescription("Vælg det foretrukne tidspunkt til serviceaftaler."));
                Preferredcontactmethodcode = group.Add(new VocabularyKey("preferredcontactmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken kontaktmetode").WithDescription("Vælg den foretrukne kontaktmetode."));
                Preferredserviceid = group.Add(new VocabularyKey("preferredserviceid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken service").WithDescription("\"Vælg firmaets foretrukne service som reference, når du planlægger serviceaktiviteter.$service_accounts\""));
                Preferredsystemuserid = group.Add(new VocabularyKey("preferredsystemuserid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken bruger").WithDescription("\"Vælg den foretrukne serviceremedarbejder som reference, når du planlægger serviceaktiviteter for firmaet.\""));
                Primarycontactid = group.Add(new VocabularyKey("primarycontactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær kontaktperson").WithDescription("Vælg firmaets primære kontakt for at sikre hurtig adgang til kontaktoplysninger."));
                Primarysatoriid = group.Add(new VocabularyKey("primarysatoriid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primært Satori-id").WithDescription("Primært Satori-id for firma"));
                Primarytwitterid = group.Add(new VocabularyKey("primarytwitterid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primært Twitter-id").WithDescription("Primært Twitter-id for firma"));
                Processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Proces").WithDescription("Viser processens id."));
                Revenue = group.Add(new VocabularyKey("revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsomsætning").WithDescription("\"Angiv firmaets årsomsætning, der bruges som indikator i analyser af det økonomiske resultat.\""));
                RevenueBase = group.Add(new VocabularyKey("revenueBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsomsætning (grund)").WithDescription("\"Viser årsomsætningen konverteret til systemets standardgrundvaluta. I beregningerne bruges den valutakurs, der er angivet i området Valutaer.\""));
                Sharesoutstanding = group.Add(new VocabularyKey("sharesoutstanding", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Udestående aktier").WithDescription("\"Angiv antallet af aktier, der er tilgængelige for offentligheden, for firmaet. Dette tal bruges som indikator i analyser af det økonomiske resultat.\""));
                Shippingmethodcode = group.Add(new VocabularyKey("shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til firmaets adresse, for at angive den foretrukne transportør eller en anden leveringsindstilling.\""));
                Sic = group.Add(new VocabularyKey("sic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("NACE-kode").WithDescription("\"Angiv SIC-koden (Standard Industrial Classification), der angiver firmaets primære branche, til brug ved marketingsegmentering og demografiske analyser.\""));
                Slaid = group.Add(new VocabularyKey("slaid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SLA").WithDescription("\"Vælg den serviceaftale (SLA), du vil anvende på firmaposten.\""));
                Slainvokedid = group.Add(new VocabularyKey("slainvokedid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidst anvendte SLA").WithDescription("\"Sidste SLA, der blev anvendt til denne sag. Dette felt er kun beregnet til intern brug.\""));
                Stageid = group.Add(new VocabularyKey("stageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Procestrin").WithDescription("Viser fasens id."));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("\"Viser, om firmaet er aktivt eller inaktivt. Inaktive firmaer er skrivebeskyttede og kan ikke redigeres, medmindre de genaktiveres.\""));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Vælg firmaets status."));
                Stockexchange = group.Add(new VocabularyKey("stockexchange", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Børs").WithDescription("\"Angiv den børs, firmaet er noteret på, for at spore selskabets aktier og økonomiske resultater.\""));
                Telephone1 = group.Add(new VocabularyKey("telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær telefon").WithDescription("Angiv hovedtelefonnummeret for dette firma."));
                Telephone2 = group.Add(new VocabularyKey("telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden telefon").WithDescription("Angiv et andet telefonnummer for dette firma."));
                Telephone3 = group.Add(new VocabularyKey("telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon 3").WithDescription("Angiv et tredje telefonnummer for dette firma."));
                Territorycode = group.Add(new VocabularyKey("territorycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Distriktskode").WithDescription("Vælg et område eller distrikt for firmaet til brug ved segmentering og analyser."));
                Territoryid = group.Add(new VocabularyKey("territoryid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Distrikt").WithDescription("\"Vælg salgsområdet eller -distriktet for firmaet for at sikre, at firmaet er tildelt den rette medarbejder og til brug ved segmentering og analyser.$territory_accounts\""));
                Tickersymbol = group.Add(new VocabularyKey("tickersymbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aktiesymbol").WithDescription("\"Angiv firmaets aktiesymbol for at spore selskabets økonomiske resultater. Du kan klikke på den kode, der er angivet i dette felt, for at få adgang til de seneste handelsoplysninger fra MSN Money.\""));
                Timespentbymeonemailandmeetings = group.Add(new VocabularyKey("timespentbymeonemailandmeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tidsforbrug for mig").WithDescription("Samlet tid jeg har brugt på mails (læsning og skrivning) samt møder i relation til firmapost."));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Vælg den lokale valuta til posten for at sikre, at budgetter rapporteres i den korrekte valuta.\""));
                Traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gennemløbet sti").WithDescription("Kun til intern brug."));
                Websiteurl = group.Add(new VocabularyKey("websiteurl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Websted").WithDescription("Angiv URL-adressen til firmaets websted for at få hurtige oplysninger om firmaprofilen."));
            });

            AddMapping(Address1Addresstypecode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressCategory);
            AddMapping(Address1City, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressCity);
            AddMapping(Address1County, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressStateDistrict);
            AddMapping(Address1Latitude, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressLattitude);
            AddMapping(Address1Longitude, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressLongitude);
            AddMapping(Address1Fax, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Fax);
            AddMapping(Address1Line1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
            AddMapping(Address1Line2, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
            AddMapping(Address1Line3, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressNameStreet);
            AddMapping(Address1Postalcode, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressZipCode);
            AddMapping(Address1Postofficebox, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressPostOfficeBox);
            AddMapping(Address1Stateorprovince, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInLocation.AddressState);
            AddMapping(Address1Telephone1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(Address1Telephone2, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(Address1Telephone3, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(DynaHovedselskab, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.OrganizationName);
            AddMapping(Emailaddress1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.ContactEmail);
            AddMapping(Emailaddress2, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.ContactEmail);
            AddMapping(Emailaddress3, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.ContactEmail);
            AddMapping(Fax, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Fax);
            AddMapping(Name, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.OrganizationName);
            AddMapping(Telephone1, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(Telephone2, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(Telephone3, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(Websiteurl, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Website);
        }

        public VocabularyKey Accountcategorycode { get; private set; }
        public VocabularyKey Accountclassificationcode { get; private set; }
        public VocabularyKey Accountid { get; private set; }
        public VocabularyKey Accountnumber { get; private set; }
        public VocabularyKey Accountratingcode { get; private set; }
        public VocabularyKey Address1Addresstypecode { get; private set; }
        public VocabularyKey Address1City { get; private set; }
        public VocabularyKey Address1Composite { get; private set; }
        public VocabularyKey Address1Country { get; private set; }
        public VocabularyKey Address1County { get; private set; }
        public VocabularyKey Address1Fax { get; private set; }
        public VocabularyKey Address1Freighttermscode { get; private set; }
        public VocabularyKey Address1Latitude { get; private set; }
        public VocabularyKey Address1Line1 { get; private set; }
        public VocabularyKey Address1Line2 { get; private set; }
        public VocabularyKey Address1Line3 { get; private set; }
        public VocabularyKey Address1Longitude { get; private set; }
        public VocabularyKey Address1Name { get; private set; }
        public VocabularyKey Address1Postalcode { get; private set; }
        public VocabularyKey Address1Postofficebox { get; private set; }
        public VocabularyKey Address1Primarycontactname { get; private set; }
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
        public VocabularyKey Address2Freighttermscode { get; private set; }
        public VocabularyKey Address2Latitude { get; private set; }
        public VocabularyKey Address2Line1 { get; private set; }
        public VocabularyKey Address2Line2 { get; private set; }
        public VocabularyKey Address2Line3 { get; private set; }
        public VocabularyKey Address2Longitude { get; private set; }
        public VocabularyKey Address2Name { get; private set; }
        public VocabularyKey Address2Postalcode { get; private set; }
        public VocabularyKey Address2Postofficebox { get; private set; }
        public VocabularyKey Address2Primarycontactname { get; private set; }
        public VocabularyKey Address2Shippingmethodcode { get; private set; }
        public VocabularyKey Address2Stateorprovince { get; private set; }
        public VocabularyKey Address2Telephone1 { get; private set; }
        public VocabularyKey Address2Telephone2 { get; private set; }
        public VocabularyKey Address2Telephone3 { get; private set; }
        public VocabularyKey Address2Upszone { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey Aging30Base { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey Aging60Base { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey Aging90Base { get; private set; }
        public VocabularyKey Businesstypecode { get; private set; }
        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdbyexternalparty { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey Creditlimit { get; private set; }
        public VocabularyKey CreditlimitBase { get; private set; }
        public VocabularyKey Creditonhold { get; private set; }
        public VocabularyKey Customersizecode { get; private set; }
        public VocabularyKey Defaultpricelevelid { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Donotbulkemail { get; private set; }
        public VocabularyKey Donotbulkpostalmail { get; private set; }
        public VocabularyKey Donotemail { get; private set; }
        public VocabularyKey Donotfax { get; private set; }
        public VocabularyKey Donotphone { get; private set; }
        public VocabularyKey Donotpostalmail { get; private set; }
        public VocabularyKey Donotsendmm { get; private set; }
        public VocabularyKey DynaAccountid { get; private set; }
        public VocabularyKey DynaBlokerNedarvAfAdresseOplysninger { get; private set; }
        public VocabularyKey DynaCoursecustomer { get; private set; }
        public VocabularyKey DynaCvrp { get; private set; }
        public VocabularyKey DynaCvrse { get; private set; }
        public VocabularyKey DynaCvrstatus { get; private set; }
        public VocabularyKey DynaCvrstatuskode { get; private set; }
        public VocabularyKey DynaDaarligbetaler { get; private set; }
        public VocabularyKey DynaDebitor { get; private set; }
        public VocabularyKey DynaDebitorunderoprettelse { get; private set; }
        public VocabularyKey DynaEannummer { get; private set; }
        public VocabularyKey DynaEanpkrvet { get; private set; }
        public VocabularyKey DynaEtableringsaar { get; private set; }
        public VocabularyKey DynaFaktureringsemail { get; private set; }
        public VocabularyKey DynaGodkendtinav { get; private set; }
        public VocabularyKey DynaHovedselskab { get; private set; }
        public VocabularyKey DynaKobteydelser { get; private set; }
        public VocabularyKey DynaKobteydelserBase { get; private set; }
        public VocabularyKey DynaKobteydelserDate { get; private set; }
        public VocabularyKey DynaKobteydelserState { get; private set; }
        public VocabularyKey DynaKoncernomstaening { get; private set; }
        public VocabularyKey DynaLandid { get; private set; }
        public VocabularyKey DynaModerselskab { get; private set; }
        public VocabularyKey DynaNavid { get; private set; }
        public VocabularyKey DynaNavtemplateid { get; private set; }
        public VocabularyKey DynaNumberofemployeesbranch { get; private set; }
        public VocabularyKey DynaOldid { get; private set; }
        public VocabularyKey DynaOprettelsesmailsendt { get; private set; }
        public VocabularyKey DynaPopkrvet { get; private set; }
        public VocabularyKey DynaRammeaftale { get; private set; }
        public VocabularyKey DynaRammeslutdato { get; private set; }
        public VocabularyKey DynaRammestartdato { get; private set; }
        public VocabularyKey DynaSegmentKundeaktivitet { get; private set; }
        public VocabularyKey DynaSegmentKundestatus { get; private set; }
        public VocabularyKey DynaSegmentVirksomhedsstoerrelse { get; private set; }
        public VocabularyKey DynaTotalamount { get; private set; }
        public VocabularyKey DynaUpdatetricker { get; private set; }
        public VocabularyKey DynaVirksomhedsform { get; private set; }
        public VocabularyKey Emailaddress1 { get; private set; }
        public VocabularyKey Emailaddress2 { get; private set; }
        public VocabularyKey Emailaddress3 { get; private set; }
        public VocabularyKey Entityimage { get; private set; }
        public VocabularyKey Entityimageid { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Followemail { get; private set; }
        public VocabularyKey Ftpsiteurl { get; private set; }
        public VocabularyKey Industrycode { get; private set; }
        public VocabularyKey Lastonholdtime { get; private set; }
        public VocabularyKey Lastusedincampaign { get; private set; }
        public VocabularyKey Marketcap { get; private set; }
        public VocabularyKey MarketcapBase { get; private set; }
        public VocabularyKey Marketingonly { get; private set; }
        public VocabularyKey Masterid { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedbyexternalparty { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NewCompanysize { get; private set; }
        public VocabularyKey NnLastupdated { get; private set; }
        public VocabularyKey NnLinks { get; private set; }
        public VocabularyKey NnPrimarytradecode { get; private set; }
        public VocabularyKey NnPrimarytradecodeno { get; private set; }
        public VocabularyKey NnTdcid { get; private set; }
        public VocabularyKey NnUpdateprotected { get; private set; }
        public VocabularyKey Numberofemployees { get; private set; }
        public VocabularyKey Onholdtime { get; private set; }
        public VocabularyKey Opendeals { get; private set; }
        public VocabularyKey OpendealsDate { get; private set; }
        public VocabularyKey OpendealsState { get; private set; }
        public VocabularyKey Openrevenue { get; private set; }
        public VocabularyKey OpenrevenueBase { get; private set; }
        public VocabularyKey OpenrevenueDate { get; private set; }
        public VocabularyKey OpenrevenueState { get; private set; }
        public VocabularyKey Originatingleadid { get; private set; }
        public VocabularyKey Parentaccountid { get; private set; }
        public VocabularyKey Participatesinworkflow { get; private set; }
        public VocabularyKey Paymenttermscode { get; private set; }
        public VocabularyKey Preferredappointmentdaycode { get; private set; }
        public VocabularyKey Preferredappointmenttimecode { get; private set; }
        public VocabularyKey Preferredcontactmethodcode { get; private set; }
        public VocabularyKey Preferredserviceid { get; private set; }
        public VocabularyKey Preferredsystemuserid { get; private set; }
        public VocabularyKey Primarycontactid { get; private set; }
        public VocabularyKey Primarysatoriid { get; private set; }
        public VocabularyKey Primarytwitterid { get; private set; }
        public VocabularyKey Processid { get; private set; }
        public VocabularyKey Revenue { get; private set; }
        public VocabularyKey RevenueBase { get; private set; }
        public VocabularyKey Sharesoutstanding { get; private set; }
        public VocabularyKey Shippingmethodcode { get; private set; }
        public VocabularyKey Sic { get; private set; }
        public VocabularyKey Slaid { get; private set; }
        public VocabularyKey Slainvokedid { get; private set; }
        public VocabularyKey Stageid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Stockexchange { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Territorycode { get; private set; }
        public VocabularyKey Territoryid { get; private set; }
        public VocabularyKey Tickersymbol { get; private set; }
        public VocabularyKey Timespentbymeonemailandmeetings { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
        public VocabularyKey Traversedpath { get; private set; }
        public VocabularyKey Websiteurl { get; private set; }
    }
}
