using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class ActivityPointer : DynamicsModel
    {
        public ActivityPointer() { }

        public ActivityPointer(IDataReader reader) : base(reader)
        {
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            ActualEnd = GetValue<DateTimeOffset>("ActualEnd");
            VersionNumber = GetValue<long>("VersionNumber");
            ActivityId = GetValue<Guid>("ActivityId");
            IsBilled = GetValue<bool>("IsBilled");
            CreatedBy = GetStringValue("CreatedBy");
            Description = GetStringValue("Description");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            ServiceId = GetStringValue("ServiceId");
            ActivityTypeCode = GetStringValue("ActivityTypeCode");
            StateCode = GetStringValue("StateCode");
            ScheduledEnd = GetValue<DateTimeOffset>("ScheduledEnd");
            ScheduledDurationMinutes = GetValue<long>("ScheduledDurationMinutes");
            ActualDurationMinutes = GetValue<long>("ActualDurationMinutes");
            StatusCode = GetStringValue("StatusCode");
            OwnerId = GetStringValue("OwnerId");
            ActualStart = GetValue<DateTimeOffset>("ActualStart");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            PriorityCode = GetStringValue("PriorityCode");
            RegardingObjectId = GetStringValue("RegardingObjectId");
            Subject = GetStringValue("Subject");
            IsWorkflowCreated = GetValue<bool>("IsWorkflowCreated");
            ScheduledStart = GetValue<DateTimeOffset>("ScheduledStart");
            ModifiedBy = GetStringValue("ModifiedBy");
            OwningUser = GetStringValue("OwningUser");
            IsBilledName = GetStringValue("IsBilledName");
            RegardingObjectTypeCode = GetStringValue("RegardingObjectTypeCode");
            OwnerIdName = GetStringValue("OwnerIdName");
            IsWorkflowCreatedName = GetStringValue("IsWorkflowCreatedName");
            CreatedByName = GetStringValue("CreatedByName");
            RegardingObjectIdName = GetStringValue("RegardingObjectIdName");
            PriorityCodeName = GetStringValue("PriorityCodeName");
            ActivityTypeCodeName = GetStringValue("ActivityTypeCodeName");
            StateCodeName = GetStringValue("StateCodeName");
            ModifiedByName = GetStringValue("ModifiedByName");
            OwnerIdType = GetStringValue("OwnerIdType");
            ServiceIdName = GetStringValue("ServiceIdName");
            StatusCodeName = GetStringValue("StatusCodeName");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            RegardingObjectIdYomiName = GetStringValue("RegardingObjectIdYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            InstanceTypeCode = GetStringValue("InstanceTypeCode");
            SeriesId = GetValue<Guid>("SeriesId");
            InstanceTypeCodeName = GetStringValue("InstanceTypeCodeName");
            IsRegularActivity = GetValue<bool>("IsRegularActivity");
            IsRegularActivityName = GetStringValue("IsRegularActivityName");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            OwningTeam = GetStringValue("OwningTeam");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            allparties = GetStringValue("allparties");
            LeftVoiceMail = GetValue<bool>("LeftVoiceMail");
            LeftVoiceMailName = GetStringValue("LeftVoiceMailName");
            Community = GetStringValue("Community");
            CommunityName = GetStringValue("CommunityName");
            TraversedPath = GetStringValue("TraversedPath");
            IsMapiPrivate = GetValue<bool>("IsMapiPrivate");
            IsMapiPrivateName = GetStringValue("IsMapiPrivateName");
            ExchangeWebLink = GetStringValue("ExchangeWebLink");
            ExchangeItemId = GetStringValue("ExchangeItemId");
            DeliveryPriorityCode = GetStringValue("DeliveryPriorityCode");
            DeliveryPriorityCodeName = GetStringValue("DeliveryPriorityCodeName");
            SentOn = GetValue<DateTimeOffset>("SentOn");
            DeliveryLastAttemptedOn = GetValue<DateTimeOffset>("DeliveryLastAttemptedOn");
            SenderMailboxId = GetStringValue("SenderMailboxId");
            SenderMailboxIdName = GetStringValue("SenderMailboxIdName");
            PostponeActivityProcessingUntil = GetValue<DateTimeOffset>("PostponeActivityProcessingUntil");
            ProcessId = GetValue<Guid>("ProcessId");
            StageId = GetValue<Guid>("StageId");
            ActivityAdditionalParams = GetStringValue("ActivityAdditionalParams");
            SLAId = GetStringValue("SLAId");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            OnHoldTime = GetValue<long>("OnHoldTime");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            SLAName = GetStringValue("SLAName");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            SortDate = GetValue<DateTimeOffset>("SortDate");

            AddCustomMappings();
        }

        public string OwningBusinessUnit { get; set; }
        public DateTimeOffset? ActualEnd { get; set; }
        public long VersionNumber { get; set; }
        public Guid? ActivityId { get; set; }
        public bool? IsBilled { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string ServiceId { get; set; }
        public string ActivityTypeCode { get; set; }
        public string StateCode { get; set; }
        public DateTimeOffset? ScheduledEnd { get; set; }
        public long? ScheduledDurationMinutes { get; set; }
        public long? ActualDurationMinutes { get; set; }
        public string StatusCode { get; set; }
        public string OwnerId { get; set; }
        public DateTimeOffset? ActualStart { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public string PriorityCode { get; set; }
        public string RegardingObjectId { get; set; }
        public string Subject { get; set; }
        public bool? IsWorkflowCreated { get; set; }
        public DateTimeOffset? ScheduledStart { get; set; }
        public string ModifiedBy { get; set; }
        public string OwningUser { get; set; }
        public string IsBilledName { get; set; }
        public string RegardingObjectTypeCode { get; set; }
        public string OwnerIdName { get; set; }
        public string IsWorkflowCreatedName { get; set; }
        public string CreatedByName { get; set; }
        public string RegardingObjectIdName { get; set; }
        public string PriorityCodeName { get; set; }
        public string ActivityTypeCodeName { get; set; }
        public string StateCodeName { get; set; }
        public string ModifiedByName { get; set; }
        public string OwnerIdType { get; set; }
        public string ServiceIdName { get; set; }
        public string StatusCodeName { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public string RegardingObjectIdYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string InstanceTypeCode { get; set; }
        public Guid? SeriesId { get; set; }
        public string InstanceTypeCodeName { get; set; }
        public bool? IsRegularActivity { get; set; }
        public string IsRegularActivityName { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string OwningTeam { get; set; }
        public string TransactionCurrencyId { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string allparties { get; set; }
        public bool? LeftVoiceMail { get; set; }
        public string LeftVoiceMailName { get; set; }
        public string Community { get; set; }
        public string CommunityName { get; set; }
        public string TraversedPath { get; set; }
        public bool? IsMapiPrivate { get; set; }
        public string IsMapiPrivateName { get; set; }
        public string ExchangeWebLink { get; set; }
        public string ExchangeItemId { get; set; }
        public string DeliveryPriorityCode { get; set; }
        public string DeliveryPriorityCodeName { get; set; }
        public DateTimeOffset? SentOn { get; set; }
        public DateTimeOffset? DeliveryLastAttemptedOn { get; set; }
        public string SenderMailboxId { get; set; }
        public string SenderMailboxIdName { get; set; }
        public DateTimeOffset? PostponeActivityProcessingUntil { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid? StageId { get; set; }
        public string ActivityAdditionalParams { get; set; }
        public string SLAId { get; set; }
        public string SLAInvokedId { get; set; }
        public long? OnHoldTime { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public string SLAName { get; set; }
        public string SLAInvokedIdName { get; set; }
        public DateTimeOffset? SortDate { get; set; }

    }
}

