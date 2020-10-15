namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("dyna_course")]
    public class DynaCourse
    {
        public DynaCourse(SqlDataReader sqlReader)
        {
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            DynaAccountid = sqlReader["dyna_accountid"]?.ToString();
            DynaAddinvoicedate = sqlReader["dyna_addinvoicedate"]?.ToString();
            DynaAftaltpris = sqlReader["dyna_aftaltpris"]?.ToString();
            DynaBemrkninger = sqlReader["dyna_bemrkninger"]?.ToString();
            DynaBreakevennumber = sqlReader["dyna_breakevennumber"]?.ToString();
            DynaCity = sqlReader["dyna_city"]?.ToString();
            DynaContactid = sqlReader["dyna_contactid"]?.ToString();
            DynaCoursecustomerid = sqlReader["dyna_coursecustomerid"]?.ToString();
            DynaCoursedate = sqlReader["dyna_coursedate"]?.ToString();
            DynaCourseevent = sqlReader["dyna_courseevent"]?.ToString();
            DynaCourseguid = sqlReader["dyna_courseguid"]?.ToString();
            DynaCourseid = sqlReader["dyna_courseid"]?.ToString();
            DynaCourseitemid = sqlReader["dyna_courseitemid"]?.ToString();
            DynaCourseresponsibleid = sqlReader["dyna_courseresponsibleid"]?.ToString();
            DynaCoursetemplate = sqlReader["dyna_coursetemplate"]?.ToString();
            DynaCoursetype = sqlReader["dyna_coursetype"]?.ToString();
            DynaCourseurl = sqlReader["dyna_courseurl"]?.ToString();
            DynaDcpautoemailbekraeftelse = sqlReader["dyna_dcpautoemailbekraeftelse"]?.ToString();
            DynaDcpautoemailkursusbevis = sqlReader["dyna_dcpautoemailkursusbevis"]?.ToString();
            DynaDcpautoemailpaamindelse = sqlReader["dyna_dcpautoemailpaamindelse"]?.ToString();
            DynaDcpvedhaeftdeltagerliste = sqlReader["dyna_dcpvedhaeftdeltagerliste"]?.ToString();
            DynaDescription = sqlReader["dyna_description"]?.ToString();
            DynaDuration = sqlReader["dyna_duration"]?.ToString();
            DynaEnddate = sqlReader["dyna_enddate"]?.ToString();
            DynaEvaluationsend = sqlReader["dyna_evaluationsend"]?.ToString();
            DynaEvaluationtype = sqlReader["dyna_evaluationtype"]?.ToString();
            DynaEvalueringsudsendelse = sqlReader["dyna_evalueringsudsendelse"]?.ToString();
            DynaExpandedcourse = sqlReader["dyna_expandedcourse"]?.ToString();
            DynaFakturastatus = sqlReader["dyna_fakturastatus"]?.ToString();
            DynaFaktureretbelob = sqlReader["dyna_faktureretbelob"]?.ToString();
            DynaFaktureretbelobBase = sqlReader["dyna_faktureretbelob_base"]?.ToString();
            DynaFaktureringsnavn = sqlReader["dyna_faktureringsnavn"]?.ToString();
            DynaFriteksttilkursusbekrftelse = sqlReader["dyna_friteksttilkursusbekrftelse"]?.ToString();
            DynaFriteksttilkursusbevisbagside = sqlReader["dyna_friteksttilkursusbevisbagside"]?.ToString();
            DynaFriteksttilkursusprogram = sqlReader["dyna_friteksttilkursusprogram"]?.ToString();
            DynaFriteksttilpmindelse = sqlReader["dyna_friteksttilpmindelse"]?.ToString();
            DynaInfoomkurset = sqlReader["dyna_infoomkurset"]?.ToString();
            DynaInstructorname = sqlReader["dyna_instructorname"]?.ToString();
            DynaInternalnotes = sqlReader["dyna_internalnotes"]?.ToString();
            DynaInvoicedirectly = sqlReader["dyna_invoicedirectly"]?.ToString();
            DynaItemname = sqlReader["dyna_itemname"]?.ToString();
            DynaItemnavid = sqlReader["dyna_itemnavid"]?.ToString();
            DynaItemtemplateid = sqlReader["dyna_itemtemplateid"]?.ToString();
            DynaKonsulentid = sqlReader["dyna_konsulentid"]?.ToString();
            DynaKursusfaellesafholdelse = sqlReader["dyna_kursusfaellesafholdelse"]?.ToString();
            DynaLastregistrationdate = sqlReader["dyna_lastregistrationdate"]?.ToString();
            DynaLastunregisterdate = sqlReader["dyna_lastunregisterdate"]?.ToString();
            DynaLmskursus = sqlReader["dyna_lmskursus"]?.ToString();
            DynaLocationid = sqlReader["dyna_locationid"]?.ToString();
            DynaLocationname = sqlReader["dyna_locationname"]?.ToString();
            DynaMaster = sqlReader["dyna_master"]?.ToString();
            DynaMastereventid = sqlReader["dyna_mastereventid"]?.ToString();
            DynaMaxnumberofparticipant = sqlReader["dyna_maxnumberofparticipant"]?.ToString();
            DynaMemberprice = sqlReader["dyna_memberprice"]?.ToString();
            DynaMemberpriceBase = sqlReader["dyna_memberprice_base"]?.ToString();
            DynaName = sqlReader["dyna_name"]?.ToString();
            DynaNavid = sqlReader["dyna_navid"]?.ToString();
            DynaNonmemberprice = sqlReader["dyna_nonmemberprice"]?.ToString();
            DynaNonmemberpriceBase = sqlReader["dyna_nonmemberprice_base"]?.ToString();
            DynaOldid = sqlReader["dyna_oldid"]?.ToString();
            DynaOprettelsesmailsendt = sqlReader["dyna_oprettelsesmailsendt"]?.ToString();
            DynaOrderedaccommodations = sqlReader["dyna_orderedaccommodations"]?.ToString();
            DynaOrderedmeals = sqlReader["dyna_orderedmeals"]?.ToString();
            DynaOverfoertilhjemmeside = sqlReader["dyna_overfoertilhjemmeside"]?.ToString();
            DynaPamindelsesendttilunderviser = sqlReader["dyna_pamindelsesendttilunderviser"]?.ToString();
            DynaPmindelsesendt = sqlReader["dyna_pmindelsesendt"]?.ToString();
            DynaPostalcode = sqlReader["dyna_postalcode"]?.ToString();
            DynaReadyforinvoice = sqlReader["dyna_readyforinvoice"]?.ToString();
            DynaRegister = sqlReader["dyna_register"]?.ToString();
            DynaResponsibleemail = sqlReader["dyna_responsibleemail"]?.ToString();
            DynaResponsiblename = sqlReader["dyna_responsiblename"]?.ToString();
            DynaSalgsmulighed = sqlReader["dyna_salgsmulighed"]?.ToString();
            DynaSenttoinvoice = sqlReader["dyna_senttoinvoice"]?.ToString();
            DynaShowmaxparticipant = sqlReader["dyna_showmaxparticipant"]?.ToString();
            DynaShowparticipant = sqlReader["dyna_showparticipant"]?.ToString();
            DynaShowwaitinglist = sqlReader["dyna_showwaitinglist"]?.ToString();
            DynaSpeakerid = sqlReader["dyna_speakerid"]?.ToString();
            DynaStreet1 = sqlReader["dyna_street1"]?.ToString();
            DynaStreet2 = sqlReader["dyna_street2"]?.ToString();
            DynaSubcoursedatesdescription = sqlReader["dyna_subcoursedatesdescription"]?.ToString();
            DynaTeaser = sqlReader["dyna_teaser"]?.ToString();
            DynaTelephone1 = sqlReader["dyna_telephone1"]?.ToString();
            DynaTotalkursusokonomi = sqlReader["dyna_totalkursusokonomi"]?.ToString();
            DynaTotalkursusokonomiBase = sqlReader["dyna_totalkursusokonomi_base"]?.ToString();
            DynaTotalkursusokonomiDate = sqlReader["dyna_totalkursusokonomi_date"]?.ToString();
            DynaTotalkursusokonomiState = sqlReader["dyna_totalkursusokonomi_state"]?.ToString();
            DynaTotalkursusokonomivip = sqlReader["dyna_totalkursusokonomivip"]?.ToString();
            DynaTotalkursusokonomivipBase = sqlReader["dyna_totalkursusokonomivip_base"]?.ToString();
            DynaTotalkursusokonomivipDate = sqlReader["dyna_totalkursusokonomivip_date"]?.ToString();
            DynaTotalkursusokonomivipState = sqlReader["dyna_totalkursusokonomivip_state"]?.ToString();
            DynaUndervisergodkendt = sqlReader["dyna_undervisergodkendt"]?.ToString();
            DynaWaitinglist = sqlReader["dyna_waitinglist"]?.ToString();
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
        public string DynaAddinvoicedate { get; private set; }
        public string DynaAftaltpris { get; private set; }
        public string DynaBemrkninger { get; private set; }
        public string DynaBreakevennumber { get; private set; }
        public string DynaCity { get; private set; }
        public string DynaContactid { get; private set; }
        public string DynaCoursecustomerid { get; private set; }
        public string DynaCoursedate { get; private set; }
        public string DynaCourseevent { get; private set; }
        public string DynaCourseguid { get; private set; }
        public string DynaCourseid { get; private set; }
        public string DynaCourseitemid { get; private set; }
        public string DynaCourseresponsibleid { get; private set; }
        public string DynaCoursetemplate { get; private set; }
        public string DynaCoursetype { get; private set; }
        public string DynaCourseurl { get; private set; }
        public string DynaDcpautoemailbekraeftelse { get; private set; }
        public string DynaDcpautoemailkursusbevis { get; private set; }
        public string DynaDcpautoemailpaamindelse { get; private set; }
        public string DynaDcpvedhaeftdeltagerliste { get; private set; }
        public string DynaDescription { get; private set; }
        public string DynaDuration { get; private set; }
        public string DynaEnddate { get; private set; }
        public string DynaEvaluationsend { get; private set; }
        public string DynaEvaluationtype { get; private set; }
        public string DynaEvalueringsudsendelse { get; private set; }
        public string DynaExpandedcourse { get; private set; }
        public string DynaFakturastatus { get; private set; }
        public string DynaFaktureretbelob { get; private set; }
        public string DynaFaktureretbelobBase { get; private set; }
        public string DynaFaktureringsnavn { get; private set; }
        public string DynaFriteksttilkursusbekrftelse { get; private set; }
        public string DynaFriteksttilkursusbevisbagside { get; private set; }
        public string DynaFriteksttilkursusprogram { get; private set; }
        public string DynaFriteksttilpmindelse { get; private set; }
        public string DynaInfoomkurset { get; private set; }
        public string DynaInstructorname { get; private set; }
        public string DynaInternalnotes { get; private set; }
        public string DynaInvoicedirectly { get; private set; }
        public string DynaItemname { get; private set; }
        public string DynaItemnavid { get; private set; }
        public string DynaItemtemplateid { get; private set; }
        public string DynaKonsulentid { get; private set; }
        public string DynaKursusfaellesafholdelse { get; private set; }
        public string DynaLastregistrationdate { get; private set; }
        public string DynaLastunregisterdate { get; private set; }
        public string DynaLmskursus { get; private set; }
        public string DynaLocationid { get; private set; }
        public string DynaLocationname { get; private set; }
        public string DynaMaster { get; private set; }
        public string DynaMastereventid { get; private set; }
        public string DynaMaxnumberofparticipant { get; private set; }
        public string DynaMemberprice { get; private set; }
        public string DynaMemberpriceBase { get; private set; }
        public string DynaName { get; private set; }
        public string DynaNavid { get; private set; }
        public string DynaNonmemberprice { get; private set; }
        public string DynaNonmemberpriceBase { get; private set; }
        public string DynaOldid { get; private set; }
        public string DynaOprettelsesmailsendt { get; private set; }
        public string DynaOrderedaccommodations { get; private set; }
        public string DynaOrderedmeals { get; private set; }
        public string DynaOverfoertilhjemmeside { get; private set; }
        public string DynaPamindelsesendttilunderviser { get; private set; }
        public string DynaPmindelsesendt { get; private set; }
        public string DynaPostalcode { get; private set; }
        public string DynaReadyforinvoice { get; private set; }
        public string DynaRegister { get; private set; }
        public string DynaResponsibleemail { get; private set; }
        public string DynaResponsiblename { get; private set; }
        public string DynaSalgsmulighed { get; private set; }
        public string DynaSenttoinvoice { get; private set; }
        public string DynaShowmaxparticipant { get; private set; }
        public string DynaShowparticipant { get; private set; }
        public string DynaShowwaitinglist { get; private set; }
        public string DynaSpeakerid { get; private set; }
        public string DynaStreet1 { get; private set; }
        public string DynaStreet2 { get; private set; }
        public string DynaSubcoursedatesdescription { get; private set; }
        public string DynaTeaser { get; private set; }
        public string DynaTelephone1 { get; private set; }
        public string DynaTotalkursusokonomi { get; private set; }
        public string DynaTotalkursusokonomiBase { get; private set; }
        public string DynaTotalkursusokonomiDate { get; private set; }
        public string DynaTotalkursusokonomiState { get; private set; }
        public string DynaTotalkursusokonomivip { get; private set; }
        public string DynaTotalkursusokonomivipBase { get; private set; }
        public string DynaTotalkursusokonomivipDate { get; private set; }
        public string DynaTotalkursusokonomivipState { get; private set; }
        public string DynaUndervisergodkendt { get; private set; }
        public string DynaWaitinglist { get; private set; }
        public string Exchangerate { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Organizationid { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
        public string Transactioncurrencyid { get; private set; }
    }
}
