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
    /// StateOptionMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMStateOptionMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMStateOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMStateOptionMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMStateOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMStateOptionMetadata(int? defaultStatus = default(int?), string invariantName = default(string))
        {
            DefaultStatus = defaultStatus;
            InvariantName = invariantName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultStatus")]
        public int? DefaultStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvariantName")]
        public string InvariantName { get; set; }

    }
}
