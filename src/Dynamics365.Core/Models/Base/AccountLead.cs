using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class AccountLead : DynamicsModel
    {
        public AccountLead() { }

        public AccountLead(IDataReader reader) : base(reader)
        {
            AccountId = GetValue<Guid>("AccountId");
            AccountLeadId = GetValue<Guid>("AccountLeadId");
            ImportSequenceNumber = GetValue<int>("ImportSequenceNumber");
            LeadId = GetValue<Guid>("LeadId");
            Name = GetStringValue("Name");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            TimezoneRuleVersionNumber = GetValue<int>("TimezoneRuleVersionNumber");
            UtcConversionTimezoneCode = GetValue<int>("UtcConversionTimezoneCode");
            VersionNumber = GetValue<long>("VersionNumber");

            AddCustomMappings();
        }

        public Guid? AccountId { get; set; }

        public Guid? AccountLeadId { get; set; }

        public int ImportSequenceNumber { get; set; }

        public Guid? LeadId { get; set; }

        public string Name { get; set; }

        public DateTimeOffset? OverriddenCreatedOn { get; set; }

        public int TimezoneRuleVersionNumber { get; set; }

        public int UtcConversionTimezoneCode{ get; set; }

        public long VersionNumber { get; set; }
    }
}
