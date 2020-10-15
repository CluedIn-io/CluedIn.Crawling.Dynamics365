namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("Lead")]
    public class Lead
    {
        public Lead(SqlDataReader sqlReader)
        {
            Accountid = sqlReader["accountid"]?.ToString();
            Address1Addresstypecode = sqlReader["address1_addresstypecode"]?.ToString();
            Address1City = sqlReader["address1_city"]?.ToString();
            Address1Composite = sqlReader["address1_composite"]?.ToString();
            Address1Country = sqlReader["address1_country"]?.ToString();
            Address1County = sqlReader["address1_county"]?.ToString();
            Address1Fax = sqlReader["address1_fax"]?.ToString();
            Address1Latitude = sqlReader["address1_latitude"]?.ToString();
            Address1Line1 = sqlReader["address1_line1"]?.ToString();
            Address1Line2 = sqlReader["address1_line2"]?.ToString();
            Address1Line3 = sqlReader["address1_line3"]?.ToString();
            Address1Longitude = sqlReader["address1_longitude"]?.ToString();
            Address1Name = sqlReader["address1_name"]?.ToString();
            Address1Postalcode = sqlReader["address1_postalcode"]?.ToString();
            Address1Postofficebox = sqlReader["address1_postofficebox"]?.ToString();
            Address1Shippingmethodcode = sqlReader["address1_shippingmethodcode"]?.ToString();
            Address1Stateorprovince = sqlReader["address1_stateorprovince"]?.ToString();
            Address1Telephone1 = sqlReader["address1_telephone1"]?.ToString();
            Address1Telephone2 = sqlReader["address1_telephone2"]?.ToString();
            Address1Telephone3 = sqlReader["address1_telephone3"]?.ToString();
            Address1Upszone = sqlReader["address1_upszone"]?.ToString();
            Address2Addresstypecode = sqlReader["address2_addresstypecode"]?.ToString();
            Address2City = sqlReader["address2_city"]?.ToString();
            Address2Composite = sqlReader["address2_composite"]?.ToString();
            Address2Country = sqlReader["address2_country"]?.ToString();
            Address2County = sqlReader["address2_county"]?.ToString();
            Address2Fax = sqlReader["address2_fax"]?.ToString();
            Address2Latitude = sqlReader["address2_latitude"]?.ToString();
            Address2Line1 = sqlReader["address2_line1"]?.ToString();
            Address2Line2 = sqlReader["address2_line2"]?.ToString();
            Address2Line3 = sqlReader["address2_line3"]?.ToString();
            Address2Longitude = sqlReader["address2_longitude"]?.ToString();
            Address2Name = sqlReader["address2_name"]?.ToString();
            Address2Postalcode = sqlReader["address2_postalcode"]?.ToString();
            Address2Postofficebox = sqlReader["address2_postofficebox"]?.ToString();
            Address2Shippingmethodcode = sqlReader["address2_shippingmethodcode"]?.ToString();
            Address2Stateorprovince = sqlReader["address2_stateorprovince"]?.ToString();
            Address2Telephone1 = sqlReader["address2_telephone1"]?.ToString();
            Address2Telephone2 = sqlReader["address2_telephone2"]?.ToString();
            Address2Telephone3 = sqlReader["address2_telephone3"]?.ToString();
            Address2Upszone = sqlReader["address2_upszone"]?.ToString();
            Budgetamount = sqlReader["budgetamount"]?.ToString();
            BudgetamountBase = sqlReader["budgetamount_base"]?.ToString();
            Budgetstatus = sqlReader["budgetstatus"]?.ToString();
            Campaignid = sqlReader["campaignid"]?.ToString();
            Companyname = sqlReader["companyname"]?.ToString();
            Confirminterest = sqlReader["confirminterest"]?.ToString();
            Contactid = sqlReader["contactid"]?.ToString();
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            Customerid = sqlReader["customerid"]?.ToString();
            Customeridtype = sqlReader["customeridtype"]?.ToString();
            Decisionmaker = sqlReader["decisionmaker"]?.ToString();
            Description = sqlReader["description"]?.ToString();
            Donotbulkemail = sqlReader["donotbulkemail"]?.ToString();
            Donotemail = sqlReader["donotemail"]?.ToString();
            Donotfax = sqlReader["donotfax"]?.ToString();
            Donotphone = sqlReader["donotphone"]?.ToString();
            Donotpostalmail = sqlReader["donotpostalmail"]?.ToString();
            Donotsendmm = sqlReader["donotsendmm"]?.ToString();
            DynaExistingopportunity = sqlReader["dyna_existingopportunity"]?.ToString();
            DynaHenvisendekonsulent = sqlReader["dyna_henvisendekonsulent"]?.ToString();
            DynaKommentar = sqlReader["dyna_kommentar"]?.ToString();
            DynaKursus = sqlReader["dyna_kursus"]?.ToString();
            DynaKursustype = sqlReader["dyna_kursustype"]?.ToString();
            DynaLastemail = sqlReader["dyna_lastemail"]?.ToString();
            DynaLastemaildate = sqlReader["dyna_lastemaildate"]?.ToString();
            DynaLastphonecall = sqlReader["dyna_lastphonecall"]?.ToString();
            DynaLastphonecalldate = sqlReader["dyna_lastphonecalldate"]?.ToString();
            DynaLinkedinprofil = sqlReader["dyna_linkedinprofil"]?.ToString();
            DynaNextcontact = sqlReader["dyna_nextcontact"]?.ToString();
            DynaProduktkategori = sqlReader["dyna_produktkategori"]?.ToString();
            DynaProduktkategoriInfoOutplacement = sqlReader["dyna_produktkategori_info_outplacement"]?.ToString();
            Emailaddress1 = sqlReader["emailaddress1"]?.ToString();
            Emailaddress2 = sqlReader["emailaddress2"]?.ToString();
            Emailaddress3 = sqlReader["emailaddress3"]?.ToString();
            Entityimage = sqlReader["entityimage"]?.ToString();
            Entityimageid = sqlReader["entityimageid"]?.ToString();
            Estimatedamount = sqlReader["estimatedamount"]?.ToString();
            EstimatedamountBase = sqlReader["estimatedamount_base"]?.ToString();
            Estimatedclosedate = sqlReader["estimatedclosedate"]?.ToString();
            Estimatedvalue = sqlReader["estimatedvalue"]?.ToString();
            Evaluatefit = sqlReader["evaluatefit"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Fax = sqlReader["fax"]?.ToString();
            Firstname = sqlReader["firstname"]?.ToString();
            Followemail = sqlReader["followemail"]?.ToString();
            Fullname = sqlReader["fullname"]?.ToString();
            Industrycode = sqlReader["industrycode"]?.ToString();
            Initialcommunication = sqlReader["initialcommunication"]?.ToString();
            Isautocreate = sqlReader["isautocreate"]?.ToString();
            Isprivate = sqlReader["isprivate"]?.ToString();
            Jobtitle = sqlReader["jobtitle"]?.ToString();
            Lastname = sqlReader["lastname"]?.ToString();
            Lastonholdtime = sqlReader["lastonholdtime"]?.ToString();
            Lastusedincampaign = sqlReader["lastusedincampaign"]?.ToString();
            Leadid = sqlReader["leadid"]?.ToString();
            Leadqualitycode = sqlReader["leadqualitycode"]?.ToString();
            Leadsourcecode = sqlReader["leadsourcecode"]?.ToString();
            Masterid = sqlReader["masterid"]?.ToString();
            Merged = sqlReader["merged"]?.ToString();
            Middlename = sqlReader["middlename"]?.ToString();
            Mobilephone = sqlReader["mobilephone"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            MsdynGdproptout = sqlReader["msdyn_gdproptout"]?.ToString();
            Need = sqlReader["need"]?.ToString();
            NnLastupdated = sqlReader["nn_lastupdated"]?.ToString();
            NnLinks = sqlReader["nn_links"]?.ToString();
            NnTdcid = sqlReader["nn_tdcid"]?.ToString();
            NnUpdateprotected = sqlReader["nn_updateprotected"]?.ToString();
            Numberofemployees = sqlReader["numberofemployees"]?.ToString();
            Onholdtime = sqlReader["onholdtime"]?.ToString();
            Originatingcaseid = sqlReader["originatingcaseid"]?.ToString();
            Pager = sqlReader["pager"]?.ToString();
            Parentaccountid = sqlReader["parentaccountid"]?.ToString();
            Parentcontactid = sqlReader["parentcontactid"]?.ToString();
            Participatesinworkflow = sqlReader["participatesinworkflow"]?.ToString();
            Preferredcontactmethodcode = sqlReader["preferredcontactmethodcode"]?.ToString();
            Prioritycode = sqlReader["prioritycode"]?.ToString();
            Processid = sqlReader["processid"]?.ToString();
            Purchaseprocess = sqlReader["purchaseprocess"]?.ToString();
            Purchasetimeframe = sqlReader["purchasetimeframe"]?.ToString();
            Qualificationcomments = sqlReader["qualificationcomments"]?.ToString();
            Qualifyingopportunityid = sqlReader["qualifyingopportunityid"]?.ToString();
            Relatedobjectid = sqlReader["relatedobjectid"]?.ToString();
            Revenue = sqlReader["revenue"]?.ToString();
            RevenueBase = sqlReader["revenue_base"]?.ToString();
            Salesstage = sqlReader["salesstage"]?.ToString();
            Salesstagecode = sqlReader["salesstagecode"]?.ToString();
            Salutation = sqlReader["salutation"]?.ToString();
            SchedulefollowupProspect = sqlReader["schedulefollowup_prospect"]?.ToString();
            SchedulefollowupQualify = sqlReader["schedulefollowup_qualify"]?.ToString();
            Sic = sqlReader["sic"]?.ToString();
            Slaid = sqlReader["slaid"]?.ToString();
            Slainvokedid = sqlReader["slainvokedid"]?.ToString();
            Stageid = sqlReader["stageid"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
            Subject = sqlReader["subject"]?.ToString();
            Telephone1 = sqlReader["telephone1"]?.ToString();
            Telephone2 = sqlReader["telephone2"]?.ToString();
            Telephone3 = sqlReader["telephone3"]?.ToString();
            Timespentbymeonemailandmeetings = sqlReader["timespentbymeonemailandmeetings"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
            Traversedpath = sqlReader["traversedpath"]?.ToString();
            Websiteurl = sqlReader["websiteurl"]?.ToString();
        }

        public string Accountid { get; private set; }
        public string Address1Addresstypecode { get; private set; }
        public string Address1City { get; private set; }
        public string Address1Composite { get; private set; }
        public string Address1Country { get; private set; }
        public string Address1County { get; private set; }
        public string Address1Fax { get; private set; }
        public string Address1Latitude { get; private set; }
        public string Address1Line1 { get; private set; }
        public string Address1Line2 { get; private set; }
        public string Address1Line3 { get; private set; }
        public string Address1Longitude { get; private set; }
        public string Address1Name { get; private set; }
        public string Address1Postalcode { get; private set; }
        public string Address1Postofficebox { get; private set; }
        public string Address1Shippingmethodcode { get; private set; }
        public string Address1Stateorprovince { get; private set; }
        public string Address1Telephone1 { get; private set; }
        public string Address1Telephone2 { get; private set; }
        public string Address1Telephone3 { get; private set; }
        public string Address1Upszone { get; private set; }
        public string Address2Addresstypecode { get; private set; }
        public string Address2City { get; private set; }
        public string Address2Composite { get; private set; }
        public string Address2Country { get; private set; }
        public string Address2County { get; private set; }
        public string Address2Fax { get; private set; }
        public string Address2Latitude { get; private set; }
        public string Address2Line1 { get; private set; }
        public string Address2Line2 { get; private set; }
        public string Address2Line3 { get; private set; }
        public string Address2Longitude { get; private set; }
        public string Address2Name { get; private set; }
        public string Address2Postalcode { get; private set; }
        public string Address2Postofficebox { get; private set; }
        public string Address2Shippingmethodcode { get; private set; }
        public string Address2Stateorprovince { get; private set; }
        public string Address2Telephone1 { get; private set; }
        public string Address2Telephone2 { get; private set; }
        public string Address2Telephone3 { get; private set; }
        public string Address2Upszone { get; private set; }
        public string Budgetamount { get; private set; }
        public string BudgetamountBase { get; private set; }
        public string Budgetstatus { get; private set; }
        public string Campaignid { get; private set; }
        public string Companyname { get; private set; }
        public string Confirminterest { get; private set; }
        public string Contactid { get; private set; }
        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string Customerid { get; private set; }
        public string Customeridtype { get; private set; }
        public string Decisionmaker { get; private set; }
        public string Description { get; private set; }
        public string Donotbulkemail { get; private set; }
        public string Donotemail { get; private set; }
        public string Donotfax { get; private set; }
        public string Donotphone { get; private set; }
        public string Donotpostalmail { get; private set; }
        public string Donotsendmm { get; private set; }
        public string DynaExistingopportunity { get; private set; }
        public string DynaHenvisendekonsulent { get; private set; }
        public string DynaKommentar { get; private set; }
        public string DynaKursus { get; private set; }
        public string DynaKursustype { get; private set; }
        public string DynaLastemail { get; private set; }
        public string DynaLastemaildate { get; private set; }
        public string DynaLastphonecall { get; private set; }
        public string DynaLastphonecalldate { get; private set; }
        public string DynaLinkedinprofil { get; private set; }
        public string DynaNextcontact { get; private set; }
        public string DynaProduktkategori { get; private set; }
        public string DynaProduktkategoriInfoOutplacement { get; private set; }
        public string Emailaddress1 { get; private set; }
        public string Emailaddress2 { get; private set; }
        public string Emailaddress3 { get; private set; }
        public string Entityimage { get; private set; }
        public string Entityimageid { get; private set; }
        public string Estimatedamount { get; private set; }
        public string EstimatedamountBase { get; private set; }
        public string Estimatedclosedate { get; private set; }
        public string Estimatedvalue { get; private set; }
        public string Evaluatefit { get; private set; }
        public string Exchangerate { get; private set; }
        public string Fax { get; private set; }
        public string Firstname { get; private set; }
        public string Followemail { get; private set; }
        public string Fullname { get; private set; }
        public string Industrycode { get; private set; }
        public string Initialcommunication { get; private set; }
        public string Isautocreate { get; private set; }
        public string Isprivate { get; private set; }
        public string Jobtitle { get; private set; }
        public string Lastname { get; private set; }
        public string Lastonholdtime { get; private set; }
        public string Lastusedincampaign { get; private set; }
        public string Leadid { get; private set; }
        public string Leadqualitycode { get; private set; }
        public string Leadsourcecode { get; private set; }
        public string Masterid { get; private set; }
        public string Merged { get; private set; }
        public string Middlename { get; private set; }
        public string Mobilephone { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string MsdynGdproptout { get; private set; }
        public string Need { get; private set; }
        public string NnLastupdated { get; private set; }
        public string NnLinks { get; private set; }
        public string NnTdcid { get; private set; }
        public string NnUpdateprotected { get; private set; }
        public string Numberofemployees { get; private set; }
        public string Onholdtime { get; private set; }
        public string Originatingcaseid { get; private set; }
        public string Pager { get; private set; }
        public string Parentaccountid { get; private set; }
        public string Parentcontactid { get; private set; }
        public string Participatesinworkflow { get; private set; }
        public string Preferredcontactmethodcode { get; private set; }
        public string Prioritycode { get; private set; }
        public string Processid { get; private set; }
        public string Purchaseprocess { get; private set; }
        public string Purchasetimeframe { get; private set; }
        public string Qualificationcomments { get; private set; }
        public string Qualifyingopportunityid { get; private set; }
        public string Relatedobjectid { get; private set; }
        public string Revenue { get; private set; }
        public string RevenueBase { get; private set; }
        public string Salesstage { get; private set; }
        public string Salesstagecode { get; private set; }
        public string Salutation { get; private set; }
        public string SchedulefollowupProspect { get; private set; }
        public string SchedulefollowupQualify { get; private set; }
        public string Sic { get; private set; }
        public string Slaid { get; private set; }
        public string Slainvokedid { get; private set; }
        public string Stageid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Subject { get; private set; }
        public string Telephone1 { get; private set; }
        public string Telephone2 { get; private set; }
        public string Telephone3 { get; private set; }
        public string Timespentbymeonemailandmeetings { get; private set; }
        public string Transactioncurrencyid { get; private set; }
        public string Traversedpath { get; private set; }
        public string Websiteurl { get; private set; }
    }
}
