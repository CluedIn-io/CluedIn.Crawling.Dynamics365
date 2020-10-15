using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CampaignItem : DynamicsModel
    {

        public CampaignItem() { }

        public CampaignItem(IDataReader reader) : base(reader)
        {
            CampaignItemId = GetValue<Guid>("CampaignItemId");
            EntityId = GetValue<Guid>("EntityId");
            EntityType = GetStringValue("EntityType");
            ImportSequenceNumber = GetValue<int>("ImportSequenceNumber");
            Name = GetStringValue("Name");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            OwningBusinessUnit = GetValue<Guid>("OwningBusinessUnit");
            OwningUser = GetValue<Guid>("OwningUser");
            TimezoneRuleVersionNumber = GetValue<int>("TimezoneRuleVersionNumber");
            UtcConversionTimezoneCode = GetValue<int>("UtcConversionTimezoneCode");
            VersionNumber = GetValue<long>("VersionNumber");

            AddCustomMappings();
        }

        public Guid? CampaignItemId { get; set; }
        public Guid? EntityId { get; set; }
        public string EntityType { get; set; }
        public int ImportSequenceNumber { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public Guid? OwningBusinessUnit { get; set; }
        public Guid? OwningUser { get; set; }
        public int TimezoneRuleVersionNumber { get; set; }
        public int UtcConversionTimezoneCode { get; set; }
        public long VersionNumber { get; set; }

    }
}
