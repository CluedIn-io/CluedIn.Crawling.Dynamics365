namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    using System.ComponentModel;
    using Microsoft.Data.SqlClient;

    [DisplayName("dyna_outplacement")]
    public class DynaOutplacement
    {
        public DynaOutplacement(SqlDataReader sqlReader)
        {
            Createdby = sqlReader["createdby"]?.ToString();
            Createdon = sqlReader["createdon"]?.ToString();
            DynaAarsagtilafslag = sqlReader["dyna_aarsagtilafslag"]?.ToString();
            DynaAfslutgrundAndenloesning = sqlReader["dyna_afslutgrund_andenloesning"]?.ToString();
            DynaAfslutgrundMidlertidigansaettelse = sqlReader["dyna_afslutgrund_midlertidigansaettelse"]?.ToString();
            DynaAfslutgrundNytjob = sqlReader["dyna_afslutgrund_nytjob"]?.ToString();
            DynaAfslutgrundOpbrugtmoeder = sqlReader["dyna_afslutgrund_opbrugtmoeder"]?.ToString();
            DynaAfslutgrundPensionefterlon = sqlReader["dyna_afslutgrund_pensionefterlon"]?.ToString();
            DynaAfslutgrundUddannelse = sqlReader["dyna_afslutgrund_uddannelse"]?.ToString();
            DynaAfslutgrundUdloebafperiode = sqlReader["dyna_afslutgrund_udloebafperiode"]?.ToString();
            DynaAfsluttetAarsag = sqlReader["dyna_afsluttet_aarsag"]?.ToString();
            DynaAfsluttetBeskrivelse = sqlReader["dyna_afsluttet_beskrivelse"]?.ToString();
            DynaAfsluttetOpstartsdato = sqlReader["dyna_afsluttet_opstartsdato"]?.ToString();
            DynaAntalmoeder = sqlReader["dyna_antalmoeder"]?.ToString();
            DynaAntaloutplacementmoeder = sqlReader["dyna_antaloutplacementmoeder"]?.ToString();
            DynaAntaloutplacementmoederandet = sqlReader["dyna_antaloutplacementmoederandet"]?.ToString();
            DynaAntaltimer = sqlReader["dyna_antaltimer"]?.ToString();
            DynaAttentionemail = sqlReader["dyna_attentionemail"]?.ToString();
            DynaBaggrundforhenvisning = sqlReader["dyna_baggrundforhenvisning"]?.ToString();
            DynaBeloebexmoms = sqlReader["dyna_beloebexmoms"]?.ToString();
            DynaBookedmoedetimer = sqlReader["dyna_bookedmoedetimer"]?.ToString();
            DynaBookedmoedetimerDate = sqlReader["dyna_bookedmoedetimer_date"]?.ToString();
            DynaBookedmoedetimerState = sqlReader["dyna_bookedmoedetimer_state"]?.ToString();
            DynaBudgetterettimer = sqlReader["dyna_budgetterettimer"]?.ToString();
            DynaCpr = sqlReader["dyna_cpr"]?.ToString();
            DynaDatoForSidsteMoede = sqlReader["dyna_dato_for_sidste_moede"]?.ToString();
            DynaDebitor = sqlReader["dyna_debitor"]?.ToString();
            DynaDebitoratt = sqlReader["dyna_debitoratt"]?.ToString();
            DynaDebitorattention = sqlReader["dyna_debitorattention"]?.ToString();
            DynaDeltagerid = sqlReader["dyna_deltagerid"]?.ToString();
            DynaEvalueringAfsendt = sqlReader["dyna_evaluering_afsendt"]?.ToString();
            DynaEvalueringUdfyldt = sqlReader["dyna_evaluering_udfyldt"]?.ToString();
            DynaEvalueringlink = sqlReader["dyna_evalueringlink"]?.ToString();
            DynaEvalueringsmaade = sqlReader["dyna_evalueringsmaade"]?.ToString();
            DynaFakturadato = sqlReader["dyna_fakturadato"]?.ToString();
            DynaFakturastatus = sqlReader["dyna_fakturastatus"]?.ToString();
            DynaFakturerdeltagerdirekte = sqlReader["dyna_fakturerdeltagerdirekte"]?.ToString();
            DynaFirma = sqlReader["dyna_firma"]?.ToString();
            DynaFirmaoplysningerquick = sqlReader["dyna_firmaoplysningerquick"]?.ToString();
            DynaFratraedelsesdato = sqlReader["dyna_fratraedelsesdato"]?.ToString();
            DynaGeografiskplacering = sqlReader["dyna_geografiskplacering"]?.ToString();
            DynaGeografiskplaceringandet = sqlReader["dyna_geografiskplaceringandet"]?.ToString();
            DynaHenvisendemedarbejder = sqlReader["dyna_henvisendemedarbejder"]?.ToString();
            DynaHenvisendemedarbejderKons = sqlReader["dyna_henvisendemedarbejder_kons"]?.ToString();
            DynaHenvisendemedarbejderini = sqlReader["dyna_henvisendemedarbejderini"]?.ToString();
            DynaJobtitel = sqlReader["dyna_jobtitel"]?.ToString();
            DynaJobvirksomhed = sqlReader["dyna_jobvirksomhed"]?.ToString();
            DynaKandidaten = sqlReader["dyna_kandidaten"]?.ToString();
            DynaKontaktessenest = sqlReader["dyna_kontaktessenest"]?.ToString();
            DynaKontaktestidligst = sqlReader["dyna_kontaktestidligst"]?.ToString();
            DynaKursusid = sqlReader["dyna_kursusid"]?.ToString();
            DynaLmsadgang = sqlReader["dyna_lmsadgang"]?.ToString();
            DynaLtafsendtbrevtdato = sqlReader["dyna_ltafsendtbrevtdato"]?.ToString();
            DynaLtdkning = sqlReader["dyna_ltdkning"]?.ToString();
            DynaLtmodtagetwebformulardato = sqlReader["dyna_ltmodtagetwebformulardato"]?.ToString();
            DynaName = sqlReader["dyna_name"]?.ToString();
            DynaOpgavelosendekonsulent = sqlReader["dyna_opgavelosendekonsulent"]?.ToString();
            DynaOpstartsdato = sqlReader["dyna_opstartsdato"]?.ToString();
            DynaOrdrebekraeftelseafsendt = sqlReader["dyna_ordrebekraeftelseafsendt"]?.ToString();
            DynaOutplacementid = sqlReader["dyna_outplacementid"]?.ToString();
            DynaOutplacementtype = sqlReader["dyna_outplacementtype"]?.ToString();
            DynaProduktkategori = sqlReader["dyna_produktkategori"]?.ToString();
            DynaRestmoedetid = sqlReader["dyna_restmoedetid"]?.ToString();
            DynaResttid = sqlReader["dyna_resttid"]?.ToString();
            DynaSaelger = sqlReader["dyna_saelger"]?.ToString();
            DynaSalgskanaler = sqlReader["dyna_salgskanaler"]?.ToString();
            DynaSluttidspunkt = sqlReader["dyna_sluttidspunkt"]?.ToString();
            DynaStatus = sqlReader["dyna_status"]?.ToString();
            Modifiedby = sqlReader["modifiedby"]?.ToString();
            Modifiedon = sqlReader["modifiedon"]?.ToString();
            Statecode = sqlReader["statecode"]?.ToString();
            Statuscode = sqlReader["statuscode"]?.ToString();
        }

        public string Createdby { get; private set; }
        public string Createdon { get; private set; }
        public string DynaAarsagtilafslag { get; private set; }
        public string DynaAfslutgrundAndenloesning { get; private set; }
        public string DynaAfslutgrundMidlertidigansaettelse { get; private set; }
        public string DynaAfslutgrundNytjob { get; private set; }
        public string DynaAfslutgrundOpbrugtmoeder { get; private set; }
        public string DynaAfslutgrundPensionefterlon { get; private set; }
        public string DynaAfslutgrundUddannelse { get; private set; }
        public string DynaAfslutgrundUdloebafperiode { get; private set; }
        public string DynaAfsluttetAarsag { get; private set; }
        public string DynaAfsluttetBeskrivelse { get; private set; }
        public string DynaAfsluttetOpstartsdato { get; private set; }
        public string DynaAntalmoeder { get; private set; }
        public string DynaAntaloutplacementmoeder { get; private set; }
        public string DynaAntaloutplacementmoederandet { get; private set; }
        public string DynaAntaltimer { get; private set; }
        public string DynaAttentionemail { get; private set; }
        public string DynaBaggrundforhenvisning { get; private set; }
        public string DynaBeloebexmoms { get; private set; }
        public string DynaBookedmoedetimer { get; private set; }
        public string DynaBookedmoedetimerDate { get; private set; }
        public string DynaBookedmoedetimerState { get; private set; }
        public string DynaBudgetterettimer { get; private set; }
        public string DynaCpr { get; private set; }
        public string DynaDatoForSidsteMoede { get; private set; }
        public string DynaDebitor { get; private set; }
        public string DynaDebitoratt { get; private set; }
        public string DynaDebitorattention { get; private set; }
        public string DynaDeltagerid { get; private set; }
        public string DynaEvalueringAfsendt { get; private set; }
        public string DynaEvalueringUdfyldt { get; private set; }
        public string DynaEvalueringlink { get; private set; }
        public string DynaEvalueringsmaade { get; private set; }
        public string DynaFakturadato { get; private set; }
        public string DynaFakturastatus { get; private set; }
        public string DynaFakturerdeltagerdirekte { get; private set; }
        public string DynaFirma { get; private set; }
        public string DynaFirmaoplysningerquick { get; private set; }
        public string DynaFratraedelsesdato { get; private set; }
        public string DynaGeografiskplacering { get; private set; }
        public string DynaGeografiskplaceringandet { get; private set; }
        public string DynaHenvisendemedarbejder { get; private set; }
        public string DynaHenvisendemedarbejderKons { get; private set; }
        public string DynaHenvisendemedarbejderini { get; private set; }
        public string DynaJobtitel { get; private set; }
        public string DynaJobvirksomhed { get; private set; }
        public string DynaKandidaten { get; private set; }
        public string DynaKontaktessenest { get; private set; }
        public string DynaKontaktestidligst { get; private set; }
        public string DynaKursusid { get; private set; }
        public string DynaLmsadgang { get; private set; }
        public string DynaLtafsendtbrevtdato { get; private set; }
        public string DynaLtdkning { get; private set; }
        public string DynaLtmodtagetwebformulardato { get; private set; }
        public string DynaName { get; private set; }
        public string DynaOpgavelosendekonsulent { get; private set; }
        public string DynaOpstartsdato { get; private set; }
        public string DynaOrdrebekraeftelseafsendt { get; private set; }
        public string DynaOutplacementid { get; private set; }
        public string DynaOutplacementtype { get; private set; }
        public string DynaProduktkategori { get; private set; }
        public string DynaRestmoedetid { get; private set; }
        public string DynaResttid { get; private set; }
        public string DynaSaelger { get; private set; }
        public string DynaSalgskanaler { get; private set; }
        public string DynaSluttidspunkt { get; private set; }
        public string DynaStatus { get; private set; }
        public string Modifiedby { get; private set; }
        public string Modifiedon { get; private set; }
        public string Statecode { get; private set; }
        public string Statuscode { get; private set; }
    }
}
