// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.contactinvoices
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontactinvoices
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontactinvoices class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactinvoices()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontactinvoices class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactinvoices(int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), string versionnumber = default(string), int? timezoneruleversionnumber = default(int?), string name = default(string), string contactid = default(string), string contactinvoiceid = default(string), string invoiceid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMteam> contactinvoicesTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMasyncoperation> contactinvoicesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contactinvoicesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contactinvoicesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contactinvoicesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Name = name;
            Contactid = contactid;
            Contactinvoiceid = contactinvoiceid;
            Invoiceid = invoiceid;
            Overriddencreatedon = overriddencreatedon;
            ContactinvoicesTeams = contactinvoicesTeams;
            ContactinvoicesAsyncOperations = contactinvoicesAsyncOperations;
            ContactinvoicesMailboxTrackingFolders = contactinvoicesMailboxTrackingFolders;
            ContactinvoicesBulkDeleteFailures = contactinvoicesBulkDeleteFailures;
            ContactinvoicesPrincipalObjectAttributeAccesses = contactinvoicesPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoiceid")]
        public string Contactinvoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "invoiceid")]
        public string Invoiceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_Teams")]
        public IList<MicrosoftDynamicsCRMteam> ContactinvoicesTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContactinvoicesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContactinvoicesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContactinvoicesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactinvoices_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContactinvoicesPrincipalObjectAttributeAccesses { get; set; }

    }
}
