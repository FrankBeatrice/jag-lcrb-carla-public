// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Spice.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IncompleteWorkerScreening
    {
        /// <summary>
        /// Initializes a new instance of the IncompleteWorkerScreening class.
        /// </summary>
        public IncompleteWorkerScreening()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncompleteWorkerScreening class.
        /// </summary>
        public IncompleteWorkerScreening(string recordIdentifier = default(string), Contact contact = default(Contact))
        {
            RecordIdentifier = recordIdentifier;
            Contact = contact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordIdentifier")]
        public string RecordIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contact")]
        public Contact Contact { get; set; }

    }
}