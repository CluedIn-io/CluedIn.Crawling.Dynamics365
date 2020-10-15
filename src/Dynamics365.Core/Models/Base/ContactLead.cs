using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ContactLead : DynamicsModel
    {

        public ContactLead() { }

        public ContactLead(IDataReader reader) : base(reader)
        {
            ContactId = GetValue<Guid>("ContactId");
            ContactLeadId = GetValue<Guid>("ContactLeadId");
            ImportSequenceNumber = GetValue<int>("ImportSequenceNumber");
            LeadId = GetValue<Guid>("LeadId");
            Name = GetStringValue("Name");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            TimezoneRuleVersionNumber = GetValue<int>("TimezoneRuleVersionNumber");
            UtcConversionTimezoneCode = GetValue<int>("UtcConversionTimezoneCode");
            VersionNumber = GetValue<long>("VersionNumber");

            AddCustomMappings();
        }

        public Guid? ContactId { get; set; }
        public Guid? ContactLeadId { get; set; }
        public int ImportSequenceNumber { get; set; }
        public Guid? LeadId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public int TimezoneRuleVersionNumber { get; set; }
        public int UtcConversionTimezoneCode { get; set; }
        public long VersionNumber { get; set; }

    }
}
