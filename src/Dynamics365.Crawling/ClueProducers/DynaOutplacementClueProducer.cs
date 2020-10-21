using System;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public class DynaOutplacementClueProducer : BaseClueProducer<DynaOutplacement>
    {
        private readonly IClueFactory _factory;

        public DynaOutplacementClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(DynaOutplacement input, Guid id)
        {
            var clue = _factory.Create("/Outplacement", input.DynaOutplacementid, id);

            var data = clue.Data.EntityData;

            // Metadata

            if (!string.IsNullOrWhiteSpace(input.DynaName))
                data.Name = input.DynaName;

            DateTimeOffset.TryParse(input.Createdon, out var createdDate);
            if (createdDate != null)
                data.CreatedDate = createdDate;

            DateTimeOffset.TryParse(input.Modifiedon, out var modifiedDate);
            if (modifiedDate != null)
                data.ModifiedDate = modifiedDate;

            // Aliases

            if (!string.IsNullOrEmpty(input.DynaName))
                data.Aliases.Add(input.DynaName);

            // Edges

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.DynaDeltagerid != null && !string.IsNullOrEmpty(input.DynaDeltagerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaDeltagerid, input.DynaDeltagerid.ToString());

            if (input.DynaKursusid != null && !string.IsNullOrEmpty(input.DynaKursusid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, "/Kursus", EntityEdgeType.AttachedTo, input.DynaKursusid, input.DynaKursusid.ToString());

            //if (input.DynaRestmoedetid != null && !string.IsNullOrEmpty(input.DynaRestmoedetid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaRestmoedetid, input.DynaRestmoedetid.ToString());

            //if (input.DynaResttid != null && !string.IsNullOrEmpty(input.DynaResttid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaResttid, input.DynaResttid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            var vocab = new DynaOutplacementVocabulary();

            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.DynaAarsagtilafslag] = input.DynaAarsagtilafslag.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundAndenloesning] = input.DynaAfslutgrundAndenloesning.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundMidlertidigansaettelse] = input.DynaAfslutgrundMidlertidigansaettelse.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundNytjob] = input.DynaAfslutgrundNytjob.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundOpbrugtmoeder] = input.DynaAfslutgrundOpbrugtmoeder.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundPensionefterlon] = input.DynaAfslutgrundPensionefterlon.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundUddannelse] = input.DynaAfslutgrundUddannelse.PrintIfAvailable();
            data.Properties[vocab.DynaAfslutgrundUdloebafperiode] = input.DynaAfslutgrundUdloebafperiode.PrintIfAvailable();
            data.Properties[vocab.DynaAfsluttetAarsag] = input.DynaAfsluttetAarsag.PrintIfAvailable();
            data.Properties[vocab.DynaAfsluttetBeskrivelse] = input.DynaAfsluttetBeskrivelse.PrintIfAvailable();
            data.Properties[vocab.DynaAfsluttetOpstartsdato] = input.DynaAfsluttetOpstartsdato.PrintIfAvailable();
            data.Properties[vocab.DynaAntalmoeder] = input.DynaAntalmoeder.PrintIfAvailable();
            data.Properties[vocab.DynaAntaloutplacementmoeder] = input.DynaAntaloutplacementmoeder.PrintIfAvailable();
            data.Properties[vocab.DynaAntaloutplacementmoederandet] = input.DynaAntaloutplacementmoederandet.PrintIfAvailable();
            data.Properties[vocab.DynaAntaltimer] = input.DynaAntaltimer.PrintIfAvailable();
            data.Properties[vocab.DynaAttentionemail] = input.DynaAttentionemail.PrintIfAvailable();
            data.Properties[vocab.DynaBaggrundforhenvisning] = input.DynaBaggrundforhenvisning.PrintIfAvailable();
            data.Properties[vocab.DynaBeloebexmoms] = input.DynaBeloebexmoms.PrintIfAvailable();
            data.Properties[vocab.DynaBookedmoedetimer] = input.DynaBookedmoedetimer.PrintIfAvailable();
            data.Properties[vocab.DynaBookedmoedetimerDate] = input.DynaBookedmoedetimerDate.PrintIfAvailable();
            data.Properties[vocab.DynaBookedmoedetimerState] = input.DynaBookedmoedetimerState.PrintIfAvailable();
            data.Properties[vocab.DynaBudgetterettimer] = input.DynaBudgetterettimer.PrintIfAvailable();
            data.Properties[vocab.DynaCpr] = input.DynaCpr.PrintIfAvailable();
            data.Properties[vocab.DynaDatoForSidsteMoede] = input.DynaDatoForSidsteMoede.PrintIfAvailable();
            data.Properties[vocab.DynaDebitor] = input.DynaDebitor.PrintIfAvailable();
            data.Properties[vocab.DynaDebitoratt] = input.DynaDebitoratt.PrintIfAvailable();
            data.Properties[vocab.DynaDebitorattention] = input.DynaDebitorattention.PrintIfAvailable();
            data.Properties[vocab.DynaDeltagerid] = input.DynaDeltagerid.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringAfsendt] = input.DynaEvalueringAfsendt.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringUdfyldt] = input.DynaEvalueringUdfyldt.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringlink] = input.DynaEvalueringlink.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringsmaade] = input.DynaEvalueringsmaade.PrintIfAvailable();
            data.Properties[vocab.DynaFakturadato] = input.DynaFakturadato.PrintIfAvailable();
            data.Properties[vocab.DynaFakturastatus] = input.DynaFakturastatus.PrintIfAvailable();
            data.Properties[vocab.DynaFakturerdeltagerdirekte] = input.DynaFakturerdeltagerdirekte.PrintIfAvailable();
            data.Properties[vocab.DynaFirma] = input.DynaFirma.PrintIfAvailable();
            data.Properties[vocab.DynaFirmaoplysningerquick] = input.DynaFirmaoplysningerquick.PrintIfAvailable();
            data.Properties[vocab.DynaFratraedelsesdato] = input.DynaFratraedelsesdato.PrintIfAvailable();
            data.Properties[vocab.DynaGeografiskplacering] = input.DynaGeografiskplacering.PrintIfAvailable();
            data.Properties[vocab.DynaGeografiskplaceringandet] = input.DynaGeografiskplaceringandet.PrintIfAvailable();
            data.Properties[vocab.DynaHenvisendemedarbejder] = input.DynaHenvisendemedarbejder.PrintIfAvailable();
            data.Properties[vocab.DynaHenvisendemedarbejderKons] = input.DynaHenvisendemedarbejderKons.PrintIfAvailable();
            data.Properties[vocab.DynaHenvisendemedarbejderini] = input.DynaHenvisendemedarbejderini.PrintIfAvailable();
            data.Properties[vocab.DynaJobtitel] = input.DynaJobtitel.PrintIfAvailable();
            data.Properties[vocab.DynaJobvirksomhed] = input.DynaJobvirksomhed.PrintIfAvailable();
            data.Properties[vocab.DynaKandidaten] = input.DynaKandidaten.PrintIfAvailable();
            data.Properties[vocab.DynaKontaktessenest] = input.DynaKontaktessenest.PrintIfAvailable();
            data.Properties[vocab.DynaKontaktestidligst] = input.DynaKontaktestidligst.PrintIfAvailable();
            data.Properties[vocab.DynaKursusid] = input.DynaKursusid.PrintIfAvailable();
            data.Properties[vocab.DynaLmsadgang] = input.DynaLmsadgang.PrintIfAvailable();
            data.Properties[vocab.DynaLtafsendtbrevtdato] = input.DynaLtafsendtbrevtdato.PrintIfAvailable();
            data.Properties[vocab.DynaLtdkning] = input.DynaLtdkning.PrintIfAvailable();
            data.Properties[vocab.DynaLtmodtagetwebformulardato] = input.DynaLtmodtagetwebformulardato.PrintIfAvailable();
            data.Properties[vocab.DynaName] = input.DynaName.PrintIfAvailable();
            data.Properties[vocab.DynaOpgavelosendekonsulent] = input.DynaOpgavelosendekonsulent.PrintIfAvailable();
            data.Properties[vocab.DynaOpstartsdato] = input.DynaOpstartsdato.PrintIfAvailable();
            data.Properties[vocab.DynaOrdrebekraeftelseafsendt] = input.DynaOrdrebekraeftelseafsendt.PrintIfAvailable();
            data.Properties[vocab.DynaOutplacementid] = input.DynaOutplacementid.PrintIfAvailable();
            data.Properties[vocab.DynaOutplacementtype] = input.DynaOutplacementtype.PrintIfAvailable();
            data.Properties[vocab.DynaProduktkategori] = input.DynaProduktkategori.PrintIfAvailable();
            data.Properties[vocab.DynaRestmoedetid] = input.DynaRestmoedetid.PrintIfAvailable();
            data.Properties[vocab.DynaResttid] = input.DynaResttid.PrintIfAvailable();
            data.Properties[vocab.DynaSaelger] = input.DynaSaelger.PrintIfAvailable();
            data.Properties[vocab.DynaSalgskanaler] = input.DynaSalgskanaler.PrintIfAvailable();
            data.Properties[vocab.DynaSluttidspunkt] = input.DynaSluttidspunkt.PrintIfAvailable();
            data.Properties[vocab.DynaStatus] = input.DynaStatus.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.Statecode] = input.Statecode.PrintIfAvailable();
            data.Properties[vocab.Statuscode] = input.Statuscode.PrintIfAvailable();

            clue.ValidationRuleSuppressions.AddRange(new[]
            {
                RuleConstants.METADATA_001_Name_MustBeSet,
                RuleConstants.PROPERTIES_001_MustExist,
                RuleConstants.METADATA_002_Uri_MustBeSet,
                RuleConstants.METADATA_003_Author_Name_MustBeSet,
                RuleConstants.METADATA_005_PreviewImage_RawData_MustBeSet
            });

            return clue;
        }
    }
}


