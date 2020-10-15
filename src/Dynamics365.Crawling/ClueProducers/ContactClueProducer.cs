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
    public class ContactClueProducer : BaseClueProducer<Contact>
    {
        private readonly IClueFactory _factory;

        public ContactClueProducer(IClueFactory factory)
        {
            _factory = factory;
        }

        protected override Clue MakeClueImpl(Contact input, Guid id)
        {
            var clue = _factory.Create(EntityType.Person, input.Contactid, id);

            var data = clue.Data.EntityData;

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

            if (!string.IsNullOrEmpty(input.Address3Composite))
                data.Aliases.Add(input.Address3Composite);

            if (!string.IsNullOrEmpty(input.Address3Telephone1))
                data.Aliases.Add(input.Address3Telephone1);

            if (!string.IsNullOrEmpty(input.Address3Telephone2))
                data.Aliases.Add(input.Address3Telephone2);

            if (!string.IsNullOrEmpty(input.Address3Telephone3))
                data.Aliases.Add(input.Address3Telephone3);

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

            if (input.Accountid != null && !string.IsNullOrEmpty(input.Accountid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Accountid, input.Accountid.ToString());

            if (input.Contactid != null && !string.IsNullOrEmpty(input.Contactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Contactid, input.Contactid.ToString());

            if (input.Createdby != null && !string.IsNullOrEmpty(input.Createdby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Createdby, input.Createdby.ToString());

            if (input.Defaultpricelevelid != null && !string.IsNullOrEmpty(input.Defaultpricelevelid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Defaultpricelevelid, input.Defaultpricelevelid.ToString());

            if (input.DynaContactid != null && !string.IsNullOrEmpty(input.DynaContactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaContactid, input.DynaContactid.ToString());

            if (input.DynaKontaktpersonid != null && !string.IsNullOrEmpty(input.DynaKontaktpersonid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaKontaktpersonid, input.DynaKontaktpersonid.ToString());

            if (input.DynaLedernecontactguid != null && !string.IsNullOrEmpty(input.DynaLedernecontactguid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaLedernecontactguid, input.DynaLedernecontactguid.ToString());

            if (input.DynaNavid != null && !string.IsNullOrEmpty(input.DynaNavid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaNavid, input.DynaNavid.ToString());

            if (input.DynaNavtemplateid != null && !string.IsNullOrEmpty(input.DynaNavtemplateid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaNavtemplateid, input.DynaNavtemplateid.ToString());

            if (input.DynaPersonid != null && !string.IsNullOrEmpty(input.DynaPersonid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.DynaPersonid, input.DynaPersonid.ToString());

            if (input.Employeeid != null && !string.IsNullOrEmpty(input.Employeeid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Employeeid, input.Employeeid.ToString());

            if (input.Entityimageid != null && !string.IsNullOrEmpty(input.Entityimageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Entityimageid, input.Entityimageid.ToString());

            if (input.Governmentid != null && !string.IsNullOrEmpty(input.Governmentid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Governmentid, input.Governmentid.ToString());

            if (input.Masterid != null && !string.IsNullOrEmpty(input.Masterid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Masterid, input.Masterid.ToString());

            if (input.Modifiedby != null && !string.IsNullOrEmpty(input.Modifiedby.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Modifiedby, input.Modifiedby.ToString());

            if (input.NnNndecisionmakerid != null && !string.IsNullOrEmpty(input.NnNndecisionmakerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.NnNndecisionmakerid, input.NnNndecisionmakerid.ToString());

            if (input.Originatingleadid != null && !string.IsNullOrEmpty(input.Originatingleadid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Originatingleadid, input.Originatingleadid.ToString());

            if (input.Parentcontactid != null && !string.IsNullOrEmpty(input.Parentcontactid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Parentcontactid, input.Parentcontactid.ToString());

            if (input.Parentcustomerid != null && !string.IsNullOrEmpty(input.Parentcustomerid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Parentcustomerid, input.Parentcustomerid.ToString());

            if (input.Preferredequipmentid != null && !string.IsNullOrEmpty(input.Preferredequipmentid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Preferredequipmentid, input.Preferredequipmentid.ToString());

            if (input.Preferredserviceid != null && !string.IsNullOrEmpty(input.Preferredserviceid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Preferredserviceid, input.Preferredserviceid.ToString());

            if (input.Preferredsystemuserid != null && !string.IsNullOrEmpty(input.Preferredsystemuserid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Preferredsystemuserid, input.Preferredsystemuserid.ToString());

            if (input.Processid != null && !string.IsNullOrEmpty(input.Processid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Processid, input.Processid.ToString());

            if (input.Slaid != null && !string.IsNullOrEmpty(input.Slaid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Slaid, input.Slaid.ToString());

            if (input.Slainvokedid != null && !string.IsNullOrEmpty(input.Slainvokedid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Slainvokedid, input.Slainvokedid.ToString());

            if (input.Stageid != null && !string.IsNullOrEmpty(input.Stageid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Stageid, input.Stageid.ToString());

            if (input.Subscriptionid != null && !string.IsNullOrEmpty(input.Subscriptionid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Subscriptionid, input.Subscriptionid.ToString());

            if (input.Transactioncurrencyid != null && !string.IsNullOrEmpty(input.Transactioncurrencyid.ToString()))
                _factory.CreateOutgoingEntityReference(clue, EntityType.Unknown, EntityEdgeType.AttachedTo, input.Transactioncurrencyid, input.Transactioncurrencyid.ToString());


            if (!data.OutgoingEdges.Any())
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);


            var vocab = new ContactVocabulary();

            data.Properties[vocab.Accountid] = input.Accountid.PrintIfAvailable();
            data.Properties[vocab.Accountrolecode] = input.Accountrolecode.PrintIfAvailable();
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
            data.Properties[vocab.Address3Addresstypecode] = input.Address3Addresstypecode.PrintIfAvailable();
            data.Properties[vocab.Address3City] = input.Address3City.PrintIfAvailable();
            data.Properties[vocab.Address3Composite] = input.Address3Composite.PrintIfAvailable();
            data.Properties[vocab.Address3Country] = input.Address3Country.PrintIfAvailable();
            data.Properties[vocab.Address3County] = input.Address3County.PrintIfAvailable();
            data.Properties[vocab.Address3Fax] = input.Address3Fax.PrintIfAvailable();
            data.Properties[vocab.Address3Freighttermscode] = input.Address3Freighttermscode.PrintIfAvailable();
            data.Properties[vocab.Address3Latitude] = input.Address3Latitude.PrintIfAvailable();
            data.Properties[vocab.Address3Line1] = input.Address3Line1.PrintIfAvailable();
            data.Properties[vocab.Address3Line2] = input.Address3Line2.PrintIfAvailable();
            data.Properties[vocab.Address3Line3] = input.Address3Line3.PrintIfAvailable();
            data.Properties[vocab.Address3Longitude] = input.Address3Longitude.PrintIfAvailable();
            data.Properties[vocab.Address3Name] = input.Address3Name.PrintIfAvailable();
            data.Properties[vocab.Address3Postalcode] = input.Address3Postalcode.PrintIfAvailable();
            data.Properties[vocab.Address3Postofficebox] = input.Address3Postofficebox.PrintIfAvailable();
            data.Properties[vocab.Address3Primarycontactname] = input.Address3Primarycontactname.PrintIfAvailable();
            data.Properties[vocab.Address3Shippingmethodcode] = input.Address3Shippingmethodcode.PrintIfAvailable();
            data.Properties[vocab.Address3Stateorprovince] = input.Address3Stateorprovince.PrintIfAvailable();
            data.Properties[vocab.Address3Telephone1] = input.Address3Telephone1.PrintIfAvailable();
            data.Properties[vocab.Address3Telephone2] = input.Address3Telephone2.PrintIfAvailable();
            data.Properties[vocab.Address3Telephone3] = input.Address3Telephone3.PrintIfAvailable();
            data.Properties[vocab.Address3Upszone] = input.Address3Upszone.PrintIfAvailable();
            data.Properties[vocab.Aging30] = input.Aging30.PrintIfAvailable();
            data.Properties[vocab.Aging30Base] = input.Aging30Base.PrintIfAvailable();
            data.Properties[vocab.Aging60] = input.Aging60.PrintIfAvailable();
            data.Properties[vocab.Aging60Base] = input.Aging60Base.PrintIfAvailable();
            data.Properties[vocab.Aging90] = input.Aging90.PrintIfAvailable();
            data.Properties[vocab.Aging90Base] = input.Aging90Base.PrintIfAvailable();
            data.Properties[vocab.Anniversary] = input.Anniversary.PrintIfAvailable();
            data.Properties[vocab.Annualincome] = input.Annualincome.PrintIfAvailable();
            data.Properties[vocab.AnnualincomeBase] = input.AnnualincomeBase.PrintIfAvailable();
            data.Properties[vocab.Assistantname] = input.Assistantname.PrintIfAvailable();
            data.Properties[vocab.Assistantphone] = input.Assistantphone.PrintIfAvailable();
            data.Properties[vocab.Birthdate] = input.Birthdate.PrintIfAvailable();
            data.Properties[vocab.Business2] = input.Business2.PrintIfAvailable();
            data.Properties[vocab.Callback] = input.Callback.PrintIfAvailable();
            data.Properties[vocab.Childrensnames] = input.Childrensnames.PrintIfAvailable();
            data.Properties[vocab.Company] = input.Company.PrintIfAvailable();
            data.Properties[vocab.Contactid] = input.Contactid.PrintIfAvailable();
            data.Properties[vocab.Createdby] = input.Createdby.PrintIfAvailable();
            data.Properties[vocab.Createdbyexternalparty] = input.Createdbyexternalparty.PrintIfAvailable();
            data.Properties[vocab.Createdon] = input.Createdon.PrintIfAvailable();
            data.Properties[vocab.Creditlimit] = input.Creditlimit.PrintIfAvailable();
            data.Properties[vocab.CreditlimitBase] = input.CreditlimitBase.PrintIfAvailable();
            data.Properties[vocab.Creditonhold] = input.Creditonhold.PrintIfAvailable();
            data.Properties[vocab.Customersizecode] = input.Customersizecode.PrintIfAvailable();
            data.Properties[vocab.Customertypecode] = input.Customertypecode.PrintIfAvailable();
            data.Properties[vocab.Defaultpricelevelid] = input.Defaultpricelevelid.PrintIfAvailable();
            data.Properties[vocab.Department] = input.Department.PrintIfAvailable();
            data.Properties[vocab.Description] = input.Description.PrintIfAvailable();
            data.Properties[vocab.Donotbulkemail] = input.Donotbulkemail.PrintIfAvailable();
            data.Properties[vocab.Donotbulkpostalmail] = input.Donotbulkpostalmail.PrintIfAvailable();
            data.Properties[vocab.Donotemail] = input.Donotemail.PrintIfAvailable();
            data.Properties[vocab.Donotfax] = input.Donotfax.PrintIfAvailable();
            data.Properties[vocab.Donotphone] = input.Donotphone.PrintIfAvailable();
            data.Properties[vocab.Donotpostalmail] = input.Donotpostalmail.PrintIfAvailable();
            data.Properties[vocab.Donotsendmm] = input.Donotsendmm.PrintIfAvailable();
            data.Properties[vocab.DynaAnsttelselsesforhold] = input.DynaAnsttelselsesforhold.PrintIfAvailable();
            data.Properties[vocab.DynaCoaching] = input.DynaCoaching.PrintIfAvailable();
            data.Properties[vocab.DynaContactid] = input.DynaContactid.PrintIfAvailable();
            data.Properties[vocab.DynaContactidnr] = input.DynaContactidnr.PrintIfAvailable();
            data.Properties[vocab.DynaCountry] = input.DynaCountry.PrintIfAvailable();
            data.Properties[vocab.DynaCoursecustomer] = input.DynaCoursecustomer.PrintIfAvailable();
            data.Properties[vocab.DynaCustomerbeingcreated] = input.DynaCustomerbeingcreated.PrintIfAvailable();
            data.Properties[vocab.DynaDelingmedlho] = input.DynaDelingmedlho.PrintIfAvailable();
            data.Properties[vocab.DynaEmail2] = input.DynaEmail2.PrintIfAvailable();
            data.Properties[vocab.DynaEmailopdateretdato] = input.DynaEmailopdateretdato.PrintIfAvailable();
            data.Properties[vocab.DynaGodkendinav] = input.DynaGodkendinav.PrintIfAvailable();
            data.Properties[vocab.DynaKonsulent] = input.DynaKonsulent.PrintIfAvailable();
            data.Properties[vocab.DynaKontaktpersonid] = input.DynaKontaktpersonid.PrintIfAvailable();
            data.Properties[vocab.DynaLedernecontactguid] = input.DynaLedernecontactguid.PrintIfAvailable();
            data.Properties[vocab.DynaLedernemandag] = input.DynaLedernemandag.PrintIfAvailable();
            data.Properties[vocab.DynaLedernemedlem] = input.DynaLedernemedlem.PrintIfAvailable();
            data.Properties[vocab.DynaLmcKontakt] = input.DynaLmcKontakt.PrintIfAvailable();
            data.Properties[vocab.DynaLmcKontaktnote] = input.DynaLmcKontaktnote.PrintIfAvailable();
            data.Properties[vocab.DynaLmsadgang] = input.DynaLmsadgang.PrintIfAvailable();
            data.Properties[vocab.DynaMedlemsnummer] = input.DynaMedlemsnummer.PrintIfAvailable();
            data.Properties[vocab.DynaNavid] = input.DynaNavid.PrintIfAvailable();
            data.Properties[vocab.DynaNavtemplateid] = input.DynaNavtemplateid.PrintIfAvailable();
            data.Properties[vocab.DynaNetvaerkKandidat] = input.DynaNetvaerkKandidat.PrintIfAvailable();
            data.Properties[vocab.DynaNytfraledelseidagdk] = input.DynaNytfraledelseidagdk.PrintIfAvailable();
            data.Properties[vocab.DynaOldiddebitor] = input.DynaOldiddebitor.PrintIfAvailable();
            data.Properties[vocab.DynaOldiddeltager] = input.DynaOldiddeltager.PrintIfAvailable();
            data.Properties[vocab.DynaOldidinstruktr] = input.DynaOldidinstruktr.PrintIfAvailable();
            data.Properties[vocab.DynaOutplacement] = input.DynaOutplacement.PrintIfAvailable();
            data.Properties[vocab.DynaPersonid] = input.DynaPersonid.PrintIfAvailable();
            data.Properties[vocab.DynaSendnyhedsbrev] = input.DynaSendnyhedsbrev.PrintIfAvailable();
            data.Properties[vocab.DynaTotalamount] = input.DynaTotalamount.PrintIfAvailable();
            data.Properties[vocab.DynaUk] = input.DynaUk.PrintIfAvailable();
            data.Properties[vocab.DynaUnderviser] = input.DynaUnderviser.PrintIfAvailable();
            data.Properties[vocab.DynaUndervisernote] = input.DynaUndervisernote.PrintIfAvailable();
            data.Properties[vocab.DynaVip] = input.DynaVip.PrintIfAvailable();
            data.Properties[vocab.Educationcode] = input.Educationcode.PrintIfAvailable();
            data.Properties[vocab.Emailaddress1] = input.Emailaddress1.PrintIfAvailable();
            data.Properties[vocab.Emailaddress2] = input.Emailaddress2.PrintIfAvailable();
            data.Properties[vocab.Emailaddress3] = input.Emailaddress3.PrintIfAvailable();
            data.Properties[vocab.Employeeid] = input.Employeeid.PrintIfAvailable();
            data.Properties[vocab.Entityimage] = input.Entityimage.PrintIfAvailable();
            data.Properties[vocab.Entityimageid] = input.Entityimageid.PrintIfAvailable();
            data.Properties[vocab.Exchangerate] = input.Exchangerate.PrintIfAvailable();
            data.Properties[vocab.Externaluseridentifier] = input.Externaluseridentifier.PrintIfAvailable();
            data.Properties[vocab.Familystatuscode] = input.Familystatuscode.PrintIfAvailable();
            data.Properties[vocab.Fax] = input.Fax.PrintIfAvailable();
            data.Properties[vocab.Firstname] = input.Firstname.PrintIfAvailable();
            data.Properties[vocab.Followemail] = input.Followemail.PrintIfAvailable();
            data.Properties[vocab.Ftpsiteurl] = input.Ftpsiteurl.PrintIfAvailable();
            data.Properties[vocab.Fullname] = input.Fullname.PrintIfAvailable();
            data.Properties[vocab.Gendercode] = input.Gendercode.PrintIfAvailable();
            data.Properties[vocab.Governmentid] = input.Governmentid.PrintIfAvailable();
            data.Properties[vocab.Haschildrencode] = input.Haschildrencode.PrintIfAvailable();
            data.Properties[vocab.Home2] = input.Home2.PrintIfAvailable();
            data.Properties[vocab.Isautocreate] = input.Isautocreate.PrintIfAvailable();
            data.Properties[vocab.Isbackofficecustomer] = input.Isbackofficecustomer.PrintIfAvailable();
            data.Properties[vocab.Jobtitle] = input.Jobtitle.PrintIfAvailable();
            data.Properties[vocab.Lastname] = input.Lastname.PrintIfAvailable();
            data.Properties[vocab.Lastonholdtime] = input.Lastonholdtime.PrintIfAvailable();
            data.Properties[vocab.Lastusedincampaign] = input.Lastusedincampaign.PrintIfAvailable();
            data.Properties[vocab.Leadsourcecode] = input.Leadsourcecode.PrintIfAvailable();
            data.Properties[vocab.Managername] = input.Managername.PrintIfAvailable();
            data.Properties[vocab.Managerphone] = input.Managerphone.PrintIfAvailable();
            data.Properties[vocab.Marketingonly] = input.Marketingonly.PrintIfAvailable();
            data.Properties[vocab.Masterid] = input.Masterid.PrintIfAvailable();
            data.Properties[vocab.Merged] = input.Merged.PrintIfAvailable();
            data.Properties[vocab.Middlename] = input.Middlename.PrintIfAvailable();
            data.Properties[vocab.Mobilephone] = input.Mobilephone.PrintIfAvailable();
            data.Properties[vocab.Modifiedby] = input.Modifiedby.PrintIfAvailable();
            data.Properties[vocab.Modifiedbyexternalparty] = input.Modifiedbyexternalparty.PrintIfAvailable();
            data.Properties[vocab.Modifiedon] = input.Modifiedon.PrintIfAvailable();
            data.Properties[vocab.MsdynGdproptout] = input.MsdynGdproptout.PrintIfAvailable();
            data.Properties[vocab.Nickname] = input.Nickname.PrintIfAvailable();
            data.Properties[vocab.NnNndecisionmakerid] = input.NnNndecisionmakerid.PrintIfAvailable();
            data.Properties[vocab.NnUpdateprotected] = input.NnUpdateprotected.PrintIfAvailable();
            data.Properties[vocab.Numberofchildren] = input.Numberofchildren.PrintIfAvailable();
            data.Properties[vocab.Onholdtime] = input.Onholdtime.PrintIfAvailable();
            data.Properties[vocab.Originatingleadid] = input.Originatingleadid.PrintIfAvailable();
            data.Properties[vocab.Pager] = input.Pager.PrintIfAvailable();
            data.Properties[vocab.Parentcontactid] = input.Parentcontactid.PrintIfAvailable();
            data.Properties[vocab.Parentcustomerid] = input.Parentcustomerid.PrintIfAvailable();
            data.Properties[vocab.Parentcustomeridtype] = input.Parentcustomeridtype.PrintIfAvailable();
            data.Properties[vocab.Participatesinworkflow] = input.Participatesinworkflow.PrintIfAvailable();
            data.Properties[vocab.Paymenttermscode] = input.Paymenttermscode.PrintIfAvailable();
            data.Properties[vocab.Preferredappointmentdaycode] = input.Preferredappointmentdaycode.PrintIfAvailable();
            data.Properties[vocab.Preferredappointmenttimecode] = input.Preferredappointmenttimecode.PrintIfAvailable();
            data.Properties[vocab.Preferredcontactmethodcode] = input.Preferredcontactmethodcode.PrintIfAvailable();
            data.Properties[vocab.Preferredequipmentid] = input.Preferredequipmentid.PrintIfAvailable();
            data.Properties[vocab.Preferredserviceid] = input.Preferredserviceid.PrintIfAvailable();
            data.Properties[vocab.Preferredsystemuserid] = input.Preferredsystemuserid.PrintIfAvailable();
            data.Properties[vocab.Processid] = input.Processid.PrintIfAvailable();
            data.Properties[vocab.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[vocab.Shippingmethodcode] = input.Shippingmethodcode.PrintIfAvailable();
            data.Properties[vocab.Slaid] = input.Slaid.PrintIfAvailable();
            data.Properties[vocab.Slainvokedid] = input.Slainvokedid.PrintIfAvailable();
            data.Properties[vocab.Spousesname] = input.Spousesname.PrintIfAvailable();
            data.Properties[vocab.Stageid] = input.Stageid.PrintIfAvailable();
            data.Properties[vocab.Statecode] = input.Statecode.PrintIfAvailable();
            data.Properties[vocab.Statuscode] = input.Statuscode.PrintIfAvailable();
            data.Properties[vocab.Subscriptionid] = input.Subscriptionid.PrintIfAvailable();
            data.Properties[vocab.Suffix] = input.Suffix.PrintIfAvailable();
            data.Properties[vocab.Telephone1] = input.Telephone1.PrintIfAvailable();
            data.Properties[vocab.Telephone2] = input.Telephone2.PrintIfAvailable();
            data.Properties[vocab.Telephone3] = input.Telephone3.PrintIfAvailable();
            data.Properties[vocab.Territorycode] = input.Territorycode.PrintIfAvailable();
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


