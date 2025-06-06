// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{

    /// <summary>
    /// Defines values for ActivationStatus.
    /// </summary>


    public static class ActivationStatus
    {
        /// <summary>
        /// The managed HSM Pool is active.
        /// </summary>
        public const string Active = "Active";
        /// <summary>
        /// The managed HSM Pool is not yet activated.
        /// </summary>
        public const string NotActivated = "NotActivated";
        /// <summary>
        /// An unknown error occurred while activating managed hsm.
        /// </summary>
        public const string Unknown = "Unknown";
        /// <summary>
        /// Failed to activate managed hsm.
        /// </summary>
        public const string Failed = "Failed";
    }
}