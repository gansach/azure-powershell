// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics
    /// pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.
    /// </summary>
    public partial class ManagedClusterAzureMonitorProfileKubeStateMetrics :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAzureMonitorProfileKubeStateMetrics,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAzureMonitorProfileKubeStateMetricsInternal
    {

        /// <summary>Backing field for <see cref="MetricAnnotationsAllowList" /> property.</summary>
        private string _metricAnnotationsAllowList;

        /// <summary>
        /// Comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric (Example: 'namespaces=[kubernetes.io/team,...],pods=[kubernetes.io/team],...').
        /// By default the metric contains only resource name and namespace labels.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string MetricAnnotationsAllowList { get => this._metricAnnotationsAllowList; set => this._metricAnnotationsAllowList = value; }

        /// <summary>Backing field for <see cref="MetricLabelsAllowlist" /> property.</summary>
        private string _metricLabelsAllowlist;

        /// <summary>
        /// Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric (Example: 'namespaces=[k8s-label-1,k8s-label-n,...],pods=[app],...').
        /// By default the metric contains only resource name and namespace labels.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string MetricLabelsAllowlist { get => this._metricLabelsAllowlist; set => this._metricLabelsAllowlist = value; }

        /// <summary>
        /// Creates an new <see cref="ManagedClusterAzureMonitorProfileKubeStateMetrics" /> instance.
        /// </summary>
        public ManagedClusterAzureMonitorProfileKubeStateMetrics()
        {

        }
    }
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics
    /// pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.
    public partial interface IManagedClusterAzureMonitorProfileKubeStateMetrics :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric (Example: 'namespaces=[kubernetes.io/team,...],pods=[kubernetes.io/team],...').
        /// By default the metric contains only resource name and namespace labels.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric (Example: 'namespaces=[kubernetes.io/team,...],pods=[kubernetes.io/team],...'). By default the metric contains only resource name and namespace labels.",
        SerializedName = @"metricAnnotationsAllowList",
        PossibleTypes = new [] { typeof(string) })]
        string MetricAnnotationsAllowList { get; set; }
        /// <summary>
        /// Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric (Example: 'namespaces=[k8s-label-1,k8s-label-n,...],pods=[app],...').
        /// By default the metric contains only resource name and namespace labels.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric (Example: 'namespaces=[k8s-label-1,k8s-label-n,...],pods=[app],...'). By default the metric contains only resource name and namespace labels.",
        SerializedName = @"metricLabelsAllowlist",
        PossibleTypes = new [] { typeof(string) })]
        string MetricLabelsAllowlist { get; set; }

    }
    /// Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics
    /// pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.
    internal partial interface IManagedClusterAzureMonitorProfileKubeStateMetricsInternal

    {
        /// <summary>
        /// Comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric (Example: 'namespaces=[kubernetes.io/team,...],pods=[kubernetes.io/team],...').
        /// By default the metric contains only resource name and namespace labels.
        /// </summary>
        string MetricAnnotationsAllowList { get; set; }
        /// <summary>
        /// Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric (Example: 'namespaces=[k8s-label-1,k8s-label-n,...],pods=[app],...').
        /// By default the metric contains only resource name and namespace labels.
        /// </summary>
        string MetricLabelsAllowlist { get; set; }

    }
}