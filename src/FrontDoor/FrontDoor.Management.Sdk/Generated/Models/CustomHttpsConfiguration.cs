// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// Https settings for a domain
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CustomHttpsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the CustomHttpsConfiguration class.
        /// </summary>
        public CustomHttpsConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomHttpsConfiguration class.
        /// </summary>

        /// <param name="certificateSource">Defines the source of the SSL certificate
        /// Possible values include: &#39;AzureKeyVault&#39;, &#39;FrontDoor&#39;</param>

        /// <param name="minimumTlsVersion">The minimum TLS version required from the clients to establish an SSL
        /// handshake with Front Door.
        /// Possible values include: &#39;1.0&#39;, &#39;1.2&#39;</param>

        /// <param name="vault">The Key Vault containing the SSL certificate
        /// </param>

        /// <param name="secretName">The name of the Key Vault secret representing the full certificate PFX
        /// </param>

        /// <param name="secretVersion">The version of the Key Vault secret representing the full certificate PFX
        /// </param>

        /// <param name="certificateType">Defines the type of the certificate used for secure connections to a
        /// frontendEndpoint
        /// Possible values include: &#39;Dedicated&#39;</param>
        public CustomHttpsConfiguration(string certificateSource, string minimumTlsVersion, KeyVaultCertificateSourceParametersVault vault = default(KeyVaultCertificateSourceParametersVault), string secretName = default(string), string secretVersion = default(string), string certificateType = default(string))

        {
            this.CertificateSource = certificateSource;
            this.MinimumTlsVersion = minimumTlsVersion;
            this.Vault = vault;
            this.SecretName = secretName;
            this.SecretVersion = secretVersion;
            this.CertificateType = certificateType;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CustomHttpsConfiguration class.
        /// </summary>
        static CustomHttpsConfiguration()
        {
            ProtocolType = "ServerNameIndication";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets defines the source of the SSL certificate Possible values include: &#39;AzureKeyVault&#39;, &#39;FrontDoor&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateSource")]
        public string CertificateSource {get; set; }

        /// <summary>
        /// Gets or sets the minimum TLS version required from the clients to establish
        /// an SSL handshake with Front Door. Possible values include: &#39;1.0&#39;, &#39;1.2&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minimumTlsVersion")]
        public string MinimumTlsVersion {get; set; }

        /// <summary>
        /// Gets or sets the Key Vault containing the SSL certificate
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultCertificateSourceParameters.vault")]
        public KeyVaultCertificateSourceParametersVault Vault {get; set; }

        /// <summary>
        /// Gets or sets the name of the Key Vault secret representing the full
        /// certificate PFX
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultCertificateSourceParameters.secretName")]
        public string SecretName {get; set; }

        /// <summary>
        /// Gets or sets the version of the Key Vault secret representing the full
        /// certificate PFX
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultCertificateSourceParameters.secretVersion")]
        public string SecretVersion {get; set; }

        /// <summary>
        /// Gets or sets defines the type of the certificate used for secure
        /// connections to a frontendEndpoint Possible values include: &#39;Dedicated&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frontDoorCertificateSourceParameters.certificateType")]
        public string CertificateType {get; set; }
        /// <summary>
        /// Gets or sets defines the TLS extension protocol that is used for secure delivery
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protocolType")]
        public static string ProtocolType {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.CertificateSource == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "CertificateSource");
            }
            if (this.MinimumTlsVersion == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MinimumTlsVersion");
            }







        }
    }
}