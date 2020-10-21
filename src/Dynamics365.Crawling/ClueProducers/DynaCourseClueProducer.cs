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
    public class DynaCourseClueProducer : BaseClueProducer<DynaCourse>
    {
        private readonly IClueFactory _factory;

        public DynaCourseClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(DynaCourse input, Guid id)
        {
            var clue = _factory.Create("/Kursus", input.DynaCourseid, id);

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

            if (!string.IsNullOrEmpty(input.DynaTelephone1))
                data.Aliases.Add(input.DynaTelephone1);

            // Edges

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.DynaAccountid != null && !string.IsNullOrEmpty(input.DynaAccountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Account, EntityEdgeType.AttachedTo, input.DynaAccountid, input.DynaAccountid.ToString());

            if (input.DynaContactid != null && !string.IsNullOrEmpty(input.DynaContactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaContactid, input.DynaContactid.ToString());

            if (input.DynaCoursecustomerid != null && !string.IsNullOrEmpty(input.DynaCoursecustomerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaCoursecustomerid, input.DynaCoursecustomerid.ToString());

            if (input.DynaCourseitemid != null && !string.IsNullOrEmpty(input.DynaCourseitemid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.AttachedTo, input.DynaCourseitemid, input.DynaCourseitemid.ToString());

            if (input.DynaCourseresponsibleid != null && !string.IsNullOrEmpty(input.DynaCourseresponsibleid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaCourseresponsibleid, input.DynaCourseresponsibleid.ToString());

            //if (input.DynaCoursetemplate != null && !string.IsNullOrEmpty(input.DynaCoursetemplate.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaCoursetemplate, input.DynaCoursetemplate.ToString());

            if (input.DynaItemnavid != null && !string.IsNullOrEmpty(input.DynaItemnavid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Product, EntityEdgeType.AttachedTo, input.DynaItemnavid, input.DynaItemnavid.ToString());

            //if (input.DynaItemtemplateid != null && !string.IsNullOrEmpty(input.DynaItemtemplateid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaItemtemplateid, input.DynaItemtemplateid.ToString());

            if (input.DynaKonsulentid != null && !string.IsNullOrEmpty(input.DynaKonsulentid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaKonsulentid, input.DynaKonsulentid.ToString());

            if (input.DynaLocationid != null && !string.IsNullOrEmpty(input.DynaLocationid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Location, EntityEdgeType.AttachedTo, input.DynaLocationid, input.DynaLocationid.ToString());

            if (input.DynaMastereventid != null && !string.IsNullOrEmpty(input.DynaMastereventid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Calendar.Event, EntityEdgeType.AttachedTo, input.DynaMastereventid, input.DynaMastereventid.ToString());

            //if (input.DynaNavid != null && !string.IsNullOrEmpty(input.DynaNavid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaNavid, input.DynaNavid.ToString());

            //if (input.DynaOldid != null && !string.IsNullOrEmpty(input.DynaOldid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.DynaOldid, input.DynaOldid.ToString());

            if (input.DynaSpeakerid != null && !string.IsNullOrEmpty(input.DynaSpeakerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.DynaSpeakerid, input.DynaSpeakerid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            if (input.Organizationid != null && !string.IsNullOrEmpty(input.Organizationid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.AttachedTo, input.Organizationid, input.Organizationid.ToString());

            //if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());


            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);


            var vocab = new DynaCourseVocabulary();

            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.DynaAccountid] = input.DynaAccountid.PrintIfAvailable();
            data.Properties[vocab.DynaAddinvoicedate] = input.DynaAddinvoicedate.PrintIfAvailable();
            data.Properties[vocab.DynaAftaltpris] = input.DynaAftaltpris.PrintIfAvailable();
            data.Properties[vocab.DynaBemrkninger] = input.DynaBemrkninger.PrintIfAvailable();
            data.Properties[vocab.DynaBreakevennumber] = input.DynaBreakevennumber.PrintIfAvailable();
            data.Properties[vocab.DynaCity] = input.DynaCity.PrintIfAvailable();
            data.Properties[vocab.DynaContactid] = input.DynaContactid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomerid] = input.DynaCoursecustomerid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursedate] = input.DynaCoursedate.PrintIfAvailable();
            data.Properties[vocab.DynaCourseevent] = input.DynaCourseevent.PrintIfAvailable();
            data.Properties[vocab.DynaCourseguid] = input.DynaCourseguid.PrintIfAvailable();
            data.Properties[vocab.DynaCourseid] = input.DynaCourseid.PrintIfAvailable();
            data.Properties[vocab.DynaCourseitemid] = input.DynaCourseitemid.PrintIfAvailable();
            data.Properties[vocab.DynaCourseresponsibleid] = input.DynaCourseresponsibleid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursetemplate] = input.DynaCoursetemplate.PrintIfAvailable();
            data.Properties[vocab.DynaCoursetype] = input.DynaCoursetype.PrintIfAvailable();
            data.Properties[vocab.DynaCourseurl] = input.DynaCourseurl.PrintIfAvailable();
            data.Properties[vocab.DynaDcpautoemailbekraeftelse] = input.DynaDcpautoemailbekraeftelse.PrintIfAvailable();
            data.Properties[vocab.DynaDcpautoemailkursusbevis] = input.DynaDcpautoemailkursusbevis.PrintIfAvailable();
            data.Properties[vocab.DynaDcpautoemailpaamindelse] = input.DynaDcpautoemailpaamindelse.PrintIfAvailable();
            data.Properties[vocab.DynaDcpvedhaeftdeltagerliste] = input.DynaDcpvedhaeftdeltagerliste.PrintIfAvailable();
            data.Properties[vocab.DynaDescription] = input.DynaDescription.PrintIfAvailable();
            data.Properties[vocab.DynaDuration] = input.DynaDuration.PrintIfAvailable();
            data.Properties[vocab.DynaEnddate] = input.DynaEnddate.PrintIfAvailable();
            data.Properties[vocab.DynaEvaluationsend] = input.DynaEvaluationsend.PrintIfAvailable();
            data.Properties[vocab.DynaEvaluationtype] = input.DynaEvaluationtype.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringsudsendelse] = input.DynaEvalueringsudsendelse.PrintIfAvailable();
            data.Properties[vocab.DynaExpandedcourse] = input.DynaExpandedcourse.PrintIfAvailable();
            data.Properties[vocab.DynaFakturastatus] = input.DynaFakturastatus.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureretbelob] = input.DynaFaktureretbelob.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureretbelobBase] = input.DynaFaktureretbelobBase.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsnavn] = input.DynaFaktureringsnavn.PrintIfAvailable();
            data.Properties[vocab.DynaFriteksttilkursusbekrftelse] = input.DynaFriteksttilkursusbekrftelse.PrintIfAvailable();
            data.Properties[vocab.DynaFriteksttilkursusbevisbagside] = input.DynaFriteksttilkursusbevisbagside.PrintIfAvailable();
            data.Properties[vocab.DynaFriteksttilkursusprogram] = input.DynaFriteksttilkursusprogram.PrintIfAvailable();
            data.Properties[vocab.DynaFriteksttilpmindelse] = input.DynaFriteksttilpmindelse.PrintIfAvailable();
            data.Properties[vocab.DynaInfoomkurset] = input.DynaInfoomkurset.PrintIfAvailable();
            data.Properties[vocab.DynaInstructorname] = input.DynaInstructorname.PrintIfAvailable();
            data.Properties[vocab.DynaInternalnotes] = input.DynaInternalnotes.PrintIfAvailable();
            data.Properties[vocab.DynaInvoicedirectly] = input.DynaInvoicedirectly.PrintIfAvailable();
            data.Properties[vocab.DynaItemname] = input.DynaItemname.PrintIfAvailable();
            data.Properties[vocab.DynaItemnavid] = input.DynaItemnavid.PrintIfAvailable();
            data.Properties[vocab.DynaItemtemplateid] = input.DynaItemtemplateid.PrintIfAvailable();
            data.Properties[vocab.DynaKonsulentid] = input.DynaKonsulentid.PrintIfAvailable();
            data.Properties[vocab.DynaKursusfaellesafholdelse] = input.DynaKursusfaellesafholdelse.PrintIfAvailable();
            data.Properties[vocab.DynaLastregistrationdate] = input.DynaLastregistrationdate.PrintIfAvailable();
            data.Properties[vocab.DynaLastunregisterdate] = input.DynaLastunregisterdate.PrintIfAvailable();
            data.Properties[vocab.DynaLmskursus] = input.DynaLmskursus.PrintIfAvailable();
            data.Properties[vocab.DynaLocationid] = input.DynaLocationid.PrintIfAvailable();
            data.Properties[vocab.DynaLocationname] = input.DynaLocationname.PrintIfAvailable();
            data.Properties[vocab.DynaMaster] = input.DynaMaster.PrintIfAvailable();
            data.Properties[vocab.DynaMastereventid] = input.DynaMastereventid.PrintIfAvailable();
            data.Properties[vocab.DynaMaxnumberofparticipant] = input.DynaMaxnumberofparticipant.PrintIfAvailable();
            data.Properties[vocab.DynaMemberprice] = input.DynaMemberprice.PrintIfAvailable();
            data.Properties[vocab.DynaMemberpriceBase] = input.DynaMemberpriceBase.PrintIfAvailable();
            data.Properties[vocab.DynaName] = input.DynaName.PrintIfAvailable();
            data.Properties[vocab.DynaNavid] = input.DynaNavid.PrintIfAvailable();
            data.Properties[vocab.DynaNonmemberprice] = input.DynaNonmemberprice.PrintIfAvailable();
            data.Properties[vocab.DynaNonmemberpriceBase] = input.DynaNonmemberpriceBase.PrintIfAvailable();
            data.Properties[vocab.DynaOldid] = input.DynaOldid.PrintIfAvailable();
            data.Properties[vocab.DynaOprettelsesmailsendt] = input.DynaOprettelsesmailsendt.PrintIfAvailable();
            data.Properties[vocab.DynaOrderedaccommodations] = input.DynaOrderedaccommodations.PrintIfAvailable();
            data.Properties[vocab.DynaOrderedmeals] = input.DynaOrderedmeals.PrintIfAvailable();
            data.Properties[vocab.DynaOverfoertilhjemmeside] = input.DynaOverfoertilhjemmeside.PrintIfAvailable();
            data.Properties[vocab.DynaPamindelsesendttilunderviser] = input.DynaPamindelsesendttilunderviser.PrintIfAvailable();
            data.Properties[vocab.DynaPmindelsesendt] = input.DynaPmindelsesendt.PrintIfAvailable();
            data.Properties[vocab.DynaPostalcode] = input.DynaPostalcode.PrintIfAvailable();
            data.Properties[vocab.DynaReadyforinvoice] = input.DynaReadyforinvoice.PrintIfAvailable();
            data.Properties[vocab.DynaRegister] = input.DynaRegister.PrintIfAvailable();
            data.Properties[vocab.DynaResponsibleemail] = input.DynaResponsibleemail.PrintIfAvailable();
            data.Properties[vocab.DynaResponsiblename] = input.DynaResponsiblename.PrintIfAvailable();
            data.Properties[vocab.DynaSalgsmulighed] = input.DynaSalgsmulighed.PrintIfAvailable();
            data.Properties[vocab.DynaSenttoinvoice] = input.DynaSenttoinvoice.PrintIfAvailable();
            data.Properties[vocab.DynaShowmaxparticipant] = input.DynaShowmaxparticipant.PrintIfAvailable();
            data.Properties[vocab.DynaShowparticipant] = input.DynaShowparticipant.PrintIfAvailable();
            data.Properties[vocab.DynaShowwaitinglist] = input.DynaShowwaitinglist.PrintIfAvailable();
            data.Properties[vocab.DynaSpeakerid] = input.DynaSpeakerid.PrintIfAvailable();
            data.Properties[vocab.DynaStreet1] = input.DynaStreet1.PrintIfAvailable();
            data.Properties[vocab.DynaStreet2] = input.DynaStreet2.PrintIfAvailable();
            data.Properties[vocab.DynaSubcoursedatesdescription] = input.DynaSubcoursedatesdescription.PrintIfAvailable();
            data.Properties[vocab.DynaTeaser] = input.DynaTeaser.PrintIfAvailable();
            data.Properties[vocab.DynaTelephone1] = input.DynaTelephone1.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomi] = input.DynaTotalkursusokonomi.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomiBase] = input.DynaTotalkursusokonomiBase.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomiDate] = input.DynaTotalkursusokonomiDate.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomiState] = input.DynaTotalkursusokonomiState.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomivip] = input.DynaTotalkursusokonomivip.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomivipBase] = input.DynaTotalkursusokonomivipBase.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomivipDate] = input.DynaTotalkursusokonomivipDate.PrintIfAvailable();
            data.Properties[vocab.DynaTotalkursusokonomivipState] = input.DynaTotalkursusokonomivipState.PrintIfAvailable();
            data.Properties[vocab.DynaUndervisergodkendt] = input.DynaUndervisergodkendt.PrintIfAvailable();
            data.Properties[vocab.DynaWaitinglist] = input.DynaWaitinglist.PrintIfAvailable();
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


