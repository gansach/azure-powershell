// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Virtual Network resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualNetwork : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="extendedLocation">The extended location of the virtual network.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="addressSpace">The AddressSpace that contains an array of IP address ranges that can be
        /// used by subnets.
        /// </param>

        /// <param name="dhcpOptions">The dhcpOptions that contains an array of DNS servers available to VMs
        /// deployed in the virtual network.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the virtual network resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="flowTimeoutInMinutes">The FlowTimeout value (in minutes) for the Virtual Network
        /// </param>

        /// <param name="subnets">A list of subnets in a Virtual Network.
        /// </param>

        /// <param name="virtualNetworkPeerings">A list of peerings in a Virtual Network.
        /// </param>

        /// <param name="resourceGuid">The resourceGuid property of the Virtual Network resource.
        /// </param>

        /// <param name="enableDdosProtection">Indicates if DDoS protection is enabled for all the protected resources in
        /// the virtual network. It requires a DDoS protection plan associated with the
        /// resource.
        /// </param>

        /// <param name="enableVMProtection">Indicates if VM protection is enabled for all the subnets in the virtual
        /// network.
        /// </param>

        /// <param name="ddosProtectionPlan">The DDoS protection plan associated with the virtual network.
        /// </param>

        /// <param name="bgpCommunities">Bgp Communities sent over ExpressRoute with each route corresponding to a
        /// prefix in this VNET.
        /// </param>

        /// <param name="encryption">Indicates if encryption is enabled on virtual network and if VM without
        /// encryption is allowed in encrypted VNet.
        /// </param>

        /// <param name="ipAllocations">Array of IpAllocation which reference this VNET.
        /// </param>

        /// <param name="flowLogs">A collection of references to flow log resources.
        /// </param>

        /// <param name="privateEndpointVNetPolicies">Private Endpoint VNet Policies.
        /// Possible values include: &#39;Disabled&#39;, &#39;Basic&#39;</param>

        /// <param name="defaultPublicNatGateway">A reference to the default public nat gateway being used by this virtual
        /// network resource.
        /// </param>
        public VirtualNetwork(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ExtendedLocation extendedLocation = default(ExtendedLocation), string etag = default(string), AddressSpace addressSpace = default(AddressSpace), DhcpOptions dhcpOptions = default(DhcpOptions), string provisioningState = default(string), int? flowTimeoutInMinutes = default(int?), System.Collections.Generic.IList<Subnet> subnets = default(System.Collections.Generic.IList<Subnet>), System.Collections.Generic.IList<VirtualNetworkPeering> virtualNetworkPeerings = default(System.Collections.Generic.IList<VirtualNetworkPeering>), string resourceGuid = default(string), bool? enableDdosProtection = default(bool?), bool? enableVMProtection = default(bool?), SubResource ddosProtectionPlan = default(SubResource), VirtualNetworkBgpCommunities bgpCommunities = default(VirtualNetworkBgpCommunities), VirtualNetworkEncryption encryption = default(VirtualNetworkEncryption), System.Collections.Generic.IList<SubResource> ipAllocations = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<FlowLog> flowLogs = default(System.Collections.Generic.IList<FlowLog>), string privateEndpointVNetPolicies = default(string), SubResource defaultPublicNatGateway = default(SubResource))

        : base(id, name, type, location, tags)
        {
            this.ExtendedLocation = extendedLocation;
            this.Etag = etag;
            this.AddressSpace = addressSpace;
            this.DhcpOptions = dhcpOptions;
            this.ProvisioningState = provisioningState;
            this.FlowTimeoutInMinutes = flowTimeoutInMinutes;
            this.Subnets = subnets;
            this.VirtualNetworkPeerings = virtualNetworkPeerings;
            this.ResourceGuid = resourceGuid;
            this.EnableDdosProtection = enableDdosProtection;
            this.EnableVMProtection = enableVMProtection;
            this.DdosProtectionPlan = ddosProtectionPlan;
            this.BgpCommunities = bgpCommunities;
            this.Encryption = encryption;
            this.IPAllocations = ipAllocations;
            this.FlowLogs = flowLogs;
            this.PrivateEndpointVNetPolicies = privateEndpointVNetPolicies;
            this.DefaultPublicNatGateway = defaultPublicNatGateway;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the extended location of the virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation {get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets or sets the AddressSpace that contains an array of IP address ranges
        /// that can be used by subnets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.addressSpace")]
        public AddressSpace AddressSpace {get; set; }

        /// <summary>
        /// Gets or sets the dhcpOptions that contains an array of DNS servers
        /// available to VMs deployed in the virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dhcpOptions")]
        public DhcpOptions DhcpOptions {get; set; }

        /// <summary>
        /// Gets the provisioning state of the virtual network resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the FlowTimeout value (in minutes) for the Virtual Network
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.flowTimeoutInMinutes")]
        public int? FlowTimeoutInMinutes {get; set; }

        /// <summary>
        /// Gets or sets a list of subnets in a Virtual Network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnets")]
        public System.Collections.Generic.IList<Subnet> Subnets {get; set; }

        /// <summary>
        /// Gets or sets a list of peerings in a Virtual Network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualNetworkPeerings")]
        public System.Collections.Generic.IList<VirtualNetworkPeering> VirtualNetworkPeerings {get; set; }

        /// <summary>
        /// Gets the resourceGuid property of the Virtual Network resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid {get; private set; }

        /// <summary>
        /// Gets or sets indicates if DDoS protection is enabled for all the protected
        /// resources in the virtual network. It requires a DDoS protection plan
        /// associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableDdosProtection")]
        public bool? EnableDdosProtection {get; set; }

        /// <summary>
        /// Gets or sets indicates if VM protection is enabled for all the subnets in
        /// the virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableVmProtection")]
        public bool? EnableVMProtection {get; set; }

        /// <summary>
        /// Gets or sets the DDoS protection plan associated with the virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ddosProtectionPlan")]
        public SubResource DdosProtectionPlan {get; set; }

        /// <summary>
        /// Gets or sets bgp Communities sent over ExpressRoute with each route
        /// corresponding to a prefix in this VNET.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.bgpCommunities")]
        public VirtualNetworkBgpCommunities BgpCommunities {get; set; }

        /// <summary>
        /// Gets or sets indicates if encryption is enabled on virtual network and if
        /// VM without encryption is allowed in encrypted VNet.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public VirtualNetworkEncryption Encryption {get; set; }

        /// <summary>
        /// Gets or sets array of IpAllocation which reference this VNET.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ipAllocations")]
        public System.Collections.Generic.IList<SubResource> IPAllocations {get; set; }

        /// <summary>
        /// Gets a collection of references to flow log resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.flowLogs")]
        public System.Collections.Generic.IList<FlowLog> FlowLogs {get; private set; }

        /// <summary>
        /// Gets or sets private Endpoint VNet Policies. Possible values include: &#39;Disabled&#39;, &#39;Basic&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateEndpointVNetPolicies")]
        public string PrivateEndpointVNetPolicies {get; set; }

        /// <summary>
        /// Gets a reference to the default public nat gateway being used by this
        /// virtual network resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.defaultPublicNatGateway")]
        public SubResource DefaultPublicNatGateway {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {






            if (this.VirtualNetworkPeerings != null)
            {
                foreach (var element in this.VirtualNetworkPeerings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }


            if (this.BgpCommunities != null)
            {
                this.BgpCommunities.Validate();
            }
            if (this.Encryption != null)
            {
                this.Encryption.Validate();
            }




        }
    }
}