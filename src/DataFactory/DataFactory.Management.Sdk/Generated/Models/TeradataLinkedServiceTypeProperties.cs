// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Teradata linked service properties.
    /// </summary>
    public partial class TeradataLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the TeradataLinkedServiceTypeProperties class.
        /// </summary>
        public TeradataLinkedServiceTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeradataLinkedServiceTypeProperties class.
        /// </summary>

        /// <param name="connectionString">Teradata ODBC connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference. Only applied for version 1.0.
        /// </param>

        /// <param name="server">Server name for connection. Type: string (or Expression with resultType
        /// string).
        /// </param>

        /// <param name="authenticationType">AuthenticationType to be used for connection.
        /// Possible values include: &#39;Basic&#39;, &#39;Windows&#39;</param>

        /// <param name="username">Username for authentication. Type: string (or Expression with resultType
        /// string).
        /// </param>

        /// <param name="password">Password for authentication.
        /// </param>

        /// <param name="sslMode">SSL mode for connection. Valid values including: “Disable”, “Allow”,
        /// “Prefer”, “Require”, “Verify-CA”, “Verify-Full”. Default value is
        /// “Verify-Full”. Type: string (or Expression with resultType string). Only
        /// applied for version 2.0.
        /// </param>

        /// <param name="portNumber">The port numbers when connecting to server through non HTTPS/TLS
        /// connections. Type: integer (or Expression with resultType integer). Only
        /// used for V2. Only applied for version 2.0.
        /// </param>

        /// <param name="httpsPortNumber">The port numbers when connecting to server through HTTPS/TLS connections.
        /// Type: integer (or Expression with resultType integer). Only applied for
        /// version 2.0.
        /// </param>

        /// <param name="useDataEncryption">Specifies whether to encrypt all communication with the Teradata database.
        /// Allowed values are 0 or 1. This setting will be ignored for HTTPS/TLS
        /// connections. Type: integer (or Expression with resultType integer). Only
        /// applied for version 2.0.
        /// </param>

        /// <param name="characterSet">The character set to use for the connection. Type: string (or Expression
        /// with resultType string). Only applied for version 2.0.
        /// </param>

        /// <param name="maxRespSize">The maximum size of the response buffer for SQL requests, in bytes. Type:
        /// integer. Only applied for version 2.0.
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public TeradataLinkedServiceTypeProperties(object connectionString = default(object), object server = default(object), string authenticationType = default(string), object username = default(object), SecretBase password = default(SecretBase), object sslMode = default(object), object portNumber = default(object), object httpsPortNumber = default(object), object useDataEncryption = default(object), object characterSet = default(object), object maxRespSize = default(object), string encryptedCredential = default(string))

        {
            this.ConnectionString = connectionString;
            this.Server = server;
            this.AuthenticationType = authenticationType;
            this.Username = username;
            this.Password = password;
            this.SslMode = sslMode;
            this.PortNumber = portNumber;
            this.HttpsPortNumber = httpsPortNumber;
            this.UseDataEncryption = useDataEncryption;
            this.CharacterSet = characterSet;
            this.MaxRespSize = maxRespSize;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets teradata ODBC connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference. Only applied for version 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "connectionString")]
        public object ConnectionString {get; set; }

        /// <summary>
        /// Gets or sets server name for connection. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "server")]
        public object Server {get; set; }

        /// <summary>
        /// Gets or sets authenticationType to be used for connection. Possible values include: &#39;Basic&#39;, &#39;Windows&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType {get; set; }

        /// <summary>
        /// Gets or sets username for authentication. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "username")]
        public object Username {get; set; }

        /// <summary>
        /// Gets or sets password for authentication.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public SecretBase Password {get; set; }

        /// <summary>
        /// Gets or sets sSL mode for connection. Valid values including: “Disable”,
        /// “Allow”, “Prefer”, “Require”, “Verify-CA”, “Verify-Full”. Default value is
        /// “Verify-Full”. Type: string (or Expression with resultType string). Only
        /// applied for version 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sslMode")]
        public object SslMode {get; set; }

        /// <summary>
        /// Gets or sets the port numbers when connecting to server through non
        /// HTTPS/TLS connections. Type: integer (or Expression with resultType
        /// integer). Only used for V2. Only applied for version 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "portNumber")]
        public object PortNumber {get; set; }

        /// <summary>
        /// Gets or sets the port numbers when connecting to server through HTTPS/TLS
        /// connections. Type: integer (or Expression with resultType integer). Only
        /// applied for version 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "httpsPortNumber")]
        public object HttpsPortNumber {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to encrypt all communication with the
        /// Teradata database. Allowed values are 0 or 1. This setting will be ignored
        /// for HTTPS/TLS connections. Type: integer (or Expression with resultType
        /// integer). Only applied for version 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "useDataEncryption")]
        public object UseDataEncryption {get; set; }

        /// <summary>
        /// Gets or sets the character set to use for the connection. Type: string (or
        /// Expression with resultType string). Only applied for version 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "characterSet")]
        public object CharacterSet {get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the response buffer for SQL requests, in
        /// bytes. Type: integer. Only applied for version 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxRespSize")]
        public object MaxRespSize {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedCredential")]
        public string EncryptedCredential {get; set; }
    }
}