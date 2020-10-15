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
    public class ActivitypointerClueProducer : BaseClueProducer<Activitypointer>
    {
        private readonly IClueFactory _factory;

        public ActivitypointerClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(Activitypointer input, Guid id)
        {
            var clue = _factory.Create(EntityType.Activity, input.Activityid, id);

            var data = clue.Data.EntityData;

            // Metadata

            if (!string.IsNullOrWhiteSpace(input.Subject) && !string.IsNullOrWhiteSpace(input.Scheduledstart))
                data.Name = $"Activity on {input.Subject}, starting {input.Scheduledstart}";
            else if (!string.IsNullOrWhiteSpace(input.Scheduledstart))
                data.Name = $"Activity starting {input.Scheduledstart}";
            else if (!string.IsNullOrWhiteSpace(input.Actualstart))
                data.Name = $"Activity starting {input.Actualstart}";

            //data.Name = input.Name;

            DateTimeOffset.TryParse(input.Createdon, out var createdDate);
            if (createdDate != null)
                data.CreatedDate = createdDate;

            DateTimeOffset.TryParse(input.Modifiedon, out var modifiedDate);
            if (modifiedDate != null)
                data.ModifiedDate = modifiedDate;

            // Edges

            if (input.Activityid != null && !string.IsNullOrEmpty(input.Activityid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Activityid, input.Activityid.ToString());

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.Exchangeitemid != null && !string.IsNullOrEmpty(input.Exchangeitemid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Exchangeitemid, input.Exchangeitemid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            if (input.Processid != null && !string.IsNullOrEmpty(input.Processid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Processid, input.Processid.ToString());

            if (input.Regardingobjectid != null && !string.IsNullOrEmpty(input.Regardingobjectid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Regardingobjectid, input.Regardingobjectid.ToString());

            if (input.Sendermailboxid != null && !string.IsNullOrEmpty(input.Sendermailboxid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Sendermailboxid, input.Sendermailboxid.ToString());

            if (input.Seriesid != null && !string.IsNullOrEmpty(input.Seriesid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Seriesid, input.Seriesid.ToString());

            if (input.Serviceid != null && !string.IsNullOrEmpty(input.Serviceid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Serviceid, input.Serviceid.ToString());

            if (input.Slaid != null && !string.IsNullOrEmpty(input.Slaid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Slaid, input.Slaid.ToString());

            if (input.Slainvokedid != null && !string.IsNullOrEmpty(input.Slainvokedid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Slainvokedid, input.Slainvokedid.ToString());

            if (input.Stageid != null && !string.IsNullOrEmpty(input.Stageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Stageid, input.Stageid.ToString());

            if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            var vocab = new ActivitypointerVocabulary();

            data.Properties[vocab.Activityadditionalparams] = input.Activityadditionalparams.PrintIfAvailable();
            data.Properties[vocab.Activityid] = input.Activityid.PrintIfAvailable();
            data.Properties[vocab.Activitytypecode] = input.Activitytypecode.PrintIfAvailable();
            data.Properties[vocab.Actualdurationminutes] = input.Actualdurationminutes.PrintIfAvailable();
            data.Properties[vocab.Actualend] = input.Actualend.PrintIfAvailable();
            data.Properties[vocab.Actualstart] = input.Actualstart.PrintIfAvailable();
            data.Properties[vocab.Allparties] = input.Allparties.PrintIfAvailable();
            data.Properties[vocab.Community] = input.Community.PrintIfAvailable();
            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.Deliverylastattemptedon] = input.Deliverylastattemptedon.PrintIfAvailable();
            data.Properties[vocab.Deliveryprioritycode] = input.Deliveryprioritycode.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.Exchangeitemid] = input.Exchangeitemid.PrintIfAvailable();
            data.Properties[vocab.Exchangerate] = input.Exchangerate.PrintIfAvailable();
            data.Properties[vocab.Exchangeweblink] = input.Exchangeweblink.PrintIfAvailable();
            data.Properties[vocab.Instancetypecode] = input.Instancetypecode.PrintIfAvailable();
            data.Properties[vocab.Isbilled] = input.Isbilled.PrintIfAvailable();
            data.Properties[vocab.Ismapiprivate] = input.Ismapiprivate.PrintIfAvailable();
            data.Properties[vocab.Isregularactivity] = input.Isregularactivity.PrintIfAvailable();
            data.Properties[vocab.Isworkflowcreated] = input.Isworkflowcreated.PrintIfAvailable();
            data.Properties[vocab.Lastonholdtime] = input.Lastonholdtime.PrintIfAvailable();
            data.Properties[vocab.Leftvoicemail] = input.Leftvoicemail.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.Onholdtime] = input.Onholdtime.PrintIfAvailable();
            data.Properties[vocab.Postponeactivityprocessinguntil] = input.Postponeactivityprocessinguntil.PrintIfAvailable();
            data.Properties[vocab.Prioritycode] = input.Prioritycode.PrintIfAvailable();
            data.Properties[vocab.Processid] = input.Processid.PrintIfAvailable();
            data.Properties[vocab.Regardingobjectid] = input.Regardingobjectid.PrintIfAvailable();
            data.Properties[vocab.Scheduleddurationminutes] = input.Scheduleddurationminutes.PrintIfAvailable();
            data.Properties[vocab.Scheduledend] = input.Scheduledend.PrintIfAvailable();
            data.Properties[vocab.Scheduledstart] = input.Scheduledstart.PrintIfAvailable();
            data.Properties[vocab.Sendermailboxid] = input.Sendermailboxid.PrintIfAvailable();
            data.Properties[vocab.Senton] = input.Senton.PrintIfAvailable();
            data.Properties[vocab.Seriesid] = input.Seriesid.PrintIfAvailable();
            data.Properties[vocab.Serviceid] = input.Serviceid.PrintIfAvailable();
            data.Properties[vocab.Slaid] = input.Slaid.PrintIfAvailable();
            data.Properties[vocab.Slainvokedid] = input.Slainvokedid.PrintIfAvailable();
            data.Properties[vocab.Sortdate] = input.Sortdate.PrintIfAvailable();
            data.Properties[vocab.Stageid] = input.Stageid.PrintIfAvailable();
            data.Properties[vocab.Statecode] = input.Statecode.PrintIfAvailable();
            data.Properties[vocab.Statuscode] = input.Statuscode.PrintIfAvailable();
            data.Properties[vocab.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[vocab.Transactioncurrencyid] = input.Transactioncurrencyid.PrintIfAvailable();
            data.Properties[vocab.Traversedpath] = input.Traversedpath.PrintIfAvailable();

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


