namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("Contact")]
    public class Contact
    {
        public Contact(SqlDataReader sqlReader)
        {
            Accountid = sqlReader["accountid"]?.ToString();
            Accountrolecode = sqlReader["accountrolecode"]?.ToString();
            Address1Addresstypecode = sqlReader["address1_addresstypecode"]?.ToString();
            Address1City = sqlReader["address1_city"]?.ToString();
            Address1Composite = sqlReader["address1_composite"]?.ToString();
            Address1Country = sqlReader["address1_country"]?.ToString();
            Address1County = sqlReader["address1_county"]?.ToString();
            Address1Fax = sqlReader["address1_fax"]?.ToString();
            Address1Freighttermscode = sqlReader["address1_freighttermscode"]?.ToString();
            Address1Latitude = sqlReader["address1_latitude"]?.ToString();
            Address1Line1 = sqlReader["address1_line1"]?.ToString();
            Address1Line2 = sqlReader["address1_line2"]?.ToString();
            Address1Line3 = sqlReader["address1_line3"]?.ToString();
            Address1Longitude = sqlReader["address1_longitude"]?.ToString();
            Address1Name = sqlReader["address1_name"]?.ToString();
            Address1Postalcode = sqlReader["address1_postalcode"]?.ToString();
            Address1Postofficebox = sqlReader["address1_postofficebox"]?.ToString();
            Address1Primarycontactname = sqlReader["address1_primarycontactname"]?.ToString();
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
            Address2Freighttermscode = sqlReader["address2_freighttermscode"]?.ToString();
            Address2Latitude = sqlReader["address2_latitude"]?.ToString();
            Address2Line1 = sqlReader["address2_line1"]?.ToString();
            Address2Line2 = sqlReader["address2_line2"]?.ToString();
            Address2Line3 = sqlReader["address2_line3"]?.ToString();
            Address2Longitude = sqlReader["address2_longitude"]?.ToString();
            Address2Name = sqlReader["address2_name"]?.ToString();
            Address2Postalcode = sqlReader["address2_postalcode"]?.ToString();
            Address2Postofficebox = sqlReader["address2_postofficebox"]?.ToString();
            Address2Primarycontactname = sqlReader["address2_primarycontactname"]?.ToString();
            Address2Shippingmethodcode = sqlReader["address2_shippingmethodcode"]?.ToString();
            Address2Stateorprovince = sqlReader["address2_stateorprovince"]?.ToString();
            Address2Telephone1 = sqlReader["address2_telephone1"]?.ToString();
            Address2Telephone2 = sqlReader["address2_telephone2"]?.ToString();
            Address2Telephone3 = sqlReader["address2_telephone3"]?.ToString();
            Address2Upszone = sqlReader["address2_upszone"]?.ToString();
            Address3Addresstypecode = sqlReader["address3_addresstypecode"]?.ToString();
            Address3City = sqlReader["address3_city"]?.ToString();
            Address3Composite = sqlReader["address3_composite"]?.ToString();
            Address3Country = sqlReader["address3_country"]?.ToString();
            Address3County = sqlReader["address3_county"]?.ToString();
            Address3Fax = sqlReader["address3_fax"]?.ToString();
            Address3Freighttermscode = sqlReader["address3_freighttermscode"]?.ToString();
            Address3Latitude = sqlReader["address3_latitude"]?.ToString();
            Address3Line1 = sqlReader["address3_line1"]?.ToString();
            Address3Line2 = sqlReader["address3_line2"]?.ToString();
            Address3Line3 = sqlReader["address3_line3"]?.ToString();
            Address3Longitude = sqlReader["address3_longitude"]?.ToString();
            Address3Name = sqlReader["address3_name"]?.ToString();
            Address3Postalcode = sqlReader["address3_postalcode"]?.ToString();
            Address3Postofficebox = sqlReader["address3_postofficebox"]?.ToString();
            Address3Primarycontactname = sqlReader["address3_primarycontactname"]?.ToString();
            Address3Shippingmethodcode = sqlReader["address3_shippingmethodcode"]?.ToString();
            Address3Stateorprovince = sqlReader["address3_stateorprovince"]?.ToString();
            Address3Telephone1 = sqlReader["address3_telephone1"]?.ToString();
            Address3Telephone2 = sqlReader["address3_telephone2"]?.ToString();
            Address3Telephone3 = sqlReader["address3_telephone3"]?.ToString();
            Address3Upszone = sqlReader["address3_upszone"]?.ToString();
            Aging30 = sqlReader["aging30"]?.ToString();
            Aging30Base = sqlReader["aging30_base"]?.ToString();
            Aging60 = sqlReader["aging60"]?.ToString();
            Aging60Base = sqlReader["aging60_base"]?.ToString();
            Aging90 = sqlReader["aging90"]?.ToString();
            Aging90Base = sqlReader["aging90_base"]?.ToString();
            Anniversary = sqlReader["anniversary"]?.ToString();
            Annualincome = sqlReader["annualincome"]?.ToString();
            AnnualincomeBase = sqlReader["annualincome_base"]?.ToString();
            Assistantname = sqlReader["assistantname"]?.ToString();
            Assistantphone = sqlReader["assistantphone"]?.ToString();
            Birthdate = sqlReader["birthdate"]?.ToString();
            Business2 = sqlReader["business2"]?.ToString();
            Callback = sqlReader["callback"]?.ToString();
            Childrensnames = sqlReader["childrensnames"]?.ToString();
            Company = sqlReader["company"]?.ToString();
            Contactid = sqlReader["contactid"]?.ToString();
            Createdby = sqlReader["createdby"]?.ToString();
            Createdbyexternalparty = sqlReader["createdbyexternalparty"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            Creditlimit = sqlReader["creditlimit"]?.ToString();
            CreditlimitBase = sqlReader["creditlimit_base"]?.ToString();
            Creditonhold = sqlReader["creditonhold"]?.ToString();
            Customersizecode = sqlReader["customersizecode"]?.ToString();
            Customertypecode = sqlReader["customertypecode"]?.ToString();
            Defaultpricelevelid = sqlReader["defaultpricelevelid"]?.ToString();
            Department = sqlReader["department"]?.ToString();
            Description = sqlReader["description"]?.ToString();
            Donotbulkemail = sqlReader["donotbulkemail"]?.ToString();
            Donotbulkpostalmail = sqlReader["donotbulkpostalmail"]?.ToString();
            Donotemail = sqlReader["donotemail"]?.ToString();
            Donotfax = sqlReader["donotfax"]?.ToString();
            Donotphone = sqlReader["donotphone"]?.ToString();
            Donotpostalmail = sqlReader["donotpostalmail"]?.ToString();
            Donotsendmm = sqlReader["donotsendmm"]?.ToString();
            DynaAnsttelselsesforhold = sqlReader["dyna_ansttelselsesforhold"]?.ToString();
            DynaCoaching = sqlReader["dyna_coaching"]?.ToString();
            DynaContactid = sqlReader["dyna_contactid"]?.ToString();
            DynaContactidnr = sqlReader["dyna_contactidnr"]?.ToString();
            DynaCountry = sqlReader["dyna_country"]?.ToString();
            DynaCoursecustomer = sqlReader["dyna_coursecustomer"]?.ToString();
            DynaCustomerbeingcreated = sqlReader["dyna_customerbeingcreated"]?.ToString();
            DynaDelingmedlho = sqlReader["dyna_delingmedlho"]?.ToString();
            DynaEmail2 = sqlReader["dyna_email2"]?.ToString();
            DynaEmailopdateretdato = sqlReader["dyna_emailopdateretdato"]?.ToString();
            DynaGodkendinav = sqlReader["dyna_godkendinav"]?.ToString();
            DynaKonsulent = sqlReader["dyna_konsulent"]?.ToString();
            DynaKontaktpersonid = sqlReader["dyna_kontaktpersonid"]?.ToString();
            DynaLedernecontactguid = sqlReader["dyna_ledernecontactguid"]?.ToString();
            DynaLedernemandag = sqlReader["dyna_ledernemandag"]?.ToString();
            DynaLedernemedlem = sqlReader["dyna_ledernemedlem"]?.ToString();
            DynaLmcKontakt = sqlReader["dyna_lmc_kontakt"]?.ToString();
            DynaLmcKontaktnote = sqlReader["dyna_lmc_kontaktnote"]?.ToString();
            DynaLmsadgang = sqlReader["dyna_lmsadgang"]?.ToString();
            DynaMedlemsnummer = sqlReader["dyna_medlemsnummer"]?.ToString();
            DynaNavid = sqlReader["dyna_navid"]?.ToString();
            DynaNavtemplateid = sqlReader["dyna_navtemplateid"]?.ToString();
            DynaNetvaerkKandidat = sqlReader["dyna_netvaerk_kandidat"]?.ToString();
            DynaNytfraledelseidagdk = sqlReader["dyna_nytfraledelseidagdk"]?.ToString();
            DynaOldiddebitor = sqlReader["dyna_oldiddebitor"]?.ToString();
            DynaOldiddeltager = sqlReader["dyna_oldiddeltager"]?.ToString();
            DynaOldidinstruktr = sqlReader["dyna_oldidinstruktr"]?.ToString();
            DynaOutplacement = sqlReader["dyna_outplacement"]?.ToString();
            DynaPersonid = sqlReader["dyna_personid"]?.ToString();
            DynaSendnyhedsbrev = sqlReader["dyna_sendnyhedsbrev"]?.ToString();
            DynaTotalamount = sqlReader["dyna_totalamount"]?.ToString();
            DynaUk = sqlReader["dyna_uk"]?.ToString();
            DynaUnderviser = sqlReader["dyna_underviser"]?.ToString();
            DynaUndervisernote = sqlReader["dyna_undervisernote"]?.ToString();
            DynaVip = sqlReader["dyna_vip"]?.ToString();
            Educationcode = sqlReader["educationcode"]?.ToString();
            Emailaddress1 = sqlReader["emailaddress1"]?.ToString();
            Emailaddress2 = sqlReader["emailaddress2"]?.ToString();
            Emailaddress3 = sqlReader["emailaddress3"]?.ToString();
            Employeeid = sqlReader["employeeid"]?.ToString();
            Entityimage = sqlReader["entityimage"]?.ToString();
            Entityimageid = sqlReader["entityimageid"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Externaluseridentifier = sqlReader["externaluseridentifier"]?.ToString();
            Familystatuscode = sqlReader["familystatuscode"]?.ToString();
            Fax = sqlReader["fax"]?.ToString();
            Firstname = sqlReader["firstname"]?.ToString();
            Followemail = sqlReader["followemail"]?.ToString();
            Ftpsiteurl = sqlReader["ftpsiteurl"]?.ToString();
            Fullname = sqlReader["fullname"]?.ToString();
            Gendercode = sqlReader["gendercode"]?.ToString();
            Governmentid = sqlReader["governmentid"]?.ToString();
            Haschildrencode = sqlReader["haschildrencode"]?.ToString();
            Home2 = sqlReader["home2"]?.ToString();
            Isautocreate = sqlReader["isautocreate"]?.ToString();
            Isbackofficecustomer = sqlReader["isbackofficecustomer"]?.ToString();
            Jobtitle = sqlReader["jobtitle"]?.ToString();
            Lastname = sqlReader["lastname"]?.ToString();
            Lastonholdtime = sqlReader["lastonholdtime"]?.ToString();
            Lastusedincampaign = sqlReader["lastusedincampaign"]?.ToString();
            Leadsourcecode = sqlReader["leadsourcecode"]?.ToString();
            Managername = sqlReader["managername"]?.ToString();
            Managerphone = sqlReader["managerphone"]?.ToString();
            Marketingonly = sqlReader["marketingonly"]?.ToString();
            Masterid = sqlReader["masterid"]?.ToString();
            Merged = sqlReader["merged"]?.ToString();
            Middlename = sqlReader["middlename"]?.ToString();
            Mobilephone = sqlReader["mobilephone"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedbyexternalparty = sqlReader["modifiedbyexternalparty"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            MsdynGdproptout = sqlReader["msdyn_gdproptout"]?.ToString();
            Nickname = sqlReader["nickname"]?.ToString();
            NnNndecisionmakerid = sqlReader["nn_nndecisionmakerid"]?.ToString();
            NnUpdateprotected = sqlReader["nn_updateprotected"]?.ToString();
            Numberofchildren = sqlReader["numberofchildren"]?.ToString();
            Onholdtime = sqlReader["onholdtime"]?.ToString();
            Originatingleadid = sqlReader["originatingleadid"]?.ToString();
            Pager = sqlReader["pager"]?.ToString();
            Parentcontactid = sqlReader["parentcontactid"]?.ToString();
            Parentcustomerid = sqlReader["parentcustomerid"]?.ToString();
            Parentcustomeridtype = sqlReader["parentcustomeridtype"]?.ToString();
            Participatesinworkflow = sqlReader["participatesinworkflow"]?.ToString();
            Paymenttermscode = sqlReader["paymenttermscode"]?.ToString();
            Preferredappointmentdaycode = sqlReader["preferredappointmentdaycode"]?.ToString();
            Preferredappointmenttimecode = sqlReader["preferredappointmenttimecode"]?.ToString();
            Preferredcontactmethodcode = sqlReader["preferredcontactmethodcode"]?.ToString();
            Preferredequipmentid = sqlReader["preferredequipmentid"]?.ToString();
            Preferredserviceid = sqlReader["preferredserviceid"]?.ToString();
            Preferredsystemuserid = sqlReader["preferredsystemuserid"]?.ToString();
            Processid = sqlReader["processid"]?.ToString();
            Salutation = sqlReader["salutation"]?.ToString();
            Shippingmethodcode = sqlReader["shippingmethodcode"]?.ToString();
            Slaid = sqlReader["slaid"]?.ToString();
            Slainvokedid = sqlReader["slainvokedid"]?.ToString();
            Spousesname = sqlReader["spousesname"]?.ToString();
            Stageid = sqlReader["stageid"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
            Subscriptionid = sqlReader["subscriptionid"]?.ToString();
            Suffix = sqlReader["suffix"]?.ToString();
            Telephone1 = sqlReader["telephone1"]?.ToString();
            Telephone2 = sqlReader["telephone2"]?.ToString();
            Telephone3 = sqlReader["telephone3"]?.ToString();
            Territorycode = sqlReader["territorycode"]?.ToString();
            Timespentbymeonemailandmeetings = sqlReader["timespentbymeonemailandmeetings"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
            Traversedpath = sqlReader["traversedpath"]?.ToString();
            Websiteurl = sqlReader["websiteurl"]?.ToString();
        }

        public string Accountid { get; private set; }
        public string Accountrolecode { get; private set; }
        public string Address1Addresstypecode { get; private set; }
        public string Address1City { get; private set; }
        public string Address1Composite { get; private set; }
        public string Address1Country { get; private set; }
        public string Address1County { get; private set; }
        public string Address1Fax { get; private set; }
        public string Address1Freighttermscode { get; private set; }
        public string Address1Latitude { get; private set; }
        public string Address1Line1 { get; private set; }
        public string Address1Line2 { get; private set; }
        public string Address1Line3 { get; private set; }
        public string Address1Longitude { get; private set; }
        public string Address1Name { get; private set; }
        public string Address1Postalcode { get; private set; }
        public string Address1Postofficebox { get; private set; }
        public string Address1Primarycontactname { get; private set; }
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
        public string Address2Freighttermscode { get; private set; }
        public string Address2Latitude { get; private set; }
        public string Address2Line1 { get; private set; }
        public string Address2Line2 { get; private set; }
        public string Address2Line3 { get; private set; }
        public string Address2Longitude { get; private set; }
        public string Address2Name { get; private set; }
        public string Address2Postalcode { get; private set; }
        public string Address2Postofficebox { get; private set; }
        public string Address2Primarycontactname { get; private set; }
        public string Address2Shippingmethodcode { get; private set; }
        public string Address2Stateorprovince { get; private set; }
        public string Address2Telephone1 { get; private set; }
        public string Address2Telephone2 { get; private set; }
        public string Address2Telephone3 { get; private set; }
        public string Address2Upszone { get; private set; }
        public string Address3Addresstypecode { get; private set; }
        public string Address3City { get; private set; }
        public string Address3Composite { get; private set; }
        public string Address3Country { get; private set; }
        public string Address3County { get; private set; }
        public string Address3Fax { get; private set; }
        public string Address3Freighttermscode { get; private set; }
        public string Address3Latitude { get; private set; }
        public string Address3Line1 { get; private set; }
        public string Address3Line2 { get; private set; }
        public string Address3Line3 { get; private set; }
        public string Address3Longitude { get; private set; }
        public string Address3Name { get; private set; }
        public string Address3Postalcode { get; private set; }
        public string Address3Postofficebox { get; private set; }
        public string Address3Primarycontactname { get; private set; }
        public string Address3Shippingmethodcode { get; private set; }
        public string Address3Stateorprovince { get; private set; }
        public string Address3Telephone1 { get; private set; }
        public string Address3Telephone2 { get; private set; }
        public string Address3Telephone3 { get; private set; }
        public string Address3Upszone { get; private set; }
        public string Aging30 { get; private set; }
        public string Aging30Base { get; private set; }
        public string Aging60 { get; private set; }
        public string Aging60Base { get; private set; }
        public string Aging90 { get; private set; }
        public string Aging90Base { get; private set; }
        public string Anniversary { get; private set; }
        public string Annualincome { get; private set; }
        public string AnnualincomeBase { get; private set; }
        public string Assistantname { get; private set; }
        public string Assistantphone { get; private set; }
        public string Birthdate { get; private set; }
        public string Business2 { get; private set; }
        public string Callback { get; private set; }
        public string Childrensnames { get; private set; }
        public string Company { get; private set; }
        public string Contactid { get; private set; }
        public string Createdby { get; private set; }
        public string Createdbyexternalparty { get; private set; }
        public string Createdon { get; private set; }
        public string Creditlimit { get; private set; }
        public string CreditlimitBase { get; private set; }
        public string Creditonhold { get; private set; }
        public string Customersizecode { get; private set; }
        public string Customertypecode { get; private set; }
        public string Defaultpricelevelid { get; private set; }
        public string Department { get; private set; }
        public string Description { get; private set; }
        public string Donotbulkemail { get; private set; }
        public string Donotbulkpostalmail { get; private set; }
        public string Donotemail { get; private set; }
        public string Donotfax { get; private set; }
        public string Donotphone { get; private set; }
        public string Donotpostalmail { get; private set; }
        public string Donotsendmm { get; private set; }
        public string DynaAnsttelselsesforhold { get; private set; }
        public string DynaCoaching { get; private set; }
        public string DynaContactid { get; private set; }
        public string DynaContactidnr { get; private set; }
        public string DynaCountry { get; private set; }
        public string DynaCoursecustomer { get; private set; }
        public string DynaCustomerbeingcreated { get; private set; }
        public string DynaDelingmedlho { get; private set; }
        public string DynaEmail2 { get; private set; }
        public string DynaEmailopdateretdato { get; private set; }
        public string DynaGodkendinav { get; private set; }
        public string DynaKonsulent { get; private set; }
        public string DynaKontaktpersonid { get; private set; }
        public string DynaLedernecontactguid { get; private set; }
        public string DynaLedernemandag { get; private set; }
        public string DynaLedernemedlem { get; private set; }
        public string DynaLmcKontakt { get; private set; }
        public string DynaLmcKontaktnote { get; private set; }
        public string DynaLmsadgang { get; private set; }
        public string DynaMedlemsnummer { get; private set; }
        public string DynaNavid { get; private set; }
        public string DynaNavtemplateid { get; private set; }
        public string DynaNetvaerkKandidat { get; private set; }
        public string DynaNytfraledelseidagdk { get; private set; }
        public string DynaOldiddebitor { get; private set; }
        public string DynaOldiddeltager { get; private set; }
        public string DynaOldidinstruktr { get; private set; }
        public string DynaOutplacement { get; private set; }
        public string DynaPersonid { get; private set; }
        public string DynaSendnyhedsbrev { get; private set; }
        public string DynaTotalamount { get; private set; }
        public string DynaUk { get; private set; }
        public string DynaUnderviser { get; private set; }
        public string DynaUndervisernote { get; private set; }
        public string DynaVip { get; private set; }
        public string Educationcode { get; private set; }
        public string Emailaddress1 { get; private set; }
        public string Emailaddress2 { get; private set; }
        public string Emailaddress3 { get; private set; }
        public string Employeeid { get; private set; }
        public string Entityimage { get; private set; }
        public string Entityimageid { get; private set; }
        public string Exchangerate { get; private set; }
        public string Externaluseridentifier { get; private set; }
        public string Familystatuscode { get; private set; }
        public string Fax { get; private set; }
        public string Firstname { get; private set; }
        public string Followemail { get; private set; }
        public string Ftpsiteurl { get; private set; }
        public string Fullname { get; private set; }
        public string Gendercode { get; private set; }
        public string Governmentid { get; private set; }
        public string Haschildrencode { get; private set; }
        public string Home2 { get; private set; }
        public string Isautocreate { get; private set; }
        public string Isbackofficecustomer { get; private set; }
        public string Jobtitle { get; private set; }
        public string Lastname { get; private set; }
        public string Lastonholdtime { get; private set; }
        public string Lastusedincampaign { get; private set; }
        public string Leadsourcecode { get; private set; }
        public string Managername { get; private set; }
        public string Managerphone { get; private set; }
        public string Marketingonly { get; private set; }
        public string Masterid { get; private set; }
        public string Merged { get; private set; }
        public string Middlename { get; private set; }
        public string Mobilephone { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedbyexternalparty { get; private set; }
        public string Modifiedon { get; private set; }
        public string MsdynGdproptout { get; private set; }
        public string Nickname { get; private set; }
        public string NnNndecisionmakerid { get; private set; }
        public string NnUpdateprotected { get; private set; }
        public string Numberofchildren { get; private set; }
        public string Onholdtime { get; private set; }
        public string Originatingleadid { get; private set; }
        public string Pager { get; private set; }
        public string Parentcontactid { get; private set; }
        public string Parentcustomerid { get; private set; }
        public string Parentcustomeridtype { get; private set; }
        public string Participatesinworkflow { get; private set; }
        public string Paymenttermscode { get; private set; }
        public string Preferredappointmentdaycode { get; private set; }
        public string Preferredappointmenttimecode { get; private set; }
        public string Preferredcontactmethodcode { get; private set; }
        public string Preferredequipmentid { get; private set; }
        public string Preferredserviceid { get; private set; }
        public string Preferredsystemuserid { get; private set; }
        public string Processid { get; private set; }
        public string Salutation { get; private set; }
        public string Shippingmethodcode { get; private set; }
        public string Slaid { get; private set; }
        public string Slainvokedid { get; private set; }
        public string Spousesname { get; private set; }
        public string Stageid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Subscriptionid { get; private set; }
        public string Suffix { get; private set; }
        public string Telephone1 { get; private set; }
        public string Telephone2 { get; private set; }
        public string Telephone3 { get; private set; }
        public string Territorycode { get; private set; }
        public string Timespentbymeonemailandmeetings { get; private set; }
        public string Transactioncurrencyid { get; private set; }
        public string Traversedpath { get; private set; }
        public string Websiteurl { get; private set; }
    }
}
