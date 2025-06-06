// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
    public partial class MetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricSpecificationInternal
    {

        /// <summary>Backing field for <see cref="AggregationType" /> property.</summary>
        private string _aggregationType;

        /// <summary>
        /// Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string AggregationType { get => this._aggregationType; set => this._aggregationType = value; }

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// Name of the metric category that the metric belongs to. A metric can only belong to a single category.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Dimension" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricDimension> _dimension;

        /// <summary>Dimensions of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricDimension> Dimension { get => this._dimension; set => this._dimension = value; }

        /// <summary>Backing field for <see cref="DisplayDescription" /> property.</summary>
        private string _displayDescription;

        /// <summary>Localized friendly description of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string DisplayDescription { get => this._displayDescription; set => this._displayDescription = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Localized friendly display name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="FillGapWithZero" /> property.</summary>
        private bool? _fillGapWithZero;

        /// <summary>
        /// Optional. If set to true, then zero will be returned for time duration where no metric is emitted/published.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public bool? FillGapWithZero { get => this._fillGapWithZero; set => this._fillGapWithZero = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SourceMdmNamespace" /> property.</summary>
        private string _sourceMdmNamespace;

        /// <summary>Name of the MDM namespace. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string SourceMdmNamespace { get => this._sourceMdmNamespace; set => this._sourceMdmNamespace = value; }

        /// <summary>Backing field for <see cref="SupportedAggregationType" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedAggregationType;

        /// <summary>Supported aggregation types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedAggregationType { get => this._supportedAggregationType; set => this._supportedAggregationType = value; }

        /// <summary>Backing field for <see cref="SupportedTimeGrainType" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedTimeGrainType;

        /// <summary>Supported time grain types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedTimeGrainType { get => this._supportedTimeGrainType; set => this._supportedTimeGrainType = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>Unit that makes sense for the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="MetricSpecification" /> instance.</summary>
        public MetricSpecification()
        {

        }
    }
    /// Specifications of the Metrics for Azure Monitoring
    public partial interface IMetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.",
        SerializedName = @"aggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string AggregationType { get; set; }
        /// <summary>
        /// Name of the metric category that the metric belongs to. A metric can only belong to a single category.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the metric category that the metric belongs to. A metric can only belong to a single category.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>Dimensions of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dimensions of the metric",
        SerializedName = @"dimensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricDimension) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricDimension> Dimension { get; set; }
        /// <summary>Localized friendly description of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Localized friendly description of the metric",
        SerializedName = @"displayDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Localized friendly display name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Localized friendly display name of the metric",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Optional. If set to true, then zero will be returned for time duration where no metric is emitted/published.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional. If set to true, then zero will be returned for time duration where no metric is emitted/published.",
        SerializedName = @"fillGapWithZero",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FillGapWithZero { get; set; }
        /// <summary>Name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the metric",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Name of the MDM namespace. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the MDM namespace. Optional.",
        SerializedName = @"sourceMdmNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string SourceMdmNamespace { get; set; }
        /// <summary>Supported aggregation types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supported aggregation types",
        SerializedName = @"supportedAggregationTypes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedAggregationType { get; set; }
        /// <summary>Supported time grain types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supported time grain types",
        SerializedName = @"supportedTimeGrainTypes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedTimeGrainType { get; set; }
        /// <summary>Unit that makes sense for the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unit that makes sense for the metric",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// Specifications of the Metrics for Azure Monitoring
    internal partial interface IMetricSpecificationInternal

    {
        /// <summary>
        /// Only provide one value for this field. Valid values: Average, Minimum, Maximum, Total, Count.
        /// </summary>
        string AggregationType { get; set; }
        /// <summary>
        /// Name of the metric category that the metric belongs to. A metric can only belong to a single category.
        /// </summary>
        string Category { get; set; }
        /// <summary>Dimensions of the metric</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IMetricDimension> Dimension { get; set; }
        /// <summary>Localized friendly description of the metric</summary>
        string DisplayDescription { get; set; }
        /// <summary>Localized friendly display name of the metric</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Optional. If set to true, then zero will be returned for time duration where no metric is emitted/published.
        /// </summary>
        bool? FillGapWithZero { get; set; }
        /// <summary>Name of the metric</summary>
        string Name { get; set; }
        /// <summary>Name of the MDM namespace. Optional.</summary>
        string SourceMdmNamespace { get; set; }
        /// <summary>Supported aggregation types</summary>
        System.Collections.Generic.List<string> SupportedAggregationType { get; set; }
        /// <summary>Supported time grain types</summary>
        System.Collections.Generic.List<string> SupportedTimeGrainType { get; set; }
        /// <summary>Unit that makes sense for the metric</summary>
        string Unit { get; set; }

    }
}