// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>The state of a private link service connection.</summary>
    public partial class PrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IPrivateLinkServiceConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IPrivateLinkServiceConnectionStateInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnectionState" /> instance.</summary>
        public PrivateLinkServiceConnectionState()
        {

        }
    }
    /// The state of a private link service connection.
    public partial interface IPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>The private link service connection description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link service connection description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link service connection status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Aks.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
    /// The state of a private link service connection.
    internal partial interface IPrivateLinkServiceConnectionStateInternal

    {
        /// <summary>The private link service connection description.</summary>
        string Description { get; set; }
        /// <summary>The private link service connection status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Aks.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
}