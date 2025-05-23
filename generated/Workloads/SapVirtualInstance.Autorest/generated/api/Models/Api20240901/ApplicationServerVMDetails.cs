// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Extensions;

    /// <summary>The Application Server VM Details.</summary>
    public partial class ApplicationServerVMDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IApplicationServerVMDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IApplicationServerVMDetailsInternal
    {

        /// <summary>Internal Acessors for StorageDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStorageInformation[] Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IApplicationServerVMDetailsInternal.StorageDetail { get => this._storageDetail; set { {_storageDetail = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.ApplicationServerVirtualMachineType? Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IApplicationServerVMDetailsInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Internal Acessors for VirtualMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IApplicationServerVMDetailsInternal.VirtualMachineId { get => this._virtualMachineId; set { {_virtualMachineId = value;} } }

        /// <summary>Backing field for <see cref="StorageDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStorageInformation[] _storageDetail;

        /// <summary>
        /// Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStorageInformation[] StorageDetail { get => this._storageDetail; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.ApplicationServerVirtualMachineType? _type;

        /// <summary>Defines the type of application server VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.ApplicationServerVirtualMachineType? Type { get => this._type; }

        /// <summary>Backing field for <see cref="VirtualMachineId" /> property.</summary>
        private string _virtualMachineId;

        /// <summary>The virtual machine id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.PropertyOrigin.Owned)]
        public string VirtualMachineId { get => this._virtualMachineId; }

        /// <summary>Creates an new <see cref="ApplicationServerVMDetails" /> instance.</summary>
        public ApplicationServerVMDetails()
        {

        }
    }
    /// The Application Server VM Details.
    public partial interface IApplicationServerVMDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.",
        SerializedName = @"storageDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStorageInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStorageInformation[] StorageDetail { get;  }
        /// <summary>Defines the type of application server VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Defines the type of application server VM.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.ApplicationServerVirtualMachineType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.ApplicationServerVirtualMachineType? Type { get;  }
        /// <summary>The virtual machine id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The virtual machine id.",
        SerializedName = @"virtualMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualMachineId { get;  }

    }
    /// The Application Server VM Details.
    internal partial interface IApplicationServerVMDetailsInternal

    {
        /// <summary>
        /// Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStorageInformation[] StorageDetail { get; set; }
        /// <summary>Defines the type of application server VM.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.ApplicationServerVirtualMachineType? Type { get; set; }
        /// <summary>The virtual machine id.</summary>
        string VirtualMachineId { get; set; }

    }
}