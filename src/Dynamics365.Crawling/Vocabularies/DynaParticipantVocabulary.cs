using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DynaParticipantVocabulary : SimpleVocabulary
    {
        public DynaParticipantVocabulary()
        {
            VocabularyName = "Dynamics365 DynaParticipant"; // TODO: Set value
            KeyPrefix = "dynamics365.dyna_participant"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Deltager"; // TODO: Check value

            AddGroup("Deltager Details", group =>
            {
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet").WithDescription("Dato og klokkeslæt for oprettelsen af posten."));
                DynaAccountid = group.Add(new VocabularyKey("dynaAccountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturer til (Firma)").WithDescription("Entydigt id for Firma tilknyttet Deltager."));
                DynaAkasse = group.Add(new VocabularyKey("dynaAkasse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("A-Kasse"));
                DynaAnsttelsesforhold = group.Add(new VocabularyKey("dynaAnsttelsesforhold", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ansættelsesforhold"));
                DynaAr237sendtmanuelt = group.Add(new VocabularyKey("dynaAr237sendtmanuelt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("AR237 u. underskrift"));
                DynaBekraeftelsesendt = group.Add(new VocabularyKey("dynaBekraeftelsesendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bekræftelse sendt"));
                DynaBekraeftelsesendtdato = group.Add(new VocabularyKey("dynaBekraeftelsesendtdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bekræftelse sendt dato"));
                DynaColleaguename = group.Add(new VocabularyKey("dynaColleaguename", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Angiv Kollega's navn"));
                DynaContactid = group.Add(new VocabularyKey("dynaContactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager").WithDescription("Entydigt id for Kontaktperson tilknyttet Participant."));
                DynaContactinvoiceid = group.Add(new VocabularyKey("dynaContactinvoiceid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturer til (Kontaktperson)").WithDescription("Entydigt id for Kontaktperson tilknyttet Deltager."));
                DynaCourseattention = group.Add(new VocabularyKey("dynaCourseattention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktura Attention"));
                DynaCoursecustomerid = group.Add(new VocabularyKey("dynaCoursecustomerid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor").WithDescription("Entydigt id for Debitor tilknyttet Deltager."));
                DynaCourseid = group.Add(new VocabularyKey("dynaCourseid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus").WithDescription("Entydigt id for Course tilknyttet Participant."));
                DynaCoursepaid = group.Add(new VocabularyKey("dynaCoursepaid", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager Pris"));
                DynaCoursepaidBase = group.Add(new VocabularyKey("dynaCoursepaidBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus betalt (grund)").WithDescription("Værdi af Kursus betalt i grundvaluta."));
                DynaCourseprice = group.Add(new VocabularyKey("dynaCourseprice", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standard Kursus Pris"));
                DynaCoursepriceBase = group.Add(new VocabularyKey("dynaCoursepriceBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Pris (grund)").WithDescription("Værdi af Kursus Pris i grundvaluta."));
                DynaCreatedfrom = group.Add(new VocabularyKey("dynaCreatedfrom", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet Fra"));
                DynaCreateinvoicelines = group.Add(new VocabularyKey("dynaCreateinvoicelines", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Opret FakturaLinjer"));
                DynaCvrse = group.Add(new VocabularyKey("dynaCvrse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR/SE"));
                DynaDeltagerstatusdato = group.Add(new VocabularyKey("dynaDeltagerstatusdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltagerstatus dato"));
                DynaDescription = group.Add(new VocabularyKey("dynaDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskrivelse"));
                DynaDiscountamount = group.Add(new VocabularyKey("dynaDiscountamount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Discount Beløb"));
                DynaDiscountamountBase = group.Add(new VocabularyKey("dynaDiscountamountBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Discount beløb (grund)").WithDescription("Værdi af Discount beløb i grundvaluta."));
                DynaDiscountrate = group.Add(new VocabularyKey("dynaDiscountrate", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Discount Rate"));
                DynaDiscounttype = group.Add(new VocabularyKey("dynaDiscounttype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Discount Type"));
                DynaEanno = group.Add(new VocabularyKey("dynaEanno", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("EAN No"));
                DynaEksternid = group.Add(new VocabularyKey("dynaEksternid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ekstern ID"));
                DynaEmailadresse = group.Add(new VocabularyKey("dynaEmailadresse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Email adresse"));
                DynaEvaluationfullfilled = group.Add(new VocabularyKey("dynaEvaluationfullfilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering udfyldt"));
                DynaEvaluationsent = group.Add(new VocabularyKey("dynaEvaluationsent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering afsendt"));
                DynaEvaluationtype = group.Add(new VocabularyKey("dynaEvaluationtype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evalueringstype"));
                DynaEvalueringlink = group.Add(new VocabularyKey("dynaEvalueringlink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering Link"));
                DynaFakturastatus = group.Add(new VocabularyKey("dynaFakturastatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktura Status"));
                DynaFaktureringsadresseattention = group.Add(new VocabularyKey("dynaFaktureringsadresseattention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse Attention"));
                DynaFaktureringsadresseby = group.Add(new VocabularyKey("dynaFaktureringsadresseby", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse By"));
                DynaFaktureringsadressegade1 = group.Add(new VocabularyKey("dynaFaktureringsadressegade1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse Gade 1"));
                DynaFaktureringsadressegade2 = group.Add(new VocabularyKey("dynaFaktureringsadressegade2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse Gade 2"));
                DynaFaktureringsadresseland = group.Add(new VocabularyKey("dynaFaktureringsadresseland", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse Land"));
                DynaFaktureringsadressenavn = group.Add(new VocabularyKey("dynaFaktureringsadressenavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse Navn"));
                DynaFaktureringsadressepostnummer = group.Add(new VocabularyKey("dynaFaktureringsadressepostnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsadresse Postnummer"));
                DynaFaktureringsemail = group.Add(new VocabularyKey("dynaFaktureringsemail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturerings Email").WithDescription("Den Email som skal benyttes til at sende pdf faktura eller kreditnota til debitor eller deltager."));
                DynaFax = group.Add(new VocabularyKey("dynaFax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fax"));
                DynaFirmanavn = group.Add(new VocabularyKey("dynaFirmanavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firmanavn"));
                DynaIndirectparticipation = group.Add(new VocabularyKey("dynaIndirectparticipation", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Indirekte deltagelse").WithDescription("Entydigt id for Kursus tilknyttet Kursus Deltager."));
                DynaInvoicereference = group.Add(new VocabularyKey("dynaInvoicereference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktura Reference"));
                DynaInvoicetoparticipant = group.Add(new VocabularyKey("dynaInvoicetoparticipant", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturer Deltager"));
                DynaKcslger = group.Add(new VocabularyKey("dynaKcslger", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("KC Sælger"));
                DynaKursusbevisafsendt = group.Add(new VocabularyKey("dynaKursusbevisafsendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursusbevis afsendt"));
                DynaKursusbevissendtdato = group.Add(new VocabularyKey("dynaKursusbevissendtdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursusbevis sendt dato"));
                DynaKursusmodulid = group.Add(new VocabularyKey("dynaKursusmodulid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursusmodul").WithDescription("Entydigt id for Kursus tilknyttet Kursus Deltager."));
                DynaKursusrabatkode = group.Add(new VocabularyKey("dynaKursusrabatkode", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus rabatkode").WithDescription("Kursus rabatkode"));
                DynaLevattention = group.Add(new VocabularyKey("dynaLevattention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Levering Attention"));
                DynaLevbrugandenleveringsadresse = group.Add(new VocabularyKey("dynaLevbrugandenleveringsadresse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev brug Anden leveringsadresse"));
                DynaLevby = group.Add(new VocabularyKey("dynaLevby", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev By"));
                DynaLevfirmanavn = group.Add(new VocabularyKey("dynaLevfirmanavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev Firmanavn").WithDescription("Firmanavn for anden levering adresse"));
                DynaLevgade = group.Add(new VocabularyKey("dynaLevgade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev Gade 1"));
                DynaLevgade2 = group.Add(new VocabularyKey("dynaLevgade2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev Gade 2"));
                DynaLevland = group.Add(new VocabularyKey("dynaLevland", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev Land"));
                DynaLevpostnummer = group.Add(new VocabularyKey("dynaLevpostnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lev Postnummer"));
                DynaMaster = group.Add(new VocabularyKey("dynaMaster", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Master"));
                DynaMasterparticipantid = group.Add(new VocabularyKey("dynaMasterparticipantid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Master Deltager").WithDescription("Entydigt id for Kursus Deltager tilknyttet Kursus Deltager."));
                DynaMember = group.Add(new VocabularyKey("dynaMember", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Medlem"));
                DynaName = group.Add(new VocabularyKey("dynaName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn").WithDescription("Navnet på det brugerdefinerede objekt."));
                DynaNavid = group.Add(new VocabularyKey("dynaNavid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("NAV ID"));
                DynaOldid = group.Add(new VocabularyKey("dynaOldid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OLDID"));
                DynaOmstillingsfonden = group.Add(new VocabularyKey("dynaOmstillingsfonden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Omstillingsfonden"));
                DynaPaamindelsesendt = group.Add(new VocabularyKey("dynaPaamindelsesendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Indkaldelse sendt"));
                DynaPaamindelsesendtdato = group.Add(new VocabularyKey("dynaPaamindelsesendtdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Indkaldelse sendt dato"));
                DynaPaidinvoice = group.Add(new VocabularyKey("dynaPaidinvoice", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Betalt Faktura"));
                DynaParticipantautoid = group.Add(new VocabularyKey("dynaParticipantautoid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager-ID"));
                DynaParticipantguid = group.Add(new VocabularyKey("dynaParticipantguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager Guid"));
                DynaParticipantid = group.Add(new VocabularyKey("dynaParticipantid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Participant").WithDescription("Entydigt id for objektforekomster"));
                DynaParticipantremarks = group.Add(new VocabularyKey("dynaParticipantremarks", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltagers bemærkninger"));
                DynaParticipated = group.Add(new VocabularyKey("dynaParticipated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltog"));
                DynaParticipatingstatus = group.Add(new VocabularyKey("dynaParticipatingstatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltagelses Status"));
                DynaPrimrtelefonnummer = group.Add(new VocabularyKey("dynaPrimrtelefonnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær telefonnummer"));
                DynaPromotioncodeid = group.Add(new VocabularyKey("dynaPromotioncodeid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Promotion Kode").WithDescription("Entydigt id for Promotion Code tilknyttet Participant."));
                DynaRabatkode = group.Add(new VocabularyKey("dynaRabatkode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Rabatkode - BRUGES IKKE").WithDescription("\"Intern rabatkode, til info for KC\""));
                DynaRammeaftalerabat = group.Add(new VocabularyKey("dynaRammeaftalerabat", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Rammeaftale rabat givet"));
                DynaReason = group.Add(new VocabularyKey("dynaReason", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsag til afbud"));
                DynaReference = group.Add(new VocabularyKey("dynaReference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Reference"));
                DynaSalgskanaler = group.Add(new VocabularyKey("dynaSalgskanaler", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salgs kanaler"));
                DynaSendkopiafbekrftelse = group.Add(new VocabularyKey("dynaSendkopiafbekrftelse", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Send kopi af bekræftelse"));
                DynaSendkopiafindkaldelse = group.Add(new VocabularyKey("dynaSendkopiafindkaldelse", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Send kopi af indkaldelse"));
                DynaSuppKompSendtmanuelt = group.Add(new VocabularyKey("dynaSuppKompSendtmanuelt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("AR237 m. underskrift").WithDescription("Supplerende. materiale til kompetencegivende uddannelse sendt manuelt. Forhindre email i arbejdsprocess at blive afsendt."));
                DynaSupplerendeinfomodtaget = group.Add(new VocabularyKey("dynaSupplerendeinfomodtaget", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bevis/CV modtaget"));
                DynaSvu = group.Add(new VocabularyKey("dynaSvu", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SVU"));
                DynaSvudato = group.Add(new VocabularyKey("dynaSvudato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SVU dato").WithDescription("Dato for hvornår der der er sendt noget ud fra status"));
                DynaSvustatus = group.Add(new VocabularyKey("dynaSvustatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SVU Status"));
                DynaTotalamount = group.Add(new VocabularyKey("dynaTotalamount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standard Total Beløb"));
                DynaTotalamountBase = group.Add(new VocabularyKey("dynaTotalamountBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Amount (grund)").WithDescription("Værdi af Total Amount i grundvaluta."));
                DynaTotalamountpaid = group.Add(new VocabularyKey("dynaTotalamountpaid", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Pris"));
                DynaTotalamountpaidBase = group.Add(new VocabularyKey("dynaTotalamountpaidBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total betalt (grund)").WithDescription("Værdi af Total betalt i grundvaluta."));
                DynaTotalproduct = group.Add(new VocabularyKey("dynaTotalproduct", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Standard Tillægsprodukter Pris"));
                DynaTotalproductBase = group.Add(new VocabularyKey("dynaTotalproductBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Samlet Produkter (grund)").WithDescription("Værdi af Samlet Produkter i grundvaluta."));
                DynaTotalproductpaid = group.Add(new VocabularyKey("dynaTotalproductpaid", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillægsprodukter Pris"));
                DynaTotalproductpaidBase = group.Add(new VocabularyKey("dynaTotalproductpaidBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tillægsprodukter betalt (grund)").WithDescription("Værdi af Tillægsprodukter betalt i grundvaluta."));
                DynaUnsubscribed = group.Add(new VocabularyKey("dynaUnsubscribed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Afmeldt"));
                DynaUnsubscribeddate = group.Add(new VocabularyKey("dynaUnsubscribeddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Afmeldt Dato"));
                DynaVirksomhedsadresseattention = group.Add(new VocabularyKey("dynaVirksomhedsadresseattention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse Attention"));
                DynaVirksomhedsadresseby = group.Add(new VocabularyKey("dynaVirksomhedsadresseby", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse By"));
                DynaVirksomhedsadressegade1 = group.Add(new VocabularyKey("dynaVirksomhedsadressegade1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse Gade 1"));
                DynaVirksomhedsadressegade2 = group.Add(new VocabularyKey("dynaVirksomhedsadressegade2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse Gade 2"));
                DynaVirksomhedsadresseland = group.Add(new VocabularyKey("dynaVirksomhedsadresseland", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse Land"));
                DynaVirksomhedsadressenavn = group.Add(new VocabularyKey("dynaVirksomhedsadressenavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse Navn"));
                DynaVirksomhedsadressepostnummer = group.Add(new VocabularyKey("dynaVirksomhedsadressepostnummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhedsadresse Postnummer"));
                DynaWebsted = group.Add(new VocabularyKey("dynaWebsted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Websted"));
                DynaWebtilmeldingdata = group.Add(new VocabularyKey("dynaWebtilmeldingdata", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Web-tilmelding data"));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("\"Valutakurs for den valuta, der er tilknyttet objektet, i forhold til grundvalutaen.\""));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("Dato og klokkeslæt for ændring af posten."));
                Organizationid = group.Add(new VocabularyKey("organizationid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Organisations-id").WithDescription("Entydigt id for organisationen"));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("Status for Participant"));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltagelses status").WithDescription("Årsag til statussen for Participant"));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Entydigt id for den valuta, der er tilknyttet objektet.\""));
            });
        }

        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey DynaAccountid { get; private set; }
        public VocabularyKey DynaAkasse { get; private set; }
        public VocabularyKey DynaAnsttelsesforhold { get; private set; }
        public VocabularyKey DynaAr237sendtmanuelt { get; private set; }
        public VocabularyKey DynaBekraeftelsesendt { get; private set; }
        public VocabularyKey DynaBekraeftelsesendtdato { get; private set; }
        public VocabularyKey DynaColleaguename { get; private set; }
        public VocabularyKey DynaContactid { get; private set; }
        public VocabularyKey DynaContactinvoiceid { get; private set; }
        public VocabularyKey DynaCourseattention { get; private set; }
        public VocabularyKey DynaCoursecustomerid { get; private set; }
        public VocabularyKey DynaCourseid { get; private set; }
        public VocabularyKey DynaCoursepaid { get; private set; }
        public VocabularyKey DynaCoursepaidBase { get; private set; }
        public VocabularyKey DynaCourseprice { get; private set; }
        public VocabularyKey DynaCoursepriceBase { get; private set; }
        public VocabularyKey DynaCreatedfrom { get; private set; }
        public VocabularyKey DynaCreateinvoicelines { get; private set; }
        public VocabularyKey DynaCvrse { get; private set; }
        public VocabularyKey DynaDeltagerstatusdato { get; private set; }
        public VocabularyKey DynaDescription { get; private set; }
        public VocabularyKey DynaDiscountamount { get; private set; }
        public VocabularyKey DynaDiscountamountBase { get; private set; }
        public VocabularyKey DynaDiscountrate { get; private set; }
        public VocabularyKey DynaDiscounttype { get; private set; }
        public VocabularyKey DynaEanno { get; private set; }
        public VocabularyKey DynaEksternid { get; private set; }
        public VocabularyKey DynaEmailadresse { get; private set; }
        public VocabularyKey DynaEvaluationfullfilled { get; private set; }
        public VocabularyKey DynaEvaluationsent { get; private set; }
        public VocabularyKey DynaEvaluationtype { get; private set; }
        public VocabularyKey DynaEvalueringlink { get; private set; }
        public VocabularyKey DynaFakturastatus { get; private set; }
        public VocabularyKey DynaFaktureringsadresseattention { get; private set; }
        public VocabularyKey DynaFaktureringsadresseby { get; private set; }
        public VocabularyKey DynaFaktureringsadressegade1 { get; private set; }
        public VocabularyKey DynaFaktureringsadressegade2 { get; private set; }
        public VocabularyKey DynaFaktureringsadresseland { get; private set; }
        public VocabularyKey DynaFaktureringsadressenavn { get; private set; }
        public VocabularyKey DynaFaktureringsadressepostnummer { get; private set; }
        public VocabularyKey DynaFaktureringsemail { get; private set; }
        public VocabularyKey DynaFax { get; private set; }
        public VocabularyKey DynaFirmanavn { get; private set; }
        public VocabularyKey DynaIndirectparticipation { get; private set; }
        public VocabularyKey DynaInvoicereference { get; private set; }
        public VocabularyKey DynaInvoicetoparticipant { get; private set; }
        public VocabularyKey DynaKcslger { get; private set; }
        public VocabularyKey DynaKursusbevisafsendt { get; private set; }
        public VocabularyKey DynaKursusbevissendtdato { get; private set; }
        public VocabularyKey DynaKursusmodulid { get; private set; }
        public VocabularyKey DynaKursusrabatkode { get; private set; }
        public VocabularyKey DynaLevattention { get; private set; }
        public VocabularyKey DynaLevbrugandenleveringsadresse { get; private set; }
        public VocabularyKey DynaLevby { get; private set; }
        public VocabularyKey DynaLevfirmanavn { get; private set; }
        public VocabularyKey DynaLevgade { get; private set; }
        public VocabularyKey DynaLevgade2 { get; private set; }
        public VocabularyKey DynaLevland { get; private set; }
        public VocabularyKey DynaLevpostnummer { get; private set; }
        public VocabularyKey DynaMaster { get; private set; }
        public VocabularyKey DynaMasterparticipantid { get; private set; }
        public VocabularyKey DynaMember { get; private set; }
        public VocabularyKey DynaName { get; private set; }
        public VocabularyKey DynaNavid { get; private set; }
        public VocabularyKey DynaOldid { get; private set; }
        public VocabularyKey DynaOmstillingsfonden { get; private set; }
        public VocabularyKey DynaPaamindelsesendt { get; private set; }
        public VocabularyKey DynaPaamindelsesendtdato { get; private set; }
        public VocabularyKey DynaPaidinvoice { get; private set; }
        public VocabularyKey DynaParticipantautoid { get; private set; }
        public VocabularyKey DynaParticipantguid { get; private set; }
        public VocabularyKey DynaParticipantid { get; private set; }
        public VocabularyKey DynaParticipantremarks { get; private set; }
        public VocabularyKey DynaParticipated { get; private set; }
        public VocabularyKey DynaParticipatingstatus { get; private set; }
        public VocabularyKey DynaPrimrtelefonnummer { get; private set; }
        public VocabularyKey DynaPromotioncodeid { get; private set; }
        public VocabularyKey DynaRabatkode { get; private set; }
        public VocabularyKey DynaRammeaftalerabat { get; private set; }
        public VocabularyKey DynaReason { get; private set; }
        public VocabularyKey DynaReference { get; private set; }
        public VocabularyKey DynaSalgskanaler { get; private set; }
        public VocabularyKey DynaSendkopiafbekrftelse { get; private set; }
        public VocabularyKey DynaSendkopiafindkaldelse { get; private set; }
        public VocabularyKey DynaSuppKompSendtmanuelt { get; private set; }
        public VocabularyKey DynaSupplerendeinfomodtaget { get; private set; }
        public VocabularyKey DynaSvu { get; private set; }
        public VocabularyKey DynaSvudato { get; private set; }
        public VocabularyKey DynaSvustatus { get; private set; }
        public VocabularyKey DynaTotalamount { get; private set; }
        public VocabularyKey DynaTotalamountBase { get; private set; }
        public VocabularyKey DynaTotalamountpaid { get; private set; }
        public VocabularyKey DynaTotalamountpaidBase { get; private set; }
        public VocabularyKey DynaTotalproduct { get; private set; }
        public VocabularyKey DynaTotalproductBase { get; private set; }
        public VocabularyKey DynaTotalproductpaid { get; private set; }
        public VocabularyKey DynaTotalproductpaidBase { get; private set; }
        public VocabularyKey DynaUnsubscribed { get; private set; }
        public VocabularyKey DynaUnsubscribeddate { get; private set; }
        public VocabularyKey DynaVirksomhedsadresseattention { get; private set; }
        public VocabularyKey DynaVirksomhedsadresseby { get; private set; }
        public VocabularyKey DynaVirksomhedsadressegade1 { get; private set; }
        public VocabularyKey DynaVirksomhedsadressegade2 { get; private set; }
        public VocabularyKey DynaVirksomhedsadresseland { get; private set; }
        public VocabularyKey DynaVirksomhedsadressenavn { get; private set; }
        public VocabularyKey DynaVirksomhedsadressepostnummer { get; private set; }
        public VocabularyKey DynaWebsted { get; private set; }
        public VocabularyKey DynaWebtilmeldingdata { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Organizationid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
    }
}
