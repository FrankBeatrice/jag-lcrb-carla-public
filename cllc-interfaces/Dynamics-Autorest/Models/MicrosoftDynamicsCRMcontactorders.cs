// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// contactorders
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontactorders
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactorders
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactorders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcontactorders
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcontactorders(string contactorderid = default(string), string contactid = default(string), long? versionnumber = default(long?), string salesorderid = default(string))
        {
            Contactorderid = contactorderid;
            Contactid = contactid;
            Versionnumber = versionnumber;
            Salesorderid = salesorderid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorderid")]
        public string Contactorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public string Salesorderid { get; set; }

    }
}
