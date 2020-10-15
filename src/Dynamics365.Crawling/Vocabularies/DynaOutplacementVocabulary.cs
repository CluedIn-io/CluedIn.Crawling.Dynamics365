using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DynaOutplacementVocabulary : SimpleVocabulary
    {
        public DynaOutplacementVocabulary()
        {
            VocabularyName = "Dynamics365 DynaOutplacement"; // TODO: Set value
            KeyPrefix = "dynamics365.dyna_outplacement"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Outplacement"; // TODO: Check value

            AddGroup("Outplacement Details", group =>
            {
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet").WithDescription("Dato og klokkeslæt for oprettelsen af posten."));
                DynaAarsagtilafslag = group.Add(new VocabularyKey("dynaAarsagtilafslag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsag til afslag").WithDescription("Årsag til afslag"));
                DynaAfslutgrundAndenloesning = group.Add(new VocabularyKey("dynaAfslutgrundAndenloesning", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Anden tilfredshedsdtillende løsning").WithDescription("Grund til afsluttet forløb"));
                DynaAfslutgrundMidlertidigansaettelse = group.Add(new VocabularyKey("dynaAfslutgrundMidlertidigansaettelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Midlertidig ansættelse"));
                DynaAfslutgrundNytjob = group.Add(new VocabularyKey("dynaAfslutgrundNytjob", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Nyt Job"));
                DynaAfslutgrundOpbrugtmoeder = group.Add(new VocabularyKey("dynaAfslutgrundOpbrugtmoeder", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Opbrugt møderække"));
                DynaAfslutgrundPensionefterlon = group.Add(new VocabularyKey("dynaAfslutgrundPensionefterlon", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Pension/Efterløn"));
                DynaAfslutgrundUddannelse = group.Add(new VocabularyKey("dynaAfslutgrundUddannelse", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Uddannelse"));
                DynaAfslutgrundUdloebafperiode = group.Add(new VocabularyKey("dynaAfslutgrundUdloebafperiode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Udløb af periode").WithDescription("Grund til forløb afsuttes"));
                DynaAfsluttetAarsag = group.Add(new VocabularyKey("dynaAfsluttetAarsag", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Årsag til forløb afsluttes").WithDescription("Årsag til forløbet er afsluttet"));
                DynaAfsluttetBeskrivelse = group.Add(new VocabularyKey("dynaAfsluttetBeskrivelse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Afsluttet beskrivelse").WithDescription("Beskrivelsen af outplacement forløbets afslutning. Dette felt hænger sammen med årsag for afslutning."));
                DynaAfsluttetOpstartsdato = group.Add(new VocabularyKey("dynaAfsluttetOpstartsdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Dato for opstart").WithDescription("\"Dato for hvornår kandidaten starter nyt job, uddannelse eller pension/efterløn\""));
                DynaAntalmoeder = group.Add(new VocabularyKey("dynaAntalmoeder", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Max antal møder").WithDescription("\"Max antal møder. Dette felt skal bruges til lave X antal aktiviteter, så brugeren ikke behøver at oprette aktiviteterne selv.\""));
                DynaAntaloutplacementmoeder = group.Add(new VocabularyKey("dynaAntaloutplacementmoeder", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal timer").WithDescription("\"Antal møde timer. Husk hvis du laver om på timerne, skal du også ændre dette i pluginet OutplacementCaltulateRestTid\""));
                DynaAntaloutplacementmoederandet = group.Add(new VocabularyKey("dynaAntaloutplacementmoederandet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal møder andet").WithDescription("\"Når man vælger andet på dropdown listen Antal møder, skal man kunne skrive en tekst.\""));
                DynaAntaltimer = group.Add(new VocabularyKey("dynaAntaltimer", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Antal timer pr. møde").WithDescription("Antal timer pr. møde"));
                DynaAttentionemail = group.Add(new VocabularyKey("dynaAttentionemail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Attention email"));
                DynaBaggrundforhenvisning = group.Add(new VocabularyKey("dynaBaggrundforhenvisning", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Baggrund for henvisning"));
                DynaBeloebexmoms = group.Add(new VocabularyKey("dynaBeloebexmoms", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beløb ex moms"));
                DynaBookedmoedetimer = group.Add(new VocabularyKey("dynaBookedmoedetimer", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Booked mødetimer - Bruges ikke!"));
                DynaBookedmoedetimerDate = group.Add(new VocabularyKey("dynaBookedmoedetimerDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Booked mødetimer (Senest opdateret den)").WithDescription("Tidspunkt for seneste opdatering af akkumuleringsfeltet Booked mødetimer."));
                DynaBookedmoedetimerState = group.Add(new VocabularyKey("dynaBookedmoedetimerState", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Booked mødetimer (tilstand)").WithDescription("Tilstand for akkumuleringsfeltet Booked mødetimer."));
                DynaBudgetterettimer = group.Add(new VocabularyKey("dynaBudgetterettimer", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Budgetteret timer- Bruges ikke!"));
                DynaCpr = group.Add(new VocabularyKey("dynaCpr", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Cpr nummer - Bruges ikke").WithDescription("Må ikke benyttes. Dette felt bruges ikke mere. SKAL SLETTES"));
                DynaDatoForSidsteMoede = group.Add(new VocabularyKey("dynaDatoForSidsteMoede", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Dato for sidste møde"));
                DynaDebitor = group.Add(new VocabularyKey("dynaDebitor", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor").WithDescription("Den person som skal modtage fakturaen. Det kan være kontaktpersonen selv eller det kan være et firma."));
                DynaDebitoratt = group.Add(new VocabularyKey("dynaDebitoratt", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor attention"));
                DynaDebitorattention = group.Add(new VocabularyKey("dynaDebitorattention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor attention").WithDescription("Den attention som skal stå på fakturaen"));
                DynaDeltagerid = group.Add(new VocabularyKey("dynaDeltagerid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Deltager"));
                DynaEvalueringAfsendt = group.Add(new VocabularyKey("dynaEvalueringAfsendt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering afsendt").WithDescription("Evaluering afsendt"));
                DynaEvalueringUdfyldt = group.Add(new VocabularyKey("dynaEvalueringUdfyldt", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering udfyldt"));
                DynaEvalueringlink = group.Add(new VocabularyKey("dynaEvalueringlink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluerings link"));
                DynaEvalueringsmaade = group.Add(new VocabularyKey("dynaEvalueringsmaade", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluerings måde"));
                DynaFakturadato = group.Add(new VocabularyKey("dynaFakturadato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktura dato"));
                DynaFakturastatus = group.Add(new VocabularyKey("dynaFakturastatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktura status").WithDescription("Faktura  status for kandidaten"));
                DynaFakturerdeltagerdirekte = group.Add(new VocabularyKey("dynaFakturerdeltagerdirekte", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturer Deltager Direkte").WithDescription("Fakturer Deltager Direkte"));
                DynaFirma = group.Add(new VocabularyKey("dynaFirma", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firma").WithDescription("Det firma som skal betale fakturaen."));
                DynaFirmaoplysningerquick = group.Add(new VocabularyKey("dynaFirmaoplysningerquick", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Firma temp").WithDescription("\"Dette felt bruges til hurtigt at indtaste firma oplysninger, som KC administrationen læser fra for at tilknytte det rigtige firma og debitor.\""));
                DynaFratraedelsesdato = group.Add(new VocabularyKey("dynaFratraedelsesdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("1. ledighedsdag"));
                DynaGeografiskplacering = group.Add(new VocabularyKey("dynaGeografiskplacering", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Geografisk placering"));
                DynaGeografiskplaceringandet = group.Add(new VocabularyKey("dynaGeografiskplaceringandet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Andet").WithDescription("Fritekst til at beskrive andet."));
                DynaHenvisendemedarbejder = group.Add(new VocabularyKey("dynaHenvisendemedarbejder", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Henvisende medarbejder (SKAL SLETTES!)"));
                DynaHenvisendemedarbejderKons = group.Add(new VocabularyKey("dynaHenvisendemedarbejderKons", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Henvisende medarbejder").WithDescription("Entydigt id for Outplacement Konsulent tilknyttet Outplacement Kandidat."));
                DynaHenvisendemedarbejderini = group.Add(new VocabularyKey("dynaHenvisendemedarbejderini", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Henvisende medarbejder (ini) (SKAL SLETTES)"));
                DynaJobtitel = group.Add(new VocabularyKey("dynaJobtitel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Jobtitel").WithDescription("Titlen på det nye job som kandidaten har fået"));
                DynaJobvirksomhed = group.Add(new VocabularyKey("dynaJobvirksomhed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Virksomhed").WithDescription("Virksomheden som kandidaten har fået job hos"));
                DynaKandidaten = group.Add(new VocabularyKey("dynaKandidaten", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kandidaten").WithDescription("\"Den person som skal igennem et outplacement forløb, eller som er en potentiel kandidat til et outplacement forløb.\""));
                DynaKontaktessenest = group.Add(new VocabularyKey("dynaKontaktessenest", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontaktes senest"));
                DynaKontaktestidligst = group.Add(new VocabularyKey("dynaKontaktestidligst", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontaktes tidligst"));
                DynaKursusid = group.Add(new VocabularyKey("dynaKursusid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kursus"));
                DynaLmsadgang = group.Add(new VocabularyKey("dynaLmsadgang", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LMS Adgang").WithDescription("If the Kandiat should have access to a LMS system and in this case Moodle"));
                DynaLtafsendtbrevtdato = group.Add(new VocabularyKey("dynaLtafsendtbrevtdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LT afsendt brevt dato"));
                DynaLtdkning = group.Add(new VocabularyKey("dynaLtdkning", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LT Dækning"));
                DynaLtmodtagetwebformulardato = group.Add(new VocabularyKey("dynaLtmodtagetwebformulardato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("LT modtaget webformular dato"));
                DynaName = group.Add(new VocabularyKey("dynaName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn").WithDescription("ID på det brugerdefinerede objekt."));
                DynaOpgavelosendekonsulent = group.Add(new VocabularyKey("dynaOpgavelosendekonsulent", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Konsulent").WithDescription("NOT IN USE. Entydigt id for Outplacement Konsulent tilknyttet Outplacement Kandidat."));
                DynaOpstartsdato = group.Add(new VocabularyKey("dynaOpstartsdato", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Opstarts dato"));
                DynaOrdrebekraeftelseafsendt = group.Add(new VocabularyKey("dynaOrdrebekraeftelseafsendt", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ordrebekræftelse afsendt"));
                DynaOutplacementid = group.Add(new VocabularyKey("dynaOutplacementid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Outplacement_ID").WithDescription("Entydigt id for objektforekomster"));
                DynaOutplacementtype = group.Add(new VocabularyKey("dynaOutplacementtype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Outplacement Forløb"));
                DynaProduktkategori = group.Add(new VocabularyKey("dynaProduktkategori", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Produkt kategori").WithDescription("\"Produkt kateogri, som forløbet høre indunder\""));
                DynaRestmoedetid = group.Add(new VocabularyKey("dynaRestmoedetid", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Rest møde tid").WithDescription("Den resterende mødetid ud fra antal timer og antal brugte møder"));
                DynaResttid = group.Add(new VocabularyKey("dynaResttid", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Resttid"));
                DynaSaelger = group.Add(new VocabularyKey("dynaSaelger", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("KC Sælger").WithDescription("KC Sælger"));
                DynaSalgskanaler = group.Add(new VocabularyKey("dynaSalgskanaler", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Salgs kanaler"));
                DynaSluttidspunkt = group.Add(new VocabularyKey("dynaSluttidspunkt", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Slut tidspunkt").WithDescription("Slut tidspunktet for hvornår outplacement forløbet skal slutte. Denne dato sættes når forløb sættes igang."));
                DynaStatus = group.Add(new VocabularyKey("dynaStatus", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Outplacement status").WithDescription("Status på outplacement forløbet"));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("Dato og klokkeslæt for ændring af posten."));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("Status for Outplacement"));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Årsag til statussen for Outplacement"));
            });
        }

        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey DynaAarsagtilafslag { get; private set; }
        public VocabularyKey DynaAfslutgrundAndenloesning { get; private set; }
        public VocabularyKey DynaAfslutgrundMidlertidigansaettelse { get; private set; }
        public VocabularyKey DynaAfslutgrundNytjob { get; private set; }
        public VocabularyKey DynaAfslutgrundOpbrugtmoeder { get; private set; }
        public VocabularyKey DynaAfslutgrundPensionefterlon { get; private set; }
        public VocabularyKey DynaAfslutgrundUddannelse { get; private set; }
        public VocabularyKey DynaAfslutgrundUdloebafperiode { get; private set; }
        public VocabularyKey DynaAfsluttetAarsag { get; private set; }
        public VocabularyKey DynaAfsluttetBeskrivelse { get; private set; }
        public VocabularyKey DynaAfsluttetOpstartsdato { get; private set; }
        public VocabularyKey DynaAntalmoeder { get; private set; }
        public VocabularyKey DynaAntaloutplacementmoeder { get; private set; }
        public VocabularyKey DynaAntaloutplacementmoederandet { get; private set; }
        public VocabularyKey DynaAntaltimer { get; private set; }
        public VocabularyKey DynaAttentionemail { get; private set; }
        public VocabularyKey DynaBaggrundforhenvisning { get; private set; }
        public VocabularyKey DynaBeloebexmoms { get; private set; }
        public VocabularyKey DynaBookedmoedetimer { get; private set; }
        public VocabularyKey DynaBookedmoedetimerDate { get; private set; }
        public VocabularyKey DynaBookedmoedetimerState { get; private set; }
        public VocabularyKey DynaBudgetterettimer { get; private set; }
        public VocabularyKey DynaCpr { get; private set; }
        public VocabularyKey DynaDatoForSidsteMoede { get; private set; }
        public VocabularyKey DynaDebitor { get; private set; }
        public VocabularyKey DynaDebitoratt { get; private set; }
        public VocabularyKey DynaDebitorattention { get; private set; }
        public VocabularyKey DynaDeltagerid { get; private set; }
        public VocabularyKey DynaEvalueringAfsendt { get; private set; }
        public VocabularyKey DynaEvalueringUdfyldt { get; private set; }
        public VocabularyKey DynaEvalueringlink { get; private set; }
        public VocabularyKey DynaEvalueringsmaade { get; private set; }
        public VocabularyKey DynaFakturadato { get; private set; }
        public VocabularyKey DynaFakturastatus { get; private set; }
        public VocabularyKey DynaFakturerdeltagerdirekte { get; private set; }
        public VocabularyKey DynaFirma { get; private set; }
        public VocabularyKey DynaFirmaoplysningerquick { get; private set; }
        public VocabularyKey DynaFratraedelsesdato { get; private set; }
        public VocabularyKey DynaGeografiskplacering { get; private set; }
        public VocabularyKey DynaGeografiskplaceringandet { get; private set; }
        public VocabularyKey DynaHenvisendemedarbejder { get; private set; }
        public VocabularyKey DynaHenvisendemedarbejderKons { get; private set; }
        public VocabularyKey DynaHenvisendemedarbejderini { get; private set; }
        public VocabularyKey DynaJobtitel { get; private set; }
        public VocabularyKey DynaJobvirksomhed { get; private set; }
        public VocabularyKey DynaKandidaten { get; private set; }
        public VocabularyKey DynaKontaktessenest { get; private set; }
        public VocabularyKey DynaKontaktestidligst { get; private set; }
        public VocabularyKey DynaKursusid { get; private set; }
        public VocabularyKey DynaLmsadgang { get; private set; }
        public VocabularyKey DynaLtafsendtbrevtdato { get; private set; }
        public VocabularyKey DynaLtdkning { get; private set; }
        public VocabularyKey DynaLtmodtagetwebformulardato { get; private set; }
        public VocabularyKey DynaName { get; private set; }
        public VocabularyKey DynaOpgavelosendekonsulent { get; private set; }
        public VocabularyKey DynaOpstartsdato { get; private set; }
        public VocabularyKey DynaOrdrebekraeftelseafsendt { get; private set; }
        public VocabularyKey DynaOutplacementid { get; private set; }
        public VocabularyKey DynaOutplacementtype { get; private set; }
        public VocabularyKey DynaProduktkategori { get; private set; }
        public VocabularyKey DynaRestmoedetid { get; private set; }
        public VocabularyKey DynaResttid { get; private set; }
        public VocabularyKey DynaSaelger { get; private set; }
        public VocabularyKey DynaSalgskanaler { get; private set; }
        public VocabularyKey DynaSluttidspunkt { get; private set; }
        public VocabularyKey DynaStatus { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
    }
}
