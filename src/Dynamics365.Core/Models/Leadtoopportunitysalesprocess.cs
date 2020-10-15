namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("LeadToOpportunitySalesProcess")]
    public class Leadtoopportunitysalesprocess
    {
        public Leadtoopportunitysalesprocess(SqlDataReader sqlReader)
        {
            Activestageid = sqlReader["activestageid"]?.ToString();
            Activestagestartedon = sqlReader["activestagestartedon"]?.ToString();
            Businessprocessflowinstanceid = sqlReader["businessprocessflowinstanceid"]?.ToString();
            Completedon = sqlReader["completedon"]?.ToString();
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            Duration = sqlReader["duration"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Leadid = sqlReader["leadid"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Name = sqlReader["name"]?.ToString();
            Opportunityid = sqlReader["opportunityid"]?.ToString();
            Organizationid = sqlReader["organizationid"]?.ToString();
            Processid = sqlReader["processid"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
            Traversedpath = sqlReader["traversedpath"]?.ToString();
        }

        public string Activestageid { get; private set; }
        public string Activestagestartedon { get; private set; }
        public string Businessprocessflowinstanceid { get; private set; }
        public string Completedon { get; private set; }
        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string Duration { get; private set; }
        public string Exchangerate { get; private set; }
        public string Leadid { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Name { get; private set; }
        public string Opportunityid { get; private set; }
        public string Organizationid { get; private set; }
        public string Processid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Transactioncurrencyid { get; private set; }
        public string Traversedpath { get; private set; }
    }
}
