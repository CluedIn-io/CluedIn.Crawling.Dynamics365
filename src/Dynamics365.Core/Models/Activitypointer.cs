namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("ActivityPointer")]
    public class Activitypointer
    {
        public Activitypointer(SqlDataReader sqlReader)
        {
            Activityadditionalparams = sqlReader["activityadditionalparams"]?.ToString();
            Activityid = sqlReader["activityid"]?.ToString();
            Activitytypecode = sqlReader["activitytypecode"]?.ToString();
            Actualdurationminutes = sqlReader["actualdurationminutes"]?.ToString();
            Actualend = sqlReader["actualend"]?.ToString();
            Actualstart = sqlReader["actualstart"]?.ToString();
            Allparties = sqlReader["allparties"]?.ToString();
            Community = sqlReader["community"]?.ToString();
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            Deliverylastattemptedon = sqlReader["deliverylastattemptedon"]?.ToString();
            Deliveryprioritycode = sqlReader["deliveryprioritycode"]?.ToString();
            Description = sqlReader["description"]?.ToString();
            Exchangeitemid = sqlReader["exchangeitemid"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Exchangeweblink = sqlReader["exchangeweblink"]?.ToString();
            Instancetypecode = sqlReader["instancetypecode"]?.ToString();
            Isbilled = sqlReader["isbilled"]?.ToString();
            Ismapiprivate = sqlReader["ismapiprivate"]?.ToString();
            Isregularactivity = sqlReader["isregularactivity"]?.ToString();
            Isworkflowcreated = sqlReader["isworkflowcreated"]?.ToString();
            Lastonholdtime = sqlReader["lastonholdtime"]?.ToString();
            Leftvoicemail = sqlReader["leftvoicemail"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Onholdtime = sqlReader["onholdtime"]?.ToString();
            Postponeactivityprocessinguntil = sqlReader["postponeactivityprocessinguntil"]?.ToString();
            Prioritycode = sqlReader["prioritycode"]?.ToString();
            Processid = sqlReader["processid"]?.ToString();
            Regardingobjectid = sqlReader["regardingobjectid"]?.ToString();
            Scheduleddurationminutes = sqlReader["scheduleddurationminutes"]?.ToString();
            Scheduledend = sqlReader["scheduledend"]?.ToString();
            Scheduledstart = sqlReader["scheduledstart"]?.ToString();
            Sendermailboxid = sqlReader["sendermailboxid"]?.ToString();
            Senton = sqlReader["senton"]?.ToString();
            Seriesid = sqlReader["seriesid"]?.ToString();
            Serviceid = sqlReader["serviceid"]?.ToString();
            Slaid = sqlReader["slaid"]?.ToString();
            Slainvokedid = sqlReader["slainvokedid"]?.ToString();
            Sortdate = sqlReader["sortdate"]?.ToString();
            Stageid = sqlReader["stageid"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
            Subject = sqlReader["subject"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
            Traversedpath = sqlReader["traversedpath"]?.ToString();
        }

        public string Activityadditionalparams { get; private set; }
        public string Activityid { get; private set; }
        public string Activitytypecode { get; private set; }
        public string Actualdurationminutes { get; private set; }
        public string Actualend { get; private set; }
        public string Actualstart { get; private set; }
        public string Allparties { get; private set; }
        public string Community { get; private set; }
        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string Deliverylastattemptedon { get; private set; }
        public string Deliveryprioritycode { get; private set; }
        public string Description { get; private set; }
        public string Exchangeitemid { get; private set; }
        public string Exchangerate { get; private set; }
        public string Exchangeweblink { get; private set; }
        public string Instancetypecode { get; private set; }
        public string Isbilled { get; private set; }
        public string Ismapiprivate { get; private set; }
        public string Isregularactivity { get; private set; }
        public string Isworkflowcreated { get; private set; }
        public string Lastonholdtime { get; private set; }
        public string Leftvoicemail { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Onholdtime { get; private set; }
        public string Postponeactivityprocessinguntil { get; private set; }
        public string Prioritycode { get; private set; }
        public string Processid { get; private set; }
        public string Regardingobjectid { get; private set; }
        public string Scheduleddurationminutes { get; private set; }
        public string Scheduledend { get; private set; }
        public string Scheduledstart { get; private set; }
        public string Sendermailboxid { get; private set; }
        public string Senton { get; private set; }
        public string Seriesid { get; private set; }
        public string Serviceid { get; private set; }
        public string Slaid { get; private set; }
        public string Slainvokedid { get; private set; }
        public string Sortdate { get; private set; }
        public string Stageid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Subject { get; private set; }
        public string Transactioncurrencyid { get; private set; }
        public string Traversedpath { get; private set; }
    }
}
