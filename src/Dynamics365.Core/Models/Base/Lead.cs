using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Lead : DynamicsModel
    {

        public Lead() { }

        public Lead(IDataReader reader) : base(reader)
        {
            LeadId = GetValue<Guid>("LeadId");
            ContactId = GetStringValue("ContactId");
            AccountId = GetStringValue("AccountId");
            LeadSourceCode = GetStringValue("LeadSourceCode");
            LeadQualityCode = GetStringValue("LeadQualityCode");
            PriorityCode = GetStringValue("PriorityCode");
            IndustryCode = GetStringValue("IndustryCode");
            PreferredContactMethodCode = GetStringValue("PreferredContactMethodCode");
            SalesStageCode = GetStringValue("SalesStageCode");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            Subject = GetStringValue("Subject");
            ParticipatesInWorkflow = GetValue<bool>("ParticipatesInWorkflow");
            Description = GetStringValue("Description");
            EstimatedValue = GetValue<double>("EstimatedValue");
            EstimatedCloseDate = GetValue<DateTimeOffset>("EstimatedCloseDate");
            CompanyName = GetStringValue("CompanyName");
            FirstName = GetStringValue("FirstName");
            MiddleName = GetStringValue("MiddleName");
            LastName = GetStringValue("LastName");
            Revenue = GetStringValue("Revenue");
            NumberOfEmployees = GetValue<long>("NumberOfEmployees");
            DoNotPhone = GetValue<bool>("DoNotPhone");
            SIC = GetStringValue("SIC");
            DoNotFax = GetValue<bool>("DoNotFax");
            EMailAddress1 = GetStringValue("EMailAddress1");
            JobTitle = GetStringValue("JobTitle");
            Salutation = GetStringValue("Salutation");
            DoNotEMail = GetValue<bool>("DoNotEMail");
            EMailAddress2 = GetStringValue("EMailAddress2");
            DoNotPostalMail = GetValue<bool>("DoNotPostalMail");
            EMailAddress3 = GetStringValue("EMailAddress3");
            FullName = GetStringValue("FullName");
            YomiFirstName = GetStringValue("YomiFirstName");
            WebSiteUrl = GetStringValue("WebSiteUrl");
            Telephone1 = GetStringValue("Telephone1");
            Telephone2 = GetStringValue("Telephone2");
            Telephone3 = GetStringValue("Telephone3");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            IsPrivate = GetValue<bool>("IsPrivate");
            Fax = GetStringValue("Fax");
            YomiMiddleName = GetStringValue("YomiMiddleName");
            YomiLastName = GetStringValue("YomiLastName");
            CreatedBy = GetStringValue("CreatedBy");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            ModifiedBy = GetStringValue("ModifiedBy");
            YomiFullName = GetStringValue("YomiFullName");
            OwningUser = GetStringValue("OwningUser");
            MobilePhone = GetStringValue("MobilePhone");
            StateCode = GetStringValue("StateCode");
            Pager = GetStringValue("Pager");
            StatusCode = GetStringValue("StatusCode");
            VersionNumber = GetValue<long>("VersionNumber");
            ContactIdName = GetStringValue("ContactIdName");
            AccountIdName = GetStringValue("AccountIdName");
            Address1_AddressId = GetValue<Guid>("Address1_AddressId");
            Address1_AddressTypeCode = GetStringValue("Address1_AddressTypeCode");
            Address1_Name = GetStringValue("Address1_Name");
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
            CustomerId = GetStringValue("CustomerId");
            CustomerIdName = GetStringValue("CustomerIdName");
            CustomerIdType = GetStringValue("CustomerIdType");
            OwnerId = GetStringValue("OwnerId");
            OwnerIdName = GetStringValue("OwnerIdName");
            OwnerIdType = GetStringValue("OwnerIdType");
            IsPrivateName = GetStringValue("IsPrivateName");
            DoNotPostalMailName = GetStringValue("DoNotPostalMailName");
            DoNotFaxName = GetStringValue("DoNotFaxName");
            DoNotEMailName = GetStringValue("DoNotEMailName");
            DoNotPhoneName = GetStringValue("DoNotPhoneName");
            ParticipatesInWorkflowName = GetStringValue("ParticipatesInWorkflowName");
            StateCodeName = GetStringValue("StateCodeName");
            LeadSourceCodeName = GetStringValue("LeadSourceCodeName");
            SalesStageCodeName = GetStringValue("SalesStageCodeName");
            PriorityCodeName = GetStringValue("PriorityCodeName");
            Address2_AddressTypeCodeName = GetStringValue("Address2_AddressTypeCodeName");
            StatusCodeName = GetStringValue("StatusCodeName");
            Address1_ShippingMethodCodeName = GetStringValue("Address1_ShippingMethodCodeName");
            LeadQualityCodeName = GetStringValue("LeadQualityCodeName");
            IndustryCodeName = GetStringValue("IndustryCodeName");
            Address1_AddressTypeCodeName = GetStringValue("Address1_AddressTypeCodeName");
            Address2_ShippingMethodCodeName = GetStringValue("Address2_ShippingMethodCodeName");
            PreferredContactMethodCodeName = GetStringValue("PreferredContactMethodCodeName");
            MasterId = GetStringValue("MasterId");
            CampaignId = GetStringValue("CampaignId");
            DoNotSendMM = GetValue<bool>("DoNotSendMM");
            Merged = GetValue<bool>("Merged");
            DoNotBulkEMail = GetValue<bool>("DoNotBulkEMail");
            LastUsedInCampaign = GetValue<DateTimeOffset>("LastUsedInCampaign");
            CampaignIdName = GetStringValue("CampaignIdName");
            DoNotBulkEMailName = GetStringValue("DoNotBulkEMailName");
            MasterLeadIdName = GetStringValue("MasterLeadIdName");
            MergedName = GetStringValue("MergedName");
            DoNotSendMarketingMaterialName = GetStringValue("DoNotSendMarketingMaterialName");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            EstimatedAmount = GetStringValue("EstimatedAmount");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            EstimatedAmount_Base = GetStringValue("EstimatedAmount_Base");
            Revenue_Base = GetStringValue("Revenue_Base");
            YomiCompanyName = GetStringValue("YomiCompanyName");
            AccountIdYomiName = GetStringValue("AccountIdYomiName");
            ContactIdYomiName = GetStringValue("ContactIdYomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            MasterLeadIdYomiName = GetStringValue("MasterLeadIdYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            CustomerIdYomiName = GetStringValue("CustomerIdYomiName");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            OwningTeam = GetStringValue("OwningTeam");
            IsAutoCreate = GetValue<bool>("IsAutoCreate");
            ParentAccountId = GetStringValue("ParentAccountId");
            ParentContactId = GetStringValue("ParentContactId");
            ParentAccountIdName = GetStringValue("ParentAccountIdName");
            ParentAccountIdYomiName = GetStringValue("ParentAccountIdYomiName");
            ParentContactIdName = GetStringValue("ParentContactIdName");
            ParentContactIdYomiName = GetStringValue("ParentContactIdYomiName");
            RelatedObjectId = GetStringValue("RelatedObjectId");
            BudgetAmount = GetStringValue("BudgetAmount");
            BudgetAmount_Base = GetStringValue("BudgetAmount_Base");
            BudgetStatus = GetStringValue("BudgetStatus");
            BudgetStatusName = GetStringValue("BudgetStatusName");
            DecisionMaker = GetValue<bool>("DecisionMaker");
            DecisionMakerName = GetStringValue("DecisionMakerName");
            Need = GetStringValue("Need");
            NeedName = GetStringValue("NeedName");
            PurchaseTimeFrame = GetStringValue("PurchaseTimeFrame");
            PurchaseTimeFrameName = GetStringValue("PurchaseTimeFrameName");
            TraversedPath = GetStringValue("TraversedPath");
            EvaluateFit = GetValue<bool>("EvaluateFit");
            EvaluateFitName = GetStringValue("EvaluateFitName");
            InitialCommunication = GetStringValue("InitialCommunication");
            InitialCommunicationName = GetStringValue("InitialCommunicationName");
            ConfirmInterest = GetValue<bool>("ConfirmInterest");
            ConfirmInterestName = GetStringValue("ConfirmInterestName");
            PurchaseProcess = GetStringValue("PurchaseProcess");
            PurchaseProcessName = GetStringValue("PurchaseProcessName");
            SalesStage = GetStringValue("SalesStage");
            SalesStageName = GetStringValue("SalesStageName");
            ScheduleFollowUp_Prospect = GetValue<DateTimeOffset>("ScheduleFollowUp_Prospect");
            ScheduleFollowUp_Qualify = GetValue<DateTimeOffset>("ScheduleFollowUp_Qualify");
            QualificationComments = GetStringValue("QualificationComments");
            QualifyingOpportunityId = GetStringValue("QualifyingOpportunityId");
            QualifyingOpportunityIdName = GetStringValue("QualifyingOpportunityIdName");
            EntityImage = GetStringValue("EntityImage");
            StageId = GetValue<Guid>("StageId");
            ProcessId = GetValue<Guid>("ProcessId");
            Address2_Composite = GetStringValue("Address2_Composite");
            Address1_Composite = GetStringValue("Address1_Composite");
            EntityImage_URL = GetStringValue("EntityImage_URL");
            EntityImageId = GetValue<Guid>("EntityImageId");
            EntityImage_Timestamp = GetValue<int>("EntityImage_Timestamp");
            OriginatingCaseId = GetStringValue("OriginatingCaseId");
            OriginatingCaseIdName = GetStringValue("OriginatingCaseIdName");
            RelatedObjectIdName = GetStringValue("RelatedObjectIdName");
            SLAId = GetStringValue("SLAId");
            SLAName = GetStringValue("SLAName");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            OnHoldTime = GetValue<long>("OnHoldTime");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            FollowEmail = GetValue<bool>("FollowEmail");
            FollowEmailName = GetStringValue("FollowEmailName");
            TimeSpentByMeOnEmailAndMeetings = GetStringValue("TimeSpentByMeOnEmailAndMeetings");
            isautocreateName = GetStringValue("isautocreateName");
            TeamsFollowed = GetValue<long>("TeamsFollowed");
            BusinessCard = GetStringValue("BusinessCard");
            BusinessCardAttributes = GetStringValue("BusinessCardAttributes");

            AddCustomMappings();
        }
        public Guid? LeadId { get; set; }
        public string ContactId { get; set; }
        public string AccountId { get; set; }
        public string LeadSourceCode { get; set; }
        public string LeadQualityCode { get; set; }
        public string PriorityCode { get; set; }
        public string IndustryCode { get; set; }
        public string PreferredContactMethodCode { get; set; }
        public string SalesStageCode { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string Subject { get; set; }
        public bool? ParticipatesInWorkflow { get; set; }
        public string Description { get; set; }
        public double? EstimatedValue { get; set; }
        public DateTimeOffset? EstimatedCloseDate { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Revenue { get; set; }
        public long? NumberOfEmployees { get; set; }
        public bool? DoNotPhone { get; set; }
        public string SIC { get; set; }
        public bool? DoNotFax { get; set; }
        public string EMailAddress1 { get; set; }
        public string JobTitle { get; set; }
        public string Salutation { get; set; }
        public bool? DoNotEMail { get; set; }
        public string EMailAddress2 { get; set; }
        public bool? DoNotPostalMail { get; set; }
        public string EMailAddress3 { get; set; }
        public string FullName { get; set; }
        public string YomiFirstName { get; set; }
        public string WebSiteUrl { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public bool? IsPrivate { get; set; }
        public string Fax { get; set; }
        public string YomiMiddleName { get; set; }
        public string YomiLastName { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string YomiFullName { get; set; }
        public string OwningUser { get; set; }
        public string MobilePhone { get; set; }
        public string StateCode { get; set; }
        public string Pager { get; set; }
        public string StatusCode { get; set; }
        public long VersionNumber { get; set; }
        public string ContactIdName { get; set; }
        public string AccountIdName { get; set; }
        public Guid? Address1_AddressId { get; set; }
        public string Address1_AddressTypeCode { get; set; }
        public string Address1_Name { get; set; }
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
        public string CustomerId { get; set; }
        public string CustomerIdName { get; set; }
        public string CustomerIdType { get; set; }
        public string OwnerId { get; set; }
        public string OwnerIdName { get; set; }
        public string OwnerIdType { get; set; }
        public string IsPrivateName { get; set; }
        public string DoNotPostalMailName { get; set; }
        public string DoNotFaxName { get; set; }
        public string DoNotEMailName { get; set; }
        public string DoNotPhoneName { get; set; }
        public string ParticipatesInWorkflowName { get; set; }
        public string StateCodeName { get; set; }
        public string LeadSourceCodeName { get; set; }
        public string SalesStageCodeName { get; set; }
        public string PriorityCodeName { get; set; }
        public string Address2_AddressTypeCodeName { get; set; }
        public string StatusCodeName { get; set; }
        public string Address1_ShippingMethodCodeName { get; set; }
        public string LeadQualityCodeName { get; set; }
        public string IndustryCodeName { get; set; }
        public string Address1_AddressTypeCodeName { get; set; }
        public string Address2_ShippingMethodCodeName { get; set; }
        public string PreferredContactMethodCodeName { get; set; }
        public string MasterId { get; set; }
        public string CampaignId { get; set; }
        public bool? DoNotSendMM { get; set; }
        public bool? Merged { get; set; }
        public bool? DoNotBulkEMail { get; set; }
        public DateTimeOffset? LastUsedInCampaign { get; set; }
        public string CampaignIdName { get; set; }
        public string DoNotBulkEMailName { get; set; }
        public string MasterLeadIdName { get; set; }
        public string MergedName { get; set; }
        public string DoNotSendMarketingMaterialName { get; set; }
        public string TransactionCurrencyId { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string EstimatedAmount { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public string EstimatedAmount_Base { get; set; }
        public string Revenue_Base { get; set; }
        public string YomiCompanyName { get; set; }
        public string AccountIdYomiName { get; set; }
        public string ContactIdYomiName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string MasterLeadIdYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string CustomerIdYomiName { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string OwningTeam { get; set; }
        public bool? IsAutoCreate { get; set; }
        public string ParentAccountId { get; set; }
        public string ParentContactId { get; set; }
        public string ParentAccountIdName { get; set; }
        public string ParentAccountIdYomiName { get; set; }
        public string ParentContactIdName { get; set; }
        public string ParentContactIdYomiName { get; set; }
        public string RelatedObjectId { get; set; }
        public string BudgetAmount { get; set; }
        public string BudgetAmount_Base { get; set; }
        public string BudgetStatus { get; set; }
        public string BudgetStatusName { get; set; }
        public bool? DecisionMaker { get; set; }
        public string DecisionMakerName { get; set; }
        public string Need { get; set; }
        public string NeedName { get; set; }
        public string PurchaseTimeFrame { get; set; }
        public string PurchaseTimeFrameName { get; set; }
        public string TraversedPath { get; set; }
        public bool? EvaluateFit { get; set; }
        public string EvaluateFitName { get; set; }
        public string InitialCommunication { get; set; }
        public string InitialCommunicationName { get; set; }
        public bool? ConfirmInterest { get; set; }
        public string ConfirmInterestName { get; set; }
        public string PurchaseProcess { get; set; }
        public string PurchaseProcessName { get; set; }
        public string SalesStage { get; set; }
        public string SalesStageName { get; set; }
        public DateTimeOffset? ScheduleFollowUp_Prospect { get; set; }
        public DateTimeOffset? ScheduleFollowUp_Qualify { get; set; }
        public string QualificationComments { get; set; }
        public string QualifyingOpportunityId { get; set; }
        public string QualifyingOpportunityIdName { get; set; }
        public string EntityImage { get; set; }
        public Guid? StageId { get; set; }
        public Guid? ProcessId { get; set; }
        public string Address2_Composite { get; set; }
        public string Address1_Composite { get; set; }
        public string EntityImage_URL { get; set; }
        public Guid? EntityImageId { get; set; }
        public int? EntityImage_Timestamp { get; set; }
        public string OriginatingCaseId { get; set; }
        public string OriginatingCaseIdName { get; set; }
        public string RelatedObjectIdName { get; set; }
        public string SLAId { get; set; }
        public string SLAName { get; set; }
        public string SLAInvokedId { get; set; }
        public long? OnHoldTime { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public string SLAInvokedIdName { get; set; }
        public bool? FollowEmail { get; set; }
        public string FollowEmailName { get; set; }
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }
        public string isautocreateName { get; set; }
        public long? TeamsFollowed { get; set; }
        public string BusinessCard { get; set; }
        public string BusinessCardAttributes { get; set; }

    }
}

