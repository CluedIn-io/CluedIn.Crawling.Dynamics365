using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Campaign : DynamicsModel
    {

        public Campaign() { }

        public Campaign(IDataReader reader) : base(reader)
        {
            TypeCode = GetStringValue("TypeCode");
            ProposedEnd = GetValue<DateTimeOffset>("ProposedEnd");
            BudgetedCost = GetStringValue("BudgetedCost");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            PromotionCodeName = GetStringValue("PromotionCodeName");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            OwnerId = GetStringValue("OwnerId");
            PriceListId = GetStringValue("PriceListId");
            StatusCode = GetStringValue("StatusCode");
            CreatedBy = GetStringValue("CreatedBy");
            IsTemplate = GetValue<bool>("IsTemplate");
            CampaignId = GetValue<Guid>("CampaignId");
            ActualStart = GetValue<DateTimeOffset>("ActualStart");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            TotalActualCost = GetStringValue("TotalActualCost");
            Message = GetStringValue("Message");
            ModifiedBy = GetStringValue("ModifiedBy");
            ExpectedRevenue = GetStringValue("ExpectedRevenue");
            VersionNumber = GetValue<long>("VersionNumber");
            CodeName = GetStringValue("CodeName");
            ProposedStart = GetValue<DateTimeOffset>("ProposedStart");
            Objective = GetStringValue("Objective");
            ActualEnd = GetValue<DateTimeOffset>("ActualEnd");
            StateCode = GetStringValue("StateCode");
            OtherCost = GetStringValue("OtherCost");
            Description = GetStringValue("Description");
            TotalCampaignActivityActualCost = GetStringValue("TotalCampaignActivityActualCost");
            ExpectedResponse = GetValue<long>("ExpectedResponse");
            Name = GetStringValue("Name");
            OwningUser = GetStringValue("OwningUser");
            ModifiedByName = GetStringValue("ModifiedByName");
            StateCodeName = GetStringValue("StateCodeName");
            StatusCodeName = GetStringValue("StatusCodeName");
            TypeCodeName = GetStringValue("TypeCodeName");
            IsTemplateName = GetStringValue("IsTemplateName");
            CreatedByName = GetStringValue("CreatedByName");
            OwnerIdType = GetStringValue("OwnerIdType");
            PriceListName = GetStringValue("PriceListName");
            OwnerIdName = GetStringValue("OwnerIdName");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            TotalCampaignActivityActualCost_Base = GetStringValue("TotalCampaignActivityActualCost_Base");
            BudgetedCost_Base = GetStringValue("BudgetedCost_Base");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            ExpectedRevenue_Base = GetStringValue("ExpectedRevenue_Base");
            OtherCost_Base = GetStringValue("OtherCost_Base");
            TotalActualCost_Base = GetStringValue("TotalActualCost_Base");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            OwningTeam = GetStringValue("OwningTeam");
            ProcessId = GetValue<Guid>("ProcessId");
            StageId = GetValue<Guid>("StageId");
            EntityImageId = GetValue<Guid>("EntityImageId");
            EntityImage = GetStringValue("EntityImage");
            EntityImage_Timestamp = GetValue<int>("EntityImage_Timestamp");
            EntityImage_URL = GetStringValue("EntityImage_URL");
            TraversedPath = GetStringValue("TraversedPath");
            EmailAddress = GetStringValue("EmailAddress");
            TmpRegardingObjectId = GetStringValue("TmpRegardingObjectId");

            AddCustomMappings();
        }

        public string TypeCode { get; set; }
        public DateTimeOffset? ProposedEnd { get; set; }
        public string BudgetedCost { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public string PromotionCodeName { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string OwnerId { get; set; }
        public string PriceListId { get; set; }
        public string StatusCode { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsTemplate { get; set; }
        public Guid? CampaignId { get; set; }
        public DateTimeOffset? ActualStart { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string TotalActualCost { get; set; }
        public string Message { get; set; }
        public string ModifiedBy { get; set; }
        public string ExpectedRevenue { get; set; }
        public long VersionNumber { get; set; }
        public string CodeName { get; set; }
        public DateTimeOffset? ProposedStart { get; set; }
        public string Objective { get; set; }
        public DateTimeOffset? ActualEnd { get; set; }
        public string StateCode { get; set; }
        public string OtherCost { get; set; }
        public string Description { get; set; }
        public string TotalCampaignActivityActualCost { get; set; }
        public long? ExpectedResponse { get; set; }
        public string Name { get; set; }
        public string OwningUser { get; set; }
        public string ModifiedByName { get; set; }
        public string StateCodeName { get; set; }
        public string StatusCodeName { get; set; }
        public string TypeCodeName { get; set; }
        public string IsTemplateName { get; set; }
        public string CreatedByName { get; set; }
        public string OwnerIdType { get; set; }
        public string PriceListName { get; set; }
        public string OwnerIdName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public string TransactionCurrencyId { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public string TotalCampaignActivityActualCost_Base { get; set; }
        public string BudgetedCost_Base { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public string ExpectedRevenue_Base { get; set; }
        public string OtherCost_Base { get; set; }
        public string TotalActualCost_Base { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string OwningTeam { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid? StageId { get; set; }
        public Guid? EntityImageId { get; set; }
        public string EntityImage { get; set; }
        public int? EntityImage_Timestamp { get; set; }
        public string EntityImage_URL { get; set; }
        public string TraversedPath { get; set; }
        public string EmailAddress { get; set; }
        public string TmpRegardingObjectId { get; set; }

    }
}

