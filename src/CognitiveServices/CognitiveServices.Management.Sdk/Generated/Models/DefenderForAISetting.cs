// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// The Defender for AI resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DefenderForAISetting : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DefenderForAISetting class.
        /// </summary>
        public DefenderForAISetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefenderForAISetting class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="systemData">Metadata pertaining to creation and last modification of the resource.
        /// </param>

        /// <param name="etag">Resource Etag.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="state">Defender for AI state on the AI resource.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>
        public DefenderForAISetting(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string state = default(string))

        : base(id, name, type)
        {
            this.SystemData = systemData;
            this.Etag = etag;
            this.Tags = tags;
            this.State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData {get; private set; }

        /// <summary>
        /// Gets resource Etag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets or sets defender for AI state on the AI resource. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.state")]
        public string State {get; set; }
    }
}