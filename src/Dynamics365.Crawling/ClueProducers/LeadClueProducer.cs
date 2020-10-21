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
    public class LeadClueProducer : BaseClueProducer<Lead>
    {
        private readonly IClueFactory _factory;

        public LeadClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(Lead input, Guid id)
        {
            var clue = _factory.Create(EntityType.Sales.Lead, input.Leadid, id);

            var data = clue.Data.EntityData;

            // Metadata

            if (!string.IsNullOrWhiteSpace(input.Fullname))
                data.Name = input.Fullname;
            else if (!string.IsNullOrWhiteSpace(input.Firstname) && !string.IsNullOrWhiteSpace(input.Lastname))
                data.Name = $"{input.Firstname} {input.Lastname}";

            if (!string.IsNullOrWhiteSpace(input.Description))
                data.Description = input.Description;

            DateTimeOffset.TryParse(input.Createdon, out var createdDate);
            if (createdDate != null)
                data.CreatedDate = createdDate;

            DateTimeOffset.TryParse(input.Modifiedon, out var modifiedDate);
            if (modifiedDate != null)
                data.ModifiedDate = modifiedDate;

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

            if (!string.IsNullOrEmpty(input.Companyname))
                data.Aliases.Add(input.Companyname);

            if (!string.IsNullOrEmpty(input.Emailaddress1))
                data.Aliases.Add(input.Emailaddress1);

            if (!string.IsNullOrEmpty(input.Emailaddress2))
                data.Aliases.Add(input.Emailaddress2);

            if (!string.IsNullOrEmpty(input.Emailaddress3))
                data.Aliases.Add(input.Emailaddress3);

            if (!string.IsNullOrEmpty(input.Leadsourcecode))
                data.Aliases.Add(input.Leadsourcecode);

            if (!string.IsNullOrEmpty(input.Telephone1))
                data.Aliases.Add(input.Telephone1);

            if (!string.IsNullOrEmpty(input.Telephone2))
                data.Aliases.Add(input.Telephone2);

            if (!string.IsNullOrEmpty(input.Telephone3))
                data.Aliases.Add(input.Telephone3);

            // Edges

            if (input.Accountid != null && !string.IsNullOrEmpty(input.Accountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Account, EntityEdgeType.AttachedTo, input.Accountid, input.Accountid.ToString());

            if (input.Campaignid != null && !string.IsNullOrEmpty(input.Campaignid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Marketing.Campaign, EntityEdgeType.AttachedTo, input.Campaignid, input.Campaignid.ToString());

            if (input.Contactid != null && !string.IsNullOrEmpty(input.Contactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.Contactid, input.Contactid.ToString());

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.Customerid != null && !string.IsNullOrEmpty(input.Customerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.Customerid, input.Customerid.ToString());

            if (input.Entityimageid != null && !string.IsNullOrEmpty(input.Entityimageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Images.Image, EntityEdgeType.AttachedTo, input.Entityimageid, input.Entityimageid.ToString());

            if (input.Leadid != null && !string.IsNullOrEmpty(input.Leadid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.AttachedTo, input.Leadid, input.Leadid.ToString());

            if (input.Masterid != null && !string.IsNullOrEmpty(input.Masterid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Lead, EntityEdgeType.AttachedTo, input.Masterid, input.Masterid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Infrastructure.User, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            //if (input.NnTdcid != null && !string.IsNullOrEmpty(input.NnTdcid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.NnTdcid, input.NnTdcid.ToString());

            //if (input.Originatingcaseid != null && !string.IsNullOrEmpty(input.Originatingcaseid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.Originatingcaseid, input.Originatingcaseid.ToString());

            if (input.Parentaccountid != null && !string.IsNullOrEmpty(input.Parentaccountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Account, EntityEdgeType.AttachedTo, input.Parentaccountid, input.Parentaccountid.ToString());

            if (input.Parentcontactid != null && !string.IsNullOrEmpty(input.Parentcontactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.AttachedTo, input.Parentcontactid, input.Parentcontactid.ToString());

            if (input.Processid != null && !string.IsNullOrEmpty(input.Processid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Process, EntityEdgeType.AttachedTo, input.Processid, input.Processid.ToString());

            //if (input.Qualifyingopportunityid != null && !string.IsNullOrEmpty(input.Qualifyingopportunityid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.Qualifyingopportunityid, input.Qualifyingopportunityid.ToString());

            //if (input.Relatedobjectid != null && !string.IsNullOrEmpty(input.Relatedobjectid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.Relatedobjectid, input.Relatedobjectid.ToString());

            if (input.Slaid != null && !string.IsNullOrEmpty(input.Slaid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.AttachedTo, input.Slaid, input.Slaid.ToString());

            if (input.Slainvokedid != null && !string.IsNullOrEmpty(input.Slainvokedid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Sales.Deal, EntityEdgeType.AttachedTo, input.Slainvokedid, input.Slainvokedid.ToString());

            if (input.Stageid != null && !string.IsNullOrEmpty(input.Stageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.ProcessStage, EntityEdgeType.AttachedTo, input.Stageid, input.Stageid.ToString());

            //if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
            //    _factory.CreateOutgoingEntityReference(clue, EntityType, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());

            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);

            var vocab = new LeadVocabulary();

            data.Properties[vocab.Accountid] = input.Accountid.PrintIfAvailable();
            data.Properties[vocab.Address1Addresstypecode] = input.Address1Addresstypecode.PrintIfAvailable();
            data.Properties[vocab.Address1City] = input.Address1City.PrintIfAvailable();
            data.Properties[vocab.Address1Composite] = input.Address1Composite.PrintIfAvailable();
            data.Properties[vocab.Address1Country] = input.Address1Country.PrintIfAvailable();
            data.Properties[vocab.Address1County] = input.Address1County.PrintIfAvailable();
            data.Properties[vocab.Address1Fax] = input.Address1Fax.PrintIfAvailable();
            data.Properties[vocab.Address1Latitude] = input.Address1Latitude.PrintIfAvailable();
            data.Properties[vocab.Address1Line1] = input.Address1Line1.PrintIfAvailable();
            data.Properties[vocab.Address1Line2] = input.Address1Line2.PrintIfAvailable();
            data.Properties[vocab.Address1Line3] = input.Address1Line3.PrintIfAvailable();
            data.Properties[vocab.Address1Longitude] = input.Address1Longitude.PrintIfAvailable();
            data.Properties[vocab.Address1Name] = input.Address1Name.PrintIfAvailable();
            data.Properties[vocab.Address1Postalcode] = input.Address1Postalcode.PrintIfAvailable();
            data.Properties[vocab.Address1Postofficebox] = input.Address1Postofficebox.PrintIfAvailable();
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
            data.Properties[vocab.Address2Latitude] = input.Address2Latitude.PrintIfAvailable();
            data.Properties[vocab.Address2Line1] = input.Address2Line1.PrintIfAvailable();
            data.Properties[vocab.Address2Line2] = input.Address2Line2.PrintIfAvailable();
            data.Properties[vocab.Address2Line3] = input.Address2Line3.PrintIfAvailable();
            data.Properties[vocab.Address2Longitude] = input.Address2Longitude.PrintIfAvailable();
            data.Properties[vocab.Address2Name] = input.Address2Name.PrintIfAvailable();
            data.Properties[vocab.Address2Postalcode] = input.Address2Postalcode.PrintIfAvailable();
            data.Properties[vocab.Address2Postofficebox] = input.Address2Postofficebox.PrintIfAvailable();
            data.Properties[vocab.Address2Shippingmethodcode] = input.Address2Shippingmethodcode.PrintIfAvailable();
            data.Properties[vocab.Address2Stateorprovince] = input.Address2Stateorprovince.PrintIfAvailable();
            data.Properties[vocab.Address2Telephone1] = input.Address2Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address2Telephone2] = input.Address2Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address2Telephone3] = input.Address2Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address2Upszone] = input.Address2Upszone.PrintIfAvailable();
            data.Properties[vocab.Budgetamount] = input.Budgetamount.PrintIfAvailable();
            data.Properties[vocab.BudgetamountBase] = input.BudgetamountBase.PrintIfAvailable();
            data.Properties[vocab.Budgetstatus] = input.Budgetstatus.PrintIfAvailable();
            data.Properties[vocab.Campaignid] = input.Campaignid.PrintIfAvailable();
            data.Properties[vocab.Companyname] = input.Companyname.PrintIfAvailable();
            data.Properties[vocab.Confirminterest] = input.Confirminterest.PrintIfAvailable();
            data.Properties[vocab.Contactid] = input.Contactid.PrintIfAvailable();
            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.Customerid] = input.Customerid.PrintIfAvailable();
            data.Properties[vocab.Customeridtype] = input.Customeridtype.PrintIfAvailable();
            data.Properties[vocab.Decisionmaker] = input.Decisionmaker.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.Donotbulkemail] = input.Donotbulkemail.PrintIfAvailable();
            data.Properties[vocab.Donotemail] = input.Donotemail.PrintIfAvailable();
            data.Properties[vocab.Donotfax] = input.Donotfax.PrintIfAvailable();
            data.Properties[vocab.Donotphone] = input.Donotphone.PrintIfAvailable();
            data.Properties[vocab.Donotpostalmail] = input.Donotpostalmail.PrintIfAvailable();
            data.Properties[vocab.Donotsendmm] = input.Donotsendmm.PrintIfAvailable();
            data.Properties[vocab.DynaExistingopportunity] = input.DynaExistingopportunity.PrintIfAvailable();
            data.Properties[vocab.DynaHenvisendekonsulent] = input.DynaHenvisendekonsulent.PrintIfAvailable();
            data.Properties[vocab.DynaKommentar] = input.DynaKommentar.PrintIfAvailable();
            data.Properties[vocab.DynaKursus] = input.DynaKursus.PrintIfAvailable();
            data.Properties[vocab.DynaKursustype] = input.DynaKursustype.PrintIfAvailable();
            data.Properties[vocab.DynaLastemail] = input.DynaLastemail.PrintIfAvailable();
            data.Properties[vocab.DynaLastemaildate] = input.DynaLastemaildate.PrintIfAvailable();
            data.Properties[vocab.DynaLastphonecall] = input.DynaLastphonecall.PrintIfAvailable();
            data.Properties[vocab.DynaLastphonecalldate] = input.DynaLastphonecalldate.PrintIfAvailable();
            data.Properties[vocab.DynaLinkedinprofil] = input.DynaLinkedinprofil.PrintIfAvailable();
            data.Properties[vocab.DynaNextcontact] = input.DynaNextcontact.PrintIfAvailable();
            data.Properties[vocab.DynaProduktkategori] = input.DynaProduktkategori.PrintIfAvailable();
            data.Properties[vocab.DynaProduktkategoriInfoOutplacement] = input.DynaProduktkategoriInfoOutplacement.PrintIfAvailable();
            data.Properties[vocab.Emailaddress1] = input.Emailaddress1.PrintIfAvailable();
            data.Properties[vocab.Emailaddress2] = input.Emailaddress2.PrintIfAvailable();
            data.Properties[vocab.Emailaddress3] = input.Emailaddress3.PrintIfAvailable();
            data.Properties[vocab.Entityimage] = input.Entityimage.PrintIfAvailable();
            data.Properties[vocab.Entityimageid] = input.Entityimageid.PrintIfAvailable();
            data.Properties[vocab.Estimatedamount] = input.Estimatedamount.PrintIfAvailable();
            data.Properties[vocab.EstimatedamountBase] = input.EstimatedamountBase.PrintIfAvailable();
            data.Properties[vocab.Estimatedclosedate] = input.Estimatedclosedate.PrintIfAvailable();
            data.Properties[vocab.Estimatedvalue] = input.Estimatedvalue.PrintIfAvailable();
            data.Properties[vocab.Evaluatefit] = input.Evaluatefit.PrintIfAvailable();
            data.Properties[vocab.Exchangerate] = input.Exchangerate.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.Firstname] = input.Firstname.PrintIfAvailable();
            data.Properties[vocab.Followemail] = input.Followemail.PrintIfAvailable();
            data.Properties[vocab.Fullname] = input.Fullname.PrintIfAvailable();
            data.Properties[vocab.Industrycode] = input.Industrycode.PrintIfAvailable();
            data.Properties[vocab.Initialcommunication] = input.Initialcommunication.PrintIfAvailable();
            data.Properties[vocab.Isautocreate] = input.Isautocreate.PrintIfAvailable();
            data.Properties[vocab.Isprivate] = input.Isprivate.PrintIfAvailable();
            data.Properties[vocab.Jobtitle] = input.Jobtitle.PrintIfAvailable();
            data.Properties[vocab.Lastname] = input.Lastname.PrintIfAvailable();
            data.Properties[vocab.Lastonholdtime] = input.Lastonholdtime.PrintIfAvailable();
            data.Properties[vocab.Lastusedincampaign] = input.Lastusedincampaign.PrintIfAvailable();
            data.Properties[vocab.Leadid] = input.Leadid.PrintIfAvailable();
            data.Properties[vocab.Leadqualitycode] = input.Leadqualitycode.PrintIfAvailable();
            data.Properties[vocab.Leadsourcecode] = input.Leadsourcecode.PrintIfAvailable();
            data.Properties[vocab.Masterid] = input.Masterid.PrintIfAvailable();
            data.Properties[vocab.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[vocab.Middlename] = input.Middlename.PrintIfAvailable();
            data.Properties[vocab.Mobilephone] = input.Mobilephone.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.MsdynGdproptout] = input.MsdynGdproptout.PrintIfAvailable();
            data.Properties[vocab.Need] = input.Need.PrintIfAvailable();
            data.Properties[vocab.NnLastupdated] = input.NnLastupdated.PrintIfAvailable();
            data.Properties[vocab.NnLinks] = input.NnLinks.PrintIfAvailable();
            data.Properties[vocab.NnTdcid] = input.NnTdcid.PrintIfAvailable();
            data.Properties[vocab.NnUpdateprotected] = input.NnUpdateprotected.PrintIfAvailable();
            data.Properties[vocab.Numberofemployees] = input.Numberofemployees.PrintIfAvailable();
            data.Properties[vocab.Onholdtime] = input.Onholdtime.PrintIfAvailable();
            data.Properties[vocab.Originatingcaseid] = input.Originatingcaseid.PrintIfAvailable();
            data.Properties[vocab.Pager] = input.Pager.PrintIfAvailable();
            data.Properties[vocab.Parentaccountid] = input.Parentaccountid.PrintIfAvailable();
            data.Properties[vocab.Parentcontactid] = input.Parentcontactid.PrintIfAvailable();
            data.Properties[vocab.Participatesinworkflow] = input.Participatesinworkflow.PrintIfAvailable();
            data.Properties[vocab.Preferredcontactmethodcode] = input.Preferredcontactmethodcode.PrintIfAvailable();
            data.Properties[vocab.Prioritycode] = input.Prioritycode.PrintIfAvailable();
            data.Properties[vocab.Processid] = input.Processid.PrintIfAvailable();
            data.Properties[vocab.Purchaseprocess] = input.Purchaseprocess.PrintIfAvailable();
            data.Properties[vocab.Purchasetimeframe] = input.Purchasetimeframe.PrintIfAvailable();
            data.Properties[vocab.Qualificationcomments] = input.Qualificationcomments.PrintIfAvailable();
            data.Properties[vocab.Qualifyingopportunityid] = input.Qualifyingopportunityid.PrintIfAvailable();
            data.Properties[vocab.Relatedobjectid] = input.Relatedobjectid.PrintIfAvailable();
            data.Properties[vocab.Revenue] = input.Revenue.PrintIfAvailable();
            data.Properties[vocab.RevenueBase] = input.RevenueBase.PrintIfAvailable();
            data.Properties[vocab.Salesstage] = input.Salesstage.PrintIfAvailable();
            data.Properties[vocab.Salesstagecode] = input.Salesstagecode.PrintIfAvailable();
            data.Properties[vocab.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[vocab.SchedulefollowupProspect] = input.SchedulefollowupProspect.PrintIfAvailable();
            data.Properties[vocab.SchedulefollowupQualify] = input.SchedulefollowupQualify.PrintIfAvailable();
            data.Properties[vocab.Sic] = input.Sic.PrintIfAvailable();
            data.Properties[vocab.Slaid] = input.Slaid.PrintIfAvailable();
            data.Properties[vocab.Slainvokedid] = input.Slainvokedid.PrintIfAvailable();
            data.Properties[vocab.Stageid] = input.Stageid.PrintIfAvailable();
            data.Properties[vocab.Statecode] = input.Statecode.PrintIfAvailable();
            data.Properties[vocab.Statuscode] = input.Statuscode.PrintIfAvailable();
            data.Properties[vocab.Subject] = input.Subject.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
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


