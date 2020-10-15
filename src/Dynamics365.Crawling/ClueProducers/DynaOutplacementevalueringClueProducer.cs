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
    public class DynaOutplacementevalueringClueProducer : BaseClueProducer<DynaOutplacementevaluering>
    {
        private readonly IClueFactory _factory;

        public DynaOutplacementevalueringClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(DynaOutplacementevaluering input, Guid id)
        {

            var clue = _factory.Create("/Outplacement Evaluering", $"FILL_IN", id);

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
            if (!string.IsNullOrEmpty(input.Emailaddress))
                data.Aliases.Add(input.Emailaddress);


            // Edges

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.DynaImportguid != null && !string.IsNullOrEmpty(input.DynaImportguid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaImportguid, input.DynaImportguid.ToString());

            if (input.DynaKontakpersonid != null && !string.IsNullOrEmpty(input.DynaKontakpersonid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaKontakpersonid, input.DynaKontakpersonid.ToString());

            if (input.DynaOutplacementevalueringid != null && !string.IsNullOrEmpty(input.DynaOutplacementevalueringid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaOutplacementevalueringid, input.DynaOutplacementevalueringid.ToString());

            if (input.DynaOutplacementid != null && !string.IsNullOrEmpty(input.DynaOutplacementid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaOutplacementid, input.DynaOutplacementid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());


            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);


            var vocab = new DynaOutplacementevalueringVocabulary();

            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg01] = input.DynaEvalspg01.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg01note] = input.DynaEvalspg01note.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg02] = input.DynaEvalspg02.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg02note] = input.DynaEvalspg02note.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg03] = input.DynaEvalspg03.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg03note] = input.DynaEvalspg03note.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg04] = input.DynaEvalspg04.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg04note] = input.DynaEvalspg04note.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg05] = input.DynaEvalspg05.PrintIfAvailable();
            data.Properties[vocab.DynaEvalspg05note] = input.DynaEvalspg05note.PrintIfAvailable();
            data.Properties[vocab.DynaEvalueringgennemsnit] = input.DynaEvalueringgennemsnit.PrintIfAvailable();
            data.Properties[vocab.DynaImportguid] = input.DynaImportguid.PrintIfAvailable();
            data.Properties[vocab.DynaKontakpersonid] = input.DynaKontakpersonid.PrintIfAvailable();
            data.Properties[vocab.DynaName] = input.DynaName.PrintIfAvailable();
            data.Properties[vocab.DynaOutplacementevalueringid] = input.DynaOutplacementevalueringid.PrintIfAvailable();
            data.Properties[vocab.DynaOutplacementid] = input.DynaOutplacementid.PrintIfAvailable();
            data.Properties[vocab.Emailaddress] = input.Emailaddress.PrintIfAvailable();
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


