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
    /// Collection of adoxio_enforcementaction
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_enforcementactionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioEnforcementactionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEnforcementactionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEnforcementactionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEnforcementactionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEnforcementactionCollection(IList<MicrosoftDynamicsCRMadoxioEnforcementaction> value = default(IList<MicrosoftDynamicsCRMadoxioEnforcementaction>))
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
        public IList<MicrosoftDynamicsCRMadoxioEnforcementaction> Value { get; set; }

    }
}
