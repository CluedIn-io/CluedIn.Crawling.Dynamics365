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
    public class DynaParticipantClueProducer : BaseClueProducer<DynaParticipant>
    {
        private readonly IClueFactory _factory;

        public DynaParticipantClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(DynaParticipant input, Guid id)
        {

            var clue = _factory.Create("/Deltager", input.DynaParticipantid, id);

            var data = clue.Data.EntityData;

            // Metadata

            if (!string.IsNullOrWhiteSpace(input.DynaName))
                data.Name = input.DynaName;

            if (!string.IsNullOrWhiteSpace(input.DynaDescription))
                data.Description = input.DynaDescription;

            DateTimeOffset.TryParse(input.Createdon, out var createdDate);
            if (createdDate != null)
                data.CreatedDate = createdDate;

            DateTimeOffset.TryParse(input.Modifiedon, out var modifiedDate);
            if (modifiedDate != null)
                data.ModifiedDate = modifiedDate;

            // Aliases

            if (!string.IsNullOrWhiteSpace(input.DynaEmailadresse))
                data.Aliases.Add(input.DynaEmailadresse);

            if (!string.IsNullOrWhiteSpace(input.DynaPrimrtelefonnummer))
                data.Aliases.Add(input.DynaPrimrtelefonnummer);

            // Edges

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.DynaAccountid != null && !string.IsNullOrEmpty(input.DynaAccountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Account, EntityEdgeType.AttachedTo, input.DynaAccountid, input.DynaAccountid.ToString());

            if (input.DynaContactid != null && !string.IsNullOrEmpty(input.DynaContactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaContactid, input.DynaContactid.ToString());

            //if (input.DynaContactinvoiceid != null && !string.IsNullOrEmpty(input.DynaContactinvoiceid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaContactinvoiceid, input.DynaContactinvoiceid.ToString());

            if (input.DynaCourseCustomerId != null && !string.IsNullOrEmpty(input.DynaCourseCustomerId.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaCourseCustomerId, input.DynaCourseCustomerId.ToString());

            if (input.DynaCourseid != null && !string.IsNullOrEmpty(input.DynaCourseid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, "/Kursus", EntityEdgeType.AttachedTo, input.DynaCourseid, input.DynaCourseid.ToString());

            //if (input.DynaEksternid != null && !string.IsNullOrEmpty(input.DynaEksternid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaEksternid, input.DynaEksternid.ToString());

            //if (input.DynaKursusmodulid != null && !string.IsNullOrEmpty(input.DynaKursusmodulid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaKursusmodulid, input.DynaKursusmodulid.ToString());

            //if (input.DynaKursusrabatkode != null && !string.IsNullOrEmpty(input.DynaKursusrabatkode.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaKursusrabatkode, input.DynaKursusrabatkode.ToString());

            if (input.DynaMasterparticipantid != null && !string.IsNullOrEmpty(input.DynaMasterparticipantid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaMasterparticipantid, input.DynaMasterparticipantid.ToString());

            //if (input.DynaNavid != null && !string.IsNullOrEmpty(input.DynaNavid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaNavid, input.DynaNavid.ToString());

            //if (input.DynaOldid != null && !string.IsNullOrEmpty(input.DynaOldid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaOldid, input.DynaOldid.ToString());

            if (input.DynaParticipantautoid != null && !string.IsNullOrEmpty(input.DynaParticipantautoid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaParticipantautoid, input.DynaParticipantautoid.ToString());

            if (input.DynaParticipantguid != null && !string.IsNullOrEmpty(input.DynaParticipantguid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaParticipantguid, input.DynaParticipantguid.ToString());

            if (input.DynaParticipantid != null && !string.IsNullOrEmpty(input.DynaParticipantid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaParticipantid, input.DynaParticipantid.ToString());

            //if (input.DynaPromotioncodeid != null && !string.IsNullOrEmpty(input.DynaPromotioncodeid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaPromotioncodeid, input.DynaPromotioncodeid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            if (input.Organizationid != null && !string.IsNullOrEmpty(input.Organizationid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.AttachedTo, input.Organizationid, input.Organizationid.ToString());

            //if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            var vocab = new DynaParticipantVocabulary();

            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.DynaAccountid] = input.DynaAccountid.PrintIfAvailable();
            data.Properties[vocab.DynaAkasse] = input.DynaAkasse.PrintIfAvailable();
            data.Properties[vocab.DynaAnsttelsesforhold] = input.DynaAnsttelsesforhold.PrintIfAvailable();
            data.Properties[vocab.DynaAr237sendtmanuelt] = input.DynaAr237sendtmanuelt.PrintIfAvailable();
            data.Properties[vocab.DynaBekraeftelsesendt] = input.DynaBekraeftelsesendt.PrintIfAvailable();
            data.Properties[vocab.DynaBekraeftelsesendtdato] = input.DynaBekraeftelsesendtdato.PrintIfAvailable();
            data.Properties[vocab.DynaColleaguename] = input.DynaColleaguename.PrintIfAvailable();
            data.Properties[vocab.DynaContactid] = input.DynaContactid.PrintIfAvailable();
            data.Properties[vocab.DynaContactinvoiceid] = input.DynaContactinvoiceid.PrintIfAvailable();
            data.Properties[vocab.DynaCourseattention] = input.DynaCourseattention.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomerid] = input.DynaCourseCustomerId.PrintIfAvailable();
            data.Properties[vocab.DynaCourseid] = input.DynaCourseid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursepaid] = input.DynaCoursepaid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursepaidBase] = input.DynaCoursepaidBase.PrintIfAvailable();
            data.Properties[vocab.DynaCourseprice] = input.DynaCourseprice.PrintIfAvailable();
            data.Properties[vocab.DynaCoursepriceBase] = input.DynaCoursepriceBase.PrintIfAvailable();
            data.Properties[vocab.DynaCreatedfrom] = input.DynaCreatedfrom.PrintIfAvailable();
            data.Properties[vocab.DynaCreateinvoicelines] = input.DynaCreateinvoicelines.PrintIfAvailable();
            data.Properties[vocab.DynaCvrse] = input.DynaCvrse.PrintIfAvailable();
            data.Properties[vocab.DynaDeltagerstatusdato] = input.DynaDeltagerstatusdato.PrintIfAvailable();
            data.Properties[vocab.DynaDescription] = input.DynaDescription.PrintIfAvailable();
            data.Properties[vocab.DynaDiscountamount] = input.DynaDiscountamount.PrintIfAvailable();
            data.Properties[vocab.DynaDiscountamountBase] = input.DynaDiscountamountBase.PrintIfAvailable();
            data.Properties[vocab.DynaDiscountrate] = input.DynaDiscountrate.PrintIfAvailable();
            data.Properties[vocab.DynaDiscounttype] = input.DynaDiscounttype.PrintIfAvailable();
            data.Properties[vocab.DynaEanno] = input.DynaEanno.PrintIfAvailable();
            data.Properties[vocab.DynaEksternid] = input.DynaEksternid.PrintIfAvailable();
            data.Properties[vocab.DynaEmailadresse] = input.DynaEmailadresse.PrintIfAvailable();
            data.Properties[vocab.DynaEvaluationfullfilled] = input.DynaEvaluationfullfilled.PrintIfAvailable();
            data.Properties[vocab.DynaEvaluationsent] = input.DynaEvaluationsent.PrintIfAvailable();
            data.Properties[vocab.DynaEvaluationtype] = input.DynaEvaluationtype.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringlink] = input.DynaEvalueringlink.PrintIfAvailable();
            data.Properties[vocab.DynaFakturastatus] = input.DynaFakturastatus.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadresseattention] = input.DynaFaktureringsadresseattention.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadresseby] = input.DynaFaktureringsadresseby.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadressegade1] = input.DynaFaktureringsadressegade1.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadressegade2] = input.DynaFaktureringsadressegade2.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadresseland] = input.DynaFaktureringsadresseland.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadressenavn] = input.DynaFaktureringsadressenavn.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsadressepostnummer] = input.DynaFaktureringsadressepostnummer.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsemail] = input.DynaFaktureringsemail.PrintIfAvailable();
            data.Properties[vocab.DynaFax] = input.DynaFax.PrintIfAvailable();
            data.Properties[vocab.DynaFirmanavn] = input.DynaFirmanavn.PrintIfAvailable();
            data.Properties[vocab.DynaIndirectparticipation] = input.DynaIndirectparticipation.PrintIfAvailable();
            data.Properties[vocab.DynaInvoicereference] = input.DynaInvoicereference.PrintIfAvailable();
            data.Properties[vocab.DynaInvoicetoparticipant] = input.DynaInvoicetoparticipant.PrintIfAvailable();
            data.Properties[vocab.DynaKcslger] = input.DynaKcslger.PrintIfAvailable();
            data.Properties[vocab.DynaKursusbevisafsendt] = input.DynaKursusbevisafsendt.PrintIfAvailable();
            data.Properties[vocab.DynaKursusbevissendtdato] = input.DynaKursusbevissendtdato.PrintIfAvailable();
            data.Properties[vocab.DynaKursusmodulid] = input.DynaKursusmodulid.PrintIfAvailable();
            data.Properties[vocab.DynaKursusrabatkode] = input.DynaKursusrabatkode.PrintIfAvailable();
            data.Properties[vocab.DynaLevattention] = input.DynaLevattention.PrintIfAvailable();
            data.Properties[vocab.DynaLevbrugandenleveringsadresse] = input.DynaLevbrugandenleveringsadresse.PrintIfAvailable();
            data.Properties[vocab.DynaLevby] = input.DynaLevby.PrintIfAvailable();
            data.Properties[vocab.DynaLevfirmanavn] = input.DynaLevfirmanavn.PrintIfAvailable();
            data.Properties[vocab.DynaLevgade] = input.DynaLevgade.PrintIfAvailable();
            data.Properties[vocab.DynaLevgade2] = input.DynaLevgade2.PrintIfAvailable();
            data.Properties[vocab.DynaLevland] = input.DynaLevland.PrintIfAvailable();
            data.Properties[vocab.DynaLevpostnummer] = input.DynaLevpostnummer.PrintIfAvailable();
            data.Properties[vocab.DynaMaster] = input.DynaMaster.PrintIfAvailable();
            data.Properties[vocab.DynaMasterparticipantid] = input.DynaMasterparticipantid.PrintIfAvailable();
            data.Properties[vocab.DynaMember] = input.DynaMember.PrintIfAvailable();
            data.Properties[vocab.DynaName] = input.DynaName.PrintIfAvailable();
            data.Properties[vocab.DynaNavid] = input.DynaNavid.PrintIfAvailable();
            data.Properties[vocab.DynaOldid] = input.DynaOldid.PrintIfAvailable();
            data.Properties[vocab.DynaOmstillingsfonden] = input.DynaOmstillingsfonden.PrintIfAvailable();
            data.Properties[vocab.DynaPaamindelsesendt] = input.DynaPaamindelsesendt.PrintIfAvailable();
            data.Properties[vocab.DynaPaamindelsesendtdato] = input.DynaPaamindelsesendtdato.PrintIfAvailable();
            data.Properties[vocab.DynaPaidinvoice] = input.DynaPaidinvoice.PrintIfAvailable();
            data.Properties[vocab.DynaParticipantautoid] = input.DynaParticipantautoid.PrintIfAvailable();
            data.Properties[vocab.DynaParticipantguid] = input.DynaParticipantguid.PrintIfAvailable();
            data.Properties[vocab.DynaParticipantid] = input.DynaParticipantid.PrintIfAvailable();
            data.Properties[vocab.DynaParticipantremarks] = input.DynaParticipantremarks.PrintIfAvailable();
            data.Properties[vocab.DynaParticipated] = input.DynaParticipated.PrintIfAvailable();
            data.Properties[vocab.DynaParticipatingstatus] = input.DynaParticipatingstatus.PrintIfAvailable();
            data.Properties[vocab.DynaPrimrtelefonnummer] = input.DynaPrimrtelefonnummer.PrintIfAvailable();
            data.Properties[vocab.DynaPromotioncodeid] = input.DynaPromotioncodeid.PrintIfAvailable();
            data.Properties[vocab.DynaRabatkode] = input.DynaRabatkode.PrintIfAvailable();
            data.Properties[vocab.DynaRammeaftalerabat] = input.DynaRammeaftalerabat.PrintIfAvailable();
            data.Properties[vocab.DynaReason] = input.DynaReason.PrintIfAvailable();
            data.Properties[vocab.DynaReference] = input.DynaReference.PrintIfAvailable();
            data.Properties[vocab.DynaSalgskanaler] = input.DynaSalgskanaler.PrintIfAvailable();
            data.Properties[vocab.DynaSendkopiafbekrftelse] = input.DynaSendkopiafbekrftelse.PrintIfAvailable();
            data.Properties[vocab.DynaSendkopiafindkaldelse] = input.DynaSendkopiafindkaldelse.PrintIfAvailable();
            data.Properties[vocab.DynaSuppKompSendtmanuelt] = input.DynaSuppKompSendtmanuelt.PrintIfAvailable();
            data.Properties[vocab.DynaSupplerendeinfomodtaget] = input.DynaSupplerendeinfomodtaget.PrintIfAvailable();
            data.Properties[vocab.DynaSvu] = input.DynaSvu.PrintIfAvailable();
            data.Properties[vocab.DynaSvudato] = input.DynaSvudato.PrintIfAvailable();
            data.Properties[vocab.DynaSvustatus] = input.DynaSvustatus.PrintIfAvailable();
            data.Properties[vocab.DynaTotalamount] = input.DynaTotalamount.PrintIfAvailable();
            data.Properties[vocab.DynaTotalamountBase] = input.DynaTotalamountBase.PrintIfAvailable();
            data.Properties[vocab.DynaTotalamountpaid] = input.DynaTotalamountpaid.PrintIfAvailable();
            data.Properties[vocab.DynaTotalamountpaidBase] = input.DynaTotalamountpaidBase.PrintIfAvailable();
            data.Properties[vocab.DynaTotalproduct] = input.DynaTotalproduct.PrintIfAvailable();
            data.Properties[vocab.DynaTotalproductBase] = input.DynaTotalproductBase.PrintIfAvailable();
            data.Properties[vocab.DynaTotalproductpaid] = input.DynaTotalproductpaid.PrintIfAvailable();
            data.Properties[vocab.DynaTotalproductpaidBase] = input.DynaTotalproductpaidBase.PrintIfAvailable();
            data.Properties[vocab.DynaUnsubscribed] = input.DynaUnsubscribed.PrintIfAvailable();
            data.Properties[vocab.DynaUnsubscribeddate] = input.DynaUnsubscribeddate.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadresseattention] = input.DynaVirksomhedsadresseattention.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadresseby] = input.DynaVirksomhedsadresseby.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadressegade1] = input.DynaVirksomhedsadressegade1.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadressegade2] = input.DynaVirksomhedsadressegade2.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadresseland] = input.DynaVirksomhedsadresseland.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadressenavn] = input.DynaVirksomhedsadressenavn.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsadressepostnummer] = input.DynaVirksomhedsadressepostnummer.PrintIfAvailable();
            data.Properties[vocab.DynaWebsted] = input.DynaWebsted.PrintIfAvailable();
            data.Properties[vocab.DynaWebtilmeldingdata] = input.DynaWebtilmeldingdata.PrintIfAvailable();
            data.Properties[vocab.Exchangerate] = input.Exchangerate.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.Organizationid] = input.Organizationid.PrintIfAvailable();
            data.Properties[vocab.Statecode] = input.Statecode.PrintIfAvailable();
            data.Properties[vocab.Statuscode] = input.Statuscode.PrintIfAvailable();
            data.Properties[vocab.Transactioncurrencyid] = input.Transactioncurrencyid.PrintIfAvailable();

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


