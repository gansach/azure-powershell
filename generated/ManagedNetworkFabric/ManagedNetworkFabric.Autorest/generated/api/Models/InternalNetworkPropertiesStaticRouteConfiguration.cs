// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Static Route Configuration properties.</summary>
    public partial class InternalNetworkPropertiesStaticRouteConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IInternalNetworkPropertiesStaticRouteConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IInternalNetworkPropertiesStaticRouteConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExtensionEnumProperty"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExtensionEnumProperty __extensionEnumProperty = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExtensionEnumProperty();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfiguration"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfiguration __staticRouteConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.StaticRouteConfiguration();

        /// <summary>BFD configuration properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IBfdConfiguration BfdConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal)__staticRouteConfiguration).BfdConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal)__staticRouteConfiguration).BfdConfiguration = value ?? null /* model class */; }

        /// <summary>Extension. Example: NoExtension | NPB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string Extension { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExtensionEnumPropertyInternal)__extensionEnumProperty).Extension; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExtensionEnumPropertyInternal)__extensionEnumProperty).Extension = value ?? null; }

        /// <summary>List of IPv4 Routes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteProperties> Ipv4Route { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal)__staticRouteConfiguration).Ipv4Route; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal)__staticRouteConfiguration).Ipv4Route = value ?? null /* arrayOf */; }

        /// <summary>List of IPv6 Routes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteProperties> Ipv6Route { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal)__staticRouteConfiguration).Ipv6Route; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal)__staticRouteConfiguration).Ipv6Route = value ?? null /* arrayOf */; }

        /// <summary>
        /// Creates an new <see cref="InternalNetworkPropertiesStaticRouteConfiguration" /> instance.
        /// </summary>
        public InternalNetworkPropertiesStaticRouteConfiguration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__staticRouteConfiguration), __staticRouteConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__staticRouteConfiguration), __staticRouteConfiguration);
            await eventListener.AssertNotNull(nameof(__extensionEnumProperty), __extensionEnumProperty);
            await eventListener.AssertObjectIsValid(nameof(__extensionEnumProperty), __extensionEnumProperty);
        }
    }
    /// Static Route Configuration properties.
    public partial interface IInternalNetworkPropertiesStaticRouteConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExtensionEnumProperty
    {

    }
    /// Static Route Configuration properties.
    internal partial interface IInternalNetworkPropertiesStaticRouteConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IStaticRouteConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExtensionEnumPropertyInternal
    {

    }
}