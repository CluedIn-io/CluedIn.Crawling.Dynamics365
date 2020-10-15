namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("dyna_participant")]
    public class DynaParticipant
    {
        public DynaParticipant(SqlDataReader sqlReader)
        {
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            DynaAccountid = sqlReader["dyna_accountid"]?.ToString();
            DynaAkasse = sqlReader["dyna_akasse"]?.ToString();
            DynaAnsttelsesforhold = sqlReader["dyna_ansttelsesforhold"]?.ToString();
            DynaAr237sendtmanuelt = sqlReader["dyna_ar237sendtmanuelt"]?.ToString();
            DynaBekraeftelsesendt = sqlReader["dyna_bekraeftelsesendt"]?.ToString();
            DynaBekraeftelsesendtdato = sqlReader["dyna_bekraeftelsesendtdato"]?.ToString();
            DynaColleaguename = sqlReader["dyna_colleaguename"]?.ToString();
            DynaContactid = sqlReader["dyna_contactid"]?.ToString();
            DynaContactinvoiceid = sqlReader["dyna_contactinvoiceid"]?.ToString();
            DynaCourseattention = sqlReader["dyna_courseattention"]?.ToString();
            DynaCoursecustomerid = sqlReader["dyna_coursecustomerid"]?.ToString();
            DynaCourseid = sqlReader["dyna_courseid"]?.ToString();
            DynaCoursepaid = sqlReader["dyna_coursepaid"]?.ToString();
            DynaCoursepaidBase = sqlReader["dyna_coursepaid_base"]?.ToString();
            DynaCourseprice = sqlReader["dyna_courseprice"]?.ToString();
            DynaCoursepriceBase = sqlReader["dyna_courseprice_base"]?.ToString();
            DynaCreatedfrom = sqlReader["dyna_createdfrom"]?.ToString();
            DynaCreateinvoicelines = sqlReader["dyna_createinvoicelines"]?.ToString();
            DynaCvrse = sqlReader["dyna_cvrse"]?.ToString();
            DynaDeltagerstatusdato = sqlReader["dyna_deltagerstatusdato"]?.ToString();
            DynaDescription = sqlReader["dyna_description"]?.ToString();
            DynaDiscountamount = sqlReader["dyna_discountamount"]?.ToString();
            DynaDiscountamountBase = sqlReader["dyna_discountamount_base"]?.ToString();
            DynaDiscountrate = sqlReader["dyna_discountrate"]?.ToString();
            DynaDiscounttype = sqlReader["dyna_discounttype"]?.ToString();
            DynaEanno = sqlReader["dyna_eanno"]?.ToString();
            DynaEksternid = sqlReader["dyna_eksternid"]?.ToString();
            DynaEmailadresse = sqlReader["dyna_emailadresse"]?.ToString();
            DynaEvaluationfullfilled = sqlReader["dyna_evaluationfullfilled"]?.ToString();
            DynaEvaluationsent = sqlReader["dyna_evaluationsent"]?.ToString();
            DynaEvaluationtype = sqlReader["dyna_evaluationtype"]?.ToString();
            DynaEvalueringlink = sqlReader["dyna_evalueringlink"]?.ToString();
            DynaFakturastatus = sqlReader["dyna_fakturastatus"]?.ToString();
            DynaFaktureringsadresseattention = sqlReader["dyna_faktureringsadresseattention"]?.ToString();
            DynaFaktureringsadresseby = sqlReader["dyna_faktureringsadresseby"]?.ToString();
            DynaFaktureringsadressegade1 = sqlReader["dyna_faktureringsadressegade1"]?.ToString();
            DynaFaktureringsadressegade2 = sqlReader["dyna_faktureringsadressegade2"]?.ToString();
            DynaFaktureringsadresseland = sqlReader["dyna_faktureringsadresseland"]?.ToString();
            DynaFaktureringsadressenavn = sqlReader["dyna_faktureringsadressenavn"]?.ToString();
            DynaFaktureringsadressepostnummer = sqlReader["dyna_faktureringsadressepostnummer"]?.ToString();
            DynaFaktureringsemail = sqlReader["dyna_faktureringsemail"]?.ToString();
            DynaFax = sqlReader["dyna_fax"]?.ToString();
            DynaFirmanavn = sqlReader["dyna_firmanavn"]?.ToString();
            DynaIndirectparticipation = sqlReader["dyna_indirectparticipation"]?.ToString();
            DynaInvoicereference = sqlReader["dyna_invoicereference"]?.ToString();
            DynaInvoicetoparticipant = sqlReader["dyna_invoicetoparticipant"]?.ToString();
            DynaKcslger = sqlReader["dyna_kcslger"]?.ToString();
            DynaKursusbevisafsendt = sqlReader["dyna_kursusbevisafsendt"]?.ToString();
            DynaKursusbevissendtdato = sqlReader["dyna_kursusbevissendtdato"]?.ToString();
            DynaKursusmodulid = sqlReader["dyna_kursusmodulid"]?.ToString();
            DynaKursusrabatkode = sqlReader["dyna_kursusrabatkode"]?.ToString();
            DynaLevattention = sqlReader["dyna_levattention"]?.ToString();
            DynaLevbrugandenleveringsadresse = sqlReader["dyna_levbrugandenleveringsadresse"]?.ToString();
            DynaLevby = sqlReader["dyna_levby"]?.ToString();
            DynaLevfirmanavn = sqlReader["dyna_levfirmanavn"]?.ToString();
            DynaLevgade = sqlReader["dyna_levgade"]?.ToString();
            DynaLevgade2 = sqlReader["dyna_levgade2"]?.ToString();
            DynaLevland = sqlReader["dyna_levland"]?.ToString();
            DynaLevpostnummer = sqlReader["dyna_levpostnummer"]?.ToString();
            DynaMaster = sqlReader["dyna_master"]?.ToString();
            DynaMasterparticipantid = sqlReader["dyna_masterparticipantid"]?.ToString();
            DynaMember = sqlReader["dyna_member"]?.ToString();
            DynaName = sqlReader["dyna_name"]?.ToString();
            DynaNavid = sqlReader["dyna_navid"]?.ToString();
            DynaOldid = sqlReader["dyna_oldid"]?.ToString();
            DynaOmstillingsfonden = sqlReader["dyna_omstillingsfonden"]?.ToString();
            DynaPaamindelsesendt = sqlReader["dyna_paamindelsesendt"]?.ToString();
            DynaPaamindelsesendtdato = sqlReader["dyna_paamindelsesendtdato"]?.ToString();
            DynaPaidinvoice = sqlReader["dyna_paidinvoice"]?.ToString();
            DynaParticipantautoid = sqlReader["dyna_participantautoid"]?.ToString();
            DynaParticipantguid = sqlReader["dyna_participantguid"]?.ToString();
            DynaParticipantid = sqlReader["dyna_participantid"]?.ToString();
            DynaParticipantremarks = sqlReader["dyna_participantremarks"]?.ToString();
            DynaParticipated = sqlReader["dyna_participated"]?.ToString();
            DynaParticipatingstatus = sqlReader["dyna_participatingstatus"]?.ToString();
            DynaPrimrtelefonnummer = sqlReader["dyna_primrtelefonnummer"]?.ToString();
            DynaPromotioncodeid = sqlReader["dyna_promotioncodeid"]?.ToString();
            DynaRabatkode = sqlReader["dyna_rabatkode"]?.ToString();
            DynaRammeaftalerabat = sqlReader["dyna_rammeaftalerabat"]?.ToString();
            DynaReason = sqlReader["dyna_reason"]?.ToString();
            DynaReference = sqlReader["dyna_reference"]?.ToString();
            DynaSalgskanaler = sqlReader["dyna_salgskanaler"]?.ToString();
            DynaSendkopiafbekrftelse = sqlReader["dyna_sendkopiafbekrftelse"]?.ToString();
            DynaSendkopiafindkaldelse = sqlReader["dyna_sendkopiafindkaldelse"]?.ToString();
            DynaSuppKompSendtmanuelt = sqlReader["dyna_supp_komp_sendtmanuelt"]?.ToString();
            DynaSupplerendeinfomodtaget = sqlReader["dyna_supplerendeinfomodtaget"]?.ToString();
            DynaSvu = sqlReader["dyna_svu"]?.ToString();
            DynaSvudato = sqlReader["dyna_svudato"]?.ToString();
            DynaSvustatus = sqlReader["dyna_svustatus"]?.ToString();
            DynaTotalamount = sqlReader["dyna_totalamount"]?.ToString();
            DynaTotalamountBase = sqlReader["dyna_totalamount_base"]?.ToString();
            DynaTotalamountpaid = sqlReader["dyna_totalamountpaid"]?.ToString();
            DynaTotalamountpaidBase = sqlReader["dyna_totalamountpaid_base"]?.ToString();
            DynaTotalproduct = sqlReader["dyna_totalproduct"]?.ToString();
            DynaTotalproductBase = sqlReader["dyna_totalproduct_base"]?.ToString();
            DynaTotalproductpaid = sqlReader["dyna_totalproductpaid"]?.ToString();
            DynaTotalproductpaidBase = sqlReader["dyna_totalproductpaid_base"]?.ToString();
            DynaUnsubscribed = sqlReader["dyna_unsubscribed"]?.ToString();
            DynaUnsubscribeddate = sqlReader["dyna_unsubscribeddate"]?.ToString();
            DynaVirksomhedsadresseattention = sqlReader["dyna_virksomhedsadresseattention"]?.ToString();
            DynaVirksomhedsadresseby = sqlReader["dyna_virksomhedsadresseby"]?.ToString();
            DynaVirksomhedsadressegade1 = sqlReader["dyna_virksomhedsadressegade1"]?.ToString();
            DynaVirksomhedsadressegade2 = sqlReader["dyna_virksomhedsadressegade2"]?.ToString();
            DynaVirksomhedsadresseland = sqlReader["dyna_virksomhedsadresseland"]?.ToString();
            DynaVirksomhedsadressenavn = sqlReader["dyna_virksomhedsadressenavn"]?.ToString();
            DynaVirksomhedsadressepostnummer = sqlReader["dyna_virksomhedsadressepostnummer"]?.ToString();
            DynaWebsted = sqlReader["dyna_websted"]?.ToString();
            DynaWebtilmeldingdata = sqlReader["dyna_webtilmeldingdata"]?.ToString();
            Exchangerate = sqlReader["exchangerate"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Organizationid = sqlReader["organizationid"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
            Transactioncurrencyid = sqlReader["transactioncurrencyid"]?.ToString();
        }

        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string DynaAccountid { get; private set; }
        public string DynaAkasse { get; private set; }
        public string DynaAnsttelsesforhold { get; private set; }
        public string DynaAr237sendtmanuelt { get; private set; }
        public string DynaBekraeftelsesendt { get; private set; }
        public string DynaBekraeftelsesendtdato { get; private set; }
        public string DynaColleaguename { get; private set; }
        public string DynaContactid { get; private set; }
        public string DynaContactinvoiceid { get; private set; }
        public string DynaCourseattention { get; private set; }
        public string DynaCoursecustomerid { get; private set; }
        public string DynaCourseid { get; private set; }
        public string DynaCoursepaid { get; private set; }
        public string DynaCoursepaidBase { get; private set; }
        public string DynaCourseprice { get; private set; }
        public string DynaCoursepriceBase { get; private set; }
        public string DynaCreatedfrom { get; private set; }
        public string DynaCreateinvoicelines { get; private set; }
        public string DynaCvrse { get; private set; }
        public string DynaDeltagerstatusdato { get; private set; }
        public string DynaDescription { get; private set; }
        public string DynaDiscountamount { get; private set; }
        public string DynaDiscountamountBase { get; private set; }
        public string DynaDiscountrate { get; private set; }
        public string DynaDiscounttype { get; private set; }
        public string DynaEanno { get; private set; }
        public string DynaEksternid { get; private set; }
        public string DynaEmailadresse { get; private set; }
        public string DynaEvaluationfullfilled { get; private set; }
        public string DynaEvaluationsent { get; private set; }
        public string DynaEvaluationtype { get; private set; }
        public string DynaEvalueringlink { get; private set; }
        public string DynaFakturastatus { get; private set; }
        public string DynaFaktureringsadresseattention { get; private set; }
        public string DynaFaktureringsadresseby { get; private set; }
        public string DynaFaktureringsadressegade1 { get; private set; }
        public string DynaFaktureringsadressegade2 { get; private set; }
        public string DynaFaktureringsadresseland { get; private set; }
        public string DynaFaktureringsadressenavn { get; private set; }
        public string DynaFaktureringsadressepostnummer { get; private set; }
        public string DynaFaktureringsemail { get; private set; }
        public string DynaFax { get; private set; }
        public string DynaFirmanavn { get; private set; }
        public string DynaIndirectparticipation { get; private set; }
        public string DynaInvoicereference { get; private set; }
        public string DynaInvoicetoparticipant { get; private set; }
        public string DynaKcslger { get; private set; }
        public string DynaKursusbevisafsendt { get; private set; }
        public string DynaKursusbevissendtdato { get; private set; }
        public string DynaKursusmodulid { get; private set; }
        public string DynaKursusrabatkode { get; private set; }
        public string DynaLevattention { get; private set; }
        public string DynaLevbrugandenleveringsadresse { get; private set; }
        public string DynaLevby { get; private set; }
        public string DynaLevfirmanavn { get; private set; }
        public string DynaLevgade { get; private set; }
        public string DynaLevgade2 { get; private set; }
        public string DynaLevland { get; private set; }
        public string DynaLevpostnummer { get; private set; }
        public string DynaMaster { get; private set; }
        public string DynaMasterparticipantid { get; private set; }
        public string DynaMember { get; private set; }
        public string DynaName { get; private set; }
        public string DynaNavid { get; private set; }
        public string DynaOldid { get; private set; }
        public string DynaOmstillingsfonden { get; private set; }
        public string DynaPaamindelsesendt { get; private set; }
        public string DynaPaamindelsesendtdato { get; private set; }
        public string DynaPaidinvoice { get; private set; }
        public string DynaParticipantautoid { get; private set; }
        public string DynaParticipantguid { get; private set; }
        public string DynaParticipantid { get; private set; }
        public string DynaParticipantremarks { get; private set; }
        public string DynaParticipated { get; private set; }
        public string DynaParticipatingstatus { get; private set; }
        public string DynaPrimrtelefonnummer { get; private set; }
        public string DynaPromotioncodeid { get; private set; }
        public string DynaRabatkode { get; private set; }
        public string DynaRammeaftalerabat { get; private set; }
        public string DynaReason { get; private set; }
        public string DynaReference { get; private set; }
        public string DynaSalgskanaler { get; private set; }
        public string DynaSendkopiafbekrftelse { get; private set; }
        public string DynaSendkopiafindkaldelse { get; private set; }
        public string DynaSuppKompSendtmanuelt { get; private set; }
        public string DynaSupplerendeinfomodtaget { get; private set; }
        public string DynaSvu { get; private set; }
        public string DynaSvudato { get; private set; }
        public string DynaSvustatus { get; private set; }
        public string DynaTotalamount { get; private set; }
        public string DynaTotalamountBase { get; private set; }
        public string DynaTotalamountpaid { get; private set; }
        public string DynaTotalamountpaidBase { get; private set; }
        public string DynaTotalproduct { get; private set; }
        public string DynaTotalproductBase { get; private set; }
        public string DynaTotalproductpaid { get; private set; }
        public string DynaTotalproductpaidBase { get; private set; }
        public string DynaUnsubscribed { get; private set; }
        public string DynaUnsubscribeddate { get; private set; }
        public string DynaVirksomhedsadresseattention { get; private set; }
        public string DynaVirksomhedsadresseby { get; private set; }
        public string DynaVirksomhedsadressegade1 { get; private set; }
        public string DynaVirksomhedsadressegade2 { get; private set; }
        public string DynaVirksomhedsadresseland { get; private set; }
        public string DynaVirksomhedsadressenavn { get; private set; }
        public string DynaVirksomhedsadressepostnummer { get; private set; }
        public string DynaWebsted { get; private set; }
        public string DynaWebtilmeldingdata { get; private set; }
        public string Exchangerate { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Organizationid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Transactioncurrencyid { get; private set; }
    }
}
