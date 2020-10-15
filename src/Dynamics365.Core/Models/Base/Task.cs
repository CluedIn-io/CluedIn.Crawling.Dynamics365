using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Task : DynamicsModel
    {

        public Task() { }

        public Task(IDataReader reader) : base(reader)
        {
            Subject = GetStringValue("Subject");
            ActualEnd = GetValue<DateTimeOffset>("ActualEnd");
            ScheduledStart = GetValue<DateTimeOffset>("ScheduledStart");
            RegardingObjectId = GetStringValue("RegardingObjectId");
            ScheduledDurationMinutes = GetValue<long>("ScheduledDurationMinutes");
            ActualStart = GetValue<DateTimeOffset>("ActualStart");
            OwnerId = GetStringValue("OwnerId");
            StateCode = GetStringValue("StateCode");
            ActivityId = GetValue<Guid>("ActivityId");
            Category = GetStringValue("Category");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            IsWorkflowCreated = GetValue<bool>("IsWorkflowCreated");
            CreatedBy = GetStringValue("CreatedBy");
            ModifiedBy = GetStringValue("ModifiedBy");
            Subcategory = GetStringValue("Subcategory");
            ScheduledEnd = GetValue<DateTimeOffset>("ScheduledEnd");
            Description = GetStringValue("Description");
            PercentComplete = GetValue<long>("PercentComplete");
            SubscriptionId = GetValue<Guid>("SubscriptionId");
            PriorityCode = GetStringValue("PriorityCode");
            VersionNumber = GetValue<long>("VersionNumber");
            ServiceId = GetStringValue("ServiceId");
            ActualDurationMinutes = GetValue<long>("ActualDurationMinutes");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            StatusCode = GetStringValue("StatusCode");
            IsBilled = GetValue<bool>("IsBilled");
            OwningUser = GetStringValue("OwningUser");
            OwnerIdName = GetStringValue("OwnerIdName");
            IsWorkflowCreatedName = GetStringValue("IsWorkflowCreatedName");
            RegardingObjectIdName = GetStringValue("RegardingObjectIdName");
            RegardingObjectTypeCode = GetStringValue("RegardingObjectTypeCode");
            StatusCodeName = GetStringValue("StatusCodeName");
            CreatedByName = GetStringValue("CreatedByName");
            ModifiedByName = GetStringValue("ModifiedByName");
            OwnerIdType = GetStringValue("OwnerIdType");
            PriorityCodeName = GetStringValue("PriorityCodeName");
            StateCodeName = GetStringValue("StateCodeName");
            IsBilledName = GetStringValue("IsBilledName");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            RegardingObjectIdYomiName = GetStringValue("RegardingObjectIdYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
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
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            ProcessId = GetValue<Guid>("ProcessId");
            StageId = GetValue<Guid>("StageId");
            TraversedPath = GetStringValue("TraversedPath");
            CrmTaskAssignedUniqueId = GetValue<Guid>("CrmTaskAssignedUniqueId");
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
        public string Subject { get; set; }
        public DateTimeOffset? ActualEnd { get; set; }
        public DateTimeOffset? ScheduledStart { get; set; }
        public string RegardingObjectId { get; set; }
        public long? ScheduledDurationMinutes { get; set; }
        public DateTimeOffset? ActualStart { get; set; }
        public string OwnerId { get; set; }
        public string StateCode { get; set; }
        public Guid? ActivityId { get; set; }
        public string Category { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public string OwningBusinessUnit { get; set; }
        public bool? IsWorkflowCreated { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Subcategory { get; set; }
        public DateTimeOffset? ScheduledEnd { get; set; }
        public string Description { get; set; }
        public long? PercentComplete { get; set; }
        public Guid? SubscriptionId { get; set; }
        public string PriorityCode { get; set; }
        public long VersionNumber { get; set; }
        public string ServiceId { get; set; }
        public long? ActualDurationMinutes { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string StatusCode { get; set; }
        public bool? IsBilled { get; set; }
        public string OwningUser { get; set; }
        public string OwnerIdName { get; set; }
        public string IsWorkflowCreatedName { get; set; }
        public string RegardingObjectIdName { get; set; }
        public string RegardingObjectTypeCode { get; set; }
        public string StatusCodeName { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string OwnerIdType { get; set; }
        public string PriorityCodeName { get; set; }
        public string StateCodeName { get; set; }
        public string IsBilledName { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string RegardingObjectIdYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string CreatedByYomiName { get; set; }
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
        public string TransactionCurrencyId { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid? StageId { get; set; }
        public string TraversedPath { get; set; }
        public Guid? CrmTaskAssignedUniqueId { get; set; }
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

