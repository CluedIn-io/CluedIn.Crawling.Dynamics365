using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class LeadtoopportunitysalesprocessVocabulary : SimpleVocabulary
    {
        public LeadtoopportunitysalesprocessVocabulary()
        {
            VocabularyName = "Dynamics365 Leadtoopportunitysalesprocess"; // TODO: Set value
            KeyPrefix = "dynamics365.LeadToOpportunitySalesProcess"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "EmneSalgsmulighed"; // TODO: Check value

            AddGroup("EmneSalgsmulighed Details", group =>
            {
                Activestageid = group.Add(new VocabularyKey("activestageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aktiv fase").WithDescription("lk_leadtoopportunitysalesprocess_activestageid"));
                Activestagestartedon = group.Add(new VocabularyKey("activestagestartedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aktiv fase startet").WithDescription("Dato og klokkeslæt for starten af den aktuelle aktive fase."));
                Businessprocessflowinstanceid = group.Add(new VocabularyKey("businessprocessflowinstanceid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Forekomst-id for kundeemne til salgsproces for salgsmulighed").WithDescription("Entydigt id for BPF-objektforekomster i kundeemne til salgsproces for salgsmulighed"));
                Completedon = group.Add(new VocabularyKey("completedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Udført den").WithDescription("\"Dato og klokkeslæt for, hvornår forekomsten af forretningsprocesforløbet er fuldført\""));
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Viser, hvem der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet Dato").WithDescription("\"Viser dato og klokkeslæt for oprettelse af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics CRM.\""));
                Duration = group.Add(new VocabularyKey("duration", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Varighed").WithDescription("\"Varighed mellem fuldført og startet, der blev brugt af forretningsprocesforløbet.\""));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("Viser omregningskursen for postens valuta. Valutakursen bruges til at konvertere alle pengefelter i posten fra den lokale valuta til systemets standardvaluta."));
                Leadid = group.Add(new VocabularyKey("leadid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kundeemne").WithDescription("lk_leadtoopportunitysalesprocess_leadid"));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Viser, hvem der sidst opdaterede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret den").WithDescription("\"Viser dato og klokkeslæt for den seneste opdatering af posten. Datoen og klokkeslættet vises i den tidszone, der er valgt i indstillingerne i Microsoft Dynamics CRM.\""));
                Name = group.Add(new VocabularyKey("name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Procesnavn").WithDescription("Procesnavn."));
                Opportunityid = group.Add(new VocabularyKey("opportunityid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for salgsmulighed").WithDescription("lk_leadtoopportunitysalesprocess_opportunityid"));
                Organizationid = group.Add(new VocabularyKey("organizationid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Organisations-id").WithDescription("\"Entydigt id for den organisation, som SDK-meddelelsesanmodningen er tilknyttet.\""));
                Processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Proces-id").WithDescription("lk_leadtoopportunitysalesprocess_processid"));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("\"Viser, om Delve-handlingsposten er åben, fuldført eller sporer.\""));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Vælg Delve-handlingens poststatus."));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("transactioncurrency_leadtoopportunitysalesprocess"));
                Traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("En kommasepareret streng med id'er for procesfaser, der repræsenterer de besøgte faser i forekomsten af forretningsprocesforløbet.").WithDescription("Gennemløbet sti"));
            });
        }

        public VocabularyKey Activestageid { get; private set; }
        public VocabularyKey Activestagestartedon { get; private set; }
        public VocabularyKey Businessprocessflowinstanceid { get; private set; }
        public VocabularyKey Completedon { get; private set; }
        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Leadid { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Opportunityid { get; private set; }
        public VocabularyKey Organizationid { get; private set; }
        public VocabularyKey Processid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
        public VocabularyKey Traversedpath { get; private set; }
    }
}
