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
    /// Collection of adoxio_endorsement
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_endorsementCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioEndorsementCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEndorsementCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEndorsementCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEndorsementCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEndorsementCollection(IList<MicrosoftDynamicsCRMadoxioEndorsement> value = default(IList<MicrosoftDynamicsCRMadoxioEndorsement>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioEndorsement> Value { get; set; }

    }
}
