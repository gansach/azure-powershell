// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Change key vault request
    /// </summary>
    public partial class ChangeKeyVault
    {
        /// <summary>
        /// Initializes a new instance of the ChangeKeyVault class.
        /// </summary>
        public ChangeKeyVault()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangeKeyVault class.
        /// </summary>

        /// <param name="keyVaultUri">The URI of the key vault/managed HSM that should be used for encryption.
        /// </param>

        /// <param name="keyName">The name of the key that should be used for encryption.
        /// </param>

        /// <param name="keyVaultResourceId">Azure resource ID of the key vault/managed HSM that should be used for
        /// encryption.
        /// </param>

        /// <param name="keyVaultPrivateEndpoints">Pairs of virtual network ID and private endpoint ID. Every virtual network
        /// that has volumes encrypted with customer-managed keys needs its own key
        /// vault private endpoint.
        /// </param>
        public ChangeKeyVault(string keyVaultUri, string keyName, System.Collections.Generic.IList<KeyVaultPrivateEndpoint> keyVaultPrivateEndpoints, string keyVaultResourceId = default(string))

        {
            this.KeyVaultUri = keyVaultUri;
            this.KeyName = keyName;
            this.KeyVaultResourceId = keyVaultResourceId;
            this.KeyVaultPrivateEndpoints = keyVaultPrivateEndpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the URI of the key vault/managed HSM that should be used for
        /// encryption.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultUri")]
        public string KeyVaultUri {get; set; }

        /// <summary>
        /// Gets or sets the name of the key that should be used for encryption.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyName")]
        public string KeyName {get; set; }

        /// <summary>
        /// Gets or sets azure resource ID of the key vault/managed HSM that should be
        /// used for encryption.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultResourceId")]
        public string KeyVaultResourceId {get; set; }

        /// <summary>
        /// Gets or sets pairs of virtual network ID and private endpoint ID. Every
        /// virtual network that has volumes encrypted with customer-managed keys needs
        /// its own key vault private endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultPrivateEndpoints")]
        public System.Collections.Generic.IList<KeyVaultPrivateEndpoint> KeyVaultPrivateEndpoints {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.KeyVaultUri == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KeyVaultUri");
            }
            if (this.KeyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KeyName");
            }
            if (this.KeyVaultPrivateEndpoints == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KeyVaultPrivateEndpoints");
            }




        }
    }
}