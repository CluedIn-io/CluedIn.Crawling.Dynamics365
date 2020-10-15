using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CampaignActivity : DynamicsModel
    {

        public CampaignActivity() { }

        public CampaignActivity(IDataReader reader) : base(reader)
        {
            PriorityCode = GetStringValue("PriorityCode");
            IgnoreInactiveListMembers = GetValue<bool>("IgnoreInactiveListMembers");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            ActualCost = GetStringValue("ActualCost");
            ActualEnd = GetValue<DateTimeOffset>("ActualEnd");
            ChannelTypeCode = GetStringValue("ChannelTypeCode");
            IsWorkflowCreated = GetValue<bool>("IsWorkflowCreated");
            ActualStart = GetValue<DateTimeOffset>("ActualStart");
            StatusCode = GetStringValue("StatusCode");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            BudgetedCost = GetStringValue("BudgetedCost");
            TypeCode = GetStringValue("TypeCode");
            ServiceId = GetStringValue("ServiceId");
            VersionNumber = GetValue<long>("VersionNumber");
            RegardingObjectId = GetStringValue("RegardingObjectId");
            Description = GetStringValue("Description");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            ScheduledEnd = GetValue<DateTimeOffset>("ScheduledEnd");
            Partners = GetStringValue("Partners");
            ScheduledDurationMinutes = GetValue<long>("ScheduledDurationMinutes");
            ActivityId = GetValue<Guid>("ActivityId");
            Subject = GetStringValue("Subject");
            ActualDurationMinutes = GetValue<long>("ActualDurationMinutes");
            OwnerId = GetStringValue("OwnerId");
            ExcludeIfContactedInXDays = GetValue<long>("ExcludeIfContactedInXDays");
            StateCode = GetStringValue("StateCode");
            ModifiedBy = GetStringValue("ModifiedBy");
            Category = GetStringValue("Category");
            DoNotSendOnOptOut = GetValue<bool>("DoNotSendOnOptOut");
            Subcategory = GetStringValue("Subcategory");
            CreatedBy = GetStringValue("CreatedBy");
            IsBilled = GetValue<bool>("IsBilled");
            ScheduledStart = GetValue<DateTimeOffset>("ScheduledStart");
            from = GetStringValue("from");
            OwningUser = GetStringValue("OwningUser");
            ChannelTypeCodeName = GetStringValue("ChannelTypeCodeName");
            StatusCodeName = GetStringValue("StatusCodeName");
            OwnerIdType = GetStringValue("OwnerIdType");
            PriorityCodeName = GetStringValue("PriorityCodeName");
            StateCodeName = GetStringValue("StateCodeName");
            RegardingObjectTypeCode = GetStringValue("RegardingObjectTypeCode");
            IsBilledName = GetStringValue("IsBilledName");
            CreatedByName = GetStringValue("CreatedByName");
            CheckForDoNotSendMMOnListMembersName = GetStringValue("CheckForDoNotSendMMOnListMembersName");
            ModifiedByName = GetStringValue("ModifiedByName");
            IsWorkflowCreatedName = GetStringValue("IsWorkflowCreatedName");
            RegardingObjectIdName = GetStringValue("RegardingObjectIdName");
            IgnoreInactiveListMembersName = GetStringValue("IgnoreInactiveListMembersName");
            TypeCodeName = GetStringValue("TypeCodeName");
            OwnerIdName = GetStringValue("OwnerIdName");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            BudgetedCost_Base = GetStringValue("BudgetedCost_Base");
            ActualCost_Base = GetStringValue("ActualCost_Base");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            RegardingObjectIdYomiName = GetStringValue("RegardingObjectIdYomiName");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            ActivityTypeCode = GetStringValue("ActivityTypeCode");
            ActivityTypeCodeName = GetStringValue("ActivityTypeCodeName");
            IsRegularActivity = GetValue<bool>("IsRegularActivity");
            IsRegularActivityName = GetStringValue("IsRegularActivityName");
            OwningTeam = GetStringValue("OwningTeam");
            ProcessId = GetValue<Guid>("ProcessId");
            StageId = GetValue<Guid>("StageId");
            TraversedPath = GetStringValue("TraversedPath");
            LeftVoiceMail = GetValue<bool>("LeftVoiceMail");
            IsMapiPrivate = GetValue<bool>("IsMapiPrivate");
            DeliveryLastAttemptedOn = GetValue<DateTimeOffset>("DeliveryLastAttemptedOn");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            PostponeActivityProcessingUntil = GetValue<DateTimeOffset>("PostponeActivityProcessingUntil");
            SentOn = GetValue<DateTimeOffset>("SentOn");
            SortDate = GetValue<DateTimeOffset>("SortDate");
            OnHoldTime = GetValue<long>("OnHoldTime");
            ActivityAdditionalParams = GetStringValue("ActivityAdditionalParams");
            ExchangeWebLink = GetStringValue("ExchangeWebLink");
            ExchangeItemId = GetStringValue("ExchangeItemId");
            SeriesId = GetValue<Guid>("SeriesId");
            DeliveryPriorityCode = GetStringValue("DeliveryPriorityCode");
            InstanceTypeCode = GetStringValue("InstanceTypeCode");
            Community = GetStringValue("Community");
            SLAId = GetStringValue("SLAId");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            SenderMailboxId = GetStringValue("SenderMailboxId");
            SLAName = GetStringValue("SLAName");
            SenderMailboxIdName = GetStringValue("SenderMailboxIdName");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            LeftVoiceMailName = GetStringValue("LeftVoiceMailName");
            IsMapiPrivateName = GetStringValue("IsMapiPrivateName");
            DeliveryPriorityCodeName = GetStringValue("DeliveryPriorityCodeName");
            CommunityName = GetStringValue("CommunityName");
            InstanceTypeCodeName = GetStringValue("InstanceTypeCodeName");
            To = GetStringValue("To");
            CC = GetStringValue("CC");
            BCC = GetStringValue("BCC");
            RequiredAttendees = GetStringValue("RequiredAttendees");
            OptionalAttendees = GetStringValue("OptionalAttendees");
            Organizer = GetStringValue("Organizer");
            Resources = GetStringValue("Resources");
            Customers = GetStringValue("Customers");

            AddCustomMappings();
        }

        public string PriorityCode { get; set; }
        public bool? IgnoreInactiveListMembers { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string ActualCost { get; set; }
        public DateTimeOffset? ActualEnd { get; set; }
        public string ChannelTypeCode { get; set; }
        public bool? IsWorkflowCreated { get; set; }
        public DateTimeOffset? ActualStart { get; set; }
        public string StatusCode { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string BudgetedCost { get; set; }
        public string TypeCode { get; set; }
        public string ServiceId { get; set; }
        public long VersionNumber { get; set; }
        public string RegardingObjectId { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ScheduledEnd { get; set; }
        public string Partners { get; set; }
        public long? ScheduledDurationMinutes { get; set; }
        public Guid? ActivityId { get; set; }
        public string Subject { get; set; }
        public long? ActualDurationMinutes { get; set; }
        public string OwnerId { get; set; }
        public long? ExcludeIfContactedInXDays { get; set; }
        public string StateCode { get; set; }
        public string ModifiedBy { get; set; }
        public string Category { get; set; }
        public bool? DoNotSendOnOptOut { get; set; }
        public string Subcategory { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsBilled { get; set; }
        public DateTimeOffset? ScheduledStart { get; set; }
        public string from { get; set; }
        public string OwningUser { get; set; }
        public string ChannelTypeCodeName { get; set; }
        public string StatusCodeName { get; set; }
        public string OwnerIdType { get; set; }
        public string PriorityCodeName { get; set; }
        public string StateCodeName { get; set; }
        public string RegardingObjectTypeCode { get; set; }
        public string IsBilledName { get; set; }
        public string CreatedByName { get; set; }
        public string CheckForDoNotSendMMOnListMembersName { get; set; }
        public string ModifiedByName { get; set; }
        public string IsWorkflowCreatedName { get; set; }
        public string RegardingObjectIdName { get; set; }
        public string IgnoreInactiveListMembersName { get; set; }
        public string TypeCodeName { get; set; }
        public string OwnerIdName { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public decimal? ExchangeRate { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public string TransactionCurrencyId { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public string BudgetedCost_Base { get; set; }
        public string ActualCost_Base { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string RegardingObjectIdYomiName { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string ActivityTypeCode { get; set; }
        public string ActivityTypeCodeName { get; set; }
        public bool? IsRegularActivity { get; set; }
        public string IsRegularActivityName { get; set; }
        public string OwningTeam { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid? StageId { get; set; }
        public string TraversedPath { get; set; }
        public bool? LeftVoiceMail { get; set; }
        public bool? IsMapiPrivate { get; set; }
        public DateTimeOffset? DeliveryLastAttemptedOn { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public DateTimeOffset? PostponeActivityProcessingUntil { get; set; }
        public DateTimeOffset? SentOn { get; set; }
        public DateTimeOffset? SortDate { get; set; }
        public long? OnHoldTime { get; set; }
        public string ActivityAdditionalParams { get; set; }
        public string ExchangeWebLink { get; set; }
        public string ExchangeItemId { get; set; }
        public Guid? SeriesId { get; set; }
        public string DeliveryPriorityCode { get; set; }
        public string InstanceTypeCode { get; set; }
        public string Community { get; set; }
        public string SLAId { get; set; }
        public string SLAInvokedId { get; set; }
        public string SenderMailboxId { get; set; }
        public string SLAName { get; set; }
        public string SenderMailboxIdName { get; set; }
        public string SLAInvokedIdName { get; set; }
        public string LeftVoiceMailName { get; set; }
        public string IsMapiPrivateName { get; set; }
        public string DeliveryPriorityCodeName { get; set; }
        public string CommunityName { get; set; }
        public string InstanceTypeCodeName { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string Organizer { get; set; }
        public string Resources { get; set; }
        public string Customers { get; set; }

    }
}

