// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// The SAS URIs of the console screenshot and serial log blobs.
    /// </summary>
    public partial class RetrieveBootDiagnosticsDataResult
    {
        /// <summary>
        /// Initializes a new instance of the RetrieveBootDiagnosticsDataResult class.
        /// </summary>
        public RetrieveBootDiagnosticsDataResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetrieveBootDiagnosticsDataResult class.
        /// </summary>

        /// <param name="consoleScreenshotBlobUri">The console screenshot blob URI
        /// </param>

        /// <param name="serialConsoleLogBlobUri">The serial console log blob URI.
        /// </param>
        public RetrieveBootDiagnosticsDataResult(string consoleScreenshotBlobUri = default(string), string serialConsoleLogBlobUri = default(string))

        {
            this.ConsoleScreenshotBlobUri = consoleScreenshotBlobUri;
            this.SerialConsoleLogBlobUri = serialConsoleLogBlobUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the console screenshot blob URI
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "consoleScreenshotBlobUri")]
        public string ConsoleScreenshotBlobUri {get; private set; }

        /// <summary>
        /// Gets the serial console log blob URI.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serialConsoleLogBlobUri")]
        public string SerialConsoleLogBlobUri {get; private set; }
    }
}