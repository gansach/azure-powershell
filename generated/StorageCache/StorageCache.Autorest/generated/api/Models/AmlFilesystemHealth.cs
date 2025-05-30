// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Extensions;

    /// <summary>
    /// An indication of AML file system health. Gives more information about health than just that related to provisioning.
    /// </summary>
    public partial class AmlFilesystemHealth :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IAmlFilesystemHealth,
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.IAmlFilesystemHealthInternal
    {

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>List of AML file system health states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StatusCode" /> property.</summary>
        private string _statusCode;

        /// <summary>Server-defined error code for the AML file system health</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string StatusCode { get => this._statusCode; set => this._statusCode = value; }

        /// <summary>Backing field for <see cref="StatusDescription" /> property.</summary>
        private string _statusDescription;

        /// <summary>Describes the health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PropertyOrigin.Owned)]
        public string StatusDescription { get => this._statusDescription; set => this._statusDescription = value; }

        /// <summary>Creates an new <see cref="AmlFilesystemHealth" /> instance.</summary>
        public AmlFilesystemHealth()
        {

        }
    }
    /// An indication of AML file system health. Gives more information about health than just that related to provisioning.
    public partial interface IAmlFilesystemHealth :
        Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.IJsonSerializable
    {
        /// <summary>List of AML file system health states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of AML file system health states.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PSArgumentCompleterAttribute("Unavailable", "Available", "Degraded", "Transitioning", "Maintenance")]
        string State { get; set; }
        /// <summary>Server-defined error code for the AML file system health</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server-defined error code for the AML file system health",
        SerializedName = @"statusCode",
        PossibleTypes = new [] { typeof(string) })]
        string StatusCode { get; set; }
        /// <summary>Describes the health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Describes the health state.",
        SerializedName = @"statusDescription",
        PossibleTypes = new [] { typeof(string) })]
        string StatusDescription { get; set; }

    }
    /// An indication of AML file system health. Gives more information about health than just that related to provisioning.
    internal partial interface IAmlFilesystemHealthInternal

    {
        /// <summary>List of AML file system health states.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StorageCache.PSArgumentCompleterAttribute("Unavailable", "Available", "Degraded", "Transitioning", "Maintenance")]
        string State { get; set; }
        /// <summary>Server-defined error code for the AML file system health</summary>
        string StatusCode { get; set; }
        /// <summary>Describes the health state.</summary>
        string StatusDescription { get; set; }

    }
}