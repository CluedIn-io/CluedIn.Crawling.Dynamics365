namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("Account")]
    public class Account
    {
        public Account(SqlDataReader sqlReader)
        {
            Accountcategorycode = sqlReader["accountcategorycode"]?.ToString();
            Accountclassificationcode = sqlReader["accountclassificationcode"]?.ToString();
            Accountid = sqlReader["accountid"]?.ToString();
            Accountnumber = sqlReader["accountnumber"]?.ToString();
            Accountratingcode = sqlReader["accountratingcode"]?.ToString();
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
            Aging30 = sqlReader["aging30"]?.ToString();
            Aging30Base = sqlReader["aging30_base"]?.ToString();
            Aging60 = sqlReader["aging60"]?.ToString();
            Aging60Base = sqlReader["aging60_base"]?.ToString();
            Aging90 = sqlReader["aging90"]?.ToString();
            Aging90Base = sqlReader["aging90_base"]?.ToString();
            Businesstypecode = sqlReader["businesstypecode"]?.ToString();
            Createdby = sqlReader["createdby"]?.ToString();
            Createdbyexternalparty = sqlReader["createdbyexternalparty"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            Creditlimit = sqlReader["creditlimit"]?.ToString();
            CreditlimitBase = sqlReader["creditlimit_base"]?.ToString();
            Creditonhold = sqlReader["creditonhold"]?.ToString();
            Customersizecode = sqlReader["customersizecode"]?.ToString();
            Defaultpricelevelid = sqlReader["defaultpricelevelid"]?.ToString();
            Description = sqlReader["description"]?.ToString();
            Donotbulkemail = sqlReader["donotbulkemail"]?.ToString();
            Donotbulkpostalmail = sqlReader["donotbulkpostalmail"]?.ToString();
            Donotemail = sqlReader["donotemail"]?.ToString();
            Donotfax = sqlReader["donotfax"]?.ToString();
            Donotphone = sqlReader["donotphone"]?.ToString();
            Donotpostalmail = sqlReader["donotpostalmail"]?.ToString();
            Donotsendmm = sqlReader["donotsendmm"]?.ToString();
            DynaAccountid = sqlReader["dyna_accountid"]?.ToString();
            DynaBlokerNedarvAfAdresseOplysninger = sqlReader["dyna_bloker_nedarv_af_adresse_oplysninger"]?.ToString();
            DynaCoursecustomer = sqlReader["dyna_coursecustomer"]?.ToString();
            DynaCvrp = sqlReader["dyna_cvrp"]?.ToString();
            DynaCvrse = sqlReader["dyna_cvrse"]?.ToString();
            DynaCvrstatus = sqlReader["dyna_cvrstatus"]?.ToString();
            DynaCvrstatuskode = sqlReader["dyna_cvrstatuskode"]?.ToString();
            DynaDaarligbetaler = sqlReader["dyna_daarligbetaler"]?.ToString();
            DynaDebitor = sqlReader["dyna_debitor"]?.ToString();
            DynaDebitorunderoprettelse = sqlReader["dyna_debitorunderoprettelse"]?.ToString();
            DynaEannummer = sqlReader["dyna_eannummer"]?.ToString();
            DynaEanpkrvet = sqlReader["dyna_eanpkrvet"]?.ToString();
            DynaEtableringsaar = sqlReader["dyna_etableringsaar"]?.ToString();
            DynaFaktureringsemail = sqlReader["dyna_faktureringsemail"]?.ToString();
            DynaGodkendtinav = sqlReader["dyna_godkendtinav"]?.ToString();
            DynaHovedselskab = sqlReader["dyna_hovedselskab"]?.ToString();
            DynaKobteydelser = sqlReader["dyna_kobteydelser"]?.ToString();
            DynaKobteydelserBase = sqlReader["dyna_kobteydelser_base"]?.ToString();
            DynaKobteydelserDate = sqlReader["dyna_kobteydelser_date"]?.ToString();
            DynaKobteydelserState = sqlReader["dyna_kobteydelser_state"]?.ToString();
            DynaKoncernomstaening = sqlReader["dyna_koncernomstaening"]?.ToString();
            DynaLandid = sqlReader["dyna_landid"]?.ToString();
            DynaModerselskab = sqlReader["dyna_moderselskab"]?.ToString();
            DynaNavid = sqlReader["dyna_navid"]?.ToString();
            DynaNavtemplateid = sqlReader["dyna_navtemplateid"]?.ToString();
            DynaNumberofemployeesbranch = sqlReader["dyna_numberofemployeesbranch"]?.ToString();
            DynaOldid = sqlReader["dyna_oldid"]?.ToString();
            DynaOprettelsesmailsendt = sqlReader["dyna_oprettelsesmailsendt"]?.ToString();
            DynaPopkrvet = sqlReader["dyna_popkrvet"]?.ToString();
            DynaRammeaftale = sqlReader["dyna_rammeaftale"]?.ToString();
            DynaRammeslutdato = sqlReader["dyna_rammeslutdato"]?.ToString();
            DynaRammestartdato = sqlReader["dyna_rammestartdato"]?.ToString();
            DynaSegmentKundeaktivitet = sqlReader["dyna_segment_kundeaktivitet"]?.ToString();
            DynaSegmentKundestatus = sqlReader["dyna_segment_kundestatus"]?.ToString();
            DynaSegmentVirksomhedsstoerrelse = sqlReader["dyna_segment_virksomhedsstoerrelse"]?.ToString();
            DynaTotalamount = sqlReader["dyna_totalamount"]?.ToString();
            DynaUpdatetricker = sqlReader["dyna_updatetricker"]?.ToString();
            DynaVirksomhedsform = sqlReader["dyna_virksomhedsform"]?.ToString();
            Emailaddress1 = sqlReader["emailaddress1"]?.ToString();
            Emailaddress2 = sqlReader["emailaddress2"]?.ToString();
            Emailaddress3 = sqlReader["emailaddress3"]?.ToString();
            Entityimage = sqlReader["entityimage"]?.ToString();
            Entityimageid = sqlReader["entityimageid"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Fax = sqlReader["fax"]?.ToString();
            Followemail = sqlReader["followemail"]?.ToString();
            Ftpsiteurl = sqlReader["ftpsiteurl"]?.ToString();
            Industrycode = sqlReader["industrycode"]?.ToString();
            Lastonholdtime = sqlReader["lastonholdtime"]?.ToString();
            Lastusedincampaign = sqlReader["lastusedincampaign"]?.ToString();
            Marketcap = sqlReader["marketcap"]?.ToString();
            MarketcapBase = sqlReader["marketcap_base"]?.ToString();
            Marketingonly = sqlReader["marketingonly"]?.ToString();
            Masterid = sqlReader["masterid"]?.ToString();
            Merged = sqlReader["merged"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedbyexternalparty = sqlReader["modifiedbyexternalparty"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Name = sqlReader["name"]?.ToString();
            NewCompanysize = sqlReader["new_companysize"]?.ToString();
            NnLastupdated = sqlReader["nn_lastupdated"]?.ToString();
            NnLinks = sqlReader["nn_links"]?.ToString();
            NnPrimarytradecode = sqlReader["nn_primarytradecode"]?.ToString();
            NnPrimarytradecodeno = sqlReader["nn_primarytradecodeno"]?.ToString();
            NnTdcid = sqlReader["nn_tdcid"]?.ToString();
            NnUpdateprotected = sqlReader["nn_updateprotected"]?.ToString();
            Numberofemployees = sqlReader["numberofemployees"]?.ToString();
            Onholdtime = sqlReader["onholdtime"]?.ToString();
            Opendeals = sqlReader["opendeals"]?.ToString();
            OpendealsDate = sqlReader["opendeals_date"]?.ToString();
            OpendealsState = sqlReader["opendeals_state"]?.ToString();
            Openrevenue = sqlReader["openrevenue"]?.ToString();
            OpenrevenueBase = sqlReader["openrevenue_base"]?.ToString();
            OpenrevenueDate = sqlReader["openrevenue_date"]?.ToString();
            OpenrevenueState = sqlReader["openrevenue_state"]?.ToString();
            Originatingleadid = sqlReader["originatingleadid"]?.ToString();
            Parentaccountid = sqlReader["parentaccountid"]?.ToString();
            Participatesinworkflow = sqlReader["participatesinworkflow"]?.ToString();
            Paymenttermscode = sqlReader["paymenttermscode"]?.ToString();
            Preferredappointmentdaycode = sqlReader["preferredappointmentdaycode"]?.ToString();
            Preferredappointmenttimecode = sqlReader["preferredappointmenttimecode"]?.ToString();
            Preferredcontactmethodcode = sqlReader["preferredcontactmethodcode"]?.ToString();
            Preferredserviceid = sqlReader["preferredserviceid"]?.ToString();
            Preferredsystemuserid = sqlReader["preferredsystemuserid"]?.ToString();
            Primarycontactid = sqlReader["primarycontactid"]?.ToString();
            Primarysatoriid = sqlReader["primarysatoriid"]?.ToString();
            Primarytwitterid = sqlReader["primarytwitterid"]?.ToString();
            Processid = sqlReader["processid"]?.ToString();
            Revenue = sqlReader["revenue"]?.ToString();
            RevenueBase = sqlReader["revenue_base"]?.ToString();
            Sharesoutstanding = sqlReader["sharesoutstanding"]?.ToString();
            Shippingmethodcode = sqlReader["shippingmethodcode"]?.ToString();
            Sic = sqlReader["sic"]?.ToString();
            Slaid = sqlReader["slaid"]?.ToString();
            Slainvokedid = sqlReader["slainvokedid"]?.ToString();
            Stageid = sqlReader["stageid"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
            Stockexchange = sqlReader["stockexchange"]?.ToString();
            Telephone1 = sqlReader["telephone1"]?.ToString();
            Telephone2 = sqlReader["telephone2"]?.ToString();
            Telephone3 = sqlReader["telephone3"]?.ToString();
            Territorycode = sqlReader["territorycode"]?.ToString();
            Territoryid = sqlReader["territoryid"]?.ToString();
            Tickersymbol = sqlReader["tickersymbol"]?.ToString();
            Timespentbymeonemailandmeetings = sqlReader["timespentbymeonemailandmeetings"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
            Traversedpath = sqlReader["traversedpath"]?.ToString();
            Websiteurl = sqlReader["websiteurl"]?.ToString();
        }

        public string Accountcategorycode { get; private set; }
        public string Accountclassificationcode { get; private set; }
        public string Accountid { get; private set; }
        public string Accountnumber { get; private set; }
        public string Accountratingcode { get; private set; }
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
        public string Aging30 { get; private set; }
        public string Aging30Base { get; private set; }
        public string Aging60 { get; private set; }
        public string Aging60Base { get; private set; }
        public string Aging90 { get; private set; }
        public string Aging90Base { get; private set; }
        public string Businesstypecode { get; private set; }
        public string Createdby { get; private set; }
        public string Createdbyexternalparty { get; private set; }
        public string Createdon { get; private set; }
        public string Creditlimit { get; private set; }
        public string CreditlimitBase { get; private set; }
        public string Creditonhold { get; private set; }
        public string Customersizecode { get; private set; }
        public string Defaultpricelevelid { get; private set; }
        public string Description { get; private set; }
        public string Donotbulkemail { get; private set; }
        public string Donotbulkpostalmail { get; private set; }
        public string Donotemail { get; private set; }
        public string Donotfax { get; private set; }
        public string Donotphone { get; private set; }
        public string Donotpostalmail { get; private set; }
        public string Donotsendmm { get; private set; }
        public string DynaAccountid { get; private set; }
        public string DynaBlokerNedarvAfAdresseOplysninger { get; private set; }
        public string DynaCoursecustomer { get; private set; }
        public string DynaCvrp { get; private set; }
        public string DynaCvrse { get; private set; }
        public string DynaCvrstatus { get; private set; }
        public string DynaCvrstatuskode { get; private set; }
        public string DynaDaarligbetaler { get; private set; }
        public string DynaDebitor { get; private set; }
        public string DynaDebitorunderoprettelse { get; private set; }
        public string DynaEannummer { get; private set; }
        public string DynaEanpkrvet { get; private set; }
        public string DynaEtableringsaar { get; private set; }
        public string DynaFaktureringsemail { get; private set; }
        public string DynaGodkendtinav { get; private set; }
        public string DynaHovedselskab { get; private set; }
        public string DynaKobteydelser { get; private set; }
        public string DynaKobteydelserBase { get; private set; }
        public string DynaKobteydelserDate { get; private set; }
        public string DynaKobteydelserState { get; private set; }
        public string DynaKoncernomstaening { get; private set; }
        public string DynaLandid { get; private set; }
        public string DynaModerselskab { get; private set; }
        public string DynaNavid { get; private set; }
        public string DynaNavtemplateid { get; private set; }
        public string DynaNumberofemployeesbranch { get; private set; }
        public string DynaOldid { get; private set; }
        public string DynaOprettelsesmailsendt { get; private set; }
        public string DynaPopkrvet { get; private set; }
        public string DynaRammeaftale { get; private set; }
        public string DynaRammeslutdato { get; private set; }
        public string DynaRammestartdato { get; private set; }
        public string DynaSegmentKundeaktivitet { get; private set; }
        public string DynaSegmentKundestatus { get; private set; }
        public string DynaSegmentVirksomhedsstoerrelse { get; private set; }
        public string DynaTotalamount { get; private set; }
        public string DynaUpdatetricker { get; private set; }
        public string DynaVirksomhedsform { get; private set; }
        public string Emailaddress1 { get; private set; }
        public string Emailaddress2 { get; private set; }
        public string Emailaddress3 { get; private set; }
        public string Entityimage { get; private set; }
        public string Entityimageid { get; private set; }
        public string Exchangerate { get; private set; }
        public string Fax { get; private set; }
        public string Followemail { get; private set; }
        public string Ftpsiteurl { get; private set; }
        public string Industrycode { get; private set; }
        public string Lastonholdtime { get; private set; }
        public string Lastusedincampaign { get; private set; }
        public string Marketcap { get; private set; }
        public string MarketcapBase { get; private set; }
        public string Marketingonly { get; private set; }
        public string Masterid { get; private set; }
        public string Merged { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedbyexternalparty { get; private set; }
        public string Modifiedon { get; private set; }
        public string Name { get; private set; }
        public string NewCompanysize { get; private set; }
        public string NnLastupdated { get; private set; }
        public string NnLinks { get; private set; }
        public string NnPrimarytradecode { get; private set; }
        public string NnPrimarytradecodeno { get; private set; }
        public string NnTdcid { get; private set; }
        public string NnUpdateprotected { get; private set; }
        public string Numberofemployees { get; private set; }
        public string Onholdtime { get; private set; }
        public string Opendeals { get; private set; }
        public string OpendealsDate { get; private set; }
        public string OpendealsState { get; private set; }
        public string Openrevenue { get; private set; }
        public string OpenrevenueBase { get; private set; }
        public string OpenrevenueDate { get; private set; }
        public string OpenrevenueState { get; private set; }
        public string Originatingleadid { get; private set; }
        public string Parentaccountid { get; private set; }
        public string Participatesinworkflow { get; private set; }
        public string Paymenttermscode { get; private set; }
        public string Preferredappointmentdaycode { get; private set; }
        public string Preferredappointmenttimecode { get; private set; }
        public string Preferredcontactmethodcode { get; private set; }
        public string Preferredserviceid { get; private set; }
        public string Preferredsystemuserid { get; private set; }
        public string Primarycontactid { get; private set; }
        public string Primarysatoriid { get; private set; }
        public string Primarytwitterid { get; private set; }
        public string Processid { get; private set; }
        public string Revenue { get; private set; }
        public string RevenueBase { get; private set; }
        public string Sharesoutstanding { get; private set; }
        public string Shippingmethodcode { get; private set; }
        public string Sic { get; private set; }
        public string Slaid { get; private set; }
        public string Slainvokedid { get; private set; }
        public string Stageid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Stockexchange { get; private set; }
        public string Telephone1 { get; private set; }
        public string Telephone2 { get; private set; }
        public string Telephone3 { get; private set; }
        public string Territorycode { get; private set; }
        public string Territoryid { get; private set; }
        public string Tickersymbol { get; private set; }
        public string Timespentbymeonemailandmeetings { get; private set; }
        public string Transactioncurrencyid { get; private set; }
        public string Traversedpath { get; private set; }
        public string Websiteurl { get; private set; }
    }
}
