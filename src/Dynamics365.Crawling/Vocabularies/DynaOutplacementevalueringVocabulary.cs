using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Dynamics365.Vocabularies
{
    public class DynaOutplacementevalueringVocabulary : SimpleVocabulary
    {
        public DynaOutplacementevalueringVocabulary()
        {
            VocabularyName = "Dynamics365 DynaOutplacementevaluering"; // TODO: Set value
            KeyPrefix = "dynamics365.dyna_outplacementEvaluering"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Outplacement Evaluering"; // TODO: Check value

            AddGroup("Outplacement Evaluering Details", group =>
            {
                Createdby = group.Add(new VocabularyKey("createdby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet af").WithDescription("\"Entydigt id for den bruger, der oprettede posten.\""));
                Createdon = group.Add(new VocabularyKey("createdon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Oprettet").WithDescription("Dato og klokkeslæt for oprettelse af posten."));
                DynaEvalspg01 = group.Add(new VocabularyKey("dynaEvalspg01", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval spg 01"));
                DynaEvalspg01note = group.Add(new VocabularyKey("dynaEvalspg01note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval Spg 01 Note").WithDescription("Evaluerings note spørgsmål 1"));
                DynaEvalspg02 = group.Add(new VocabularyKey("dynaEvalspg02", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval spg 02"));
                DynaEvalspg02note = group.Add(new VocabularyKey("dynaEvalspg02note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval Spg 02 Note").WithDescription("Evaluerings note spørgsmål 2"));
                DynaEvalspg03 = group.Add(new VocabularyKey("dynaEvalspg03", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval spg 03"));
                DynaEvalspg03note = group.Add(new VocabularyKey("dynaEvalspg03note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval Spg 03 Note").WithDescription("Evaluerings note spørgsmål 3"));
                DynaEvalspg04 = group.Add(new VocabularyKey("dynaEvalspg04", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval spg 04"));
                DynaEvalspg04note = group.Add(new VocabularyKey("dynaEvalspg04note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval Spg 04 Note").WithDescription("Evaluerings note spørgsmål 4"));
                DynaEvalspg05 = group.Add(new VocabularyKey("dynaEvalspg05", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval spg 05"));
                DynaEvalspg05note = group.Add(new VocabularyKey("dynaEvalspg05note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Eval Spg 05 Note").WithDescription("Evaluerings note spørgsmål 5"));
                DynaEvalueringgennemsnit = group.Add(new VocabularyKey("dynaEvalueringgennemsnit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Evaluering Gennemsnit"));
                DynaImportguid = group.Add(new VocabularyKey("dynaImportguid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("ImportGUID"));
                DynaKontakpersonid = group.Add(new VocabularyKey("dynaKontakpersonid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Kontakperson"));
                DynaName = group.Add(new VocabularyKey("dynaName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Navn").WithDescription("Navnet på det brugerdefinerede objekt."));
                DynaOutplacementevalueringid = group.Add(new VocabularyKey("dynaOutplacementevalueringid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Outplacement Evaluering").WithDescription("Entydigt id for objektforekomster"));
                DynaOutplacementid = group.Add(new VocabularyKey("dynaOutplacementid", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Outplacement"));
                Emailaddress = group.Add(new VocabularyKey("emailaddress", VocabularyKeyDataType.Email, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("E-mail-adresse").WithDescription("Den primære e-mail-adresse for objektet."));
                Modifiedby = group.Add(new VocabularyKey("modifiedby", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret af").WithDescription("\"Entydigt id for den bruger, der ændrede posten.\""));
                Modifiedon = group.Add(new VocabularyKey("modifiedon", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Ændret").WithDescription("Dato og klokkeslæt for ændring af posten."));
                Statecode = group.Add(new VocabularyKey("statecode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Status").WithDescription("Status for Outplacement Evaluering"));
                Statuscode = group.Add(new VocabularyKey("statuscode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.HiddenInFrontendUI).WithDisplayName("Statusårsag").WithDescription("Årsag til statussen for Outplacement Evaluering"));
            });
        }

        public VocabularyKey Createdby { get; private set; }
        public VocabularyKey Createdon { get; private set; }
        public VocabularyKey DynaEvalspg01 { get; private set; }
        public VocabularyKey DynaEvalspg01note { get; private set; }
        public VocabularyKey DynaEvalspg02 { get; private set; }
        public VocabularyKey DynaEvalspg02note { get; private set; }
        public VocabularyKey DynaEvalspg03 { get; private set; }
        public VocabularyKey DynaEvalspg03note { get; private set; }
        public VocabularyKey DynaEvalspg04 { get; private set; }
        public VocabularyKey DynaEvalspg04note { get; private set; }
        public VocabularyKey DynaEvalspg05 { get; private set; }
        public VocabularyKey DynaEvalspg05note { get; private set; }
        public VocabularyKey DynaEvalueringgennemsnit { get; private set; }
        public VocabularyKey DynaImportguid { get; private set; }
        public VocabularyKey DynaKontakpersonid { get; private set; }
        public VocabularyKey DynaName { get; private set; }
        public VocabularyKey DynaOutplacementevalueringid { get; private set; }
        public VocabularyKey DynaOutplacementid { get; private set; }
        public VocabularyKey Emailaddress { get; private set; }
        public VocabularyKey Modifiedby { get; private set; }
        public VocabularyKey Modifiedon { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
    }
}
