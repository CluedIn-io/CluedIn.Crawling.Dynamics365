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
    public class SystemuserClueProducer : BaseClueProducer<Systemuser>
    {
        private readonly IClueFactory _factory;

        public SystemuserClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(Systemuser input, Guid id)
        {

            var clue = _factory.Create("/Bruger", $"FILL_IN", id);

            var data = clue.Data.EntityData;

            // Metadata

            //data.Name = input.Name;

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

            if (!string.IsNullOrEmpty(input.Internalemailaddress))
                data.Aliases.Add(input.Internalemailaddress);

            if (!string.IsNullOrEmpty(input.Isemailaddressapprovedbyo365admin))
                data.Aliases.Add(input.Isemailaddressapprovedbyo365admin);

            if (!string.IsNullOrEmpty(input.Personalemailaddress))
                data.Aliases.Add(input.Personalemailaddress);

            if (!string.IsNullOrEmpty(input.Sharepointemailaddress))
                data.Aliases.Add(input.Sharepointemailaddress);

            if (!string.IsNullOrEmpty(input.Yammeremailaddress))
                data.Aliases.Add(input.Yammeremailaddress);


            // Edges

            if (input.Activedirectoryguid != null && !string.IsNullOrEmpty(input.Activedirectoryguid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Activedirectoryguid, input.Activedirectoryguid.ToString());

            if (input.Applicationid != null && !string.IsNullOrEmpty(input.Applicationid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Applicationid, input.Applicationid.ToString());

            if (input.Applicationiduri != null && !string.IsNullOrEmpty(input.Applicationiduri.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Applicationiduri, input.Applicationiduri.ToString());

            if (input.Azureactivedirectoryobjectid != null && !string.IsNullOrEmpty(input.Azureactivedirectoryobjectid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Azureactivedirectoryobjectid, input.Azureactivedirectoryobjectid.ToString());

            if (input.Businessunitid != null && !string.IsNullOrEmpty(input.Businessunitid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Businessunitid, input.Businessunitid.ToString());

            if (input.Calendarid != null && !string.IsNullOrEmpty(input.Calendarid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Calendarid, input.Calendarid.ToString());

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.Employeeid != null && !string.IsNullOrEmpty(input.Employeeid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Employeeid, input.Employeeid.ToString());

            if (input.Entityimageid != null && !string.IsNullOrEmpty(input.Entityimageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Entityimageid, input.Entityimageid.ToString());

            if (input.Governmentid != null && !string.IsNullOrEmpty(input.Governmentid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Governmentid, input.Governmentid.ToString());

            if (input.Identityid != null && !string.IsNullOrEmpty(input.Identityid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Identityid, input.Identityid.ToString());

            if (input.Mobileofflineprofileid != null && !string.IsNullOrEmpty(input.Mobileofflineprofileid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Mobileofflineprofileid, input.Mobileofflineprofileid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            if (input.Organizationid != null && !string.IsNullOrEmpty(input.Organizationid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Organizationid, input.Organizationid.ToString());

            if (input.Parentsystemuserid != null && !string.IsNullOrEmpty(input.Parentsystemuserid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Parentsystemuserid, input.Parentsystemuserid.ToString());

            if (input.Positionid != null && !string.IsNullOrEmpty(input.Positionid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Positionid, input.Positionid.ToString());

            if (input.Processid != null && !string.IsNullOrEmpty(input.Processid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Processid, input.Processid.ToString());

            if (input.Queueid != null && !string.IsNullOrEmpty(input.Queueid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Queueid, input.Queueid.ToString());

            if (input.Siteid != null && !string.IsNullOrEmpty(input.Siteid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Siteid, input.Siteid.ToString());

            if (input.Stageid != null && !string.IsNullOrEmpty(input.Stageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Stageid, input.Stageid.ToString());

            if (input.Systemuserid != null && !string.IsNullOrEmpty(input.Systemuserid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Systemuserid, input.Systemuserid.ToString());

            if (input.Territoryid != null && !string.IsNullOrEmpty(input.Territoryid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Territoryid, input.Territoryid.ToString());

            if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());

            if (input.Userpuid != null && !string.IsNullOrEmpty(input.Userpuid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Userpuid, input.Userpuid.ToString());

            if (input.Windowsliveid != null && !string.IsNullOrEmpty(input.Windowsliveid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Windowsliveid, input.Windowsliveid.ToString());

            if (input.Yammeruserid != null && !string.IsNullOrEmpty(input.Yammeruserid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Yammeruserid, input.Yammeruserid.ToString());


            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);


            var vocab = new SystemuserVocabulary();

            data.Properties[vocab.Accessmode] = input.Accessmode.PrintIfAvailable();
            data.Properties[vocab.Activedirectoryguid] = input.Activedirectoryguid.PrintIfAvailable();
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
            data.Properties[vocab.Applicationid] = input.Applicationid.PrintIfAvailable();
            data.Properties[vocab.Applicationiduri] = input.Applicationiduri.PrintIfAvailable();
            data.Properties[vocab.Azureactivedirectoryobjectid] = input.Azureactivedirectoryobjectid.PrintIfAvailable();
            data.Properties[vocab.Businessunitid] = input.Businessunitid.PrintIfAvailable();
            data.Properties[vocab.Calendarid] = input.Calendarid.PrintIfAvailable();
            data.Properties[vocab.Caltype] = input.Caltype.PrintIfAvailable();
            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.Defaultfilterspopulated] = input.Defaultfilterspopulated.PrintIfAvailable();
            data.Properties[vocab.Defaultmailbox] = input.Defaultmailbox.PrintIfAvailable();
            data.Properties[vocab.Defaultodbfoldername] = input.Defaultodbfoldername.PrintIfAvailable();
            data.Properties[vocab.Disabledreason] = input.Disabledreason.PrintIfAvailable();
            data.Properties[vocab.Displayinserviceviews] = input.Displayinserviceviews.PrintIfAvailable();
            data.Properties[vocab.Domainname] = input.Domainname.PrintIfAvailable();
            data.Properties[vocab.DynaInitialer] = input.DynaInitialer.PrintIfAvailable();
            data.Properties[vocab.Emailrouteraccessapproval] = input.Emailrouteraccessapproval.PrintIfAvailable();
            data.Properties[vocab.Employeeid] = input.Employeeid.PrintIfAvailable();
            data.Properties[vocab.Entityimage] = input.Entityimage.PrintIfAvailable();
            data.Properties[vocab.Entityimageid] = input.Entityimageid.PrintIfAvailable();
            data.Properties[vocab.Exchangerate] = input.Exchangerate.PrintIfAvailable();
            data.Properties[vocab.Firstname] = input.Firstname.PrintIfAvailable();
            data.Properties[vocab.Fullname] = input.Fullname.PrintIfAvailable();
            data.Properties[vocab.Governmentid] = input.Governmentid.PrintIfAvailable();
            data.Properties[vocab.Homephone] = input.Homephone.PrintIfAvailable();
            data.Properties[vocab.Identityid] = input.Identityid.PrintIfAvailable();
            data.Properties[vocab.Incomingemaildeliverymethod] = input.Incomingemaildeliverymethod.PrintIfAvailable();
            data.Properties[vocab.Internalemailaddress] = input.Internalemailaddress.PrintIfAvailable();
            data.Properties[vocab.Invitestatuscode] = input.Invitestatuscode.PrintIfAvailable();
            data.Properties[vocab.Isactivedirectoryuser] = input.Isactivedirectoryuser.PrintIfAvailable();
            data.Properties[vocab.Isdisabled] = input.Isdisabled.PrintIfAvailable();
            data.Properties[vocab.Isemailaddressapprovedbyo365admin] = input.Isemailaddressapprovedbyo365admin.PrintIfAvailable();
            data.Properties[vocab.Isintegrationuser] = input.Isintegrationuser.PrintIfAvailable();
            data.Properties[vocab.Islicensed] = input.Islicensed.PrintIfAvailable();
            data.Properties[vocab.Issyncwithdirectory] = input.Issyncwithdirectory.PrintIfAvailable();
            data.Properties[vocab.Jobtitle] = input.Jobtitle.PrintIfAvailable();
            data.Properties[vocab.Lastname] = input.Lastname.PrintIfAvailable();
            data.Properties[vocab.Latestupdatetime] = input.Latestupdatetime.PrintIfAvailable();
            data.Properties[vocab.Middlename] = input.Middlename.PrintIfAvailable();
            data.Properties[vocab.Mobilealertemail] = input.Mobilealertemail.PrintIfAvailable();
            data.Properties[vocab.Mobileofflineprofileid] = input.Mobileofflineprofileid.PrintIfAvailable();
            data.Properties[vocab.Mobilephone] = input.Mobilephone.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.MsdynGdproptout] = input.MsdynGdproptout.PrintIfAvailable();
            data.Properties[vocab.Nickname] = input.Nickname.PrintIfAvailable();
            data.Properties[vocab.Organizationid] = input.Organizationid.PrintIfAvailable();
            data.Properties[vocab.Outgoingemaildeliverymethod] = input.Outgoingemaildeliverymethod.PrintIfAvailable();
            data.Properties[vocab.Parentsystemuserid] = input.Parentsystemuserid.PrintIfAvailable();
            data.Properties[vocab.Passporthi] = input.Passporthi.PrintIfAvailable();
            data.Properties[vocab.Passportlo] = input.Passportlo.PrintIfAvailable();
            data.Properties[vocab.Personalemailaddress] = input.Personalemailaddress.PrintIfAvailable();
            data.Properties[vocab.Photourl] = input.Photourl.PrintIfAvailable();
            data.Properties[vocab.Positionid] = input.Positionid.PrintIfAvailable();
            data.Properties[vocab.Preferredaddresscode] = input.Preferredaddresscode.PrintIfAvailable();
            data.Properties[vocab.Preferredemailcode] = input.Preferredemailcode.PrintIfAvailable();
            data.Properties[vocab.Preferredphonecode] = input.Preferredphonecode.PrintIfAvailable();
            data.Properties[vocab.Processid] = input.Processid.PrintIfAvailable();
            data.Properties[vocab.PtmPeruserlicensingdocumentscorepack] = input.PtmPeruserlicensingdocumentscorepack.PrintIfAvailable();
            data.Properties[vocab.PtmPeruserlicensingdocumentscorepackserver] = input.PtmPeruserlicensingdocumentscorepackserver.PrintIfAvailable();
            data.Properties[vocab.Queueid] = input.Queueid.PrintIfAvailable();
            data.Properties[vocab.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[vocab.Setupuser] = input.Setupuser.PrintIfAvailable();
            data.Properties[vocab.Sharepointemailaddress] = input.Sharepointemailaddress.PrintIfAvailable();
            data.Properties[vocab.Siteid] = input.Siteid.PrintIfAvailable();
            data.Properties[vocab.Skills] = input.Skills.PrintIfAvailable();
            data.Properties[vocab.Stageid] = input.Stageid.PrintIfAvailable();
            data.Properties[vocab.Systemuserid] = input.Systemuserid.PrintIfAvailable();
            data.Properties[vocab.Territoryid] = input.Territoryid.PrintIfAvailable();
            data.Properties[vocab.Title] = input.Title.PrintIfAvailable();
            data.Properties[vocab.Transactioncurrencyid] = input.Transactioncurrencyid.PrintIfAvailable();
            data.Properties[vocab.Traversedpath] = input.Traversedpath.PrintIfAvailable();
            data.Properties[vocab.Userlicensetype] = input.Userlicensetype.PrintIfAvailable();
            data.Properties[vocab.Userpuid] = input.Userpuid.PrintIfAvailable();
            data.Properties[vocab.Windowsliveid] = input.Windowsliveid.PrintIfAvailable();
            data.Properties[vocab.Yammeremailaddress] = input.Yammeremailaddress.PrintIfAvailable();
            data.Properties[vocab.Yammeruserid] = input.Yammeruserid.PrintIfAvailable();

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


