using System;
using System.Data;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Dynamics365.Core.Models
{
    public class CustomerAddress : DynamicsModel
    {

        public CustomerAddress() { }

        public CustomerAddress(IDataReader reader) : base(reader)
        {
            ParentId = GetStringValue("ParentId");
            CustomerAddressId = GetValue<Guid>("CustomerAddressId");
            AddressNumber = GetValue<long>("AddressNumber");
            ObjectTypeCode = GetStringValue("ObjectTypeCode");
            AddressTypeCode = GetStringValue("AddressTypeCode");
            Name = GetStringValue("Name");
            PrimaryContactName = GetStringValue("PrimaryContactName");
            Line1 = GetStringValue("Line1");
            Line2 = GetStringValue("Line2");
            Line3 = GetStringValue("Line3");
            City = GetStringValue("City");
            StateOrProvince = GetStringValue("StateOrProvince");
            County = GetStringValue("County");
            Country = GetStringValue("Country");
            PostOfficeBox = GetStringValue("PostOfficeBox");
            PostalCode = GetStringValue("PostalCode");
            UTCOffset = GetValue<long>("UTCOffset");
            FreightTermsCode = GetStringValue("FreightTermsCode");
            UPSZone = GetStringValue("UPSZone");
            Latitude = GetValue<double>("Latitude");
            Telephone1 = GetStringValue("Telephone1");
            Longitude = GetValue<double>("Longitude");
            ShippingMethodCode = GetStringValue("ShippingMethodCode");
            Telephone2 = GetStringValue("Telephone2");
            Telephone3 = GetStringValue("Telephone3");
            Fax = GetStringValue("Fax");
            VersionNumber = GetValue<long>("VersionNumber");
            CreatedBy = GetStringValue("CreatedBy");
            CreatedOn = GetValue<DateTimeOffset>("CreatedOn");
            ModifiedBy = GetStringValue("ModifiedBy");
            ModifiedOn = GetValue<DateTimeOffset>("ModifiedOn");
            CreatedByName = GetStringValue("CreatedByName");
            ModifiedByName = GetStringValue("ModifiedByName");
            ShippingMethodCodeName = GetStringValue("ShippingMethodCodeName");
            FreightTermsCodeName = GetStringValue("FreightTermsCodeName");
            AddressTypeCodeName = GetStringValue("AddressTypeCodeName");
            ObjectTypeCodeName = GetStringValue("ObjectTypeCodeName");
            OwningBusinessUnit = GetStringValue("OwningBusinessUnit");
            OwningUser = GetStringValue("OwningUser");
            TimeZoneRuleVersionNumber = GetValue<long>("TimeZoneRuleVersionNumber");
            OverriddenCreatedOn = GetValue<DateTimeOffset>("OverriddenCreatedOn");
            UTCConversionTimeZoneCode = GetValue<long>("UTCConversionTimeZoneCode");
            ImportSequenceNumber = GetValue<long>("ImportSequenceNumber");
            CreatedByYomiName = GetStringValue("CreatedByYomiName");
            ModifiedByYomiName = GetStringValue("ModifiedByYomiName");
            OwnerIdType = GetStringValue("OwnerIdType");
            OwnerId = GetStringValue("OwnerId");
            ParentIdTypeCode = GetStringValue("ParentIdTypeCode");
            CreatedOnBehalfBy = GetStringValue("CreatedOnBehalfBy");
            CreatedOnBehalfByName = GetStringValue("CreatedOnBehalfByName");
            CreatedOnBehalfByYomiName = GetStringValue("CreatedOnBehalfByYomiName");
            ModifiedOnBehalfBy = GetStringValue("ModifiedOnBehalfBy");
            ModifiedOnBehalfByName = GetStringValue("ModifiedOnBehalfByName");
            ModifiedOnBehalfByYomiName = GetStringValue("ModifiedOnBehalfByYomiName");
            TransactionCurrencyId = GetStringValue("TransactionCurrencyId");
            TransactionCurrencyIdName = GetStringValue("TransactionCurrencyIdName");
            ExchangeRate = GetValue<decimal>("ExchangeRate");
            Composite = GetStringValue("Composite");

            AddCustomMappings();
        }
        public string ParentId { get; set; }
        public Guid? CustomerAddressId { get; set; }
        public long? AddressNumber { get; set; }
        public string ObjectTypeCode { get; set; }
        public string AddressTypeCode { get; set; }
        public string Name { get; set; }
        public string PrimaryContactName { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostOfficeBox { get; set; }
        public string PostalCode { get; set; }
        public long? UTCOffset { get; set; }
        public string FreightTermsCode { get; set; }
        public string UPSZone { get; set; }
        public double? Latitude { get; set; }
        public string Telephone1 { get; set; }
        public double? Longitude { get; set; }
        public string ShippingMethodCode { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
        public string Fax { get; set; }
        public long VersionNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public string ShippingMethodCodeName { get; set; }
        public string FreightTermsCodeName { get; set; }
        public string AddressTypeCodeName { get; set; }
        public string ObjectTypeCodeName { get; set; }
        public string OwningBusinessUnit { get; set; }
        public string OwningUser { get; set; }
        public long? TimeZoneRuleVersionNumber { get; set; }
        public DateTimeOffset? OverriddenCreatedOn { get; set; }
        public long? UTCConversionTimeZoneCode { get; set; }
        public long? ImportSequenceNumber { get; set; }
        public string CreatedByYomiName { get; set; }
        public string ModifiedByYomiName { get; set; }
        public string OwnerIdType { get; set; }
        public string OwnerId { get; set; }
        public string ParentIdTypeCode { get; set; }
        public string CreatedOnBehalfBy { get; set; }
        public string CreatedOnBehalfByName { get; set; }
        public string CreatedOnBehalfByYomiName { get; set; }
        public string ModifiedOnBehalfBy { get; set; }
        public string ModifiedOnBehalfByName { get; set; }
        public string ModifiedOnBehalfByYomiName { get; set; }
        public string TransactionCurrencyId { get; set; }
        public string TransactionCurrencyIdName { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string Composite { get; set; }

    }
}

