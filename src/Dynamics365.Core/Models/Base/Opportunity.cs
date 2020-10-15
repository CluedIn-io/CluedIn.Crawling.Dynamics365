using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Opportunity : DynamicsModel
    {

        public Opportunity() { }

        public Opportunity(IDataReader reader) : base(reader)
        {
            OpportunityId = GetValue<Guid>("OpportunityId");
            PriceLevelId = GetStringValue("PriceLevelId");
            OpportunityRatingCode = GetStringValue("OpportunityRatingCode");
            PriorityCode = GetStringValue("PriorityCode");
            ContactId = GetStringValue("ContactId");
            AccountId = GetStringValue("AccountId");
            Name = GetStringValue("Name");
            StepId = GetValue<Guid>("StepId");
            Description = GetStringValue("Description");
            EstimatedValue = GetStringValue("EstimatedValue");
            StepName = GetStringValue("StepName");
            SalesStageCode = GetStringValue("SalesStageCode");
            ParticipatesInWorkflow = GetValue<bool>("ParticipatesInWorkflow");
            PricingErrorCode = GetStringValue("PricingErrorCode");
            EstimatedCloseDate = GetValue<DateTimeOffset>("EstimatedCloseDate");
            CloseProbability = GetValue<long>("CloseProbability");
            ActualValue = GetStringValue("ActualValue");
            ActualCloseDate = GetValue<DateTimeOffset>("ActualCloseDate");
            OwningUser = GetStringValue("OwningUser");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            OriginatingLeadId = GetStringValue("OriginatingLeadId");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            IsPrivate = GetValue<bool>("IsPrivate");
            CreatedBy = GetStringValue("CreatedBy");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            ModifiedBy = GetStringValue("ModifiedBy");
            VersionNumber = GetValue<long>("VersionNumber");
            StateCode = GetStringValue("StateCode");
            StatusCode = GetStringValue("StatusCode");
            IsRevenueSystemCalculated = GetValue<bool>("IsRevenueSystemCalculated");
            OriginatingLeadIdName = GetStringValue("OriginatingLeadIdName");
            ContactIdName = GetStringValue("ContactIdName");
            AccountIdName = GetStringValue("AccountIdName");
            PriceLevelIdName = GetStringValue("PriceLevelIdName");
            CreatedByName = GetStringValue("CreatedByName");
            ModifiedByName = GetStringValue("ModifiedByName");
            CustomerId = GetStringValue("CustomerId");
            CustomerIdName = GetStringValue("CustomerIdName");
            CustomerIdType = GetStringValue("CustomerIdType");
            OwnerId = GetStringValue("OwnerId");
            OwnerIdName = GetStringValue("OwnerIdName");
            OwnerIdType = GetStringValue("OwnerIdType");
            IsPrivateName = GetStringValue("IsPrivateName");
            ParticipatesInWorkflowName = GetStringValue("ParticipatesInWorkflowName");
            IsRevenueSystemCalculatedName = GetStringValue("IsRevenueSystemCalculatedName");
            PriorityCodeName = GetStringValue("PriorityCodeName");
            SalesStageCodeName = GetStringValue("SalesStageCodeName");
            StateCodeName = GetStringValue("StateCodeName");
            OpportunityRatingCodeName = GetStringValue("OpportunityRatingCodeName");
            StatusCodeName = GetStringValue("StatusCodeName");
            PricingErrorCodeName = GetStringValue("PricingErrorCodeName");
            CampaignId = GetStringValue("CampaignId");
            CampaignIdName = GetStringValue("CampaignIdName");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            ActualValue_Base = GetStringValue("ActualValue_Base");
            EstimatedValue_Base = GetStringValue("EstimatedValue_Base");
            ContactIdYomiName = GetStringValue("ContactIdYomiName");
            AccountIdYomiName = GetStringValue("AccountIdYomiName");
            OriginatingLeadIdYomiName = GetStringValue("OriginatingLeadIdYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            CustomerIdYomiName = GetStringValue("CustomerIdYomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            TotalTax = GetStringValue("TotalTax");
            DiscountPercentage = GetValue<decimal>("DiscountPercentage");
            TotalAmount = GetStringValue("TotalAmount");
            DiscountAmount = GetStringValue("DiscountAmount");
            TotalAmountLessFreight = GetStringValue("TotalAmountLessFreight");
            FreightAmount = GetStringValue("FreightAmount");
            TotalLineItemDiscountAmount = GetStringValue("TotalLineItemDiscountAmount");
            TotalLineItemAmount = GetStringValue("TotalLineItemAmount");
            TotalDiscountAmount = GetStringValue("TotalDiscountAmount");
            TotalLineItemAmount_Base = GetStringValue("TotalLineItemAmount_Base");
            TotalDiscountAmount_Base = GetStringValue("TotalDiscountAmount_Base");
            TotalTax_Base = GetStringValue("TotalTax_Base");
            DiscountAmount_Base = GetStringValue("DiscountAmount_Base");
            TotalLineItemDiscountAmount_Base = GetStringValue("TotalLineItemDiscountAmount_Base");
            TotalAmount_Base = GetStringValue("TotalAmount_Base");
            TotalAmountLessFreight_Base = GetStringValue("TotalAmountLessFreight_Base");
            FreightAmount_Base = GetStringValue("FreightAmount_Base");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            OwningTeam = GetStringValue("OwningTeam");
            BudgetStatus = GetStringValue("BudgetStatus");
            DecisionMaker = GetValue<bool>("DecisionMaker");
            Need = GetStringValue("Need");
            TimeLine = GetStringValue("TimeLine");
            TimelineName = GetStringValue("TimelineName");
            NeedName = GetStringValue("NeedName");
            DecisionMakerName = GetStringValue("DecisionMakerName");
            BudgetTypeName = GetStringValue("BudgetTypeName");
            BudgetAmount = GetStringValue("BudgetAmount");
            BudgetAmount_Base = GetStringValue("BudgetAmount_Base");
            ParentAccountId = GetStringValue("ParentAccountId");
            ParentAccountIdName = GetStringValue("ParentAccountIdName");
            ParentAccountIdYomiName = GetStringValue("ParentAccountIdYomiName");
            ParentContactId = GetStringValue("ParentContactId");
            ParentContactIdName = GetStringValue("ParentContactIdName");
            ParentContactIdYomiName = GetStringValue("ParentContactIdYomiName");
            EvaluateFit = GetValue<bool>("EvaluateFit");
            EvaluateFitName = GetStringValue("EvaluateFitName");
            InitialCommunication = GetStringValue("InitialCommunication");
            InitialCommunicationName = GetStringValue("InitialCommunicationName");
            ConfirmInterest = GetValue<bool>("ConfirmInterest");
            ConfirmInterestName = GetStringValue("ConfirmInterestName");
            ScheduleFollowup_Prospect = GetValue<DateTimeOffset>("ScheduleFollowup_Prospect");
            ScheduleFollowup_Qualify = GetValue<DateTimeOffset>("ScheduleFollowup_Qualify");
            ScheduleProposalMeeting = GetValue<DateTimeOffset>("ScheduleProposalMeeting");
            FinalDecisionDate = GetValue<DateTimeOffset>("FinalDecisionDate");
            DevelopProposal = GetValue<bool>("DevelopProposal");
            DevelopProposalName = GetStringValue("DevelopProposalName");
            CompleteInternalReview = GetValue<bool>("CompleteInternalReview");
            CompleteInternalReviewName = GetStringValue("CompleteInternalReviewName");
            CaptureProposalFeedback = GetValue<bool>("CaptureProposalFeedback");
            CaptureProposalFeedbackName = GetStringValue("CaptureProposalFeedbackName");
            ResolveFeedback = GetValue<bool>("ResolveFeedback");
            ResolveFeedbackName = GetStringValue("ResolveFeedbackName");
            PresentProposal = GetValue<bool>("PresentProposal");
            PresentProposalName = GetStringValue("PresentProposalName");
            SendThankYouNote = GetValue<bool>("SendThankYouNote");
            SendThankYouNoteName = GetStringValue("SendThankYouNoteName");
            SalesStage = GetStringValue("SalesStage");
            SalesStageName = GetStringValue("SalesStageName");
            TraversedPath = GetStringValue("TraversedPath");
            CompleteFinalProposal = GetValue<bool>("CompleteFinalProposal");
            CompleteFinalProposalName = GetStringValue("CompleteFinalProposalName");
            FileDebrief = GetValue<bool>("FileDebrief");
            FileDeBriefName = GetStringValue("FileDeBriefName");
            PursuitDecision = GetValue<bool>("PursuitDecision");
            PursuitDecisionName = GetStringValue("PursuitDecisionName");
            CustomerPainPoints = GetStringValue("CustomerPainPoints");
            CustomerNeed = GetStringValue("CustomerNeed");
            ProposedSolution = GetStringValue("ProposedSolution");
            QualificationComments = GetStringValue("QualificationComments");
            QuoteComments = GetStringValue("QuoteComments");
            PurchaseProcess = GetStringValue("PurchaseProcess");
            PurchaseProcessName = GetStringValue("PurchaseProcessName");
            PurchaseTimeframe = GetStringValue("PurchaseTimeframe");
            PurchaseTimeframeName = GetStringValue("PurchaseTimeframeName");
            IdentifyCustomerContacts = GetValue<bool>("IdentifyCustomerContacts");
            IdentifyCustomerContactsName = GetStringValue("IdentifyCustomerContactsName");
            IdentifyCompetitors = GetValue<bool>("IdentifyCompetitors");
            IdentifyCompetitorsName = GetStringValue("IdentifyCompetitorsName");
            IdentifyPursuitTeam = GetValue<bool>("IdentifyPursuitTeam");
            IdentifyPursuitTeamName = GetStringValue("IdentifyPursuitTeamName");
            CurrentSituation = GetStringValue("CurrentSituation");
            PresentFinalProposal = GetValue<bool>("PresentFinalProposal");
            PresentFinalProposalName = GetStringValue("PresentFinalProposalName");
            OnHoldTime = GetValue<long>("OnHoldTime");
            StageId = GetValue<Guid>("StageId");
            ProcessId = GetValue<Guid>("ProcessId");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            SLAId = GetStringValue("SLAId");
            SLAName = GetStringValue("SLAName");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            TimeSpentByMeOnEmailAndMeetings = GetStringValue("TimeSpentByMeOnEmailAndMeetings");
            EmailAddress = GetStringValue("EmailAddress");
            TeamsFollowed = GetValue<long>("TeamsFollowed");
            SkipPriceCalculation = GetStringValue("SkipPriceCalculation");
            skippricecalculationName = GetStringValue("skippricecalculationName");

            AddCustomMappings();
        }

        public Guid? OpportunityId { get; set; }
        public string PriceLevelId { get; set; }
        public string OpportunityRatingCode { get; set; }
        public string PriorityCode { get; set; }
        public string ContactId { get; set; }
        public string AccountId { get; set; }
        public string Name { get; set; }
        public Guid? StepId { get; set; }
        public string Description { get; set; }
        public string EstimatedValue { get; set; }
        public string StepName { get; set; }
        public string SalesStageCode { get; set; }
        public bool? ParticipatesInWorkflow { get; set; }
        public string PricingErrorCode { get; set; }
        public DateTimeOffset? EstimatedCloseDate { get; set; }
        public long? CloseProbability { get; set; }
        public string ActualValue { get; set; }
        public DateTimeOffset? ActualCloseDate { get; set; }
        public string OwningUser { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string OriginatingLeadId { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public bool? IsPrivate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public long VersionNumber { get; set; }
        public string StateCode { get; set; }
        public string StatusCode { get; set; }
        public bool? IsRevenueSystemCalculated { get; set; }
        public string OriginatingLeadIdName { get; set; }
        public string ContactIdName { get; set; }
        public string AccountIdName { get; set; }
        public string PriceLevelIdName { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerIdName { get; set; }
        public string CustomerIdType { get; set; }
        public string OwnerId { get; set; }
        public string OwnerIdName { get; set; }
        public string OwnerIdType { get; set; }
        public string IsPrivateName { get; set; }
        public string ParticipatesInWorkflowName { get; set; }
        public string IsRevenueSystemCalculatedName { get; set; }
        public string PriorityCodeName { get; set; }
        public string SalesStageCodeName { get; set; }
        public string StateCodeName { get; set; }
        public string OpportunityRatingCodeName { get; set; }
        public string StatusCodeName { get; set; }
        public string PricingErrorCodeName { get; set; }
        public string CampaignId { get; set; }
        public string CampaignIdName { get; set; }
        public string TransactionCurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public string ActualValue_Base { get; set; }
        public string EstimatedValue_Base { get; set; }
        public string ContactIdYomiName { get; set; }
        public string AccountIdYomiName { get; set; }
        public string OriginatingLeadIdYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string CustomerIdYomiName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string TotalTax { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string TotalAmount { get; set; }
        public string DiscountAmount { get; set; }
        public string TotalAmountLessFreight { get; set; }
        public string FreightAmount { get; set; }
        public string TotalLineItemDiscountAmount { get; set; }
        public string TotalLineItemAmount { get; set; }
        public string TotalDiscountAmount { get; set; }
        public string TotalLineItemAmount_Base { get; set; }
        public string TotalDiscountAmount_Base { get; set; }
        public string TotalTax_Base { get; set; }
        public string DiscountAmount_Base { get; set; }
        public string TotalLineItemDiscountAmount_Base { get; set; }
        public string TotalAmount_Base { get; set; }
        public string TotalAmountLessFreight_Base { get; set; }
        public string FreightAmount_Base { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string OwningTeam { get; set; }
        public string BudgetStatus { get; set; }
        public bool? DecisionMaker { get; set; }
        public string Need { get; set; }
        public string TimeLine { get; set; }
        public string TimelineName { get; set; }
        public string NeedName { get; set; }
        public string DecisionMakerName { get; set; }
        public string BudgetTypeName { get; set; }
        public string BudgetAmount { get; set; }
        public string BudgetAmount_Base { get; set; }
        public string ParentAccountId { get; set; }
        public string ParentAccountIdName { get; set; }
        public string ParentAccountIdYomiName { get; set; }
        public string ParentContactId { get; set; }
        public string ParentContactIdName { get; set; }
        public string ParentContactIdYomiName { get; set; }
        public bool? EvaluateFit { get; set; }
        public string EvaluateFitName { get; set; }
        public string InitialCommunication { get; set; }
        public string InitialCommunicationName { get; set; }
        public bool? ConfirmInterest { get; set; }
        public string ConfirmInterestName { get; set; }
        public DateTimeOffset? ScheduleFollowup_Prospect { get; set; }
        public DateTimeOffset? ScheduleFollowup_Qualify { get; set; }
        public DateTimeOffset? ScheduleProposalMeeting { get; set; }
        public DateTimeOffset? FinalDecisionDate { get; set; }
        public bool? DevelopProposal { get; set; }
        public string DevelopProposalName { get; set; }
        public bool? CompleteInternalReview { get; set; }
        public string CompleteInternalReviewName { get; set; }
        public bool? CaptureProposalFeedback { get; set; }
        public string CaptureProposalFeedbackName { get; set; }
        public bool? ResolveFeedback { get; set; }
        public string ResolveFeedbackName { get; set; }
        public bool? PresentProposal { get; set; }
        public string PresentProposalName { get; set; }
        public bool? SendThankYouNote { get; set; }
        public string SendThankYouNoteName { get; set; }
        public string SalesStage { get; set; }
        public string SalesStageName { get; set; }
        public string TraversedPath { get; set; }
        public bool? CompleteFinalProposal { get; set; }
        public string CompleteFinalProposalName { get; set; }
        public bool? FileDebrief { get; set; }
        public string FileDeBriefName { get; set; }
        public bool? PursuitDecision { get; set; }
        public string PursuitDecisionName { get; set; }
        public string CustomerPainPoints { get; set; }
        public string CustomerNeed { get; set; }
        public string ProposedSolution { get; set; }
        public string QualificationComments { get; set; }
        public string QuoteComments { get; set; }
        public string PurchaseProcess { get; set; }
        public string PurchaseProcessName { get; set; }
        public string PurchaseTimeframe { get; set; }
        public string PurchaseTimeframeName { get; set; }
        public bool? IdentifyCustomerContacts { get; set; }
        public string IdentifyCustomerContactsName { get; set; }
        public bool? IdentifyCompetitors { get; set; }
        public string IdentifyCompetitorsName { get; set; }
        public bool? IdentifyPursuitTeam { get; set; }
        public string IdentifyPursuitTeamName { get; set; }
        public string CurrentSituation { get; set; }
        public bool? PresentFinalProposal { get; set; }
        public string PresentFinalProposalName { get; set; }
        public long? OnHoldTime { get; set; }
        public Guid? StageId { get; set; }
        public Guid? ProcessId { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public string SLAId { get; set; }
        public string SLAName { get; set; }
        public string SLAInvokedId { get; set; }
        public string SLAInvokedIdName { get; set; }
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }
        public string EmailAddress { get; set; }
        public long? TeamsFollowed { get; set; }
        public string SkipPriceCalculation { get; set; }
        public string skippricecalculationName { get; set; }

    }
}

