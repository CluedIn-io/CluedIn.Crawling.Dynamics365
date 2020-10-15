using System;
using System.Linq;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Dynamics365.Core.Models;
using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{
    public class AccountClueProducer : BaseClueProducer<Account>
    {
        private readonly IClueFactory _factory;

        public AccountClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(Account input, Guid id)
        {
            var clue = _factory.Create(EntityType.Organization, input.Accountid, id);

            var data = clue.Data.EntityData;

            // Metadata

            if (!string.IsNullOrWhiteSpace(input.Name))
                data.Name = input.Name;

            if (!string.IsNullOrWhiteSpace(input.Description))
                data.Description = input.Description;

            DateTimeOffset.TryParse(input.Createdon, out var createdDate);
            if (createdDate != null)
                data.CreatedDate = createdDate;

            DateTimeOffset.TryParse(input.Modifiedon, out var modifiedDate);
            if (modifiedDate != null)
                data.ModifiedDate = modifiedDate;

            data.Codes.Add(new EntityCode(EntityType.Account, "Dynamics365", input.Accountnumber));

            // Aliases

            if (!string.IsNullOrEmpty(input.Address1Composite))
                data.Aliases.Add(input.Address1Composite);

            if (!string.IsNullOrEmpty(input.Address1Telephone1))
                data.Aliases.Add(input.Address1Telephone1);

            if (!string.IsNullOrEmpty(input.Address1Telephone2))
                data.Aliases.Add(input.Address1Telephone2);

            if (!string.IsNullOrEmpty(input.Address1Telephone3))
                data.Aliases.Add(input.Address1Telephone3);

            if (!string.IsNullOrEmpty(input.Address2Composite))
                data.Aliases.Add(input.Address2Composite);

            if (!string.IsNullOrEmpty(input.Address2Telephone1))
                data.Aliases.Add(input.Address2Telephone1);

            if (!string.IsNullOrEmpty(input.Address2Telephone2))
                data.Aliases.Add(input.Address2Telephone2);

            if (!string.IsNullOrEmpty(input.Address2Telephone3))
                data.Aliases.Add(input.Address2Telephone3);

            if (!string.IsNullOrEmpty(input.Businesstypecode))
                data.Aliases.Add(input.Businesstypecode);

            if (!string.IsNullOrEmpty(input.Emailaddress1))
                data.Aliases.Add(input.Emailaddress1);

            if (!string.IsNullOrEmpty(input.Emailaddress2))
                data.Aliases.Add(input.Emailaddress2);

            if (!string.IsNullOrEmpty(input.Emailaddress3))
                data.Aliases.Add(input.Emailaddress3);

            if (!string.IsNullOrEmpty(input.Telephone1))
                data.Aliases.Add(input.Telephone1);

            if (!string.IsNullOrEmpty(input.Telephone2))
                data.Aliases.Add(input.Telephone2);

            if (!string.IsNullOrEmpty(input.Telephone3))
                data.Aliases.Add(input.Telephone3);

            // Edges

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.CreatedBy, input, input.Createdby.ToString());

            if (input.DynaAccountid != null && !string.IsNullOrEmpty(input.DynaAccountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Account, EntityEdgeType.AttachedTo, input, input.DynaAccountid.ToString());

            if (input.DynaLandid != null && !string.IsNullOrEmpty(input.DynaLandid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Geography, EntityEdgeType.LocatedIn, input, input.DynaLandid.ToString());

            if (input.Masterid != null && !string.IsNullOrEmpty(input.Masterid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.PartOf, input, input.Masterid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.ModifiedBy, input, input.Modifiedby.ToString());

            if (input.Originatingleadid != null && !string.IsNullOrEmpty(input.Originatingleadid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.AttachedTo, input, input.Originatingleadid.ToString());

            if (input.Parentaccountid != null && !string.IsNullOrEmpty(input.Parentaccountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Account, EntityEdgeType.PartOf, input.Parentaccountid, input.Parentaccountid.ToString());

            if (input.Preferredsystemuserid != null && !string.IsNullOrEmpty(input.Preferredsystemuserid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Preferredsystemuserid, input.Preferredsystemuserid.ToString());

            if (input.Primarycontactid != null && !string.IsNullOrEmpty(input.Primarycontactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.Primarycontactid, input.Primarycontactid.ToString());

            if (input.Slaid != null && !string.IsNullOrEmpty(input.Slaid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.UsedBy, input.Slaid, input.Slaid.ToString());

            if (input.Slainvokedid != null && !string.IsNullOrEmpty(input.Slainvokedid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.UsedBy, input.Slainvokedid, input.Slainvokedid.ToString());

            if (input.Territoryid != null && !string.IsNullOrEmpty(input.Territoryid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Geography.Territory, EntityEdgeType.LocatedIn, input.Territoryid, input.Territoryid.ToString());

            //if (input.Defaultpricelevelid != null && !string.IsNullOrEmpty(input.Defaultpricelevelid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Defaultpricelevelid, input.Defaultpricelevelid.ToString());

            //if (input.DynaNavid != null && !string.IsNullOrEmpty(input.DynaNavid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaNavid, input.DynaNavid.ToString());

            //if (input.DynaNavtemplateid != null && !string.IsNullOrEmpty(input.DynaNavtemplateid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaNavtemplateid, input.DynaNavtemplateid.ToString());

            //if (input.DynaOldid != null && !string.IsNullOrEmpty(input.DynaOldid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaOldid, input.DynaOldid.ToString());

            //if (input.Entityimageid != null && !string.IsNullOrEmpty(input.Entityimageid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Entityimageid, input.Entityimageid.ToString());

            //if (input.NnTdcid != null && !string.IsNullOrEmpty(input.NnTdcid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.NnTdcid, input.NnTdcid.ToString());

            //if (input.Preferredserviceid != null && !string.IsNullOrEmpty(input.Preferredserviceid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Preferredserviceid, input.Preferredserviceid.ToString());

            //if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType.Uknown, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            var vocab = new AccountVocabulary();

            data.Properties[vocab.Accountcategorycode] = input.Accountcategorycode.PrintIfAvailable();
            data.Properties[vocab.Accountclassificationcode] = input.Accountclassificationcode.PrintIfAvailable();
            data.Properties[vocab.Accountid] = input.Accountid.PrintIfAvailable();
            data.Properties[vocab.Accountnumber] = input.Accountnumber.PrintIfAvailable();
            data.Properties[vocab.Accountratingcode] = input.Accountratingcode.PrintIfAvailable();
            data.Properties[vocab.Address1Addresstypecode] = input.Address1Addresstypecode.PrintIfAvailable();
            data.Properties[vocab.Address1City] = input.Address1City.PrintIfAvailable();
            data.Properties[vocab.Address1Composite] = input.Address1Composite.PrintIfAvailable();
            data.Properties[vocab.Address1Country] = input.Address1Country.PrintIfAvailable();
            data.Properties[vocab.Address1County] = input.Address1County.PrintIfAvailable();
            data.Properties[vocab.Address1Fax] = input.Address1Fax.PrintIfAvailable();
            data.Properties[vocab.Address1Freighttermscode] = input.Address1Freighttermscode.PrintIfAvailable();
            data.Properties[vocab.Address1Latitude] = input.Address1Latitude.PrintIfAvailable();
            data.Properties[vocab.Address1Line1] = input.Address1Line1.PrintIfAvailable();
            data.Properties[vocab.Address1Line2] = input.Address1Line2.PrintIfAvailable();
            data.Properties[vocab.Address1Line3] = input.Address1Line3.PrintIfAvailable();
            data.Properties[vocab.Address1Longitude] = input.Address1Longitude.PrintIfAvailable();
            data.Properties[vocab.Address1Name] = input.Address1Name.PrintIfAvailable();
            data.Properties[vocab.Address1Postalcode] = input.Address1Postalcode.PrintIfAvailable();
            data.Properties[vocab.Address1Postofficebox] = input.Address1Postofficebox.PrintIfAvailable();
            data.Properties[vocab.Address1Primarycontactname] = input.Address1Primarycontactname.PrintIfAvailable();
            data.Properties[vocab.Address1Shippingmethodcode] = input.Address1Shippingmethodcode.PrintIfAvailable();
            data.Properties[vocab.Address1Stateorprovince] = input.Address1Stateorprovince.PrintIfAvailable();
            data.Properties[vocab.Address1Telephone1] = input.Address1Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address1Telephone2] = input.Address1Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address1Telephone3] = input.Address1Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address1Upszone] = input.Address1Upszone.PrintIfAvailable();
            data.Properties[vocab.Address2Addresstypecode] = input.Address2Addresstypecode.PrintIfAvailable();
            data.Properties[vocab.Address2City] = input.Address2City.PrintIfAvailable();
            data.Properties[vocab.Address2Composite] = input.Address2Composite.PrintIfAvailable();
            data.Properties[vocab.Address2Country] = input.Address2Country.PrintIfAvailable();
            data.Properties[vocab.Address2County] = input.Address2County.PrintIfAvailable();
            data.Properties[vocab.Address2Fax] = input.Address2Fax.PrintIfAvailable();
            data.Properties[vocab.Address2Freighttermscode] = input.Address2Freighttermscode.PrintIfAvailable();
            data.Properties[vocab.Address2Latitude] = input.Address2Latitude.PrintIfAvailable();
            data.Properties[vocab.Address2Line1] = input.Address2Line1.PrintIfAvailable();
            data.Properties[vocab.Address2Line2] = input.Address2Line2.PrintIfAvailable();
            data.Properties[vocab.Address2Line3] = input.Address2Line3.PrintIfAvailable();
            data.Properties[vocab.Address2Longitude] = input.Address2Longitude.PrintIfAvailable();
            data.Properties[vocab.Address2Name] = input.Address2Name.PrintIfAvailable();
            data.Properties[vocab.Address2Postalcode] = input.Address2Postalcode.PrintIfAvailable();
            data.Properties[vocab.Address2Postofficebox] = input.Address2Postofficebox.PrintIfAvailable();
            data.Properties[vocab.Address2Primarycontactname] = input.Address2Primarycontactname.PrintIfAvailable();
            data.Properties[vocab.Address2Shippingmethodcode] = input.Address2Shippingmethodcode.PrintIfAvailable();
            data.Properties[vocab.Address2Stateorprovince] = input.Address2Stateorprovince.PrintIfAvailable();
            data.Properties[vocab.Address2Telephone1] = input.Address2Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address2Telephone2] = input.Address2Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address2Telephone3] = input.Address2Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address2Upszone] = input.Address2Upszone.PrintIfAvailable();
            data.Properties[vocab.Aging30] = input.Aging30.PrintIfAvailable();
            data.Properties[vocab.Aging30Base] = input.Aging30Base.PrintIfAvailable();
            data.Properties[vocab.Aging60] = input.Aging60.PrintIfAvailable();
            data.Properties[vocab.Aging60Base] = input.Aging60Base.PrintIfAvailable();
            data.Properties[vocab.Aging90] = input.Aging90.PrintIfAvailable();
            data.Properties[vocab.Aging90Base] = input.Aging90Base.PrintIfAvailable();
            data.Properties[vocab.Businesstypecode] = input.Businesstypecode.PrintIfAvailable();
            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdbyexternalparty] = input.Createdbyexternalparty.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.Creditlimit] = input.Creditlimit.PrintIfAvailable();
            data.Properties[vocab.CreditlimitBase] = input.CreditlimitBase.PrintIfAvailable();
            data.Properties[vocab.Creditonhold] = input.Creditonhold.PrintIfAvailable();
            data.Properties[vocab.Customersizecode] = input.Customersizecode.PrintIfAvailable();
            data.Properties[vocab.Defaultpricelevelid] = input.Defaultpricelevelid.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.Donotbulkemail] = input.Donotbulkemail.PrintIfAvailable();
            data.Properties[vocab.Donotbulkpostalmail] = input.Donotbulkpostalmail.PrintIfAvailable();
            data.Properties[vocab.Donotemail] = input.Donotemail.PrintIfAvailable();
            data.Properties[vocab.Donotfax] = input.Donotfax.PrintIfAvailable();
            data.Properties[vocab.Donotphone] = input.Donotphone.PrintIfAvailable();
            data.Properties[vocab.Donotpostalmail] = input.Donotpostalmail.PrintIfAvailable();
            data.Properties[vocab.Donotsendmm] = input.Donotsendmm.PrintIfAvailable();
            data.Properties[vocab.DynaAccountid] = input.DynaAccountid.PrintIfAvailable();
            data.Properties[vocab.DynaBlokerNedarvAfAdresseOplysninger] = input.DynaBlokerNedarvAfAdresseOplysninger.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomer] = input.DynaCoursecustomer.PrintIfAvailable();
            data.Properties[vocab.DynaCvrp] = input.DynaCvrp.PrintIfAvailable();
            data.Properties[vocab.DynaCvrse] = input.DynaCvrse.PrintIfAvailable();
            data.Properties[vocab.DynaCvrstatus] = input.DynaCvrstatus.PrintIfAvailable();
            data.Properties[vocab.DynaCvrstatuskode] = input.DynaCvrstatuskode.PrintIfAvailable();
            data.Properties[vocab.DynaDaarligbetaler] = input.DynaDaarligbetaler.PrintIfAvailable();
            data.Properties[vocab.DynaDebitor] = input.DynaDebitor.PrintIfAvailable();
            data.Properties[vocab.DynaDebitorunderoprettelse] = input.DynaDebitorunderoprettelse.PrintIfAvailable();
            data.Properties[vocab.DynaEannummer] = input.DynaEannummer.PrintIfAvailable();
            data.Properties[vocab.DynaEanpkrvet] = input.DynaEanpkrvet.PrintIfAvailable();
            data.Properties[vocab.DynaEtableringsaar] = input.DynaEtableringsaar.PrintIfAvailable();
            data.Properties[vocab.DynaFaktureringsemail] = input.DynaFaktureringsemail.PrintIfAvailable();
            data.Properties[vocab.DynaGodkendtinav] = input.DynaGodkendtinav.PrintIfAvailable();
            data.Properties[vocab.DynaHovedselskab] = input.DynaHovedselskab.PrintIfAvailable();
            data.Properties[vocab.DynaKobteydelser] = input.DynaKobteydelser.PrintIfAvailable();
            data.Properties[vocab.DynaKobteydelserBase] = input.DynaKobteydelserBase.PrintIfAvailable();
            data.Properties[vocab.DynaKobteydelserDate] = input.DynaKobteydelserDate.PrintIfAvailable();
            data.Properties[vocab.DynaKobteydelserState] = input.DynaKobteydelserState.PrintIfAvailable();
            data.Properties[vocab.DynaKoncernomstaening] = input.DynaKoncernomstaening.PrintIfAvailable();
            data.Properties[vocab.DynaLandid] = input.DynaLandid.PrintIfAvailable();
            data.Properties[vocab.DynaModerselskab] = input.DynaModerselskab.PrintIfAvailable();
            data.Properties[vocab.DynaNavid] = input.DynaNavid.PrintIfAvailable();
            data.Properties[vocab.DynaNavtemplateid] = input.DynaNavtemplateid.PrintIfAvailable();
            data.Properties[vocab.DynaNumberofemployeesbranch] = input.DynaNumberofemployeesbranch.PrintIfAvailable();
            data.Properties[vocab.DynaOldid] = input.DynaOldid.PrintIfAvailable();
            data.Properties[vocab.DynaOprettelsesmailsendt] = input.DynaOprettelsesmailsendt.PrintIfAvailable();
            data.Properties[vocab.DynaPopkrvet] = input.DynaPopkrvet.PrintIfAvailable();
            data.Properties[vocab.DynaRammeaftale] = input.DynaRammeaftale.PrintIfAvailable();
            data.Properties[vocab.DynaRammeslutdato] = input.DynaRammeslutdato.PrintIfAvailable();
            data.Properties[vocab.DynaRammestartdato] = input.DynaRammestartdato.PrintIfAvailable();
            data.Properties[vocab.DynaSegmentKundeaktivitet] = input.DynaSegmentKundeaktivitet.PrintIfAvailable();
            data.Properties[vocab.DynaSegmentKundestatus] = input.DynaSegmentKundestatus.PrintIfAvailable();
            data.Properties[vocab.DynaSegmentVirksomhedsstoerrelse] = input.DynaSegmentVirksomhedsstoerrelse.PrintIfAvailable();
            data.Properties[vocab.DynaTotalamount] = input.DynaTotalamount.PrintIfAvailable();
            data.Properties[vocab.DynaUpdatetricker] = input.DynaUpdatetricker.PrintIfAvailable();
            data.Properties[vocab.DynaVirksomhedsform] = input.DynaVirksomhedsform.PrintIfAvailable();
            data.Properties[vocab.Emailaddress1] = input.Emailaddress1.PrintIfAvailable();
            data.Properties[vocab.Emailaddress2] = input.Emailaddress2.PrintIfAvailable();
            data.Properties[vocab.Emailaddress3] = input.Emailaddress3.PrintIfAvailable();
            data.Properties[vocab.Entityimage] = input.Entityimage.PrintIfAvailable();
            data.Properties[vocab.Entityimageid] = input.Entityimageid.PrintIfAvailable();
            data.Properties[vocab.Exchangerate] = input.Exchangerate.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.Followemail] = input.Followemail.PrintIfAvailable();
            data.Properties[vocab.Ftpsiteurl] = input.Ftpsiteurl.PrintIfAvailable();
            data.Properties[vocab.Industrycode] = input.Industrycode.PrintIfAvailable();
            data.Properties[vocab.Lastonholdtime] = input.Lastonholdtime.PrintIfAvailable();
            data.Properties[vocab.Lastusedincampaign] = input.Lastusedincampaign.PrintIfAvailable();
            data.Properties[vocab.Marketcap] = input.Marketcap.PrintIfAvailable();
            data.Properties[vocab.MarketcapBase] = input.MarketcapBase.PrintIfAvailable();
            data.Properties[vocab.Marketingonly] = input.Marketingonly.PrintIfAvailable();
            data.Properties[vocab.Masterid] = input.Masterid.PrintIfAvailable();
            data.Properties[vocab.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedbyexternalparty] = input.Modifiedbyexternalparty.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.Name] = input.Name.PrintIfAvailable();
            data.Properties[vocab.NewCompanysize] = input.NewCompanysize.PrintIfAvailable();
            data.Properties[vocab.NnLastupdated] = input.NnLastupdated.PrintIfAvailable();
            data.Properties[vocab.NnLinks] = input.NnLinks.PrintIfAvailable();
            data.Properties[vocab.NnPrimarytradecode] = input.NnPrimarytradecode.PrintIfAvailable();
            data.Properties[vocab.NnPrimarytradecodeno] = input.NnPrimarytradecodeno.PrintIfAvailable();
            data.Properties[vocab.NnTdcid] = input.NnTdcid.PrintIfAvailable();
            data.Properties[vocab.NnUpdateprotected] = input.NnUpdateprotected.PrintIfAvailable();
            data.Properties[vocab.Numberofemployees] = input.Numberofemployees.PrintIfAvailable();
            data.Properties[vocab.Onholdtime] = input.Onholdtime.PrintIfAvailable();
            data.Properties[vocab.Opendeals] = input.Opendeals.PrintIfAvailable();
            data.Properties[vocab.OpendealsDate] = input.OpendealsDate.PrintIfAvailable();
            data.Properties[vocab.OpendealsState] = input.OpendealsState.PrintIfAvailable();
            data.Properties[vocab.Openrevenue] = input.Openrevenue.PrintIfAvailable();
            data.Properties[vocab.OpenrevenueBase] = input.OpenrevenueBase.PrintIfAvailable();
            data.Properties[vocab.OpenrevenueDate] = input.OpenrevenueDate.PrintIfAvailable();
            data.Properties[vocab.OpenrevenueState] = input.OpenrevenueState.PrintIfAvailable();
            data.Properties[vocab.Originatingleadid] = input.Originatingleadid.PrintIfAvailable();
            data.Properties[vocab.Parentaccountid] = input.Parentaccountid.PrintIfAvailable();
            data.Properties[vocab.Participatesinworkflow] = input.Participatesinworkflow.PrintIfAvailable();
            data.Properties[vocab.Paymenttermscode] = input.Paymenttermscode.PrintIfAvailable();
            data.Properties[vocab.Preferredappointmentdaycode] = input.Preferredappointmentdaycode.PrintIfAvailable();
            data.Properties[vocab.Preferredappointmenttimecode] = input.Preferredappointmenttimecode.PrintIfAvailable();
            data.Properties[vocab.Preferredcontactmethodcode] = input.Preferredcontactmethodcode.PrintIfAvailable();
            data.Properties[vocab.Preferredserviceid] = input.Preferredserviceid.PrintIfAvailable();
            data.Properties[vocab.Preferredsystemuserid] = input.Preferredsystemuserid.PrintIfAvailable();
            data.Properties[vocab.Primarycontactid] = input.Primarycontactid.PrintIfAvailable();
            data.Properties[vocab.Primarysatoriid] = input.Primarysatoriid.PrintIfAvailable();
            data.Properties[vocab.Primarytwitterid] = input.Primarytwitterid.PrintIfAvailable();
            data.Properties[vocab.Processid] = input.Processid.PrintIfAvailable();
            data.Properties[vocab.Revenue] = input.Revenue.PrintIfAvailable();
            data.Properties[vocab.RevenueBase] = input.RevenueBase.PrintIfAvailable();
            data.Properties[vocab.Sharesoutstanding] = input.Sharesoutstanding.PrintIfAvailable();
            data.Properties[vocab.Shippingmethodcode] = input.Shippingmethodcode.PrintIfAvailable();
            data.Properties[vocab.Sic] = input.Sic.PrintIfAvailable();
            data.Properties[vocab.Slaid] = input.Slaid.PrintIfAvailable();
            data.Properties[vocab.Slainvokedid] = input.Slainvokedid.PrintIfAvailable();
            data.Properties[vocab.Stageid] = input.Stageid.PrintIfAvailable();
            data.Properties[vocab.Statecode] = input.Statecode.PrintIfAvailable();
            data.Properties[vocab.Statuscode] = input.Statuscode.PrintIfAvailable();
            data.Properties[vocab.Stockexchange] = input.Stockexchange.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[vocab.Territorycode] = input.Territorycode.PrintIfAvailable();
            data.Properties[vocab.Territoryid] = input.Territoryid.PrintIfAvailable();
            data.Properties[vocab.Tickersymbol] = input.Tickersymbol.PrintIfAvailable();
            data.Properties[vocab.Timespentbymeonemailandmeetings] = input.Timespentbymeonemailandmeetings.PrintIfAvailable();
            data.Properties[vocab.Transactioncurrencyid] = input.Transactioncurrencyid.PrintIfAvailable();
            data.Properties[vocab.Traversedpath] = input.Traversedpath.PrintIfAvailable();
            data.Properties[vocab.Websiteurl] = input.Websiteurl.PrintIfAvailable();

            clue.ValidationRuleSuppressions.AddRange(new[]
                        {
                RuleConstants.METADATA_001_Name_MustBeSet,
                RuleConstants.PROPERTIES_001_MustExist,
                RuleConstants.METADATA_002_Uri_MustBeSet,
                RuleConstants.METADATA_003_Author_Name_MustBeSet,
                RuleConstants.METADATA_005_PreviewImage_RawData_MustBeSet
            });

            return clue;
        }
    }
}


