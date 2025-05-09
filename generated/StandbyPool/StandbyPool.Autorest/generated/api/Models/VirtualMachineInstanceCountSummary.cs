// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Contains the counts of VMs in each power state in a given zone, fault domain, as known by the StandbyPool resource provider.
    /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
    /// </summary>
    public partial class VirtualMachineInstanceCountSummary :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummaryInternal
    {

        /// <summary>Backing field for <see cref="InstanceCountsByState" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolVirtualMachineStateCount> _instanceCountsByState;

        /// <summary>The count of pooled virtual machines in each state for the given zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolVirtualMachineStateCount> InstanceCountsByState { get => this._instanceCountsByState; set => this._instanceCountsByState = value; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private long? _zone;

        /// <summary>
        /// The zone that the provided counts are in. It will not have a value if zones are not enabled on the attached VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long? Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Creates an new <see cref="VirtualMachineInstanceCountSummary" /> instance.</summary>
        public VirtualMachineInstanceCountSummary()
        {

        }
    }
    /// Contains the counts of VMs in each power state in a given zone, fault domain, as known by the StandbyPool resource provider.
    /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
    public partial interface IVirtualMachineInstanceCountSummary :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>The count of pooled virtual machines in each state for the given zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of pooled virtual machines in each state for the given zone.",
        SerializedName = @"instanceCountsByState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolVirtualMachineStateCount) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolVirtualMachineStateCount> InstanceCountsByState { get; set; }
        /// <summary>
        /// The zone that the provided counts are in. It will not have a value if zones are not enabled on the attached VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The zone that the provided counts are in. It will not have a value if zones are not enabled on the attached VMSS.",
        SerializedName = @"zone",
        PossibleTypes = new [] { typeof(long) })]
        long? Zone { get; set; }

    }
    /// Contains the counts of VMs in each power state in a given zone, fault domain, as known by the StandbyPool resource provider.
    /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
    internal partial interface IVirtualMachineInstanceCountSummaryInternal

    {
        /// <summary>The count of pooled virtual machines in each state for the given zone.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolVirtualMachineStateCount> InstanceCountsByState { get; set; }
        /// <summary>
        /// The zone that the provided counts are in. It will not have a value if zones are not enabled on the attached VMSS.
        /// </summary>
        long? Zone { get; set; }

    }
}