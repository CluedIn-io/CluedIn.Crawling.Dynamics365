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
    public class DynaCoursecustomerClueProducer : BaseClueProducer<DynaCoursecustomer>
    {
        private readonly IClueFactory _factory;

        public DynaCoursecustomerClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(DynaCoursecustomer input, Guid id)
        {

            var clue = _factory.Create("/Kursusdeltager", $"FILL_IN", id);

            var data = clue.Data.EntityData;

            // Metadata

            //data.Name = input.Name;

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
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.DynaCountry != null && !string.IsNullOrEmpty(input.DynaCountry.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaCountry, input.DynaCountry.ToString());

            if (input.DynaCoursecustomeraccountid != null && !string.IsNullOrEmpty(input.DynaCoursecustomeraccountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaCoursecustomeraccountid, input.DynaCoursecustomeraccountid.ToString());

            if (input.DynaCoursecustomercontactid != null && !string.IsNullOrEmpty(input.DynaCoursecustomercontactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaCoursecustomercontactid, input.DynaCoursecustomercontactid.ToString());

            if (input.DynaCoursecustomerid != null && !string.IsNullOrEmpty(input.DynaCoursecustomerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaCoursecustomerid, input.DynaCoursecustomerid.ToString());

            if (input.DynaNavtemplateid != null && !string.IsNullOrEmpty(input.DynaNavtemplateid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaNavtemplateid, input.DynaNavtemplateid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());


            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);


            var vocab = new DynaCoursecustomerVocabulary();

            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.DynaAddressLine1] = input.DynaAddressLine1.PrintIfAvailable();
            data.Properties[vocab.DynaAddressLine2] = input.DynaAddressLine2.PrintIfAvailable();
            data.Properties[vocab.DynaApproved] = input.DynaApproved.PrintIfAvailable();
            data.Properties[vocab.DynaAttention] = input.DynaAttention.PrintIfAvailable();
            data.Properties[vocab.DynaCity] = input.DynaCity.PrintIfAvailable();
            data.Properties[vocab.DynaCountry] = input.DynaCountry.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomeraccountid] = input.DynaCoursecustomeraccountid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomercontactid] = input.DynaCoursecustomercontactid.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomerid] = input.DynaCoursecustomerid.PrintIfAvailable();
            data.Properties[vocab.DynaCustomername] = input.DynaCustomername.PrintIfAvailable();
            data.Properties[vocab.DynaCvrp] = input.DynaCvrp.PrintIfAvailable();
            data.Properties[vocab.DynaCvrse] = input.DynaCvrse.PrintIfAvailable();
            data.Properties[vocab.DynaDirty] = input.DynaDirty.PrintIfAvailable();
            data.Properties[vocab.DynaEannummer] = input.DynaEannummer.PrintIfAvailable();
            data.Properties[vocab.DynaEanpkrvet] = input.DynaEanpkrvet.PrintIfAvailable();
            data.Properties[vocab.DynaEmail] = input.DynaEmail.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsemail] = input.DynaFaktureringsemail.PrintIfAvailable();
            data.Properties[vocab.DynaFax] = input.DynaFax.PrintIfAvailable();
            data.Properties[vocab.DynaName] = input.DynaName.PrintIfAvailable();
            data.Properties[vocab.DynaNavtemplateid] = input.DynaNavtemplateid.PrintIfAvailable();
            data.Properties[vocab.DynaPostalcode] = input.DynaPostalcode.PrintIfAvailable();
            data.Properties[vocab.DynaPrimarycustomer] = input.DynaPrimarycustomer.PrintIfAvailable();
            data.Properties[vocab.DynaTelephone1] = input.DynaTelephone1.PrintIfAvailable();
            data.Properties[vocab.DynaType] = input.DynaType.PrintIfAvailable();
            data.Properties[vocab.DynaWebsted] = input.DynaWebsted.PrintIfAvailable();
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


