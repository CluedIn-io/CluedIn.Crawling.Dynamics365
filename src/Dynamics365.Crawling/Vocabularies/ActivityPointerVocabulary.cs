using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class ActivitypointerVocabulary : SimpleVocabulary
    {
        public ActivitypointerVocabulary()
        {
            VocabularyName = "Dynamics365 Activitypointer"; // TODO: Set value
            KeyPrefix = "dynamics365.ActivityPointer"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Aktivitet"; // TODO: Check value

            AddGroup("Aktivitet Details", group =>
            {
                Activityadditionalparams = group.Add(new VocabularyKey("activityadditionalparams", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Flere parametre for aktivitet").WithDescription("Yderligere oplysninger leveret af det eksterne program som JSON. Kun til intern brug."));
                Activityid = group.Add(new VocabularyKey("activityid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aktivitet").WithDescription("Entydigt id for aktiviteten."));
                Activitytypecode = group.Add(new VocabularyKey("activitytypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aktivitetstype").WithDescription("Aktivitetstypen."));
                Actualdurationminutes = group.Add(new VocabularyKey("actualdurationminutes", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktisk varighed").WithDescription("Aktivitetens faktiske varighed i minutter."));
                Actualend = group.Add(new VocabularyKey("actualend", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktisk slutning").WithDescription("Aktivitetens faktiske sluttidspunkt."));
                Actualstart = group.Add(new VocabularyKey("actualstart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Faktisk start").WithDescription("Aktivitetens faktiske starttidspunkt."));
                Allparties = group.Add(new VocabularyKey("allparties", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Alle parter i aktiviteter").WithDescription("\"Alle aktivitetsparter, der er knyttet til denne aktivitet.\""));
                Community = group.Add(new VocabularyKey("community", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Social kanal").WithDescription("\"Viser, hvor kontakt om den sociale aktivitet stammer fra, f.eks. fra Twitter eller Facebook. Dette felt er skrivebeskyttet.\""));
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede aktiviteten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Dato for oprettelse").WithDescription("Dato og klokkeslæt for oprettelse af aktiviteten."));
                Deliverylastattemptedon = group.Add(new VocabularyKey("deliverylastattemptedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Dato for seneste leveringsforsøg").WithDescription("Dato og klokkeslæt for det seneste forsøg på levering af aktiviteten."));
                Deliveryprioritycode = group.Add(new VocabularyKey("deliveryprioritycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Leveringsprioritet").WithDescription("Prioritet for levering af aktiviteten til mailserveren."));
                Description = group.Add(new VocabularyKey("description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Beskrivelse").WithDescription("Beskrivelse af aktiviteten."));
                Exchangeitemid = group.Add(new VocabularyKey("exchangeitemid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Id for Exchange-element").WithDescription("\"Meddelelses-id'et for aktivitet, der returneres fra Exchange Server.\""));
                Exchangerate = group.Add(new VocabularyKey("exchangerate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valutakurs").WithDescription("\"Valutakurs for den valuta, der er tilknyttet aktivitetspointeren, i forhold til grundvalutaen.\""));
                Exchangeweblink = group.Add(new VocabularyKey("exchangeweblink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Exchange WebLink").WithDescription("Viser weblinket for aktivitet af typen mail."));
                Instancetypecode = group.Add(new VocabularyKey("instancetypecode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tilbagevendende forekomsttype").WithDescription("Forekomsttype for en tilbagevendende serie."));
                Isbilled = group.Add(new VocabularyKey("isbilled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Er faktureret").WithDescription("\"Angiver, om aktiviteten blev faktureret som en del af løsning af en sag.\""));
                Ismapiprivate = group.Add(new VocabularyKey("ismapiprivate", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Er privat").WithDescription("Kun til intern brug."));
                Isregularactivity = group.Add(new VocabularyKey("isregularactivity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Er en almindelig aktivitet").WithDescription("\"Oplysninger om, hvorvidt aktiviteten er en almindelig aktivitetstype eller hændelsestype.\""));
                Isworkflowcreated = group.Add(new VocabularyKey("isworkflowcreated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Er der oprettet en arbejdsproces?").WithDescription("\"Angiver, om aktiviteten blev oprettet ud fra en arbejdsprocesregel.\""));
                Lastonholdtime = group.Add(new VocabularyKey("lastonholdtime", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Seneste tid for I venteposition").WithDescription("Indeholder dato- og klokkeslætsstemplet for den seneste tid for I venteposition."));
                Leftvoicemail = group.Add(new VocabularyKey("leftvoicemail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Har lagt talebesked").WithDescription("Har lagt talebeskeden"));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der sidst ændrede aktiviteten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidst opdateret").WithDescription("Dato og klokkeslæt for den seneste ændring af aktiviteten."));
                Onholdtime = group.Add(new VocabularyKey("onholdtime", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Tid for I venteposition (minutter)").WithDescription("\"Viser, hvor længe posten var i venteposition i minutter.\""));
                Postponeactivityprocessinguntil = group.Add(new VocabularyKey("postponeactivityprocessinguntil", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Udskyd aktivitetsbehandlingen indtil").WithDescription("Kun til intern brug."));
                Prioritycode = group.Add(new VocabularyKey("prioritycode", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Prioritet").WithDescription("Aktivitetens prioritet."));
                Processid = group.Add(new VocabularyKey("processid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Proces").WithDescription("Entydigt id for processen."));
                Regardingobjectid = group.Add(new VocabularyKey("regardingobjectid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Angående").WithDescription("\"CampaignActivity_ActivityPointers$Contract_ActivityPointers$Entydigt id for det objekt, som aktiviteten er tilknyttet.$Lead_ActivityPointers$SalesOrder_ActivityPointers$bookableresourcebooking_ActivityPointers\""));
                Scheduleddurationminutes = group.Add(new VocabularyKey("scheduleddurationminutes", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Planlagt varighed").WithDescription("\"Planlagt varighed af aktiviteten, angivet i minutter.\""));
                Scheduledend = group.Add(new VocabularyKey("scheduledend", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Forfaldsdato").WithDescription("Aktivitetens planlagte sluttidspunkt."));
                Scheduledstart = group.Add(new VocabularyKey("scheduledstart", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Startdato").WithDescription("Aktivitetens planlagte starttidspunkt."));
                Sendermailboxid = group.Add(new VocabularyKey("sendermailboxid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Afsenders postkasse").WithDescription("\"Entydigt id for den postkasse, der er tilknyttet afsenderen af mailen.\""));
                Senton = group.Add(new VocabularyKey("senton", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sendt").WithDescription("Dato og klokkeslæt for afsendelse af aktiviteten."));
                Seriesid = group.Add(new VocabularyKey("seriesid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Serie-id").WithDescription("Entydigt id for en tilbagevendende serie af en forekomst."));
                Serviceid = group.Add(new VocabularyKey("serviceid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Service").WithDescription("service_activity_pointers"));
                Slaid = group.Add(new VocabularyKey("slaid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("SLA").WithDescription("\"Vælg den serviceaftale (SLA), du vil anvende på sagsposten.\""));
                Slainvokedid = group.Add(new VocabularyKey("slainvokedid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sidst anvendte SLA").WithDescription("\"Sidste SLA, der blev anvendt til denne sag. Dette felt er kun beregnet til intern brug.\""));
                Sortdate = group.Add(new VocabularyKey("sortdate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Sorteringsdato").WithDescription("\"Viser den dato og det klokkeslæt, aktiviteterne er sorteret efter.\""));
                Stageid = group.Add(new VocabularyKey("stageid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Procestrin").WithDescription("Entydigt id for fasen."));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Aktivitetsstatus").WithDescription("Status for aktiviteten."));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Årsag til aktivitetens status."));
                Subject = group.Add(new VocabularyKey("subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Emne").WithDescription("\"Det emne, der er tilknyttet aktiviteten.\""));
                Transactioncurrencyid = group.Add(new VocabularyKey("transactioncurrencyid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Valuta").WithDescription("\"Entydigt id for den valuta, der er tilknyttet aktivitetspointeren.\""));
                Traversedpath = group.Add(new VocabularyKey("traversedpath", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gennemløbet sti").WithDescription("Kun til intern brug."));
            });
        }

        public VocabularyKey Activityadditionalparams { get; private set; }
        public VocabularyKey Activityid { get; private set; }
        public VocabularyKey Activitytypecode { get; private set; }
        public VocabularyKey Actualdurationminutes { get; private set; }
        public VocabularyKey Actualend { get; private set; }
        public VocabularyKey Actualstart { get; private set; }
        public VocabularyKey Allparties { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey Deliverylastattemptedon { get; private set; }
        public VocabularyKey Deliveryprioritycode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Exchangeitemid { get; private set; }
        public VocabularyKey Exchangerate { get; private set; }
        public VocabularyKey Exchangeweblink { get; private set; }
        public VocabularyKey Instancetypecode { get; private set; }
        public VocabularyKey Isbilled { get; private set; }
        public VocabularyKey Ismapiprivate { get; private set; }
        public VocabularyKey Isregularactivity { get; private set; }
        public VocabularyKey Isworkflowcreated { get; private set; }
        public VocabularyKey Lastonholdtime { get; private set; }
        public VocabularyKey Leftvoicemail { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Onholdtime { get; private set; }
        public VocabularyKey Postponeactivityprocessinguntil { get; private set; }
        public VocabularyKey Prioritycode { get; private set; }
        public VocabularyKey Processid { get; private set; }
        public VocabularyKey Regardingobjectid { get; private set; }
        public VocabularyKey Scheduleddurationminutes { get; private set; }
        public VocabularyKey Scheduledend { get; private set; }
        public VocabularyKey Scheduledstart { get; private set; }
        public VocabularyKey Sendermailboxid { get; private set; }
        public VocabularyKey Senton { get; private set; }
        public VocabularyKey Seriesid { get; private set; }
        public VocabularyKey Serviceid { get; private set; }
        public VocabularyKey Slaid { get; private set; }
        public VocabularyKey Slainvokedid { get; private set; }
        public VocabularyKey Sortdate { get; private set; }
        public VocabularyKey Stageid { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey Transactioncurrencyid { get; private set; }
        public VocabularyKey Traversedpath { get; private set; }
    }
}
