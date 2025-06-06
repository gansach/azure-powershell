// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Hive Server linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Hive")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class HiveLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the HiveLinkedService class.
        /// </summary>
        public HiveLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HiveLinkedService class.
        /// </summary>

        /// <param name="additionalProperties">The nested object which contains the information and credential which can
        /// be used to connect with related store or compute resource.
        /// </param>

        /// <param name="version">Version of the linked service.
        /// </param>

        /// <param name="connectVia">The integration runtime reference.
        /// </param>

        /// <param name="description">Linked service description.
        /// </param>

        /// <param name="parameters">Parameters for linked service.
        /// </param>

        /// <param name="annotations">List of tags that can be used for describing the linked service.
        /// </param>

        /// <param name="host">IP address or host name of the Hive server, separated by &#39;;&#39; for multiple
        /// hosts (only when serviceDiscoveryMode is enable).
        /// </param>

        /// <param name="port">The TCP port that the Hive server uses to listen for client connections.
        /// </param>

        /// <param name="serverType">The type of Hive server.
        /// Possible values include: &#39;HiveServer1&#39;, &#39;HiveServer2&#39;, &#39;HiveThriftServer&#39;</param>

        /// <param name="thriftTransportProtocol">The transport protocol to use in the Thrift layer.
        /// Possible values include: &#39;Binary&#39;, &#39;SASL&#39;, &#39;HTTP &#39;</param>

        /// <param name="authenticationType">The authentication method used to access the Hive server.
        /// Possible values include: &#39;Anonymous&#39;, &#39;Username&#39;, &#39;UsernameAndPassword&#39;,
        /// &#39;WindowsAzureHDInsightService&#39;</param>

        /// <param name="serviceDiscoveryMode">true to indicate using the ZooKeeper service, false not.
        /// </param>

        /// <param name="zooKeeperNameSpace">The namespace on ZooKeeper under which Hive Server 2 nodes are added.
        /// </param>

        /// <param name="useNativeQuery">Specifies whether the driver uses native HiveQL queries,or converts them
        /// into an equivalent form in HiveQL.
        /// </param>

        /// <param name="username">The user name that you use to access Hive Server.
        /// </param>

        /// <param name="password">The password corresponding to the user name that you provided in the
        /// Username field
        /// </param>

        /// <param name="httpPath">The partial URL corresponding to the Hive server.
        /// </param>

        /// <param name="enableSsl">Specifies whether the connections to the server are encrypted using SSL.
        /// The default value is false.
        /// </param>

        /// <param name="enableServerCertificateValidation">Specifies whether the connections to the server will validate server
        /// certificate, the default value is True. Only used for Version 2.0
        /// </param>

        /// <param name="trustedCertPath">The full path of the .pem file containing trusted CA certificates for
        /// verifying the server when connecting over SSL. This property can only be
        /// set when using SSL on self-hosted IR. The default value is the cacerts.pem
        /// file installed with the IR.
        /// </param>

        /// <param name="useSystemTrustStore">Specifies whether to use a CA certificate from the system trust store or
        /// from a specified PEM file. The default value is false.
        /// </param>

        /// <param name="allowHostNameCnMismatch">Specifies whether to require a CA-issued SSL certificate name to match the
        /// host name of the server when connecting over SSL. The default value is
        /// false.
        /// </param>

        /// <param name="allowSelfSignedServerCert">Specifies whether to allow self-signed certificates from the server. The
        /// default value is false.
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public HiveLinkedService(object host, string authenticationType, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string version = default(string), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), System.Collections.Generic.IDictionary<string, ParameterSpecification> parameters = default(System.Collections.Generic.IDictionary<string, ParameterSpecification>), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>), object port = default(object), string serverType = default(string), string thriftTransportProtocol = default(string), object serviceDiscoveryMode = default(object), object zooKeeperNameSpace = default(object), object useNativeQuery = default(object), object username = default(object), SecretBase password = default(SecretBase), object httpPath = default(object), object enableSsl = default(object), object enableServerCertificateValidation = default(object), object trustedCertPath = default(object), object useSystemTrustStore = default(object), object allowHostNameCnMismatch = default(object), object allowSelfSignedServerCert = default(object), string encryptedCredential = default(string))

        : base(additionalProperties, version, connectVia, description, parameters, annotations)
        {
            this.Host = host;
            this.Port = port;
            this.ServerType = serverType;
            this.ThriftTransportProtocol = thriftTransportProtocol;
            this.AuthenticationType = authenticationType;
            this.ServiceDiscoveryMode = serviceDiscoveryMode;
            this.ZooKeeperNameSpace = zooKeeperNameSpace;
            this.UseNativeQuery = useNativeQuery;
            this.Username = username;
            this.Password = password;
            this.HttpPath = httpPath;
            this.EnableSsl = enableSsl;
            this.EnableServerCertificateValidation = enableServerCertificateValidation;
            this.TrustedCertPath = trustedCertPath;
            this.UseSystemTrustStore = useSystemTrustStore;
            this.AllowHostNameCnMismatch = allowHostNameCnMismatch;
            this.AllowSelfSignedServerCert = allowSelfSignedServerCert;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets iP address or host name of the Hive server, separated by &#39;;&#39;
        /// for multiple hosts (only when serviceDiscoveryMode is enable).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.host")]
        public object Host {get; set; }

        /// <summary>
        /// Gets or sets the TCP port that the Hive server uses to listen for client
        /// connections.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.port")]
        public object Port {get; set; }

        /// <summary>
        /// Gets or sets the type of Hive server. Possible values include: &#39;HiveServer1&#39;, &#39;HiveServer2&#39;, &#39;HiveThriftServer&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.serverType")]
        public string ServerType {get; set; }

        /// <summary>
        /// Gets or sets the transport protocol to use in the Thrift layer. Possible values include: &#39;Binary&#39;, &#39;SASL&#39;, &#39;HTTP &#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.thriftTransportProtocol")]
        public string ThriftTransportProtocol {get; set; }

        /// <summary>
        /// Gets or sets the authentication method used to access the Hive server. Possible values include: &#39;Anonymous&#39;, &#39;Username&#39;, &#39;UsernameAndPassword&#39;, &#39;WindowsAzureHDInsightService&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType {get; set; }

        /// <summary>
        /// Gets or sets true to indicate using the ZooKeeper service, false not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.serviceDiscoveryMode")]
        public object ServiceDiscoveryMode {get; set; }

        /// <summary>
        /// Gets or sets the namespace on ZooKeeper under which Hive Server 2 nodes are
        /// added.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.zooKeeperNameSpace")]
        public object ZooKeeperNameSpace {get; set; }

        /// <summary>
        /// Gets or sets specifies whether the driver uses native HiveQL queries,or
        /// converts them into an equivalent form in HiveQL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.useNativeQuery")]
        public object UseNativeQuery {get; set; }

        /// <summary>
        /// Gets or sets the user name that you use to access Hive Server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.username")]
        public object Username {get; set; }

        /// <summary>
        /// Gets or sets the password corresponding to the user name that you provided
        /// in the Username field
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password {get; set; }

        /// <summary>
        /// Gets or sets the partial URL corresponding to the Hive server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.httpPath")]
        public object HttpPath {get; set; }

        /// <summary>
        /// Gets or sets specifies whether the connections to the server are encrypted
        /// using SSL. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.enableSsl")]
        public object EnableSsl {get; set; }

        /// <summary>
        /// Gets or sets specifies whether the connections to the server will validate
        /// server certificate, the default value is True. Only used for Version 2.0
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.enableServerCertificateValidation")]
        public object EnableServerCertificateValidation {get; set; }

        /// <summary>
        /// Gets or sets the full path of the .pem file containing trusted CA
        /// certificates for verifying the server when connecting over SSL. This
        /// property can only be set when using SSL on self-hosted IR. The default
        /// value is the cacerts.pem file installed with the IR.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.trustedCertPath")]
        public object TrustedCertPath {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use a CA certificate from the system
        /// trust store or from a specified PEM file. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.useSystemTrustStore")]
        public object UseSystemTrustStore {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require a CA-issued SSL certificate name
        /// to match the host name of the server when connecting over SSL. The default
        /// value is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.allowHostNameCNMismatch")]
        public object AllowHostNameCnMismatch {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to allow self-signed certificates from the
        /// server. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.allowSelfSignedServerCert")]
        public object AllowSelfSignedServerCert {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Host == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Host");
            }
            if (this.AuthenticationType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AuthenticationType");
            }


















        }
    }
}