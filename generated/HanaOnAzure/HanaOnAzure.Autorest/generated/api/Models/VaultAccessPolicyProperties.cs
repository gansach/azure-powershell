// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Extensions;

    /// <summary>Properties of the vault access policy</summary>
    public partial class VaultAccessPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultAccessPolicyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IVaultAccessPolicyPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AccessPolicy" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry> _accessPolicy;

        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry> AccessPolicy { get => this._accessPolicy; set => this._accessPolicy = value; }

        /// <summary>Creates an new <see cref="VaultAccessPolicyProperties" /> instance.</summary>
        public VaultAccessPolicyProperties()
        {

        }
    }
    /// Properties of the vault access policy
    public partial interface IVaultAccessPolicyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IJsonSerializable
    {
        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID.",
        SerializedName = @"accessPolicies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry> AccessPolicy { get; set; }

    }
    /// Properties of the vault access policy
    internal partial interface IVaultAccessPolicyPropertiesInternal

    {
        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.IAccessPolicyEntry> AccessPolicy { get; set; }

    }
}