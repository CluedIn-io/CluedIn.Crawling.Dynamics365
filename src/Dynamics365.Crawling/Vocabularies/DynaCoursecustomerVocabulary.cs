using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DynaCoursecustomerVocabulary : SimpleVocabulary
    {
        public DynaCoursecustomerVocabulary()
        {
            VocabularyName = "Dynamics365 DynaCoursecustomer"; // TODO: Set value
            KeyPrefix = "dynamics365.dyna_coursecustomer"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Kursusdeltager"; // TODO: Check value

            AddGroup("Kursusdeltager Details", group =>
            {
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet").WithDescription("Dato og klokkeslæt for oprettelsen af posten."));
                DynaAddressLine1 = group.Add(new VocabularyKey("dynaAddressLine1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gade 1"));
                DynaAddressLine2 = group.Add(new VocabularyKey("dynaAddressLine2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Gade 2"));
                DynaApproved = group.Add(new VocabularyKey("dynaApproved", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Godkendt i NAV"));
                DynaAttention = group.Add(new VocabularyKey("dynaAttention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Att:"));
                DynaCity = group.Add(new VocabularyKey("dynaCity", VocabularyKeyDataType.GeographyCity, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("By"));
                DynaCountry = group.Add(new VocabularyKey("dynaCountry", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Land").WithDescription("Entydigt id for Land tilknyttet Debitor."));
                DynaCoursecustomeraccountid = group.Add(new VocabularyKey("dynaCoursecustomeraccountid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor ( Firma )").WithDescription("Entydigt id for Firma tilknyttet Debitor."));
                DynaCoursecustomercontactid = group.Add(new VocabularyKey("dynaCoursecustomercontactid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor ( Kontakt )").WithDescription("Entydigt id for Kontaktperson tilknyttet Debitor."));
                DynaCoursecustomerid = group.Add(new VocabularyKey("dynaCoursecustomerid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor").WithDescription("Entydigt id for Kursuskunde debitor"));
                DynaCustomername = group.Add(new VocabularyKey("dynaCustomername", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn"));
                DynaCvrp = group.Add(new VocabularyKey("dynaCvrp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR-P"));
                DynaCvrse = group.Add(new VocabularyKey("dynaCvrse", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("CVR"));
                DynaDirty = group.Add(new VocabularyKey("dynaDirty", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Dirty"));
                DynaEannummer = group.Add(new VocabularyKey("dynaEannummer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("EAN-Nummer"));
                DynaEanpkrvet = group.Add(new VocabularyKey("dynaEanpkrvet", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("EAN Påkrævet"));
                DynaEmail = group.Add(new VocabularyKey("dynaEmail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("E-mail"));
                DynaFaktureringsemail = group.Add(new VocabularyKey("dynaFaktureringsemail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fakturerings Email").WithDescription("Den email som skal benyttes til at sende faktura på email."));
                DynaFax = group.Add(new VocabularyKey("dynaFax", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Fax"));
                DynaName = group.Add(new VocabularyKey("dynaName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("ID").WithDescription("Navnet på det brugerdefinerede objekt."));
                DynaNavtemplateid = group.Add(new VocabularyKey("dynaNavtemplateid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Debitor Opsætning").WithDescription("Entydigt id for Nav Skabelon tilknyttet Debitor."));
                DynaPostalcode = group.Add(new VocabularyKey("dynaPostalcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Postnummer"));
                DynaPrimarycustomer = group.Add(new VocabularyKey("dynaPrimarycustomer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær Faktureringsenhed"));
                DynaTelephone1 = group.Add(new VocabularyKey("dynaTelephone1", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Primær telefon"));
                DynaType = group.Add(new VocabularyKey("dynaType", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Type"));
                DynaWebsted = group.Add(new VocabularyKey("dynaWebsted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Websted"));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("Dato og klokkeslæt for ændring af posten."));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("Status for Debitor"));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Årsag til statussen for Debitor"));
            });
        }

        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey DynaAddressLine1 { get; private set; }
        public VocabularyKey DynaAddressLine2 { get; private set; }
        public VocabularyKey DynaApproved { get; private set; }
        public VocabularyKey DynaAttention { get; private set; }
        public VocabularyKey DynaCity { get; private set; }
        public VocabularyKey DynaCountry { get; private set; }
        public VocabularyKey DynaCoursecustomeraccountid { get; private set; }
        public VocabularyKey DynaCoursecustomercontactid { get; private set; }
        public VocabularyKey DynaCoursecustomerid { get; private set; }
        public VocabularyKey DynaCustomername { get; private set; }
        public VocabularyKey DynaCvrp { get; private set; }
        public VocabularyKey DynaCvrse { get; private set; }
        public VocabularyKey DynaDirty { get; private set; }
        public VocabularyKey DynaEannummer { get; private set; }
        public VocabularyKey DynaEanpkrvet { get; private set; }
        public VocabularyKey DynaEmail { get; private set; }
        public VocabularyKey DynaFaktureringsemail { get; private set; }
        public VocabularyKey DynaFax { get; private set; }
        public VocabularyKey DynaName { get; private set; }
        public VocabularyKey DynaNavtemplateid { get; private set; }
        public VocabularyKey DynaPostalcode { get; private set; }
        public VocabularyKey DynaPrimarycustomer { get; private set; }
        public VocabularyKey DynaTelephone1 { get; private set; }
        public VocabularyKey DynaType { get; private set; }
        public VocabularyKey DynaWebsted { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
    }
}
