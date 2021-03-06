// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V2;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI Gateways list
    /// </summary>
    public partial class ODataResponseListGateway
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListGateway class.
        /// </summary>
        public ODataResponseListGateway()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListGateway class.
        /// </summary>
        /// <param name="value">The Gateways</param>
        public ODataResponseListGateway(string odatacontext = default(string), IList<Gateway> value = default(IList<Gateway>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the Gateways
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Gateway> Value { get; set; }

    }
}
