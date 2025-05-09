// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of Virtual Network Tap configuration.
    /// </summary>
    public partial class NetworkInterfaceTapConfigurationPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceTapConfigurationPropertiesFormat class.
        /// </summary>
        public NetworkInterfaceTapConfigurationPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceTapConfigurationPropertiesFormat class.
        /// </summary>

        /// <param name="virtualNetworkTap">The reference to the Virtual Network Tap resource.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the network interface tap configuration resource.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;</param>
        public NetworkInterfaceTapConfigurationPropertiesFormat(VirtualNetworkTap virtualNetworkTap = default(VirtualNetworkTap), string provisioningState = default(string))

        {
            this.VirtualNetworkTap = virtualNetworkTap;
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the reference to the Virtual Network Tap resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualNetworkTap")]
        public VirtualNetworkTap VirtualNetworkTap {get; set; }

        /// <summary>
        /// Gets the provisioning state of the network interface tap configuration
        /// resource. Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.VirtualNetworkTap != null)
            {
                this.VirtualNetworkTap.Validate();
            }

        }
    }
}