using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class Contact : DynamicsModel
    {

        public Contact() { }

        public Contact(IDataReader reader) : base(reader)
        {
            ContactId = GetValue<Guid>("ContactId");
            DefaultPriceLevelId = GetStringValue("DefaultPriceLevelId");
            CustomerSizeCode = GetStringValue("CustomerSizeCode");
            CustomerTypeCode = GetStringValue("CustomerTypeCode");
            PreferredContactMethodCode = GetStringValue("PreferredContactMethodCode");
            LeadSourceCode = GetStringValue("LeadSourceCode");
            OriginatingLeadId = GetStringValue("OriginatingLeadId");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            OwningUser = GetStringValue("OwningUser");
            PaymentTermsCode = GetStringValue("PaymentTermsCode");
            ShippingMethodCode = GetStringValue("ShippingMethodCode");
            AccountId = GetStringValue("AccountId");
            ParticipatesInWorkflow = GetValue<bool>("ParticipatesInWorkflow");
            IsBackofficeCustomer = GetValue<bool>("IsBackofficeCustomer");
            Salutation = GetStringValue("Salutation");
            JobTitle = GetStringValue("JobTitle");
            FirstName = GetStringValue("FirstName");
            Department = GetStringValue("Department");
            NickName = GetStringValue("NickName");
            MiddleName = GetStringValue("MiddleName");
            LastName = GetStringValue("LastName");
            Suffix = GetStringValue("Suffix");
            YomiFirstName = GetStringValue("YomiFirstName");
            FullName = GetStringValue("FullName");
            YomiMiddleName = GetStringValue("YomiMiddleName");
            YomiLastName = GetStringValue("YomiLastName");
            Anniversary = GetValue<DateTimeOffset>("Anniversary");
            BirthDate = GetValue<DateTimeOffset>("BirthDate");
            GovernmentId = GetStringValue("GovernmentId");
            YomiFullName = GetStringValue("YomiFullName");
            Description = GetStringValue("Description");
            EmployeeId = GetStringValue("EmployeeId");
            GenderCode = GetStringValue("GenderCode");
            AnnualIncome = GetStringValue("AnnualIncome");
            HasChildrenCode = GetStringValue("HasChildrenCode");
            EducationCode = GetStringValue("EducationCode");
            WebSiteUrl = GetStringValue("WebSiteUrl");
            FamilyStatusCode = GetStringValue("FamilyStatusCode");
            FtpSiteUrl = GetStringValue("FtpSiteUrl");
            EMailAddress1 = GetStringValue("EMailAddress1");
            SpousesName = GetStringValue("SpousesName");
            AssistantName = GetStringValue("AssistantName");
            EMailAddress2 = GetStringValue("EMailAddress2");
            AssistantPhone = GetStringValue("AssistantPhone");
            EMailAddress3 = GetStringValue("EMailAddress3");
            DoNotPhone = GetValue<bool>("DoNotPhone");
            ManagerName = GetStringValue("ManagerName");
            ManagerPhone = GetStringValue("ManagerPhone");
            DoNotFax = GetValue<bool>("DoNotFax");
            DoNotEMail = GetValue<bool>("DoNotEMail");
            DoNotPostalMail = GetValue<bool>("DoNotPostalMail");
            DoNotBulkEMail = GetValue<bool>("DoNotBulkEMail");
            DoNotBulkPostalMail = GetValue<bool>("DoNotBulkPostalMail");
            AccountRoleCode = GetStringValue("AccountRoleCode");
            TerritoryCode = GetStringValue("TerritoryCode");
            IsPrivate = GetValue<bool>("IsPrivate");
            CreditLimit = GetStringValue("CreditLimit");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            CreditOnHold = GetValue<bool>("CreditOnHold");
            CreatedBy = GetStringValue("CreatedBy");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            ModifiedBy = GetStringValue("ModifiedBy");
            NumberOfChildren = GetValue<long>("NumberOfChildren");
            ChildrensNames = GetStringValue("ChildrensNames");
            VersionNumber = GetValue<long>("VersionNumber");
            MobilePhone = GetStringValue("MobilePhone");
            Pager = GetStringValue("Pager");
            Telephone1 = GetStringValue("Telephone1");
            Telephone2 = GetStringValue("Telephone2");
            Telephone3 = GetStringValue("Telephone3");
            Fax = GetStringValue("Fax");
            Aging30 = GetStringValue("Aging30");
            StateCode = GetStringValue("StateCode");
            Aging60 = GetStringValue("Aging60");
            StatusCode = GetStringValue("StatusCode");
            Aging90 = GetStringValue("Aging90");
            ParentContactId = GetStringValue("ParentContactId");
            OriginatingLeadIdName = GetStringValue("OriginatingLeadIdName");
            ParentContactIdName = GetStringValue("ParentContactIdName");
            AccountIdName = GetStringValue("AccountIdName");
            DefaultPriceLevelIdName = GetStringValue("DefaultPriceLevelIdName");
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
            IsPrivateName = GetStringValue("IsPrivateName");
            DoNotFaxName = GetStringValue("DoNotFaxName");
            IsBackofficeCustomerName = GetStringValue("IsBackofficeCustomerName");
            ParticipatesInWorkflowName = GetStringValue("ParticipatesInWorkflowName");
            DoNotPostalMailName = GetStringValue("DoNotPostalMailName");
            CreditOnHoldName = GetStringValue("CreditOnHoldName");
            DoNotPhoneName = GetStringValue("DoNotPhoneName");
            DoNotEMailName = GetStringValue("DoNotEMailName");
            DoNotBulkPostalMailName = GetStringValue("DoNotBulkPostalMailName");
            DoNotBulkEMailName = GetStringValue("DoNotBulkEMailName");
            Address1_AddressTypeCodeName = GetStringValue("Address1_AddressTypeCodeName");
            PreferredContactMethodCodeName = GetStringValue("PreferredContactMethodCodeName");
            Address2_AddressTypeCodeName = GetStringValue("Address2_AddressTypeCodeName");
            CustomerTypeCodeName = GetStringValue("CustomerTypeCodeName");
            StateCodeName = GetStringValue("StateCodeName");
            AccountRoleCodeName = GetStringValue("AccountRoleCodeName");
            StatusCodeName = GetStringValue("StatusCodeName");
            HasChildrenCodeName = GetStringValue("HasChildrenCodeName");
            TerritoryCodeName = GetStringValue("TerritoryCodeName");
            Address1_ShippingMethodCodeName = GetStringValue("Address1_ShippingMethodCodeName");
            PaymentTermsCodeName = GetStringValue("PaymentTermsCodeName");
            GenderCodeName = GetStringValue("GenderCodeName");
            Address2_FreightTermsCodeName = GetStringValue("Address2_FreightTermsCodeName");
            FamilyStatusCodeName = GetStringValue("FamilyStatusCodeName");
            CustomerSizeCodeName = GetStringValue("CustomerSizeCodeName");
            ShippingMethodCodeName = GetStringValue("ShippingMethodCodeName");
            Address1_FreightTermsCodeName = GetStringValue("Address1_FreightTermsCodeName");
            LeadSourceCodeName = GetStringValue("LeadSourceCodeName");
            EducationCodeName = GetStringValue("EducationCodeName");
            Address2_ShippingMethodCodeName = GetStringValue("Address2_ShippingMethodCodeName");
            PreferredSystemUserId = GetStringValue("PreferredSystemUserId");
            PreferredServiceId = GetStringValue("PreferredServiceId");
            MasterId = GetStringValue("MasterId");
            PreferredAppointmentDayCode = GetStringValue("PreferredAppointmentDayCode");
            PreferredAppointmentTimeCode = GetStringValue("PreferredAppointmentTimeCode");
            DoNotSendMM = GetValue<bool>("DoNotSendMM");
            ParentCustomerId = GetStringValue("ParentCustomerId");
            Merged = GetValue<bool>("Merged");
            ExternalUserIdentifier = GetStringValue("ExternalUserIdentifier");
            SubscriptionId = GetValue<Guid>("SubscriptionId");
            PreferredEquipmentId = GetStringValue("PreferredEquipmentId");
            LastUsedInCampaign = GetValue<DateTimeOffset>("LastUsedInCampaign");
            MasterContactIdName = GetStringValue("MasterContactIdName");
            PreferredSystemUserIdName = GetStringValue("PreferredSystemUserIdName");
            MergedName = GetStringValue("MergedName");
            PreferredAppointmentTimeCodeName = GetStringValue("PreferredAppointmentTimeCodeName");
            PreferredEquipmentIdName = GetStringValue("PreferredEquipmentIdName");
            ParentCustomerIdName = GetStringValue("ParentCustomerIdName");
            PreferredAppointmentDayCodeName = GetStringValue("PreferredAppointmentDayCodeName");
            PreferredServiceIdName = GetStringValue("PreferredServiceIdName");
            ParentCustomerIdType = GetStringValue("ParentCustomerIdType");
            DoNotSendMarketingMaterialName = GetStringValue("DoNotSendMarketingMaterialName");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            AnnualIncome_Base = GetStringValue("AnnualIncome_Base");
            CreditLimit_Base = GetStringValue("CreditLimit_Base");
            Aging60_Base = GetStringValue("Aging60_Base");
            Aging90_Base = GetStringValue("Aging90_Base");
            Aging30_Base = GetStringValue("Aging30_Base");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            OriginatingLeadIdYomiName = GetStringValue("OriginatingLeadIdYomiName");
            ParentCustomerIdYomiName = GetStringValue("ParentCustomerIdYomiName");
            PreferredSystemUserIdYomiName = GetStringValue("PreferredSystemUserIdYomiName");
            OwnerIdYomiName = GetStringValue("OwnerIdYomiName");
            MasterContactIdYomiName = GetStringValue("MasterContactIdYomiName");
            AccountIdYomiName = GetStringValue("AccountIdYomiName");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            ParentContactIdYomiName = GetStringValue("ParentContactIdYomiName");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            OwningTeam = GetStringValue("OwningTeam");
            IsAutoCreate = GetValue<bool>("IsAutoCreate");
            EntityImage = GetStringValue("EntityImage");
            StageId = GetValue<Guid>("StageId");
            ProcessId = GetValue<Guid>("ProcessId");
            Address2_Composite = GetStringValue("Address2_Composite");
            Address1_Composite = GetStringValue("Address1_Composite");
            EntityImageId = GetValue<Guid>("EntityImageId");
            EntityImage_URL = GetStringValue("EntityImage_URL");
            EntityImage_Timestamp = GetValue<int>("EntityImage_Timestamp");
            TraversedPath = GetStringValue("TraversedPath");
            SLAId = GetStringValue("SLAId");
            SLAName = GetStringValue("SLAName");
            SLAInvokedId = GetStringValue("SLAInvokedId");
            OnHoldTime = GetValue<long>("OnHoldTime");
            LastOnHoldTime = GetValue<DateTimeOffset>("LastOnHoldTime");
            SLAInvokedIdName = GetStringValue("SLAInvokedIdName");
            FollowEmail = GetValue<bool>("FollowEmail");
            FollowEmailName = GetStringValue("FollowEmailName");
            TimeSpentByMeOnEmailAndMeetings = GetStringValue("TimeSpentByMeOnEmailAndMeetings");
            Address3_Country = GetStringValue("Address3_Country");
            Address3_Line1 = GetStringValue("Address3_Line1");
            Address3_Line2 = GetStringValue("Address3_Line2");
            Address3_Line3 = GetStringValue("Address3_Line3");
            Address3_PostalCode = GetStringValue("Address3_PostalCode");
            Address3_PostOfficeBox = GetStringValue("Address3_PostOfficeBox");
            Address3_StateOrProvince = GetStringValue("Address3_StateOrProvince");
            Address3_City = GetStringValue("Address3_City");
            Business2 = GetStringValue("Business2");
            Callback = GetStringValue("Callback");
            Company = GetStringValue("Company");
            Home2 = GetStringValue("Home2");
            Address3_AddressId = GetValue<Guid>("Address3_AddressId");
            Address3_AddressTypeCodeName = GetStringValue("Address3_AddressTypeCodeName");
            Address3_Composite = GetStringValue("Address3_Composite");
            Address3_Fax = GetStringValue("Address3_Fax");
            Address3_FreightTermsCode = GetStringValue("Address3_FreightTermsCode");
            Address3_FreightTermsCodeName = GetStringValue("Address3_FreightTermsCodeName");
            Address3_Latitude = GetValue<double>("Address3_Latitude");
            Address3_Longitude = GetValue<double>("Address3_Longitude");
            Address3_Name = GetStringValue("Address3_Name");
            Address3_PrimaryContactName = GetStringValue("Address3_PrimaryContactName");
            Address3_ShippingMethodCode = GetStringValue("Address3_ShippingMethodCode");
            Address3_ShippingMethodCodeName = GetStringValue("Address3_ShippingMethodCodeName");
            Address3_Telephone1 = GetStringValue("Address3_Telephone1");
            Address3_Telephone2 = GetStringValue("Address3_Telephone2");
            Address3_Telephone3 = GetStringValue("Address3_Telephone3");
            Address3_UPSZone = GetStringValue("Address3_UPSZone");
            Address3_UTCOffset = GetValue<long>("Address3_UTCOffset");
            Address3_County = GetStringValue("Address3_County");
            Address3_AddressTypeCode = GetStringValue("Address3_AddressTypeCode");
            CreatedByExternalParty = GetStringValue("CreatedByExternalParty");
            CreatedByExternalPartyName = GetStringValue("CreatedByExternalPartyName");
            CreatedByExternalPartyYomiName = GetStringValue("CreatedByExternalPartyYomiName");
            ModifiedByExternalParty = GetStringValue("ModifiedByExternalParty");
            ModifiedByExternalPartyName = GetStringValue("ModifiedByExternalPartyName");
            ModifiedByExternalPartyYomiName = GetStringValue("ModifiedByExternalPartyYomiName");
            MarketingOnly = GetValue<bool>("MarketingOnly");
            MarketingOnlyName = GetStringValue("MarketingOnlyName");
            TeamsFollowed = GetValue<long>("TeamsFollowed");
            BusinessCard = GetStringValue("BusinessCard");
            BusinessCardAttributes = GetStringValue("BusinessCardAttributes");

            AddCustomMappings();
        }

        public Guid? ContactId { get; set; }
        public string DefaultPriceLevelId { get; set; }
        public string CustomerSizeCode { get; set; }
        public string CustomerTypeCode { get; set; }
        public string PreferredContactMethodCode { get; set; }
        public string LeadSourceCode { get; set; }
        public string OriginatingLeadId { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string OwningUser { get; set; }
        public string PaymentTermsCode { get; set; }
        public string ShippingMethodCode { get; set; }
        public string AccountId { get; set; }
        public bool? ParticipatesInWorkflow { get; set; }
        public bool? IsBackofficeCustomer { get; set; }
        public string Salutation { get; set; }
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
        public string NickName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string YomiFirstName { get; set; }
        public string FullName { get; set; }
        public string YomiMiddleName { get; set; }
        public string YomiLastName { get; set; }
        public DateTimeOffset? Anniversary { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public string GovernmentId { get; set; }
        public string YomiFullName { get; set; }
        public string Description { get; set; }
        public string EmployeeId { get; set; }
        public string GenderCode { get; set; }
        public string AnnualIncome { get; set; }
        public string HasChildrenCode { get; set; }
        public string EducationCode { get; set; }
        public string WebSiteUrl { get; set; }
        public string FamilyStatusCode { get; set; }
        public string FtpSiteUrl { get; set; }
        public string EMailAddress1 { get; set; }
        public string SpousesName { get; set; }
        public string AssistantName { get; set; }
        public string EMailAddress2 { get; set; }
        public string AssistantPhone { get; set; }
        public string EMailAddress3 { get; set; }
        public bool? DoNotPhone { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhone { get; set; }
        public bool? DoNotFax { get; set; }
        public bool? DoNotEMail { get; set; }
        public bool? DoNotPostalMail { get; set; }
        public bool? DoNotBulkEMail { get; set; }
        public bool? DoNotBulkPostalMail { get; set; }
        public string AccountRoleCode { get; set; }
        public string TerritoryCode { get; set; }
        public bool? IsPrivate { get; set; }
        public string CreditLimit { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public bool? CreditOnHold { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public long? NumberOfChildren { get; set; }
        public string ChildrensNames { get; set; }
        public long VersionNumber { get; set; }
        public string MobilePhone { get; set; }
        public string Pager { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
        public string Fax { get; set; }
        public string Aging30 { get; set; }
        public string StateCode { get; set; }
        public string Aging60 { get; set; }
        public string StatusCode { get; set; }
        public string Aging90 { get; set; }
        public string ParentContactId { get; set; }
        public string OriginatingLeadIdName { get; set; }
        public string ParentContactIdName { get; set; }
        public string AccountIdName { get; set; }
        public string DefaultPriceLevelIdName { get; set; }
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
        public string IsPrivateName { get; set; }
        public string DoNotFaxName { get; set; }
        public string IsBackofficeCustomerName { get; set; }
        public string ParticipatesInWorkflowName { get; set; }
        public string DoNotPostalMailName { get; set; }
        public string CreditOnHoldName { get; set; }
        public string DoNotPhoneName { get; set; }
        public string DoNotEMailName { get; set; }
        public string DoNotBulkPostalMailName { get; set; }
        public string DoNotBulkEMailName { get; set; }
        public string Address1_AddressTypeCodeName { get; set; }
        public string PreferredContactMethodCodeName { get; set; }
        public string Address2_AddressTypeCodeName { get; set; }
        public string CustomerTypeCodeName { get; set; }
        public string StateCodeName { get; set; }
        public string AccountRoleCodeName { get; set; }
        public string StatusCodeName { get; set; }
        public string HasChildrenCodeName { get; set; }
        public string TerritoryCodeName { get; set; }
        public string Address1_ShippingMethodCodeName { get; set; }
        public string PaymentTermsCodeName { get; set; }
        public string GenderCodeName { get; set; }
        public string Address2_FreightTermsCodeName { get; set; }
        public string FamilyStatusCodeName { get; set; }
        public string CustomerSizeCodeName { get; set; }
        public string ShippingMethodCodeName { get; set; }
        public string Address1_FreightTermsCodeName { get; set; }
        public string LeadSourceCodeName { get; set; }
        public string EducationCodeName { get; set; }
        public string Address2_ShippingMethodCodeName { get; set; }
        public string PreferredSystemUserId { get; set; }
        public string PreferredServiceId { get; set; }
        public string MasterId { get; set; }
        public string PreferredAppointmentDayCode { get; set; }
        public string PreferredAppointmentTimeCode { get; set; }
        public bool? DoNotSendMM { get; set; }
        public string ParentCustomerId { get; set; }
        public bool? Merged { get; set; }
        public string ExternalUserIdentifier { get; set; }
        public Guid? SubscriptionId { get; set; }
        public string PreferredEquipmentId { get; set; }
        public DateTimeOffset? LastUsedInCampaign { get; set; }
        public string MasterContactIdName { get; set; }
        public string PreferredSystemUserIdName { get; set; }
        public string MergedName { get; set; }
        public string PreferredAppointmentTimeCodeName { get; set; }
        public string PreferredEquipmentIdName { get; set; }
        public string ParentCustomerIdName { get; set; }
        public string PreferredAppointmentDayCodeName { get; set; }
        public string PreferredServiceIdName { get; set; }
        public string ParentCustomerIdType { get; set; }
        public string DoNotSendMarketingMaterialName { get; set; }
        public string TransactionCurrencyId { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public decimal? ExchangeRate { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public string AnnualIncome_Base { get; set; }
        public string CreditLimit_Base { get; set; }
        public string Aging60_Base { get; set; }
        public string Aging90_Base { get; set; }
        public string Aging30_Base { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string OriginatingLeadIdYomiName { get; set; }
        public string ParentCustomerIdYomiName { get; set; }
        public string PreferredSystemUserIdYomiName { get; set; }
        public string OwnerIdYomiName { get; set; }
        public string MasterContactIdYomiName { get; set; }
        public string AccountIdYomiName { get; set; }
        public string CreatedByYomiName { get; set; }
        public string ParentContactIdYomiName { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string OwningTeam { get; set; }
        public bool? IsAutoCreate { get; set; }
        public string EntityImage { get; set; }
        public Guid? StageId { get; set; }
        public Guid? ProcessId { get; set; }
        public string Address2_Composite { get; set; }
        public string Address1_Composite { get; set; }
        public Guid? EntityImageId { get; set; }
        public string EntityImage_URL { get; set; }
        public int? EntityImage_Timestamp { get; set; }
        public string TraversedPath { get; set; }
        public string SLAId { get; set; }
        public string SLAName { get; set; }
        public string SLAInvokedId { get; set; }
        public long? OnHoldTime { get; set; }
        public DateTimeOffset? LastOnHoldTime { get; set; }
        public string SLAInvokedIdName { get; set; }
        public bool? FollowEmail { get; set; }
        public string FollowEmailName { get; set; }
        public string TimeSpentByMeOnEmailAndMeetings { get; set; }
        public string Address3_Country { get; set; }
        public string Address3_Line1 { get; set; }
        public string Address3_Line2 { get; set; }
        public string Address3_Line3 { get; set; }
        public string Address3_PostalCode { get; set; }
        public string Address3_PostOfficeBox { get; set; }
        public string Address3_StateOrProvince { get; set; }
        public string Address3_City { get; set; }
        public string Business2 { get; set; }
        public string Callback { get; set; }
        public string Company { get; set; }
        public string Home2 { get; set; }
        public Guid? Address3_AddressId { get; set; }
        public string Address3_AddressTypeCodeName { get; set; }
        public string Address3_Composite { get; set; }
        public string Address3_Fax { get; set; }
        public string Address3_FreightTermsCode { get; set; }
        public string Address3_FreightTermsCodeName { get; set; }
        public double? Address3_Latitude { get; set; }
        public double? Address3_Longitude { get; set; }
        public string Address3_Name { get; set; }
        public string Address3_PrimaryContactName { get; set; }
        public string Address3_ShippingMethodCode { get; set; }
        public string Address3_ShippingMethodCodeName { get; set; }
        public string Address3_Telephone1 { get; set; }
        public string Address3_Telephone2 { get; set; }
        public string Address3_Telephone3 { get; set; }
        public string Address3_UPSZone { get; set; }
        public long? Address3_UTCOffset { get; set; }
        public string Address3_County { get; set; }
        public string Address3_AddressTypeCode { get; set; }
        public string CreatedByExternalParty { get; set; }
        public string CreatedByExternalPartyName { get; set; }
        public string CreatedByExternalPartyYomiName { get; set; }
        public string ModifiedByExternalParty { get; set; }
        public string ModifiedByExternalPartyName { get; set; }
        public string ModifiedByExternalPartyYomiName { get; set; }
        public bool? MarketingOnly { get; set; }
        public string MarketingOnlyName { get; set; }
        public long? TeamsFollowed { get; set; }
        public string BusinessCard { get; set; }
        public string BusinessCardAttributes { get; set; }

    }
}

