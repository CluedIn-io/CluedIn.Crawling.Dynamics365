﻿using System;
using System.Linq;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public abstract class CampaignItemClueProducer<T> : DynamicsClueProducer<T> where T : CampaignItem
    {
        private readonly IClueFactory _factory;

        private readonly Dynamics365CrawlJobData _dynamics365CrawlJobData;

        public CampaignItemClueProducer([NotNull] IClueFactory factory, IAgentJobProcessorState<CrawlJobData> state)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            _factory = factory;

            _dynamics365CrawlJobData = state.JobData as Dynamics365CrawlJobData;
        }

        protected override Clue MakeClueImpl([NotNull] T input, Guid accountId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var clue = _factory.Create("/CampaignItem", input.CampaignItemId.ToString(), accountId);

            var data = clue.Data.EntityData;

            if (Uri.TryCreate(string.Format("{0}/main.aspx?pagetype=entityrecord&etn=campaignitem&id={1}", _dynamics365CrawlJobData.Api, input.CampaignItemId.ToString()), UriKind.Absolute, out Uri uri))
                data.Uri = uri;

            data.Name = input.Name;

            var vocab = new CampaignItemVocabulary();

            data.Properties[vocab.CampaignItemId] = input.CampaignItemId.PrintIfAvailable();
            data.Properties[vocab.EntityId] = input.EntityId.PrintIfAvailable();
            data.Properties[vocab.EntityType] = input.EntityType.PrintIfAvailable();
            data.Properties[vocab.ImportSequenceNumber] = input.ImportSequenceNumber.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.OverriddenCreatedOn] = input.OverriddenCreatedOn.PrintIfAvailable();
            data.Properties[vocab.OwningBusinessUnit] = input.OwningBusinessUnit.PrintIfAvailable();
            data.Properties[vocab.OwningUser] = input.OwningUser.PrintIfAvailable();
            data.Properties[vocab.TimezoneRuleVersionNumber] = input.TimezoneRuleVersionNumber.PrintIfAvailable();
            data.Properties[vocab.UtcConversionTimezoneCode] = input.UtcConversionTimezoneCode.PrintIfAvailable();
            data.Properties[vocab.VersionNumber] = input.VersionNumber.PrintIfAvailable();

            Customize(clue, input);

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            return clue;
        }
    }
}

