namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("SystemUser")]
    public class Systemuser
    {
        public Systemuser(SqlDataReader sqlReader)
        {
            Accessmode = sqlReader["accessmode"]?.ToString();
            Activedirectoryguid = sqlReader["activedirectoryguid"]?.ToString();
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
            Applicationid = sqlReader["applicationid"]?.ToString();
            Applicationiduri = sqlReader["applicationiduri"]?.ToString();
            Azureactivedirectoryobjectid = sqlReader["azureactivedirectoryobjectid"]?.ToString();
            Businessunitid = sqlReader["businessunitid"]?.ToString();
            Calendarid = sqlReader["calendarid"]?.ToString();
            Caltype = sqlReader["caltype"]?.ToString();
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            Defaultfilterspopulated = sqlReader["defaultfilterspopulated"]?.ToString();
            Defaultmailbox = sqlReader["defaultmailbox"]?.ToString();
            Defaultodbfoldername = sqlReader["defaultodbfoldername"]?.ToString();
            Disabledreason = sqlReader["disabledreason"]?.ToString();
            Displayinserviceviews = sqlReader["displayinserviceviews"]?.ToString();
            Domainname = sqlReader["domainname"]?.ToString();
            DynaInitialer = sqlReader["dyna_initialer"]?.ToString();
            Emailrouteraccessapproval = sqlReader["emailrouteraccessapproval"]?.ToString();
            Employeeid = sqlReader["employeeid"]?.ToString();
            Entityimage = sqlReader["entityimage"]?.ToString();
            Entityimageid = sqlReader["entityimageid"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Firstname = sqlReader["firstname"]?.ToString();
            Fullname = sqlReader["fullname"]?.ToString();
            Governmentid = sqlReader["governmentid"]?.ToString();
            Homephone = sqlReader["homephone"]?.ToString();
            Identityid = sqlReader["identityid"]?.ToString();
            Incomingemaildeliverymethod = sqlReader["incomingemaildeliverymethod"]?.ToString();
            Internalemailaddress = sqlReader["internalemailaddress"]?.ToString();
            Invitestatuscode = sqlReader["invitestatuscode"]?.ToString();
            Isactivedirectoryuser = sqlReader["isactivedirectoryuser"]?.ToString();
            Isdisabled = sqlReader["isdisabled"]?.ToString();
            Isemailaddressapprovedbyo365admin = sqlReader["isemailaddressapprovedbyo365admin"]?.ToString();
            Isintegrationuser = sqlReader["isintegrationuser"]?.ToString();
            Islicensed = sqlReader["islicensed"]?.ToString();
            Issyncwithdirectory = sqlReader["issyncwithdirectory"]?.ToString();
            Jobtitle = sqlReader["jobtitle"]?.ToString();
            Lastname = sqlReader["lastname"]?.ToString();
            Latestupdatetime = sqlReader["latestupdatetime"]?.ToString();
            Middlename = sqlReader["middlename"]?.ToString();
            Mobilealertemail = sqlReader["mobilealertemail"]?.ToString();
            Mobileofflineprofileid = sqlReader["mobileofflineprofileid"]?.ToString();
            Mobilephone = sqlReader["mobilephone"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            MsdynGdproptout = sqlReader["msdyn_gdproptout"]?.ToString();
            Nickname = sqlReader["nickname"]?.ToString();
            Organizationid = sqlReader["organizationid"]?.ToString();
            Outgoingemaildeliverymethod = sqlReader["outgoingemaildeliverymethod"]?.ToString();
            Parentsystemuserid = sqlReader["parentsystemuserid"]?.ToString();
            Passporthi = sqlReader["passporthi"]?.ToString();
            Passportlo = sqlReader["passportlo"]?.ToString();
            Personalemailaddress = sqlReader["personalemailaddress"]?.ToString();
            Photourl = sqlReader["photourl"]?.ToString();
            Positionid = sqlReader["positionid"]?.ToString();
            Preferredaddresscode = sqlReader["preferredaddresscode"]?.ToString();
            Preferredemailcode = sqlReader["preferredemailcode"]?.ToString();
            Preferredphonecode = sqlReader["preferredphonecode"]?.ToString();
            Processid = sqlReader["processid"]?.ToString();
            PtmPeruserlicensingdocumentscorepack = sqlReader["ptm_peruserlicensingdocumentscorepack"]?.ToString();
            PtmPeruserlicensingdocumentscorepackserver = sqlReader["ptm_peruserlicensingdocumentscorepackserver"]?.ToString();
            Queueid = sqlReader["queueid"]?.ToString();
            Salutation = sqlReader["salutation"]?.ToString();
            Setupuser = sqlReader["setupuser"]?.ToString();
            Sharepointemailaddress = sqlReader["sharepointemailaddress"]?.ToString();
            Siteid = sqlReader["siteid"]?.ToString();
            Skills = sqlReader["skills"]?.ToString();
            Stageid = sqlReader["stageid"]?.ToString();
            Systemuserid = sqlReader["systemuserid"]?.ToString();
            Territoryid = sqlReader["territoryid"]?.ToString();
            Title = sqlReader["title"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
            Traversedpath = sqlReader["traversedpath"]?.ToString();
            Userlicensetype = sqlReader["userlicensetype"]?.ToString();
            Userpuid = sqlReader["userpuid"]?.ToString();
            Windowsliveid = sqlReader["windowsliveid"]?.ToString();
            Yammeremailaddress = sqlReader["yammeremailaddress"]?.ToString();
            Yammeruserid = sqlReader["yammeruserid"]?.ToString();
        }

        public string Accessmode { get; private set; }
        public string Activedirectoryguid { get; private set; }
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
        public string Applicationid { get; private set; }
        public string Applicationiduri { get; private set; }
        public string Azureactivedirectoryobjectid { get; private set; }
        public string Businessunitid { get; private set; }
        public string Calendarid { get; private set; }
        public string Caltype { get; private set; }
        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string Defaultfilterspopulated { get; private set; }
        public string Defaultmailbox { get; private set; }
        public string Defaultodbfoldername { get; private set; }
        public string Disabledreason { get; private set; }
        public string Displayinserviceviews { get; private set; }
        public string Domainname { get; private set; }
        public string DynaInitialer { get; private set; }
        public string Emailrouteraccessapproval { get; private set; }
        public string Employeeid { get; private set; }
        public string Entityimage { get; private set; }
        public string Entityimageid { get; private set; }
        public string Exchangerate { get; private set; }
        public string Firstname { get; private set; }
        public string Fullname { get; private set; }
        public string Governmentid { get; private set; }
        public string Homephone { get; private set; }
        public string Identityid { get; private set; }
        public string Incomingemaildeliverymethod { get; private set; }
        public string Internalemailaddress { get; private set; }
        public string Invitestatuscode { get; private set; }
        public string Isactivedirectoryuser { get; private set; }
        public string Isdisabled { get; private set; }
        public string Isemailaddressapprovedbyo365admin { get; private set; }
        public string Isintegrationuser { get; private set; }
        public string Islicensed { get; private set; }
        public string Issyncwithdirectory { get; private set; }
        public string Jobtitle { get; private set; }
        public string Lastname { get; private set; }
        public string Latestupdatetime { get; private set; }
        public string Middlename { get; private set; }
        public string Mobilealertemail { get; private set; }
        public string Mobileofflineprofileid { get; private set; }
        public string Mobilephone { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string MsdynGdproptout { get; private set; }
        public string Nickname { get; private set; }
        public string Organizationid { get; private set; }
        public string Outgoingemaildeliverymethod { get; private set; }
        public string Parentsystemuserid { get; private set; }
        public string Passporthi { get; private set; }
        public string Passportlo { get; private set; }
        public string Personalemailaddress { get; private set; }
        public string Photourl { get; private set; }
        public string Positionid { get; private set; }
        public string Preferredaddresscode { get; private set; }
        public string Preferredemailcode { get; private set; }
        public string Preferredphonecode { get; private set; }
        public string Processid { get; private set; }
        public string PtmPeruserlicensingdocumentscorepack { get; private set; }
        public string PtmPeruserlicensingdocumentscorepackserver { get; private set; }
        public string Queueid { get; private set; }
        public string Salutation { get; private set; }
        public string Setupuser { get; private set; }
        public string Sharepointemailaddress { get; private set; }
        public string Siteid { get; private set; }
        public string Skills { get; private set; }
        public string Stageid { get; private set; }
        public string Systemuserid { get; private set; }
        public string Territoryid { get; private set; }
        public string Title { get; private set; }
        public string Transactioncurrencyid { get; private set; }
        public string Traversedpath { get; private set; }
        public string Userlicensetype { get; private set; }
        public string Userpuid { get; private set; }
        public string Windowsliveid { get; private set; }
        public string Yammeremailaddress { get; private set; }
        public string Yammeruserid { get; private set; }
    }
}
