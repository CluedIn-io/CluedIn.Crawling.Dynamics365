namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("dyna_coursecustomer")]
    public class DynaCoursecustomer
    {
        public DynaCoursecustomer(SqlDataReader sqlReader)
        {
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            DynaAddressLine1 = sqlReader["dyna_address_line1"]?.ToString();
            DynaAddressLine2 = sqlReader["dyna_address_line2"]?.ToString();
            DynaApproved = sqlReader["dyna_approved"]?.ToString();
            DynaAttention = sqlReader["dyna_attention"]?.ToString();
            DynaCity = sqlReader["dyna_city"]?.ToString();
            DynaCountry = sqlReader["dyna_country"]?.ToString();
            DynaCoursecustomeraccountid = sqlReader["dyna_coursecustomeraccountid"]?.ToString();
            DynaCoursecustomercontactid = sqlReader["dyna_coursecustomercontactid"]?.ToString();
            DynaCoursecustomerid = sqlReader["dyna_coursecustomerid"]?.ToString();
            DynaCustomername = sqlReader["dyna_customername"]?.ToString();
            DynaCvrp = sqlReader["dyna_cvrp"]?.ToString();
            DynaCvrse = sqlReader["dyna_cvrse"]?.ToString();
            DynaDirty = sqlReader["dyna_dirty"]?.ToString();
            DynaEannummer = sqlReader["dyna_eannummer"]?.ToString();
            DynaEanpkrvet = sqlReader["dyna_eanpkrvet"]?.ToString();
            DynaEmail = sqlReader["dyna_email"]?.ToString();
            DynaFaktureringsemail = sqlReader["dyna_faktureringsemail"]?.ToString();
            DynaFax = sqlReader["dyna_fax"]?.ToString();
            DynaName = sqlReader["dyna_name"]?.ToString();
            DynaNavtemplateid = sqlReader["dyna_navtemplateid"]?.ToString();
            DynaPostalcode = sqlReader["dyna_postalcode"]?.ToString();
            DynaPrimarycustomer = sqlReader["dyna_primarycustomer"]?.ToString();
            DynaTelephone1 = sqlReader["dyna_telephone1"]?.ToString();
            DynaType = sqlReader["dyna_type"]?.ToString();
            DynaWebsted = sqlReader["dyna_websted"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
        }

        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string DynaAddressLine1 { get; private set; }
        public string DynaAddressLine2 { get; private set; }
        public string DynaApproved { get; private set; }
        public string DynaAttention { get; private set; }
        public string DynaCity { get; private set; }
        public string DynaCountry { get; private set; }
        public string DynaCoursecustomeraccountid { get; private set; }
        public string DynaCoursecustomercontactid { get; private set; }
        public string DynaCoursecustomerid { get; private set; }
        public string DynaCustomername { get; private set; }
        public string DynaCvrp { get; private set; }
        public string DynaCvrse { get; private set; }
        public string DynaDirty { get; private set; }
        public string DynaEannummer { get; private set; }
        public string DynaEanpkrvet { get; private set; }
        public string DynaEmail { get; private set; }
        public string DynaFaktureringsemail { get; private set; }
        public string DynaFax { get; private set; }
        public string DynaName { get; private set; }
        public string DynaNavtemplateid { get; private set; }
        public string DynaPostalcode { get; private set; }
        public string DynaPrimarycustomer { get; private set; }
        public string DynaTelephone1 { get; private set; }
        public string DynaType { get; private set; }
        public string DynaWebsted { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
    }
}
