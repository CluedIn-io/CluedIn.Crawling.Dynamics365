using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Appointment : DynamicsModel
    {

        public Appointment() { }

        public Appointment(IDataReader reader) : base(reader)
        {
            CreatedBy = GetStringValue("CreatedBy");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            IsAllDayEvent = GetValue<bool>("IsAllDayEvent");
            ActualEnd = GetValue<DateTimeOffset>("ActualEnd");
            Subject = GetStringValue("Subject");
            ServiceId = GetStringValue("ServiceId");
            Category = GetStringValue("Category");
            IsWorkflowCreated = GetValue<bool>("IsWorkflowCreated");
            RegardingObjectId = GetStringValue("RegardingObjectId");
            Description = GetStringValue("Description");
            IsBilled = GetValue<bool>("IsBilled");
            ScheduledDurationMinutes = GetValue<long>("ScheduledDurationMinutes");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            OptionalAttendees = GetStringValue("OptionalAttendees");
            GlobalObjectId = GetStringValue("GlobalObjectId");
            ScheduledStart = GetValue<DateTimeOffset>("ScheduledStart");
            StatusCode = GetStringValue("StatusCode");
            OutlookOwnerApptId = GetValue<long>("OutlookOwnerApptId");
            ScheduledEnd = GetValue<DateTimeOffset>("ScheduledEnd");
            ActualDurationMinutes = GetValue<long>("ActualDurationMinutes");
            Location = GetStringValue("Location");
            ActualStart = GetValue<DateTimeOffset>("ActualStart");
            Organizer = GetStringValue("Organizer");
            SubscriptionId = GetValue<Guid>("SubscriptionId");
            VersionNumber = GetValue<long>("VersionNumber");
            OwnerId = GetStringValue("OwnerId");
            ModifiedBy = GetStringValue("ModifiedBy");
            StateCode = GetStringValue("StateCode");
            ActivityId = GetValue<Guid>("ActivityId");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            PriorityCode = GetStringValue("PriorityCode");
            Subcategory = GetStringValue("Subcategory");
            requiredattendees = GetStringValue("requiredattendees");
            OwningUser = GetStringValue("OwningUser");
            RegardingObjectTypeCode = GetStringValue("RegardingObjectTypeCode");
            IsBilledName = GetStringValue("IsBilledName");
            OwnerIdName = GetStringValue("OwnerIdName");
            StateCodeName = GetStringValue("StateCodeName");
            RegardingObjectIdName = GetStringValue("RegardingObjectIdName");
            StatusCodeName = GetStringValue("StatusCodeName");
            OwnerIdType = GetStringValue("OwnerIdType");
            IsAllDayEventName = GetStringValue("IsAllDayEventName");
            PriorityCodeName = GetStringValue("PriorityCodeName");
            IsWorkflowCreatedName = GetStringValue("IsWorkflowCreatedName");
            CreatedByName = GetStringValue("CreatedByName");
            ModifiedByName = GetStringValue("ModifiedByName");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            RegardingObjectIdYomiName = GetStringValue("RegardingObjectIdYomiName");
            TraversedPath = GetStringValue("TraversedPath");
            InstanceTypeCode = GetStringValue("InstanceTypeCode");
            ModifiedFieldsMask = GetStringValue("ModifiedFieldsMask");
            SeriesId = GetValue<Guid>("SeriesId");
            OriginalStartDate = GetValue<DateTimeOffset>("OriginalStartDate");
            InstanceTypeCodeName = GetStringValue("InstanceTypeCodeName");
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
            IsMapiPrivate = GetValue<bool>("IsMapiPrivate");
            IsMapiPrivateName = GetStringValue("IsMapiPrivateName");
            ProcessId = GetValue<Guid>("ProcessId");
            StageId = GetValue<Guid>("StageId");
            AttachmentErrors = GetStringValue("AttachmentErrors");
            AttachmentErrorsName = GetStringValue("AttachmentErrorsName");
            AttachmentCount = GetValue<long>("AttachmentCount");
            ActivityAdditionalParams = GetStringValue("ActivityAdditionalParams");
            SLAName = GetStringValue("SLAName");
            SLAId = GetStringValue("SLAId");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            OnHoldTime = GetValue<long>("OnHoldTime");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            SortDate = GetValue<DateTimeOffset>("SortDate");
            SafeDescription = GetStringValue("SafeDescription");
            IsUnsafe = GetValue<long>("IsUnsafe");
            IsDraft = GetValue<bool>("IsDraft");
            IsDraftName = GetStringValue("IsDraftName");

            AddCustomMappings();
        }

        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public bool? IsAllDayEvent { get; set; }
        public DateTimeOffset? ActualEnd { get; set; }
        public string Subject { get; set; }
        public string ServiceId { get; set; }
        public string Category { get; set; }
        public bool? IsWorkflowCreated { get; set; }
        public string RegardingObjectId { get; set; }
        public string Description { get; set; }
        public bool? IsBilled { get; set; }
        public long? ScheduledDurationMinutes { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string OptionalAttendees { get; set; }
        public string GlobalObjectId { get; set; }
        public DateTimeOffset? ScheduledStart { get; set; }
        public string StatusCode { get; set; }
        public long? OutlookOwnerApptId { get; set; }
        public DateTimeOffset? ScheduledEnd { get; set; }
        public long? ActualDurationMinutes { get; set; }
        public string Location { get; set; }
        public DateTimeOffset? ActualStart { get; set; }
        public string Organizer { get; set; }
        public Guid? SubscriptionId { get; set; }
        public long VersionNumber { get; set; }
        public string OwnerId { get; set; }
        public string ModifiedBy { get; set; }
        public string StateCode { get; set; }
        public Guid? ActivityId { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string PriorityCode { get; set; }
        public string Subcategory { get; set; }
        public string requiredattendees { get; set; }
        public string OwningUser { get; set; }
        public string RegardingObjectTypeCode { get; set; }
        public string IsBilledName { get; set; }
        public string OwnerIdName { get; set; }
        public string StateCodeName { get; set; }
        public string RegardingObjectIdName { get; set; }
        public string StatusCodeName { get; set; }
        public string OwnerIdType { get; set; }
        public string IsAllDayEventName { get; set; }
        public string PriorityCodeName { get; set; }
        public string IsWorkflowCreatedName { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public string CreatedByYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string RegardingObjectIdYomiName { get; set; }
        public string TraversedPath { get; set; }
        public string InstanceTypeCode { get; set; }
        public string ModifiedFieldsMask { get; set; }
        public Guid? SeriesId { get; set; }
        public DateTimeOffset? OriginalStartDate { get; set; }
        public string InstanceTypeCodeName { get; set; }
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
        public bool? IsMapiPrivate { get; set; }
        public string IsMapiPrivateName { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid? StageId { get; set; }
        public string AttachmentErrors { get; set; }
        public string AttachmentErrorsName { get; set; }
        public long? AttachmentCount { get; set; }
        public string ActivityAdditionalParams { get; set; }
        public string SLAName { get; set; }
        public string SLAId { get; set; }
        public string SLAInvokedId { get; set; }
        public long? OnHoldTime { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public string SLAInvokedIdName { get; set; }
        public DateTimeOffset? SortDate { get; set; }
        public string SafeDescription { get; set; }
        public long? IsUnsafe { get; set; }
        public bool? IsDraft { get; set; }
        public string IsDraftName { get; set; }

    }
}

