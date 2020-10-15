using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActivityParty : DynamicsModel
    {

        public ActivityParty() { }

        public ActivityParty(IDataReader reader) : base(reader)
        {

            AddCustomMappings();
        }

        public string ActivityId { get; set; }
        public Guid? ActivityPartyId { get; set; }
        public string PartyId { get; set; }
        public string PartyObjectTypeCode { get; set; }
        public string ParticipationTypeMask { get; set; }
        public string AddressUsed { get; set; }
        public string PartyIdName { get; set; }
        public Guid? OwningBusinessUnit { get; set; }
        public bool? DoNotFax { get; set; }
        public DateTimeOffset? ScheduledStart { get; set; }
        public DateTimeOffset? ScheduledEnd { get; set; }
        public double? Effort { get; set; }
        public bool? DoNotEmail { get; set; }
        public Guid? OwningUser { get; set; }
        public string ExchangeEntryId { get; set; }
        public string ResourceSpecId { get; set; }
        public long VersionNumber { get; set; }
        public string ResourceSpecIdName { get; set; }
        public string DoNotFaxName { get; set; }
        public string DoNotEmailName { get; set; }
        public string ParticipationTypeMaskName { get; set; }
        public bool? DoNotPostalMail { get; set; }
        public bool? DoNotPhone { get; set; }
        public string DoNotPhoneName { get; set; }
        public string DoNotPostalMailName { get; set; }
        public string OwnerId { get; set; }
        public string OwnerIdType { get; set; }
        public string InstanceTypeCode { get; set; }
        public string InstanceTypeCodeName { get; set; }
        public bool? IsPartyDeleted { get; set; }
        public string IsPartyDeletedName { get; set; }
        public long? AddressUsedEmailColumnNumber { get; set; }
    }
}

