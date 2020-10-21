namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("dyna_outplacementEvaluering")]
    public class DynaOutplacementEvaluering
    {
        public DynaOutplacementEvaluering(SqlDataReader sqlReader)
        {
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            DynaEvalspg01 = sqlReader["dyna_evalspg01"]?.ToString();
            DynaEvalspg01note = sqlReader["dyna_evalspg01note"]?.ToString();
            DynaEvalspg02 = sqlReader["dyna_evalspg02"]?.ToString();
            DynaEvalspg02note = sqlReader["dyna_evalspg02note"]?.ToString();
            DynaEvalspg03 = sqlReader["dyna_evalspg03"]?.ToString();
            DynaEvalspg03note = sqlReader["dyna_evalspg03note"]?.ToString();
            DynaEvalspg04 = sqlReader["dyna_evalspg04"]?.ToString();
            DynaEvalspg04note = sqlReader["dyna_evalspg04note"]?.ToString();
            DynaEvalspg05 = sqlReader["dyna_evalspg05"]?.ToString();
            DynaEvalspg05note = sqlReader["dyna_evalspg05note"]?.ToString();
            DynaEvalueringgennemsnit = sqlReader["dyna_evalueringgennemsnit"]?.ToString();
            DynaImportguid = sqlReader["dyna_importguid"]?.ToString();
            DynaKontakpersonid = sqlReader["dyna_kontakpersonid"]?.ToString();
            DynaName = sqlReader["dyna_name"]?.ToString();
            DynaOutplacementevalueringid = sqlReader["dyna_outplacementevalueringid"]?.ToString();
            DynaOutplacementid = sqlReader["dyna_outplacementid"]?.ToString();
            Emailaddress = sqlReader["emailaddress"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
        }

        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string DynaEvalspg01 { get; private set; }
        public string DynaEvalspg01note { get; private set; }
        public string DynaEvalspg02 { get; private set; }
        public string DynaEvalspg02note { get; private set; }
        public string DynaEvalspg03 { get; private set; }
        public string DynaEvalspg03note { get; private set; }
        public string DynaEvalspg04 { get; private set; }
        public string DynaEvalspg04note { get; private set; }
        public string DynaEvalspg05 { get; private set; }
        public string DynaEvalspg05note { get; private set; }
        public string DynaEvalueringgennemsnit { get; private set; }
        public string DynaImportguid { get; private set; }
        public string DynaKontakpersonid { get; private set; }
        public string DynaName { get; private set; }
        public string DynaOutplacementevalueringid { get; private set; }
        public string DynaOutplacementid { get; private set; }
        public string Emailaddress { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
    }
}
