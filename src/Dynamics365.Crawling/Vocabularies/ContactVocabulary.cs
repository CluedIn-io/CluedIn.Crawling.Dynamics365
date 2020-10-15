using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Dynamics365 Contact"; // TODO: Set value
            KeyPrefix = "dynamics365.Contact"; // TODO: Set value
            KeySeparator = ".";
            Grouping = EntityType.Person; // TODO: Check value

            AddGroup("Person Details", group =>
            {
                Accountid = group.Add(new VocabularyKey("accountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhed_ID").WithDescription("\"Entydigt id for det firma, som kontaktpersonen er tilknyttet.\""));
                Accountrolecode = group.Add(new VocabularyKey("accountrolecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Rolle").WithDescription("\"Vælg kontaktens rolle i firmaet eller salgsprocessen, f.eks. beslutningstager, medarbejder eller person, der øver indflydelse.\""));
                Address1Addresstypecode = group.Add(new VocabularyKey("address1Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Adressetype").WithDescription("Vælg den primære adressetype."));
                Address1City = group.Add(new VocabularyKey("address1City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - By").WithDescription("Angiv byen for den primære adresse."));
                Address1Composite = group.Add(new VocabularyKey("address1Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Sammensat").WithDescription("Viser den fulde primære adresse."));
                Address1Country = group.Add(new VocabularyKey("address1Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Land/område").WithDescription("Angiv landet eller området for den primære adresse."));
                Address1County = group.Add(new VocabularyKey("address1County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Region").WithDescription("Angiv regionen for den primære adresse."));
                Address1Fax = group.Add(new VocabularyKey("address1Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Fax").WithDescription("\"Angiv det faxnummer, der er tilknyttet den primære adresse.\""));
                Address1Freighttermscode = group.Add(new VocabularyKey("address1Freighttermscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Fragtbetingelser").WithDescription("\"Vælg fragtbetingelser for den primære adresse for at sikre, at forsendelsesordrer behandles korrekt.\""));
                Address1Latitude = group.Add(new VocabularyKey("address1Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Breddegrad").WithDescription("Angiv værdien for breddegraden for den primære adresse til brug ved kortlægning og andre programmer."));
                Address1Line1 = group.Add(new VocabularyKey("address1Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Gade 1").WithDescription("Angiv den første linje i den primære adresse."));
                Address1Line2 = group.Add(new VocabularyKey("address1Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Gade 2").WithDescription("Angiv den anden linje i den primære adresse."));
                Address1Line3 = group.Add(new VocabularyKey("address1Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Gade 3").WithDescription("Angiv den tredje linje i den primære adresse."));
                Address1Longitude = group.Add(new VocabularyKey("address1Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Længdegrad").WithDescription("Angiv værdien for længdegraden for den primære adresse til brug ved kortlægning og andre programmer."));
                Address1Name = group.Add(new VocabularyKey("address1Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Navn").WithDescription("\"Angiv et beskrivende navn til den primære adresse, f.eks. koncernhovedsæde.\""));
                Address1Postalcode = group.Add(new VocabularyKey("address1Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Privat Adresse - Postnummer").WithDescription("Angiv postnummeret for den primære adresse."));
                Address1Postofficebox = group.Add(new VocabularyKey("address1Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Postboksnummer").WithDescription("Angiv postboksnummeret for den primære adresse."));
                Address1Primarycontactname = group.Add(new VocabularyKey("address1Primarycontactname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Navn på primær kontaktperson").WithDescription("Angiv navnet på hovedkontakten på firmaets primære adresse."));
                Address1Shippingmethodcode = group.Add(new VocabularyKey("address1Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address1Stateorprovince = group.Add(new VocabularyKey("address1Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Område").WithDescription("Angiv staten eller området for den primære adresse."));
                Address1Telephone1 = group.Add(new VocabularyKey("address1Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 1: Telefon").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den primære adresse.\""));
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
                Address2Primarycontactname = group.Add(new VocabularyKey("address2Primarycontactname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Navn på primær kontaktperson").WithDescription("Angiv navnet på hovedkontakten på firmaets sekundære adresse."));
                Address2Shippingmethodcode = group.Add(new VocabularyKey("address2Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address2Stateorprovince = group.Add(new VocabularyKey("address2Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Område").WithDescription("Angiv staten eller området for den sekundære adresse."));
                Address2Telephone1 = group.Add(new VocabularyKey("address2Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 1").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Telephone2 = group.Add(new VocabularyKey("address2Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 2").WithDescription("\"Angiv et andet telefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Telephone3 = group.Add(new VocabularyKey("address2Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: Telefon 3").WithDescription("\"Angiv et tredje telefonnummer, der er tilknyttet den sekundære adresse.\""));
                Address2Upszone = group.Add(new VocabularyKey("address2Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 2: UPS-zone").WithDescription("\"Angiv UPS-zonen for den sekundære adresse for at sikre, at forsendelsesgebyrer beregnes korrekt, og at leverancer foretages prompte, hvis forsendelse sker med UPS.\""));
                Address3Addresstypecode = group.Add(new VocabularyKey("address3Addresstypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Adressetype").WithDescription("Vælg den tredje adressetype."));
                Address3City = group.Add(new VocabularyKey("address3City", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: By").WithDescription("Angiv byen i adresse 3."));
                Address3Composite = group.Add(new VocabularyKey("address3Composite", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3").WithDescription("Viser den fulde tredje adresse."));
                Address3Country = group.Add(new VocabularyKey("address3Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Land/område").WithDescription("landet/området for adresse 3."));
                Address3County = group.Add(new VocabularyKey("address3County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Region").WithDescription("Angiv regionen for den tredje adresse."));
                Address3Fax = group.Add(new VocabularyKey("address3Fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Fax").WithDescription("\"Angiv det faxnummer, der er tilknyttet den tredje adresse.\""));
                Address3Freighttermscode = group.Add(new VocabularyKey("address3Freighttermscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Fragtbetingelser").WithDescription("\"Vælg fragtbetingelser for den tredje adresse for at sikre, at forsendelsesordrer behandles korrekt.\""));
                Address3Latitude = group.Add(new VocabularyKey("address3Latitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Breddegrad").WithDescription("Angiv værdien for breddegraden for den tredje adresse til brug ved kortlægning og i andre programmer."));
                Address3Line1 = group.Add(new VocabularyKey("address3Line1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Gade 1").WithDescription("den første linje i adresse 3."));
                Address3Line2 = group.Add(new VocabularyKey("address3Line2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Gade 2").WithDescription("den anden linje i adresse 3."));
                Address3Line3 = group.Add(new VocabularyKey("address3Line3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Gade 3").WithDescription("den tredje linje i adresse 3."));
                Address3Longitude = group.Add(new VocabularyKey("address3Longitude", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Længdegrad").WithDescription("Angiv værdien for længdegraden for den tredje adresse til brug ved kortlægning og i andre programmer."));
                Address3Name = group.Add(new VocabularyKey("address3Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Navn").WithDescription("\"Angiv et beskrivende navn til den tredje adresse, f.eks. koncernhovedsæde.\""));
                Address3Postalcode = group.Add(new VocabularyKey("address3Postalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Postnummer").WithDescription("postnummeret i adresse 3."));
                Address3Postofficebox = group.Add(new VocabularyKey("address3Postofficebox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Postboksnummer").WithDescription("postboksnummeret i adresse 3."));
                Address3Primarycontactname = group.Add(new VocabularyKey("address3Primarycontactname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Navn på primær kontaktperson").WithDescription("Angiv navnet på hovedkontakten på firmaets tredje adresse."));
                Address3Shippingmethodcode = group.Add(new VocabularyKey("address3Shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Address3Stateorprovince = group.Add(new VocabularyKey("address3Stateorprovince", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Område").WithDescription("området i adresse 3."));
                Address3Telephone1 = group.Add(new VocabularyKey("address3Telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Telefon 1").WithDescription("\"Angiv det hovedtelefonnummer, der er tilknyttet den tredje adresse.\""));
                Address3Telephone2 = group.Add(new VocabularyKey("address3Telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Telefon 2").WithDescription("\"Angiv et andet telefonnummer, der er tilknyttet den tredje adresse.\""));
                Address3Telephone3 = group.Add(new VocabularyKey("address3Telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: Telefon 3").WithDescription("\"Angiv et tredje telefonnummer, der er tilknyttet den primære adresse.\""));
                Address3Upszone = group.Add(new VocabularyKey("address3Upszone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Adresse 3: UPS-zone").WithDescription("\"Angiv UPS-zonen for den tredje adresse for at sikre, at forsendelsesgebyrer beregnes korrekt, og at leverancer foretages prompte, hvis forsendelse sker med UPS.\""));
                Aging30 = group.Add(new VocabularyKey("aging30", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 30").WithDescription("Kun til systembrug."));
                Aging30Base = group.Add(new VocabularyKey("aging30Base", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 30 (grund)").WithDescription("\"Viser feltet Aldersfordeling 30 konverteret til systemets standardgrundvaluta. I beregningerne bruges den valutakurs, der er angivet i området Valutaer.\""));
                Aging60 = group.Add(new VocabularyKey("aging60", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 60").WithDescription("Kun til systembrug."));
                Aging60Base = group.Add(new VocabularyKey("aging60Base", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 60 (grund)").WithDescription("\"Viser feltet Aldersfordeling 60 konverteret til systemets standardgrundvaluta. I beregningerne bruges den valutakurs, der er angivet i området Valutaer.\""));
                Aging90 = group.Add(new VocabularyKey("aging90", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 90").WithDescription("Kun til systembrug."));
                Aging90Base = group.Add(new VocabularyKey("aging90Base", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aldersfordeling 90 (grund)").WithDescription("\"Viser feltet Aldersfordeling 90 konverteret til systemets standardgrundvaluta. I beregningerne bruges den valutakurs, der er angivet i området Valutaer.\""));
                Anniversary = group.Add(new VocabularyKey("anniversary", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mærkedag").WithDescription("Angiv datoen for kontaktens bryllupsdag eller årsdagen for servicen til brug i gaveprogrammer til kunder eller anden kommunikation."));
                Annualincome = group.Add(new VocabularyKey("annualincome", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årlig indkomst").WithDescription("Angiv kontaktens årlige indkomst til brug i profileringer og økonomiske analyser."));
                AnnualincomeBase = group.Add(new VocabularyKey("annualincomeBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årlig indkomst (grund)").WithDescription("\"Viser feltet Årlig indkomst konverteret til systemets standardgrundvaluta. I beregningerne bruges den valutakurs, der er angivet i området Valutaer.\""));
                Assistantname = group.Add(new VocabularyKey("assistantname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Assistent").WithDescription("Angiv navnet på kontaktpersonens assistent."));
                Assistantphone = group.Add(new VocabularyKey("assistantphone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Assistents telefon").WithDescription("Angiv telefonnummeret til kontaktpersonens assistent."));
                Birthdate = group.Add(new VocabularyKey("birthdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fødselsdato").WithDescription("Angiv kontaktens fødselsdag til brug i gaveprogrammer til kunder eller anden kommunikation."));
                Business2 = group.Add(new VocabularyKey("business2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon 2 (arbejde)").WithDescription("Angiv et andet arbejdstelefonnummer til denne kontakt."));
                Callback = group.Add(new VocabularyKey("callback", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tilbagekaldsnummer").WithDescription("Angiv et tilbagekaldstelefonnummer til denne kontakt."));
                Childrensnames = group.Add(new VocabularyKey("childrensnames", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn på børn").WithDescription("Angiv navnene på kontaktens børn som reference i kommunikation og klientprogrammer."));
                Company = group.Add(new VocabularyKey("company", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firmatelefon").WithDescription("Angiv kontaktens firmatelefon."));
                Contactid = group.Add(new VocabularyKey("contactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontaktperson").WithDescription("Entydigt id for kontaktpersonen."));
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Viser, hvem der har oprettet posten.\""));
                Createdbyexternalparty = group.Add(new VocabularyKey("createdbyexternalparty", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af (ekstern part)").WithDescription("\"Viser den eksterne part, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet Dato").WithDescription("\"Viser dato og klokkeslæt for oprettelse af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics 365.\""));
                Creditlimit = group.Add(new VocabularyKey("creditlimit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kreditgrænse").WithDescription("\"Angiv kontaktens kreditgrænse som reference, når du håndterer faktura- og regnskabsproblemer over for kunden.\""));
                CreditlimitBase = group.Add(new VocabularyKey("creditlimitBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kreditgrænse (grund)").WithDescription("\"Viser feltet Kreditgrænse konverteret til systemets standardgrundvaluta til brug for rapportering. I beregningerne bruges den valutakurs, der er angivet i området Valutaer.\""));
                Creditonhold = group.Add(new VocabularyKey("creditonhold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kreditstop").WithDescription("\"Vælg, om kontakten er genstand for kreditstop, som reference ved håndtering af faktura- og regnskabsproblemer.\""));
                Customersizecode = group.Add(new VocabularyKey("customersizecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kundestørrelse").WithDescription("Vælg størrelsen på kontaktens firma til brug for segmentering og rapportering."));
                Customertypecode = group.Add(new VocabularyKey("customertypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Relationstype").WithDescription("\"Vælg den kategori, der bedst beskriver relationen mellem kontakten og din organisation.\""));
                Defaultpricelevelid = group.Add(new VocabularyKey("defaultpricelevelid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Prisliste").WithDescription("\"Vælg den standardprisliste, der er tilknyttet kontakten, for at sikre, at salgsmuligheder, tilbud og ordrer anvender de korrekte produktpriser over for denne kunde.$price_level_contacts\""));
                Department = group.Add(new VocabularyKey("department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Afdeling").WithDescription("\"Angiv den division eller afdeling, hvor kontakten arbejder, i moderselskabet eller den overordnede afdeling.\""));
                Description = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Personlig info").WithDescription("\"Angiv flere oplysninger for at beskrive kontakten, f.eks. et uddrag fra firmaets websted.\""));
                Donotbulkemail = group.Add(new VocabularyKey("donotbulkemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke e-mail-masseforsend.").WithDescription("\"Vælg, om kontakten accepterer masseforsendelser af e-mails, der sendes via marketingkampagner eller lynkampagner. Hvis Tillad ikke er valgt, kan kontakten tilføjes på marketinglisten, men er udelukket fra e-mailen.\""));
                Donotbulkpostalmail = group.Add(new VocabularyKey("donotbulkpostalmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke masseforsendelse").WithDescription("\"Vælg, om kontakten accepterer masseforsendelser af almindelig post, der sendes via marketingkampagner eller lynkampagner. Hvis Tillad ikke er valgt, kan kontakten tilføjes på marketinglisten, men er udelukket fra brevene.\""));
                Donotemail = group.Add(new VocabularyKey("donotemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke e-mails").WithDescription("\"Vælg, om kontakten tillader, at der sendes direct mail fra Microsoft Dynamics 365. Hvis Tillad ikke er valgt, sender Microsoft Dynamics 365 ikke mailen.\""));
                Donotfax = group.Add(new VocabularyKey("donotfax", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke faxer").WithDescription("\"Vælg, om kontakten tillader faxer. Hvis Tillad ikke er valgt, udelukkes kontakten fra alle faxaktiviteter, der distribueres i marketingkampagner.\""));
                Donotphone = group.Add(new VocabularyKey("donotphone", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke telefonopkald").WithDescription("\"Vælg, om kontakten accepterer telefonopkald. Hvis Tillad ikke er valgt, udelukkes kontakten fra alle telefonopkaldsaktiviteter, der distribueres i marketingkampagner.\""));
                Donotpostalmail = group.Add(new VocabularyKey("donotpostalmail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillad ikke post").WithDescription("\"Vælg, om kontakten tillader direct mail. Hvis Tillad ikke er valgt, udelukkes kontakten fra brevaktiviteter, der distribueres i marketingkampagner.\""));
                Donotsendmm = group.Add(new VocabularyKey("donotsendmm", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Marketingmatr.").WithDescription("\"Vælg, om kontakten accepterer marketingmateriale som f.eks. brochurer eller kataloger. Kontakter, der har frameldt dette, kan udelukkes fra marketinginitiativer.\""));
                DynaAnsttelselsesforhold = group.Add(new VocabularyKey("dynaAnsttelselsesforhold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ansættelselsesforhold"));
                DynaCoaching = group.Add(new VocabularyKey("dynaCoaching", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Coaching").WithDescription("Coachiing"));
                DynaContactid = group.Add(new VocabularyKey("dynaContactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær Debitor").WithDescription("Entydigt id for Debitor tilknyttet Kontaktperson."));
                DynaContactidnr = group.Add(new VocabularyKey("dynaContactidnr", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("KontaktID").WithDescription("Unique auto number for Contact"));
                DynaCountry = group.Add(new VocabularyKey("dynaCountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lande_ID").WithDescription("Entydigt id for Land tilknyttet Kontaktperson."));
                DynaCoursecustomer = group.Add(new VocabularyKey("dynaCoursecustomer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor"));
                DynaCustomerbeingcreated = group.Add(new VocabularyKey("dynaCustomerbeingcreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DebitorUnderOprettelse"));
                DynaDelingmedlho = group.Add(new VocabularyKey("dynaDelingmedlho", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deling med LHO").WithDescription("Deling med LHO"));
                DynaEmail2 = group.Add(new VocabularyKey("dynaEmail2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("E-mail 2"));
                DynaEmailopdateretdato = group.Add(new VocabularyKey("dynaEmailopdateretdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Email opdateret dato").WithDescription("Dato for hvornår email sidst har været opdateret"));
                DynaGodkendinav = group.Add(new VocabularyKey("dynaGodkendinav", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Godkend i NAV"));
                DynaKonsulent = group.Add(new VocabularyKey("dynaKonsulent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Konsulent"));
                DynaKontaktpersonid = group.Add(new VocabularyKey("dynaKontaktpersonid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontaktperson ID"));
                DynaLedernecontactguid = group.Add(new VocabularyKey("dynaLedernecontactguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lederne Contact GUID"));
                DynaLedernemandag = group.Add(new VocabularyKey("dynaLedernemandag", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("*Lederne Mandag").WithDescription("Field is hidden"));
                DynaLedernemedlem = group.Add(new VocabularyKey("dynaLedernemedlem", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lederne Medlem"));
                DynaLmcKontakt = group.Add(new VocabularyKey("dynaLmcKontakt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LMC kontakt").WithDescription("LMC kontakt"));
                DynaLmcKontaktnote = group.Add(new VocabularyKey("dynaLmcKontaktnote", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LMC kontakt note").WithDescription("LMC kontakt note"));
                DynaLmsadgang = group.Add(new VocabularyKey("dynaLmsadgang", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LMS Adgang").WithDescription("If the Contact should have access to a LMS system and in this case Moodle"));
                DynaMedlemsnummer = group.Add(new VocabularyKey("dynaMedlemsnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Medlemsnummer"));
                DynaNavid = group.Add(new VocabularyKey("dynaNavid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("NavID"));
                DynaNavtemplateid = group.Add(new VocabularyKey("dynaNavtemplateid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor Opsætning").WithDescription("Entydigt id for Nav Skabelon tilknyttet Kontaktperson."));
                DynaNetvaerkKandidat = group.Add(new VocabularyKey("dynaNetvaerkKandidat", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Netværk").WithDescription("Netværks kandidat!"));
                DynaNytfraledelseidagdk = group.Add(new VocabularyKey("dynaNytfraledelseidagdk", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Nyt fra Ledelseidag.dk"));
                DynaOldiddebitor = group.Add(new VocabularyKey("dynaOldiddebitor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OLDID-Debitor"));
                DynaOldiddeltager = group.Add(new VocabularyKey("dynaOldiddeltager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OLDID-Deltager"));
                DynaOldidinstruktr = group.Add(new VocabularyKey("dynaOldidinstruktr", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OLDID-Underviser"));
                DynaOutplacement = group.Add(new VocabularyKey("dynaOutplacement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Outplacement").WithDescription("Outplacement"));
                DynaPersonid = group.Add(new VocabularyKey("dynaPersonid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Person ID"));
                DynaSendnyhedsbrev = group.Add(new VocabularyKey("dynaSendnyhedsbrev", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Send nyhedsbrev").WithDescription("Om der må sendes nydhedsbrev fra globase for kurser og konferencer"));
                DynaTotalamount = group.Add(new VocabularyKey("dynaTotalamount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total omsætning"));
                DynaUk = group.Add(new VocabularyKey("dynaUk", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("UK").WithDescription("UK"));
                DynaUnderviser = group.Add(new VocabularyKey("dynaUnderviser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Underviser"));
                DynaUndervisernote = group.Add(new VocabularyKey("dynaUndervisernote", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Note").WithDescription("\"Note til brug for Netvork,Outplacement,Coaching,VIP og UK\""));
                DynaVip = group.Add(new VocabularyKey("dynaVip", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("VIP").WithDescription("VIP"));
                Educationcode = group.Add(new VocabularyKey("educationcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Uddannelse").WithDescription("Vælg kontaktens højeste uddannelsesniveau til brug ved segmentering og analyser."));
                Emailaddress1 = group.Add(new VocabularyKey("emailaddress1", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("E-mail - primær").WithDescription("Angiv kontaktens primære e-mail-adresse."));
                Emailaddress2 = group.Add(new VocabularyKey("emailaddress2", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("E-mail - sekundær").WithDescription("Angiv kontaktens sekundære e-mail-adresse."));
                Emailaddress3 = group.Add(new VocabularyKey("emailaddress3", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mailadresse 3").WithDescription("Angiv kontaktens alternative e-mail-adresse."));
                Employeeid = group.Add(new VocabularyKey("employeeid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Medarbejder").WithDescription("\"Angiv kontaktens medarbejder-id eller -nummer som reference i ordrer, servicesager eller anden kommunikation med kontaktens organisation.\""));
                Entityimage = group.Add(new VocabularyKey("entityimage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Objektbillede").WithDescription("Viser postens standardbillede."));
                Entityimageid = group.Add(new VocabularyKey("entityimageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for objektbillede").WithDescription("Kun til intern brug."));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("Viser omregningskursen for postens valuta. Valutakursen bruges til at konvertere alle pengefelter i posten fra den lokale valuta til systemets standardvaluta."));
                Externaluseridentifier = group.Add(new VocabularyKey("externaluseridentifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for ekstern bruger").WithDescription("Id for en ekstern bruger."));
                Familystatuscode = group.Add(new VocabularyKey("familystatuscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Civilstand").WithDescription("Vælg kontaktens civilstand som reference i opfølgende telefonopkald og anden kommunikation."));
                Fax = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fax").WithDescription("Angiv kontaktens faxnummer."));
                Firstname = group.Add(new VocabularyKey("firstname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fornavn").WithDescription("\"Angiv kontaktens fornavn for at sikre, at kontakten tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Followemail = group.Add(new VocabularyKey("followemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Følg mailaktivitet").WithDescription("\"Oplysninger om, hvorvidt følgende mailaktivitet som åbninger, visning af vedhæftede filer og klik på links skal tillades for mails, der sendes til kontakten.\""));
                Ftpsiteurl = group.Add(new VocabularyKey("ftpsiteurl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("FTP-sted").WithDescription("\"Angiv URL-adressen til kontaktens FTP-websted, for at brugerne kan få adgang til data og dele dokumenter.\""));
                Fullname = group.Add(new VocabularyKey("fullname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fulde navn").WithDescription("\"Kombinerer og viser kontaktens for- og efternavn, så det fulde navn kan vises i visninger og rapporter.\""));
                Gendercode = group.Add(new VocabularyKey("gendercode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Køn").WithDescription("\"Vælg kontaktens køn for at sikre, at kontakten tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Governmentid = group.Add(new VocabularyKey("governmentid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CPR-nummer").WithDescription("Angiv pasnummeret eller cpr-nummeret på kontakten til brug i dokumenter eller rapporter."));
                Haschildrencode = group.Add(new VocabularyKey("haschildrencode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Har børn").WithDescription("\"Vælg, om kontaktens har børn, som reference i opfølgende telefonopkald og anden kommunikation.\""));
                Home2 = group.Add(new VocabularyKey("home2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon 2 (privat)").WithDescription("Angiv et andet privat telefonnummer til denne kontakt."));
                Isautocreate = group.Add(new VocabularyKey("isautocreate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet automatisk").WithDescription("\"Angiver, om kontakten blev oprettet automatisk, da en e-mail eller en aftale blev opgraderet.\""));
                Isbackofficecustomer = group.Add(new VocabularyKey("isbackofficecustomer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kunde i administrationssystem").WithDescription("\"Vælg, om kontakten findes i et separat regnskabssystem eller et andet system, f.eks. Microsoft Dynamics GP eller en anden ERP-database, til brug i integrationsprocesser.\""));
                Jobtitle = group.Add(new VocabularyKey("jobtitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Stilling").WithDescription("\"Angiv kontaktens stilling for at sikre, at kontakten tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Lastname = group.Add(new VocabularyKey("lastname", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Efternavn").WithDescription("\"Angiv kontaktens efternavn for at sikre, at kontakten tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Lastonholdtime = group.Add(new VocabularyKey("lastonholdtime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste tid i venteposition").WithDescription("Indeholder dato- og klokkeslætsstemplet for den seneste tid for I venteposition."));
                Lastusedincampaign = group.Add(new VocabularyKey("lastusedincampaign", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste dato i kampagnen").WithDescription("\"Viser den dato, hvor kontakten sidst blev inkluderet i en marketingkampagne eller lynkampagne.\""));
                Leadsourcecode = group.Add(new VocabularyKey("leadsourcecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kilde til kundeemne 2").WithDescription("\"Vælg den primære marketingkilde, der dirigerede kontakten til din organisation.\""));
                Managername = group.Add(new VocabularyKey("managername", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Leder").WithDescription("Angiv navnet på kontaktens overordnede til brug ved eskalering af problemer eller anden opfølgende kommunikation med kontakten."));
                Managerphone = group.Add(new VocabularyKey("managerphone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Leders telefon").WithDescription("Angiv telefonnummeret til kontaktpersonens overordnede."));
                Marketingonly = group.Add(new VocabularyKey("marketingonly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kun marketing").WithDescription("\"Angiver, om det kun er til marketingbrug\""));
                Masterid = group.Add(new VocabularyKey("masterid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Person_ID").WithDescription("Entydigt id for hovedkontaktpersonen til fletning."));
                Merged = group.Add(new VocabularyKey("merged", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Flettet").WithDescription("\"Viser, om firmaet er blevet flettet med en hovedkontaktperson.\""));
                Middlename = group.Add(new VocabularyKey("middlename", VocabularyKeyDataType.PersonName, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Mellemnavn").WithDescription("\"Angiv kontaktens mellemnavn eller initialer for at sikre, at kontakten tituleres korrekt.\""));
                Mobilephone = group.Add(new VocabularyKey("mobilephone", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon (primær)").WithDescription("Angiv kontaktpersonens mobilnummer."));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Viser, hvem der sidst har opdateret posten.\""));
                Modifiedbyexternalparty = group.Add(new VocabularyKey("modifiedbyexternalparty", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af (ekstern part)").WithDescription("\"Viser den eksterne part, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("\"Viser dato og klokkeslæt for den seneste opdatering af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics 365.\""));
                MsdynGdproptout = group.Add(new VocabularyKey("msdynGdproptout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("GDPR-framelding").WithDescription("\"Beskriver, om kontakten er frameldt eller ej\""));
                Nickname = group.Add(new VocabularyKey("nickname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kaldenavn").WithDescription("Angiv kontaktpersonens kælenavn."));
                NnNndecisionmakerid = group.Add(new VocabularyKey("nnNndecisionmakerid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("TDC DMID - kun til intern brug").WithDescription("TDC DMID - kun til intern brug"));
                NnUpdateprotected = group.Add(new VocabularyKey("nnUpdateprotected", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskyt mod automatiske opdateringer").WithDescription("Beskyt mod automatiske opdateringer"));
                Numberofchildren = group.Add(new VocabularyKey("numberofchildren", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal børn").WithDescription("\"Angiv antal børn tilhørende kontakten, som reference i opfølgende telefonopkald og anden kommunikation.\""));
                Onholdtime = group.Add(new VocabularyKey("onholdtime", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tid for I venteposition (minutter)").WithDescription("\"Viser, hvor længe posten var i venteposition i minutter.\""));
                Originatingleadid = group.Add(new VocabularyKey("originatingleadid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kilde til kundeemne 1").WithDescription("\"Viser det kundeemne, som kontakten er oprettet ud fra, hvis kontakten er oprettet ved konvertering af et kundeemne i Microsoft Dynamics 365. Dette bruges til at relatere kontakten til dataene i det oprindelige kundeemne til brug ved rapportering og analyser.$contact_originating_lead\""));
                Pager = group.Add(new VocabularyKey("pager", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Personsøger").WithDescription("Angiv kontaktens personsøgernummer."));
                Parentcontactid = group.Add(new VocabularyKey("parentcontactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overordnet kontakt").WithDescription("Entydigt id for den overordnede kontaktperson."));
                Parentcustomerid = group.Add(new VocabularyKey("parentcustomerid", VocabularyKeyDataType.Number, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firmanavn").WithDescription("\"Vælg det overordnede firma eller den overordnede kontakt for kontakten for at give et hurtigt link til flere oplysninger som f.eks. økonomiske oplysninger, aktiviteter og salgsmuligheder.\""));
                Parentcustomeridtype = group.Add(new VocabularyKey("parentcustomeridtype", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overordnet kundetype"));
                Participatesinworkflow = group.Add(new VocabularyKey("participatesinworkflow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager i arbejdsproces").WithDescription("\"Viser, om kontaktpersonen deltager i arbejdsprocesregler.\""));
                Paymenttermscode = group.Add(new VocabularyKey("paymenttermscode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bet.betingelser").WithDescription("\"Vælg betalingsbetingelserne for at angive, hvornår kunden skal betale det samlede beløb.\""));
                Preferredappointmentdaycode = group.Add(new VocabularyKey("preferredappointmentdaycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket dag").WithDescription("Vælg den foretrukne ugedag til serviceaftaler."));
                Preferredappointmenttimecode = group.Add(new VocabularyKey("preferredappointmenttimecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket klokkeslæt").WithDescription("Vælg det foretrukne tidspunkt til serviceaftaler."));
                Preferredcontactmethodcode = group.Add(new VocabularyKey("preferredcontactmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken kontaktmetode").WithDescription("Vælg den foretrukne kontaktmetode."));
                Preferredequipmentid = group.Add(new VocabularyKey("preferredequipmentid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukket udstyr").WithDescription("\"Vælg kontaktens foretrukne servicelokale eller -udstyr for at sikre, at servicer planlægges korrekt i forhold til kunden.$equipment_contacts\""));
                Preferredserviceid = group.Add(new VocabularyKey("preferredserviceid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken service").WithDescription("\"Vælg kontaktens foretrukne service for at sikre, at servicer planlægges korrekt i forhold til kunden.$service_contacts\""));
                Preferredsystemuserid = group.Add(new VocabularyKey("preferredsystemuserid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Foretrukken bruger").WithDescription("\"Vælg den regelmæssige eller foretrukne kundeservicemedarbejder som reference, når du planlægger serviceaktiviteter for kontakten.\""));
                Processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Proces").WithDescription("Viser processens id."));
                Salutation = group.Add(new VocabularyKey("salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Titel").WithDescription("\"Angiv kontaktens titulering for at sikre, at kontakten tituleres korrekt i salgsopkald, e-mails og marketingkampagner.\""));
                Shippingmethodcode = group.Add(new VocabularyKey("shippingmethodcode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Forsendelsesmåde").WithDescription("\"Vælg en forsendelsesmetode til leverancer, der sendes til denne adresse.\""));
                Slaid = group.Add(new VocabularyKey("slaid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SLA").WithDescription("\"Vælg den serviceaftale (SLA), du vil anvende på kontaktposten.\""));
                Slainvokedid = group.Add(new VocabularyKey("slainvokedid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidst anvendte SLA").WithDescription("\"Sidste SLA, der blev anvendt til denne sag. Dette felt er kun beregnet til intern brug.\""));
                Spousesname = group.Add(new VocabularyKey("spousesname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn på ægtefælle/partner").WithDescription("\"Angiv navnet på kontaktens ægtefælle eller partner som reference ved opkald, arrangementer eller anden kommunikation med kontakten.\""));
                Stageid = group.Add(new VocabularyKey("stageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Procestrin").WithDescription("Viser fasens id."));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("\"Viser, om kontakten er aktiv eller inaktiv. Inaktive kontakter er skrivebeskyttede og kan ikke redigeres, medmindre de genaktiveres.\""));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Vælg kontaktens status."));
                Subscriptionid = group.Add(new VocabularyKey("subscriptionid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Abonnement").WithDescription("Kun til intern brug."));
                Suffix = group.Add(new VocabularyKey("suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Suffiks").WithDescription("\"Angiv det suffiks, der bruges i kontaktens navn, f.eks. Jr. eller Sr. for at sikre, at kontakten tituleres korrekt i salgsopkald, e-mail og marketingkampagner.\""));
                Telephone1 = group.Add(new VocabularyKey("telephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon (arbejde)").WithDescription("Angiv hovedtelefonnummeret til denne kontakt."));
                Telephone2 = group.Add(new VocabularyKey("telephone2", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon (Sekundær)").WithDescription("Angiv et andet telefonnummer til denne kontakt."));
                Telephone3 = group.Add(new VocabularyKey("telephone3", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Telefon 3").WithDescription("Angiv et tredje telefonnummer til denne kontakt."));
                Territorycode = group.Add(new VocabularyKey("territorycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Distrikt").WithDescription("Vælg et område eller distrikt for kontakten til brug ved segmentering og analyser."));
                Timespentbymeonemailandmeetings = group.Add(new VocabularyKey("timespentbymeonemailandmeetings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tidsforbrug for mig").WithDescription("Samlet tid jeg har brugt på mails (læsning og skrivning) samt møder i relation til kontakten."));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Vælg den lokale valuta til posten for at sikre, at budgetter rapporteres i den korrekte valuta.\""));
                Traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gennemløbet sti").WithDescription("Kun til intern brug."));
                Websiteurl = group.Add(new VocabularyKey("websiteurl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Websted").WithDescription("Angiv kontaktens forretningswebsted eller personlige websted eller URL-adresse til blog."));
            });
        }

        public VocabularyKey Accountid { get; private set; }
        public VocabularyKey Accountrolecode { get; private set; }
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
        public VocabularyKey Address3Addresstypecode { get; private set; }
        public VocabularyKey Address3City { get; private set; }
        public VocabularyKey Address3Composite { get; private set; }
        public VocabularyKey Address3Country { get; private set; }
        public VocabularyKey Address3County { get; private set; }
        public VocabularyKey Address3Fax { get; private set; }
        public VocabularyKey Address3Freighttermscode { get; private set; }
        public VocabularyKey Address3Latitude { get; private set; }
        public VocabularyKey Address3Line1 { get; private set; }
        public VocabularyKey Address3Line2 { get; private set; }
        public VocabularyKey Address3Line3 { get; private set; }
        public VocabularyKey Address3Longitude { get; private set; }
        public VocabularyKey Address3Name { get; private set; }
        public VocabularyKey Address3Postalcode { get; private set; }
        public VocabularyKey Address3Postofficebox { get; private set; }
        public VocabularyKey Address3Primarycontactname { get; private set; }
        public VocabularyKey Address3Shippingmethodcode { get; private set; }
        public VocabularyKey Address3Stateorprovince { get; private set; }
        public VocabularyKey Address3Telephone1 { get; private set; }
        public VocabularyKey Address3Telephone2 { get; private set; }
        public VocabularyKey Address3Telephone3 { get; private set; }
        public VocabularyKey Address3Upszone { get; private set; }
        public VocabularyKey Aging30 { get; private set; }
        public VocabularyKey Aging30Base { get; private set; }
        public VocabularyKey Aging60 { get; private set; }
        public VocabularyKey Aging60Base { get; private set; }
        public VocabularyKey Aging90 { get; private set; }
        public VocabularyKey Aging90Base { get; private set; }
        public VocabularyKey Anniversary { get; private set; }
        public VocabularyKey Annualincome { get; private set; }
        public VocabularyKey AnnualincomeBase { get; private set; }
        public VocabularyKey Assistantname { get; private set; }
        public VocabularyKey Assistantphone { get; private set; }
        public VocabularyKey Birthdate { get; private set; }
        public VocabularyKey Business2 { get; private set; }
        public VocabularyKey Callback { get; private set; }
        public VocabularyKey Childrensnames { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Contactid { get; private set; }
        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdbyexternalparty { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey Creditlimit { get; private set; }
        public VocabularyKey CreditlimitBase { get; private set; }
        public VocabularyKey Creditonhold { get; private set; }
        public VocabularyKey Customersizecode { get; private set; }
        public VocabularyKey Customertypecode { get; private set; }
        public VocabularyKey Defaultpricelevelid { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Donotbulkemail { get; private set; }
        public VocabularyKey Donotbulkpostalmail { get; private set; }
        public VocabularyKey Donotemail { get; private set; }
        public VocabularyKey Donotfax { get; private set; }
        public VocabularyKey Donotphone { get; private set; }
        public VocabularyKey Donotpostalmail { get; private set; }
        public VocabularyKey Donotsendmm { get; private set; }
        public VocabularyKey DynaAnsttelselsesforhold { get; private set; }
        public VocabularyKey DynaCoaching { get; private set; }
        public VocabularyKey DynaContactid { get; private set; }
        public VocabularyKey DynaContactidnr { get; private set; }
        public VocabularyKey DynaCountry { get; private set; }
        public VocabularyKey DynaCoursecustomer { get; private set; }
        public VocabularyKey DynaCustomerbeingcreated { get; private set; }
        public VocabularyKey DynaDelingmedlho { get; private set; }
        public VocabularyKey DynaEmail2 { get; private set; }
        public VocabularyKey DynaEmailopdateretdato { get; private set; }
        public VocabularyKey DynaGodkendinav { get; private set; }
        public VocabularyKey DynaKonsulent { get; private set; }
        public VocabularyKey DynaKontaktpersonid { get; private set; }
        public VocabularyKey DynaLedernecontactguid { get; private set; }
        public VocabularyKey DynaLedernemandag { get; private set; }
        public VocabularyKey DynaLedernemedlem { get; private set; }
        public VocabularyKey DynaLmcKontakt { get; private set; }
        public VocabularyKey DynaLmcKontaktnote { get; private set; }
        public VocabularyKey DynaLmsadgang { get; private set; }
        public VocabularyKey DynaMedlemsnummer { get; private set; }
        public VocabularyKey DynaNavid { get; private set; }
        public VocabularyKey DynaNavtemplateid { get; private set; }
        public VocabularyKey DynaNetvaerkKandidat { get; private set; }
        public VocabularyKey DynaNytfraledelseidagdk { get; private set; }
        public VocabularyKey DynaOldiddebitor { get; private set; }
        public VocabularyKey DynaOldiddeltager { get; private set; }
        public VocabularyKey DynaOldidinstruktr { get; private set; }
        public VocabularyKey DynaOutplacement { get; private set; }
        public VocabularyKey DynaPersonid { get; private set; }
        public VocabularyKey DynaSendnyhedsbrev { get; private set; }
        public VocabularyKey DynaTotalamount { get; private set; }
        public VocabularyKey DynaUk { get; private set; }
        public VocabularyKey DynaUnderviser { get; private set; }
        public VocabularyKey DynaUndervisernote { get; private set; }
        public VocabularyKey DynaVip { get; private set; }
        public VocabularyKey Educationcode { get; private set; }
        public VocabularyKey Emailaddress1 { get; private set; }
        public VocabularyKey Emailaddress2 { get; private set; }
        public VocabularyKey Emailaddress3 { get; private set; }
        public VocabularyKey Employeeid { get; private set; }
        public VocabularyKey Entityimage { get; private set; }
        public VocabularyKey Entityimageid { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Externaluseridentifier { get; private set; }
        public VocabularyKey Familystatuscode { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Firstname { get; private set; }
        public VocabularyKey Followemail { get; private set; }
        public VocabularyKey Ftpsiteurl { get; private set; }
        public VocabularyKey Fullname { get; private set; }
        public VocabularyKey Gendercode { get; private set; }
        public VocabularyKey Governmentid { get; private set; }
        public VocabularyKey Haschildrencode { get; private set; }
        public VocabularyKey Home2 { get; private set; }
        public VocabularyKey Isautocreate { get; private set; }
        public VocabularyKey Isbackofficecustomer { get; private set; }
        public VocabularyKey Jobtitle { get; private set; }
        public VocabularyKey Lastname { get; private set; }
        public VocabularyKey Lastonholdtime { get; private set; }
        public VocabularyKey Lastusedincampaign { get; private set; }
        public VocabularyKey Leadsourcecode { get; private set; }
        public VocabularyKey Managername { get; private set; }
        public VocabularyKey Managerphone { get; private set; }
        public VocabularyKey Marketingonly { get; private set; }
        public VocabularyKey Masterid { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey Middlename { get; private set; }
        public VocabularyKey Mobilephone { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedbyexternalparty { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey MsdynGdproptout { get; private set; }
        public VocabularyKey Nickname { get; private set; }
        public VocabularyKey NnNndecisionmakerid { get; private set; }
        public VocabularyKey NnUpdateprotected { get; private set; }
        public VocabularyKey Numberofchildren { get; private set; }
        public VocabularyKey Onholdtime { get; private set; }
        public VocabularyKey Originatingleadid { get; private set; }
        public VocabularyKey Pager { get; private set; }
        public VocabularyKey Parentcontactid { get; private set; }
        public VocabularyKey Parentcustomerid { get; private set; }
        public VocabularyKey Parentcustomeridtype { get; private set; }
        public VocabularyKey Participatesinworkflow { get; private set; }
        public VocabularyKey Paymenttermscode { get; private set; }
        public VocabularyKey Preferredappointmentdaycode { get; private set; }
        public VocabularyKey Preferredappointmenttimecode { get; private set; }
        public VocabularyKey Preferredcontactmethodcode { get; private set; }
        public VocabularyKey Preferredequipmentid { get; private set; }
        public VocabularyKey Preferredserviceid { get; private set; }
        public VocabularyKey Preferredsystemuserid { get; private set; }
        public VocabularyKey Processid { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey Shippingmethodcode { get; private set; }
        public VocabularyKey Slaid { get; private set; }
        public VocabularyKey Slainvokedid { get; private set; }
        public VocabularyKey Spousesname { get; private set; }
        public VocabularyKey Stageid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Subscriptionid { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Territorycode { get; private set; }
        public VocabularyKey Timespentbymeonemailandmeetings { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
        public VocabularyKey Traversedpath { get; private set; }
        public VocabularyKey Websiteurl { get; private set; }
    }
}
