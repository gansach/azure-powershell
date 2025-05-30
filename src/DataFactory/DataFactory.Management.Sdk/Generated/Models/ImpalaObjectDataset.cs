// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Impala server dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ImpalaObject")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ImpalaObjectDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the ImpalaObjectDataset class.
        /// </summary>
        public ImpalaObjectDataset()
        {
            this.LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImpalaObjectDataset class.
        /// </summary>

        /// <param name="additionalProperties">The Azure Data Factory nested object which identifies data within different
        /// data stores, such as tables, files, folders, and documents.
        /// </param>

        /// <param name="description">Dataset description.
        /// </param>

        /// <param name="structure">Columns that define the structure of the dataset. Type: array (or
        /// Expression with resultType array), itemType: DatasetDataElement.
        /// </param>

        /// <param name="schema">Columns that define the physical type schema of the dataset. Type: array
        /// (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </param>

        /// <param name="linkedServiceName">Linked service reference.
        /// </param>

        /// <param name="parameters">Parameters for dataset.
        /// </param>

        /// <param name="annotations">List of tags that can be used for describing the Dataset.
        /// </param>

        /// <param name="folder">The folder that this Dataset is in. If not specified, Dataset will appear
        /// at the root level.
        /// </param>

        /// <param name="tableName">This property will be retired. Please consider using schema + table
        /// properties instead.
        /// </param>

        /// <param name="table">The table name of the Impala. Type: string (or Expression with resultType
        /// string).
        /// </param>

        /// <param name="typePropertiesSchema">The schema name of the Impala. Type: string (or Expression with resultType
        /// string).
        /// </param>
        public ImpalaObjectDataset(LinkedServiceReference linkedServiceName, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), object structure = default(object), object schema = default(object), System.Collections.Generic.IDictionary<string, ParameterSpecification> parameters = default(System.Collections.Generic.IDictionary<string, ParameterSpecification>), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>), DatasetFolder folder = default(DatasetFolder), object tableName = default(object), object table = default(object), object typePropertiesSchema = default(object))

        : base(linkedServiceName, additionalProperties, description, structure, schema, parameters, annotations, folder)
        {
            this.TableName = tableName;
            this.Table = table;
            this.TypePropertiesSchema = typePropertiesSchema;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets this property will be retired. Please consider using schema +
        /// table properties instead.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.tableName")]
        public object TableName {get; set; }

        /// <summary>
        /// Gets or sets the table name of the Impala. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.table")]
        public object Table {get; set; }

        /// <summary>
        /// Gets or sets the schema name of the Impala. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.schema")]
        public object TypePropertiesSchema {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();



        }
    }
}