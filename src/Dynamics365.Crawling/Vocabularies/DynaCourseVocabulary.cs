using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DynaCourseVocabulary : SimpleVocabulary
    {
        public DynaCourseVocabulary()
        {
            VocabularyName = "Dynamics365 DynaCourse"; // TODO: Set value
            KeyPrefix = "dynamics365.dyna_course"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Kursus"; // TODO: Check value

            AddGroup("Kursus Details", group =>
            {
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet").WithDescription("Dato og klokkeslæt for oprettelsen af posten."));
                DynaAccountid = group.Add(new VocabularyKey("dynaAccountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturer til Firma"));
                DynaAddinvoicedate = group.Add(new VocabularyKey("dynaAddinvoicedate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Angiv Fakturerings Dato"));
                DynaAftaltpris = group.Add(new VocabularyKey("dynaAftaltpris", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aftalt pris").WithDescription("Beløb som benyttes i forbindelse med VIP kurser hvor der skal faktureres direkte. Det er for at vise et retvisende beløb når et salgsmulighed splittes op"));
                DynaBemrkninger = group.Add(new VocabularyKey("dynaBemrkninger", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Bemærkninger"));
                DynaBreakevennumber = group.Add(new VocabularyKey("dynaBreakevennumber", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Break even antal").WithDescription("\"Hvor mange kursister skal deltage, for at kurset er rentabelt\""));
                DynaCity = group.Add(new VocabularyKey("dynaCity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokation By"));
                DynaContactid = group.Add(new VocabularyKey("dynaContactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontaktperson").WithDescription("Kontaktperson hos virksomheden"));
                DynaCoursecustomerid = group.Add(new VocabularyKey("dynaCoursecustomerid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor"));
                DynaCoursedate = group.Add(new VocabularyKey("dynaCoursedate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Start Dato"));
                DynaCourseevent = group.Add(new VocabularyKey("dynaCourseevent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Publicering"));
                DynaCourseguid = group.Add(new VocabularyKey("dynaCourseguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Guid"));
                DynaCourseid = group.Add(new VocabularyKey("dynaCourseid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus_ID").WithDescription("Entydigt id for objektforekomster"));
                DynaCourseitemid = group.Add(new VocabularyKey("dynaCourseitemid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Vare").WithDescription("Entydigt id for Kursus Vare tilknyttet Kursus."));
                DynaCourseresponsibleid = group.Add(new VocabularyKey("dynaCourseresponsibleid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ansvarlig").WithDescription("Entydigt id for Bruger tilknyttet Kursus."));
                DynaCoursetemplate = group.Add(new VocabularyKey("dynaCoursetemplate", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus skabelon").WithDescription("Entydigt id for Kursus skabelon tilknyttet Event."));
                DynaCoursetype = group.Add(new VocabularyKey("dynaCoursetype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Type"));
                DynaCourseurl = group.Add(new VocabularyKey("dynaCourseurl", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus URL"));
                DynaDcpautoemailbekraeftelse = group.Add(new VocabularyKey("dynaDcpautoemailbekraeftelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DCP Auto email bekræftelse").WithDescription("Auto udsendelse af bekræftelse via Document Core Pack."));
                DynaDcpautoemailkursusbevis = group.Add(new VocabularyKey("dynaDcpautoemailkursusbevis", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DCP Auto email kursusbevis").WithDescription("Document Core Pack (DCP) Auto email kursusbevis"));
                DynaDcpautoemailpaamindelse = group.Add(new VocabularyKey("dynaDcpautoemailpaamindelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DCP Auto email indkaldelse").WithDescription("Document Core Pack (DCP) Auto email udsendelse af indkaldelse"));
                DynaDcpvedhaeftdeltagerliste = group.Add(new VocabularyKey("dynaDcpvedhaeftdeltagerliste", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("DCP vedhæft deltagerliste på indkaldelse").WithDescription("Markere om der skal vedhæftes deltagerlist til indkaldelsen"));
                DynaDescription = group.Add(new VocabularyKey("dynaDescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskrivelse"));
                DynaDuration = group.Add(new VocabularyKey("dynaDuration", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Varighed"));
                DynaEnddate = group.Add(new VocabularyKey("dynaEnddate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Slut Dato"));
                DynaEvaluationsend = group.Add(new VocabularyKey("dynaEvaluationsend", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering afsendt"));
                DynaEvaluationtype = group.Add(new VocabularyKey("dynaEvaluationtype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluerings Type"));
                DynaEvalueringsudsendelse = group.Add(new VocabularyKey("dynaEvalueringsudsendelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluerings udsendelse").WithDescription("Specificering om en evaluering skal sende ud automatisk eller manuel"));
                DynaExpandedcourse = group.Add(new VocabularyKey("dynaExpandedcourse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Udvidet Kursus"));
                DynaFakturastatus = group.Add(new VocabularyKey("dynaFakturastatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktura Status"));
                DynaFaktureretbelob = group.Add(new VocabularyKey("dynaFaktureretbelob", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureret beløb"));
                DynaFaktureretbelobBase = group.Add(new VocabularyKey("dynaFaktureretbelobBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureret beløb (grund)").WithDescription("Værdi af Faktureret beløb i grundvaluta."));
                DynaFaktureringsnavn = group.Add(new VocabularyKey("dynaFaktureringsnavn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktureringsnavn").WithDescription("Max 30 karakterer"));
                DynaFriteksttilkursusbekrftelse = group.Add(new VocabularyKey("dynaFriteksttilkursusbekrftelse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fritekst til Kursusbekræftelse"));
                DynaFriteksttilkursusbevisbagside = group.Add(new VocabularyKey("dynaFriteksttilkursusbevisbagside", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fritekst til kursusbevis bagside"));
                DynaFriteksttilkursusprogram = group.Add(new VocabularyKey("dynaFriteksttilkursusprogram", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fritekst til kursusprogram-BRUGES IKKE-SLET").WithDescription("Fritekst til Document core pack til at danne kursusprogrammet"));
                DynaFriteksttilpmindelse = group.Add(new VocabularyKey("dynaFriteksttilpmindelse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fritekst til indkaldelse"));
                DynaInfoomkurset = group.Add(new VocabularyKey("dynaInfoomkurset", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Info om kurset"));
                DynaInstructorname = group.Add(new VocabularyKey("dynaInstructorname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Underviser Navn"));
                DynaInternalnotes = group.Add(new VocabularyKey("dynaInternalnotes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Interne Noter").WithDescription("Benyttes til interne noter. Bliver ikke publiseret på hjemmesiden"));
                DynaInvoicedirectly = group.Add(new VocabularyKey("dynaInvoicedirectly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturer samlet til Firma"));
                DynaItemname = group.Add(new VocabularyKey("dynaItemname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navision Varenavn"));
                DynaItemnavid = group.Add(new VocabularyKey("dynaItemnavid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Vare ID"));
                DynaItemtemplateid = group.Add(new VocabularyKey("dynaItemtemplateid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Vare Opsætning").WithDescription("Entydigt id for Nav Skabelon tilknyttet Kursus."));
                DynaKonsulentid = group.Add(new VocabularyKey("dynaKonsulentid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Konsulent"));
                DynaKursusfaellesafholdelse = group.Add(new VocabularyKey("dynaKursusfaellesafholdelse", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus fælles afholdelse"));
                DynaLastregistrationdate = group.Add(new VocabularyKey("dynaLastregistrationdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidst Tilmeldings Dato"));
                DynaLastunregisterdate = group.Add(new VocabularyKey("dynaLastunregisterdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidst Afmeldings Dato"));
                DynaLmskursus = group.Add(new VocabularyKey("dynaLmskursus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LMS kursus").WithDescription("If the Course should be viewed in the LMS-solution"));
                DynaLocationid = group.Add(new VocabularyKey("dynaLocationid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokation").WithDescription("Entydigt id for Kursus Lokation tilknyttet Kursus."));
                DynaLocationname = group.Add(new VocabularyKey("dynaLocationname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokation Navn"));
                DynaMaster = group.Add(new VocabularyKey("dynaMaster", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Master"));
                DynaMastereventid = group.Add(new VocabularyKey("dynaMastereventid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overordnet kursus").WithDescription("Entydigt id for Event tilknyttet Event."));
                DynaMaxnumberofparticipant = group.Add(new VocabularyKey("dynaMaxnumberofparticipant", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Max Deltagere"));
                DynaMemberprice = group.Add(new VocabularyKey("dynaMemberprice", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Medlems Pris"));
                DynaMemberpriceBase = group.Add(new VocabularyKey("dynaMemberpriceBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Member Price (grund)").WithDescription("Værdi af Member Price i grundvaluta."));
                DynaName = group.Add(new VocabularyKey("dynaName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus Navn").WithDescription("Navnet på det brugerdefinerede objekt."));
                DynaNavid = group.Add(new VocabularyKey("dynaNavid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Nav ID"));
                DynaNonmemberprice = group.Add(new VocabularyKey("dynaNonmemberprice", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ikke-medlems Pris"));
                DynaNonmemberpriceBase = group.Add(new VocabularyKey("dynaNonmemberpriceBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Non-member Price (grund)").WithDescription("Værdi af Non-member Price i grundvaluta."));
                DynaOldid = group.Add(new VocabularyKey("dynaOldid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("OLDID"));
                DynaOprettelsesmailsendt = group.Add(new VocabularyKey("dynaOprettelsesmailsendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettelsesmail Sendt"));
                DynaOrderedaccommodations = group.Add(new VocabularyKey("dynaOrderedaccommodations", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overnatninger bestilt"));
                DynaOrderedmeals = group.Add(new VocabularyKey("dynaOrderedmeals", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Forplejning bestilt"));
                DynaOverfoertilhjemmeside = group.Add(new VocabularyKey("dynaOverfoertilhjemmeside", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Overfør til hjemmeside").WithDescription("Overfør til hjemmeside"));
                DynaPamindelsesendttilunderviser = group.Add(new VocabularyKey("dynaPamindelsesendttilunderviser", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Påmindelse sendt til underviser"));
                DynaPmindelsesendt = group.Add(new VocabularyKey("dynaPmindelsesendt", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Påmindelse sendt"));
                DynaPostalcode = group.Add(new VocabularyKey("dynaPostalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokation Postnr."));
                DynaReadyforinvoice = group.Add(new VocabularyKey("dynaReadyforinvoice", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ready For Invoice"));
                DynaRegister = group.Add(new VocabularyKey("dynaRegister", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tilmeldte"));
                DynaResponsibleemail = group.Add(new VocabularyKey("dynaResponsibleemail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ansvarlig E-mail"));
                DynaResponsiblename = group.Add(new VocabularyKey("dynaResponsiblename", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ansvarlig Navn"));
                DynaSalgsmulighed = group.Add(new VocabularyKey("dynaSalgsmulighed", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salgsmulighed"));
                DynaSenttoinvoice = group.Add(new VocabularyKey("dynaSenttoinvoice", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Send til Faktura"));
                DynaShowmaxparticipant = group.Add(new VocabularyKey("dynaShowmaxparticipant", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Vis Max Deltager"));
                DynaShowparticipant = group.Add(new VocabularyKey("dynaShowparticipant", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Vis Tilmeldte"));
                DynaShowwaitinglist = group.Add(new VocabularyKey("dynaShowwaitinglist", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Vis Venteliste"));
                DynaSpeakerid = group.Add(new VocabularyKey("dynaSpeakerid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær Underviser").WithDescription("Entydigt id for Kontaktperson tilknyttet Kursus."));
                DynaStreet1 = group.Add(new VocabularyKey("dynaStreet1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokations gade 1"));
                DynaStreet2 = group.Add(new VocabularyKey("dynaStreet2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokation Gade 2"));
                DynaSubcoursedatesdescription = group.Add(new VocabularyKey("dynaSubcoursedatesdescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Underkursus Dato liste").WithDescription("\"Sammensat felt til visning a undeliggende kursusdage, skal bruges til brevfletning\""));
                DynaTeaser = group.Add(new VocabularyKey("dynaTeaser", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Teaser"));
                DynaTelephone1 = group.Add(new VocabularyKey("dynaTelephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Lokation telefon"));
                DynaTotalkursusokonomi = group.Add(new VocabularyKey("dynaTotalkursusokonomi", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi").WithDescription("Total sum i kr af alle kursusdeltagerne"));
                DynaTotalkursusokonomiBase = group.Add(new VocabularyKey("dynaTotalkursusokonomiBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi (grund)").WithDescription("Værdi af Total Kursus Økonomi i grundvaluta."));
                DynaTotalkursusokonomiDate = group.Add(new VocabularyKey("dynaTotalkursusokonomiDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi (Senest opdateret den)").WithDescription("Tidspunkt for seneste opdatering af akkumuleringsfeltet Total Kursus Økonomi."));
                DynaTotalkursusokonomiState = group.Add(new VocabularyKey("dynaTotalkursusokonomiState", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi (tilstand)").WithDescription("Tilstand for akkumuleringsfeltet Total Kursus Økonomi."));
                DynaTotalkursusokonomivip = group.Add(new VocabularyKey("dynaTotalkursusokonomivip", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi Vip"));
                DynaTotalkursusokonomivipBase = group.Add(new VocabularyKey("dynaTotalkursusokonomivipBase", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi Vip (grund)").WithDescription("Værdi af Total Kursus Økonomi Vip i grundvaluta."));
                DynaTotalkursusokonomivipDate = group.Add(new VocabularyKey("dynaTotalkursusokonomivipDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi (Senest opdateret den)").WithDescription("Tidspunkt for seneste opdatering af akkumuleringsfeltet Total Kursus Økonomi."));
                DynaTotalkursusokonomivipState = group.Add(new VocabularyKey("dynaTotalkursusokonomivipState", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Total Kursus Økonomi (tilstand)").WithDescription("Tilstand for akkumuleringsfeltet Total Kursus Økonomi."));
                DynaUndervisergodkendt = group.Add(new VocabularyKey("dynaUndervisergodkendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Underviser godkendt"));
                DynaWaitinglist = group.Add(new VocabularyKey("dynaWaitinglist", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Venteliste"));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("\"Valutakurs for den valuta, der er tilknyttet objektet, i forhold til grundvalutaen.\""));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("Dato og klokkeslæt for ændring af posten."));
                Organizationid = group.Add(new VocabularyKey("organizationid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Organisations-id").WithDescription("Entydigt id for organisationen"));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("Status for Course"));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus status").WithDescription("Årsag til statussen for Course"));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Entydigt id for den valuta, der er tilknyttet objektet.\""));
            });
        }

        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey DynaAccountid { get; private set; }
        public VocabularyKey DynaAddinvoicedate { get; private set; }
        public VocabularyKey DynaAftaltpris { get; private set; }
        public VocabularyKey DynaBemrkninger { get; private set; }
        public VocabularyKey DynaBreakevennumber { get; private set; }
        public VocabularyKey DynaCity { get; private set; }
        public VocabularyKey DynaContactid { get; private set; }
        public VocabularyKey DynaCoursecustomerid { get; private set; }
        public VocabularyKey DynaCoursedate { get; private set; }
        public VocabularyKey DynaCourseevent { get; private set; }
        public VocabularyKey DynaCourseguid { get; private set; }
        public VocabularyKey DynaCourseid { get; private set; }
        public VocabularyKey DynaCourseitemid { get; private set; }
        public VocabularyKey DynaCourseresponsibleid { get; private set; }
        public VocabularyKey DynaCoursetemplate { get; private set; }
        public VocabularyKey DynaCoursetype { get; private set; }
        public VocabularyKey DynaCourseurl { get; private set; }
        public VocabularyKey DynaDcpautoemailbekraeftelse { get; private set; }
        public VocabularyKey DynaDcpautoemailkursusbevis { get; private set; }
        public VocabularyKey DynaDcpautoemailpaamindelse { get; private set; }
        public VocabularyKey DynaDcpvedhaeftdeltagerliste { get; private set; }
        public VocabularyKey DynaDescription { get; private set; }
        public VocabularyKey DynaDuration { get; private set; }
        public VocabularyKey DynaEnddate { get; private set; }
        public VocabularyKey DynaEvaluationsend { get; private set; }
        public VocabularyKey DynaEvaluationtype { get; private set; }
        public VocabularyKey DynaEvalueringsudsendelse { get; private set; }
        public VocabularyKey DynaExpandedcourse { get; private set; }
        public VocabularyKey DynaFakturastatus { get; private set; }
        public VocabularyKey DynaFaktureretbelob { get; private set; }
        public VocabularyKey DynaFaktureretbelobBase { get; private set; }
        public VocabularyKey DynaFaktureringsnavn { get; private set; }
        public VocabularyKey DynaFriteksttilkursusbekrftelse { get; private set; }
        public VocabularyKey DynaFriteksttilkursusbevisbagside { get; private set; }
        public VocabularyKey DynaFriteksttilkursusprogram { get; private set; }
        public VocabularyKey DynaFriteksttilpmindelse { get; private set; }
        public VocabularyKey DynaInfoomkurset { get; private set; }
        public VocabularyKey DynaInstructorname { get; private set; }
        public VocabularyKey DynaInternalnotes { get; private set; }
        public VocabularyKey DynaInvoicedirectly { get; private set; }
        public VocabularyKey DynaItemname { get; private set; }
        public VocabularyKey DynaItemnavid { get; private set; }
        public VocabularyKey DynaItemtemplateid { get; private set; }
        public VocabularyKey DynaKonsulentid { get; private set; }
        public VocabularyKey DynaKursusfaellesafholdelse { get; private set; }
        public VocabularyKey DynaLastregistrationdate { get; private set; }
        public VocabularyKey DynaLastunregisterdate { get; private set; }
        public VocabularyKey DynaLmskursus { get; private set; }
        public VocabularyKey DynaLocationid { get; private set; }
        public VocabularyKey DynaLocationname { get; private set; }
        public VocabularyKey DynaMaster { get; private set; }
        public VocabularyKey DynaMastereventid { get; private set; }
        public VocabularyKey DynaMaxnumberofparticipant { get; private set; }
        public VocabularyKey DynaMemberprice { get; private set; }
        public VocabularyKey DynaMemberpriceBase { get; private set; }
        public VocabularyKey DynaName { get; private set; }
        public VocabularyKey DynaNavid { get; private set; }
        public VocabularyKey DynaNonmemberprice { get; private set; }
        public VocabularyKey DynaNonmemberpriceBase { get; private set; }
        public VocabularyKey DynaOldid { get; private set; }
        public VocabularyKey DynaOprettelsesmailsendt { get; private set; }
        public VocabularyKey DynaOrderedaccommodations { get; private set; }
        public VocabularyKey DynaOrderedmeals { get; private set; }
        public VocabularyKey DynaOverfoertilhjemmeside { get; private set; }
        public VocabularyKey DynaPamindelsesendttilunderviser { get; private set; }
        public VocabularyKey DynaPmindelsesendt { get; private set; }
        public VocabularyKey DynaPostalcode { get; private set; }
        public VocabularyKey DynaReadyforinvoice { get; private set; }
        public VocabularyKey DynaRegister { get; private set; }
        public VocabularyKey DynaResponsibleemail { get; private set; }
        public VocabularyKey DynaResponsiblename { get; private set; }
        public VocabularyKey DynaSalgsmulighed { get; private set; }
        public VocabularyKey DynaSenttoinvoice { get; private set; }
        public VocabularyKey DynaShowmaxparticipant { get; private set; }
        public VocabularyKey DynaShowparticipant { get; private set; }
        public VocabularyKey DynaShowwaitinglist { get; private set; }
        public VocabularyKey DynaSpeakerid { get; private set; }
        public VocabularyKey DynaStreet1 { get; private set; }
        public VocabularyKey DynaStreet2 { get; private set; }
        public VocabularyKey DynaSubcoursedatesdescription { get; private set; }
        public VocabularyKey DynaTeaser { get; private set; }
        public VocabularyKey DynaTelephone1 { get; private set; }
        public VocabularyKey DynaTotalkursusokonomi { get; private set; }
        public VocabularyKey DynaTotalkursusokonomiBase { get; private set; }
        public VocabularyKey DynaTotalkursusokonomiDate { get; private set; }
        public VocabularyKey DynaTotalkursusokonomiState { get; private set; }
        public VocabularyKey DynaTotalkursusokonomivip { get; private set; }
        public VocabularyKey DynaTotalkursusokonomivipBase { get; private set; }
        public VocabularyKey DynaTotalkursusokonomivipDate { get; private set; }
        public VocabularyKey DynaTotalkursusokonomivipState { get; private set; }
        public VocabularyKey DynaUndervisergodkendt { get; private set; }
        public VocabularyKey DynaWaitinglist { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Organizationid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
    }
}
