using System;
using System.Data;
using Newtonsoft.Json;
using Serilog.Debugging;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Account : DynamicsModel
    {

        public Account() { }

        public Account(IDataReader reader) : base(reader)
        {
            AccountId = GetValue<Guid>("AccountId");
            AccountCategoryCode = GetStringValue("AccountCategoryCode");
            TerritoryId = GetStringValue("TerritoryId");
            DefaultPriceLevelId = GetStringValue("DefaultPriceLevelId");
            CustomerSizeCode = GetStringValue("CustomerSizeCode");
            PreferredContactMethodCode = GetStringValue("PreferredContactMethodCode");
            CustomerTypeCode = GetStringValue("CustomerTypeCode");
            AccountRatingCode = GetStringValue("AccountRatingCode");
            IndustryCode = GetStringValue("IndustryCode");
            TerritoryCode = GetStringValue("TerritoryCode");
            AccountClassificationCode = GetStringValue("AccountClassificationCode");
            BusinessTypeCode = GetStringValue("BusinessTypeCode");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            TraversedPath = GetStringValue("TraversedPath");
            OwningUser = GetStringValue("OwningUser");
            OriginatingLeadId = GetStringValue("OriginatingLeadId");
            PaymentTermsCode = GetStringValue("PaymentTermsCode");
            ShippingMethodCode = GetStringValue("ShippingMethodCode");
            PrimaryContactId = GetStringValue("PrimaryContactId");
            ParticipatesInWorkflow = GetValue<bool>("ParticipatesInWorkflow");
            Name = GetStringValue("Name");
            AccountNumber = GetStringValue("AccountNumber");
            Revenue = GetStringValue("Revenue");
            NumberOfEmployees = GetValue<long>("NumberOfEmployees");
            Description = GetStringValue("Description");
            SIC = GetStringValue("SIC");
            OwnershipCode = GetStringValue("OwnershipCode");
            MarketCap = GetStringValue("MarketCap");
            SharesOutstanding = GetValue<long>("SharesOutstanding");
            TickerSymbol = GetStringValue("TickerSymbol");
            StockExchange = GetStringValue("StockExchange");
            WebSiteURL = GetStringValue("WebSiteURL");
            FtpSiteURL = GetStringValue("FtpSiteURL");
            EMailAddress1 = GetStringValue("EMailAddress1");
            EMailAddress2 = GetStringValue("EMailAddress2");
            EMailAddress3 = GetStringValue("EMailAddress3");
            DoNotPhone = GetValue<bool>("DoNotPhone");
            DoNotFax = GetValue<bool>("DoNotFax");
            Telephone1 = GetStringValue("Telephone1");
            DoNotEMail = GetValue<bool>("DoNotEMail");
            Telephone2 = GetStringValue("Telephone2");
            Fax = GetStringValue("Fax");
            Telephone3 = GetStringValue("Telephone3");
            DoNotPostalMail = GetValue<bool>("DoNotPostalMail");
            DoNotBulkEMail = GetValue<bool>("DoNotBulkEMail");
            DoNotBulkPostalMail = GetValue<bool>("DoNotBulkPostalMail");
            CreditLimit = GetStringValue("CreditLimit");
            CreditOnHold = GetValue<bool>("CreditOnHold");
            IsPrivate = GetValue<bool>("IsPrivate");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            CreatedBy = GetStringValue("CreatedBy");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            ModifiedBy = GetStringValue("ModifiedBy");
            VersionNumber = GetValue<long>("VersionNumber");
            ParentAccountId = GetStringValue("ParentAccountId");
            Aging30 = GetStringValue("Aging30");
            StateCode = GetStringValue("StateCode");
            Aging60 = GetStringValue("Aging60");
            StatusCode = GetStringValue("StatusCode");
            Aging90 = GetStringValue("Aging90");
            OriginatingLeadIdName = GetStringValue("OriginatingLeadIdName");
            PrimaryContactIdName = GetStringValue("PrimaryContactIdName");
            ParentAccountIdName = GetStringValue("ParentAccountIdName");
            DefaultPriceLevelIdName = GetStringValue("DefaultPriceLevelIdName");
            TerritoryIdName = GetStringValue("TerritoryIdName");
            Address1_AddressId = GetValue<Guid>("Address1_AddressId");
            Address1_AddressTypeCode = GetStringValue("Address1_AddressTypeCode");
            Address1_Name = GetStringValue("Address1_Name");
            Address1_PrimaryContactName = GetStringValue("Address1_PrimaryContactName");
            Address1_Line1 = GetStringValue("Address1_Line1");
            Address1_Line2 = GetStringValue("Address1_Line2");
            Address1_Line3 = GetStringValue("Address1_Line3");
            Address1_City = GetStringValue("Address1_City");
            Address1_StateOrProvince = GetStringValue("Address1_StateOrProvince");
            Address1_County = GetStringValue("Address1_County");
            Address1_Country = GetStringValue("Address1_Country");
            Address1_PostOfficeBox = GetStringValue("Address1_PostOfficeBox");
            Address1_PostalCode = GetStringValue("Address1_PostalCode");
            Address1_UTCOffset = GetValue<long>("Address1_UTCOffset");
            Address1_FreightTermsCode = GetStringValue("Address1_FreightTermsCode");
            Address1_UPSZone = GetStringValue("Address1_UPSZone");
            Address1_Latitude = GetValue<double>("Address1_Latitude");
            Address1_Telephone1 = GetStringValue("Address1_Telephone1");
            Address1_Longitude = GetValue<double>("Address1_Longitude");
            Address1_ShippingMethodCode = GetStringValue("Address1_ShippingMethodCode");
            Address1_Telephone2 = GetStringValue("Address1_Telephone2");
            Address1_Telephone3 = GetStringValue("Address1_Telephone3");
            Address1_Fax = GetStringValue("Address1_Fax");
            Address2_AddressId = GetValue<Guid>("Address2_AddressId");
            Address2_AddressTypeCode = GetStringValue("Address2_AddressTypeCode");
            Address2_Name = GetStringValue("Address2_Name");
            Address2_PrimaryContactName = GetStringValue("Address2_PrimaryContactName");
            Address2_Line1 = GetStringValue("Address2_Line1");
            Address2_Line2 = GetStringValue("Address2_Line2");
            Address2_Line3 = GetStringValue("Address2_Line3");
            Address2_City = GetStringValue("Address2_City");
            Address2_StateOrProvince = GetStringValue("Address2_StateOrProvince");
            Address2_County = GetStringValue("Address2_County");
            Address2_Country = GetStringValue("Address2_Country");
            Address2_PostOfficeBox = GetStringValue("Address2_PostOfficeBox");
            Address2_PostalCode = GetStringValue("Address2_PostalCode");
            Address2_UTCOffset = GetValue<long>("Address2_UTCOffset");
            Address2_FreightTermsCode = GetStringValue("Address2_FreightTermsCode");
            Address2_UPSZone = GetStringValue("Address2_UPSZone");
            Address2_Latitude = GetValue<double>("Address2_Latitude");
            Address2_Telephone1 = GetStringValue("Address2_Telephone1");
            Address2_Longitude = GetValue<double>("Address2_Longitude");
            Address2_ShippingMethodCode = GetStringValue("Address2_ShippingMethodCode");
            Address2_Telephone2 = GetStringValue("Address2_Telephone2");
            Address2_Telephone3 = GetStringValue("Address2_Telephone3");
            Address2_Fax = GetStringValue("Address2_Fax");
            CreatedByName = GetStringValue("CreatedByName");
            ModifiedByName = GetStringValue("ModifiedByName");
            OwnerId = GetStringValue("OwnerId");
            OwnerIdName = GetStringValue("OwnerIdName");
            OwnerIdType = GetStringValue("OwnerIdType");
            DoNotFaxName = GetStringValue("DoNotFaxName");
            DoNotPhoneName = GetStringValue("DoNotPhoneName");
            DoNotBulkPostalMailName = GetStringValue("DoNotBulkPostalMailName");
            CreditOnHoldName = GetStringValue("CreditOnHoldName");
            DoNotEMailName = GetStringValue("DoNotEMailName");
            IsPrivateName = GetStringValue("IsPrivateName");
            DoNotPostalMailName = GetStringValue("DoNotPostalMailName");
            ParticipatesInWorkflowName = GetStringValue("ParticipatesInWorkflowName");
            DoNotBulkEMailName = GetStringValue("DoNotBulkEMailName");
            Address1_ShippingMethodCodeName = GetStringValue("Address1_ShippingMethodCodeName");
            IndustryCodeName = GetStringValue("IndustryCodeName");
            AccountRatingCodeName = GetStringValue("AccountRatingCodeName");
            OwnershipCodeName = GetStringValue("OwnershipCodeName");
            AccountClassificationCodeName = GetStringValue("AccountClassificationCodeName");
            CustomerSizeCodeName = GetStringValue("CustomerSizeCodeName");
            StateCodeName = GetStringValue("StateCodeName");
            ShippingMethodCodeName = GetStringValue("ShippingMethodCodeName");
            Address1_FreightTermsCodeName = GetStringValue("Address1_FreightTermsCodeName");
            BusinessTypeCodeName = GetStringValue("BusinessTypeCodeName");
            Address2_FreightTermsCodeName = GetStringValue("Address2_FreightTermsCodeName");
            AccountCategoryCodeName = GetStringValue("AccountCategoryCodeName");
            PaymentTermsCodeName = GetStringValue("PaymentTermsCodeName");
            PreferredContactMethodCodeName = GetStringValue("PreferredContactMethodCodeName");
            TerritoryCodeName = GetStringValue("TerritoryCodeName");
            StatusCodeName = GetStringValue("StatusCodeName");
            CustomerTypeCodeName = GetStringValue("CustomerTypeCodeName");
            Address1_AddressTypeCodeName = GetStringValue("Address1_AddressTypeCodeName");
            Address2_ShippingMethodCodeName = GetStringValue("Address2_ShippingMethodCodeName");
            Address2_AddressTypeCodeName = GetStringValue("Address2_AddressTypeCodeName");
            PreferredAppointmentDayCode = GetStringValue("PreferredAppointmentDayCode");
            PreferredSystemUserId = GetStringValue("PreferredSystemUserId");
            PreferredAppointmentTimeCode = GetStringValue("PreferredAppointmentTimeCode");
            Merged = GetValue<bool>("Merged");
            DoNotSendMM = GetValue<bool>("DoNotSendMM");
            MasterId = GetStringValue("MasterId");
            LastUsedInCampaign = GetValue<DateTimeOffset>("LastUsedInCampaign");
            PreferredServiceId = GetStringValue("PreferredServiceId");
            PreferredEquipmentId = GetStringValue("PreferredEquipmentId");
            PreferredEquipmentIdName = GetStringValue("PreferredEquipmentIdName");
            PreferredServiceIdName = GetStringValue("PreferredServiceIdName");
            PreferredAppointmentTimeCodeName = GetStringValue("PreferredAppointmentTimeCodeName");
            PreferredAppointmentDayCodeName = GetStringValue("PreferredAppointmentDayCodeName");
            PreferredSystemUserIdName = GetStringValue("PreferredSystemUserIdName");
            MergedName = GetStringValue("MergedName");
            MasterAccountIdName = GetStringValue("MasterAccountIdName");
            DoNotSendMarketingMaterialName = GetStringValue("DoNotSendMarketingMaterialName");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            CreditLimit_Base = GetStringValue("CreditLimit_Base");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            Aging30_Base = GetStringValue("Aging30_Base");
            Revenue_Base = GetStringValue("Revenue_Base");
            Aging90_Base = GetStringValue("Aging90_Base");
            MarketCap_Base = GetStringValue("MarketCap_Base");
            Aging60_Base = GetStringValue("Aging60_Base");
            PreferredSystemUserIdYomiName = GetStringValue("PreferredSystemUserIdYomiName");
            ParentAccountIdYomiName = GetStringValue("ParentAccountIdYomiName");
            OriginatingLeadIdYomiName = GetStringValue("OriginatingLeadIdYomiName");
            MasterAccountIdYomiName = GetStringValue("MasterAccountIdYomiName");
            PrimaryContactIdYomiName = GetStringValue("PrimaryContactIdYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            YomiName = GetStringValue("YomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            OwningTeam = GetStringValue("OwningTeam");
            EntityImage = GetStringValue("EntityImage");
            StageId = GetValue<Guid>("StageId");
            ProcessId = GetValue<Guid>("ProcessId");
            EntityImage_URL = GetStringValue("EntityImage_URL");
            Address2_Composite = GetStringValue("Address2_Composite");
            Address1_Composite = GetStringValue("Address1_Composite");
            EntityImageId = GetValue<Guid>("EntityImageId");
            EntityImage_Timestamp = GetValue<long>("EntityImage_Timestamp");
            OpenDeals = GetValue<long>("OpenDeals");
            OpenDeals_Date = GetValue<DateTimeOffset>("OpenDeals_Date");
            OpenDeals_State = GetValue<long>("OpenDeals_State");
            TimeSpentByMeOnEmailAndMeetings = GetStringValue("TimeSpentByMeOnEmailAndMeetings");
            OpenRevenue = GetStringValue("OpenRevenue");
            OpenRevenue_Base = GetStringValue("OpenRevenue_Base");
            OpenRevenue_Date = GetValue<DateTimeOffset>("OpenRevenue_Date");
            OpenRevenue_State = GetValue<long>("OpenRevenue_State");
            CreatedByExternalParty = GetStringValue("CreatedByExternalParty");
            CreatedByExternalPartyName = GetStringValue("CreatedByExternalPartyName");
            CreatedByExternalPartyYomiName = GetStringValue("CreatedByExternalPartyYomiName");
            ModifiedByExternalParty = GetStringValue("ModifiedByExternalParty");
            ModifiedByExternalPartyName = GetStringValue("ModifiedByExternalPartyName");
            ModifiedByExternalPartyYomiName = GetStringValue("ModifiedByExternalPartyYomiName");
            PrimarySatoriId = GetStringValue("PrimarySatoriId");
            PrimaryTwitterId = GetStringValue("PrimaryTwitterId");
            SLAId = GetStringValue("SLAId");
            SLAName = GetStringValue("SLAName");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            OnHoldTime = GetValue<long>("OnHoldTime");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            FollowEmail = GetValue<bool>("FollowEmail");
            FollowEmailName = GetStringValue("FollowEmailName");
            MarketingOnly = GetValue<bool>("MarketingOnly");
            MarketingOnlyName = GetStringValue("MarketingOnlyName");
            TeamsFollowed = GetValue<long>("TeamsFollowed");

            AddCustomMappings();
        }

        public Guid? AccountId { get; set; }
        public string AccountCategoryCode { get; set; }
        public string TerritoryId { get; set; }
        public string DefaultPriceLevelId { get; set; }
        public string CustomerSizeCode { get; set; }
        public string PreferredContactMethodCode { get; set; }
        public string CustomerTypeCode { get; set; }
        public string AccountRatingCode { get; set; }
        public string IndustryCode { get; set; }
        public string TerritoryCode { get; set; }
        public string AccountClassificationCode { get; set; }
        public string BusinessTypeCode { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string TraversedPath { get; set; }
        public string OwningUser { get; set; }
        public string OriginatingLeadId { get; set; }
        public string PaymentTermsCode { get; set; }
        public string ShippingMethodCode { get; set; }
        public string PrimaryContactId { get; set; }
        public bool? ParticipatesInWorkflow { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Revenue { get; set; }
        public long? NumberOfEmployees { get; set; }
        public string Description { get; set; }
        public string SIC { get; set; }
        public string OwnershipCode { get; set; }
        public string MarketCap { get; set; }
        public long? SharesOutstanding { get; set; }
        public string TickerSymbol { get; set; }
        public string StockExchange { get; set; }
        public string WebSiteURL { get; set; }
        public string FtpSiteURL { get; set; }
        public string EMailAddress1 { get; set; }
        public string EMailAddress2 { get; set; }
        public string EMailAddress3 { get; set; }
        public bool? DoNotPhone { get; set; }
        public bool? DoNotFax { get; set; }
        public string Telephone1 { get; set; }
        public bool? DoNotEMail { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string Telephone3 { get; set; }
        public bool? DoNotPostalMail { get; set; }
        public bool? DoNotBulkEMail { get; set; }
        public bool? DoNotBulkPostalMail { get; set; }
        public string CreditLimit { get; set; }
        public bool? CreditOnHold { get; set; }
        public bool? IsPrivate { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public long? VersionNumber { get; set; }
        public string ParentAccountId { get; set; }
        public string Aging30 { get; set; }
        public string StateCode { get; set; }
        public string Aging60 { get; set; }
        public string StatusCode { get; set; }
        public string Aging90 { get; set; }
        public string OriginatingLeadIdName { get; set; }
        public string PrimaryContactIdName { get; set; }
        public string ParentAccountIdName { get; set; }
        public string DefaultPriceLevelIdName { get; set; }
        public string TerritoryIdName { get; set; }
        public Guid? Address1_AddressId { get; set; }
        public string Address1_AddressTypeCode { get; set; }
        public string Address1_Name { get; set; }
        public string Address1_PrimaryContactName { get; set; }
        public string Address1_Line1 { get; set; }
        public string Address1_Line2 { get; set; }
        public string Address1_Line3 { get; set; }
        public string Address1_City { get; set; }
        public string Address1_StateOrProvince { get; set; }
        public string Address1_County { get; set; }
        public string Address1_Country { get; set; }
        public string Address1_PostOfficeBox { get; set; }
        public string Address1_PostalCode { get; set; }
        public long? Address1_UTCOffset { get; set; }
        public string Address1_FreightTermsCode { get; set; }
        public string Address1_UPSZone { get; set; }
        public double? Address1_Latitude { get; set; }
        public string Address1_Telephone1 { get; set; }
        public double? Address1_Longitude { get; set; }
        public string Address1_ShippingMethodCode { get; set; }
        public string Address1_Telephone2 { get; set; }
        public string Address1_Telephone3 { get; set; }
        public string Address1_Fax { get; set; }
        public Guid? Address2_AddressId { get; set; }
        public string Address2_AddressTypeCode { get; set; }
        public string Address2_Name { get; set; }
        public string Address2_PrimaryContactName { get; set; }
        public string Address2_Line1 { get; set; }
        public string Address2_Line2 { get; set; }
        public string Address2_Line3 { get; set; }
        public string Address2_City { get; set; }
        public string Address2_StateOrProvince { get; set; }
        public string Address2_County { get; set; }
        public string Address2_Country { get; set; }
        public string Address2_PostOfficeBox { get; set; }
        public string Address2_PostalCode { get; set; }
        public long? Address2_UTCOffset { get; set; }
        public string Address2_FreightTermsCode { get; set; }
        public string Address2_UPSZone { get; set; }
        public double? Address2_Latitude { get; set; }
        public string Address2_Telephone1 { get; set; }
        public double? Address2_Longitude { get; set; }
        public string Address2_ShippingMethodCode { get; set; }
        public string Address2_Telephone2 { get; set; }
        public string Address2_Telephone3 { get; set; }
        public string Address2_Fax { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string OwnerId { get; set; }
        public string OwnerIdName { get; set; }
        public string OwnerIdType { get; set; }
        public string DoNotFaxName { get; set; }
        public string DoNotPhoneName { get; set; }
        public string DoNotBulkPostalMailName { get; set; }
        public string CreditOnHoldName { get; set; }
        public string DoNotEMailName { get; set; }
        public string IsPrivateName { get; set; }
        public string DoNotPostalMailName { get; set; }
        public string ParticipatesInWorkflowName { get; set; }
        public string DoNotBulkEMailName { get; set; }
        public string Address1_ShippingMethodCodeName { get; set; }
        public string IndustryCodeName { get; set; }
        public string AccountRatingCodeName { get; set; }
        public string OwnershipCodeName { get; set; }
        public string AccountClassificationCodeName { get; set; }
        public string CustomerSizeCodeName { get; set; }
        public string StateCodeName { get; set; }
        public string ShippingMethodCodeName { get; set; }
        public string Address1_FreightTermsCodeName { get; set; }
        public string BusinessTypeCodeName { get; set; }
        public string Address2_FreightTermsCodeName { get; set; }
        public string AccountCategoryCodeName { get; set; }
        public string PaymentTermsCodeName { get; set; }
        public string PreferredContactMethodCodeName { get; set; }
        public string TerritoryCodeName { get; set; }
        public string StatusCodeName { get; set; }
        public string CustomerTypeCodeName { get; set; }
        public string Address1_AddressTypeCodeName { get; set; }
        public string Address2_ShippingMethodCodeName { get; set; }
        public string Address2_AddressTypeCodeName { get; set; }
        public string PreferredAppointmentDayCode { get; set; }
        public string PreferredSystemUserId { get; set; }
        public string PreferredAppointmentTimeCode { get; set; }
        public bool? Merged { get; set; }
        public bool? DoNotSendMM { get; set; }
        public string MasterId { get; set; }
        public DateTimeOffset? LastUsedInCampaign { get; set; }
        public string PreferredServiceId { get; set; }
        public string PreferredEquipmentId { get; set; }
        public string PreferredEquipmentIdName { get; set; }
        public string PreferredServiceIdName { get; set; }
        public string PreferredAppointmentTimeCodeName { get; set; }
        public string PreferredAppointmentDayCodeName { get; set; }
        public string PreferredSystemUserIdName { get; set; }
        public string MergedName { get; set; }
        public string MasterAccountIdName { get; set; }
        public string DoNotSendMarketingMaterialName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public string TransactionCurrencyId { get; set; }
        public string CreditLimit_Base { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public string Aging30_Base { get; set; }
        public string Revenue_Base { get; set; }
        public string Aging90_Base { get; set; }
        public string MarketCap_Base { get; set; }
        public string Aging60_Base { get; set; }
        public string PreferredSystemUserIdYomiName { get; set; }
        public string ParentAccountIdYomiName { get; set; }
        public string OriginatingLeadIdYomiName { get; set; }
        public string MasterAccountIdYomiName { get; set; }
        public string PrimaryContactIdYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string YomiName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string OwningTeam { get; set; }
        public string EntityImage { get; set; }
        public Guid? StageId { get; set; }
        public Guid? ProcessId { get; set; }
        public string EntityImage_URL { get; set; }
        public string Address2_Composite { get; set; }
        public string Address1_Composite { get; set; }
        public Guid? EntityImageId { get; set; }
        public long? EntityImage_Timestamp { get; set; }
        public long? OpenDeals { get; set; }
        public DateTimeOffset? OpenDeals_Date { get; set; }
        public long? OpenDeals_State { get; set; }
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }
        public string OpenRevenue { get; set; }
        public string OpenRevenue_Base { get; set; }
        public DateTimeOffset? OpenRevenue_Date { get; set; }
        public long? OpenRevenue_State { get; set; }
        public string CreatedByExternalParty { get; set; }
        public string CreatedByExternalPartyName { get; set; }
        public string CreatedByExternalPartyYomiName { get; set; }
        public string ModifiedByExternalParty { get; set; }
        public string ModifiedByExternalPartyName { get; set; }
        public string ModifiedByExternalPartyYomiName { get; set; }
        public string PrimarySatoriId { get; set; }
        public string PrimaryTwitterId { get; set; }
        public string SLAId { get; set; }
        public string SLAName { get; set; }
        public string SLAInvokedId { get; set; }
        public long? OnHoldTime { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public string SLAInvokedIdName { get; set; }
        public bool? FollowEmail { get; set; }
        public string FollowEmailName { get; set; }
        public bool? MarketingOnly { get; set; }
        public string MarketingOnlyName { get; set; }
        public long? TeamsFollowed { get; set; }
    }
}

