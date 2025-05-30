﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    using System;
    using System.Collections;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Attributes;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Components;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation.CmdletBase;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels.Deployments;
    using Microsoft.Azure.Commands.ResourceManager.Common;
    using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
    using Microsoft.Azure.Management.Resources.Models;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;

    /// <summary>
    /// Creates a new deployment.
    /// </summary>
    [Cmdlet(VerbsCommon.New, AzureRMConstants.AzureRMPrefix + "Deployment", SupportsShouldProcess = true,
        DefaultParameterSetName = ParameterlessTemplateFileParameterSetName), OutputType(typeof(PSDeployment))]
    [Alias("New-AzSubscriptionDeployment")]
    public class NewAzureSubscriptionDeploymentCmdlet : DeploymentCreateCmdlet
    {
        [Alias("DeploymentName")]
        [Parameter(Mandatory = false,
            HelpMessage = "The name of the deployment it's going to create. If not specified, defaults to the template file name when a template file is provided; defaults to the current time when a template object is provided, e.g. \"20131223140835\".")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The location to store deployment data.")]
        [LocationCompleter("Microsoft.Resources/resourceGroups")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The deployment debug log level.")]
        [PSArgumentCompleter("RequestContent", "ResponseContent", "All", "None")]
        public string DeploymentDebugLogLevel { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The tags to put on the deployment.")]
        [ValidateNotNullOrEmpty]
        public Hashtable Tag { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The What-If result format. Applicable when the -WhatIf or -Confirm switch is set.")]
        public WhatIfResultFormat WhatIfResultFormat { get; set; } = WhatIfResultFormat.FullResourcePayloads;

        [Parameter(Mandatory = false, HelpMessage = "Comma-separated resource change types to be excluded from What-If results. Applicable when the -WhatIf or -Confirm switch is set.")]
        [ChangeTypeCompleter]
        [ValidateChangeTypes]
        public string[] WhatIfExcludeChangeType { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation if there is no changes in the What-If result. Applicable when the -Confirm switch is set.")]
        public SwitchParameter ProceedIfNoChange { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        protected override ConfirmImpact ConfirmImpact => ((CmdletAttribute)Attribute.GetCustomAttribute(
            typeof(NewAzureSubscriptionDeploymentCmdlet),
            typeof(CmdletAttribute))).ConfirmImpact;

        protected override PSDeploymentCmdletParameters BuildDeploymentParameters() => new PSDeploymentCmdletParameters()
        {
            ScopeType = DeploymentScopeType.Subscription,
            Location = this.Location,
            DeploymentName = this.Name,
            DeploymentMode = DeploymentMode.Incremental,
            TemplateFile = this.TemplateUri ?? this.TryResolvePath(this.TemplateFile),
            TemplateObject = this.TemplateObject,
            TemplateSpecId = TemplateSpecId,
            QueryString = QueryString,
            TemplateParameterObject = this.GetTemplateParameterObject(),
            ParameterUri = this.TemplateParameterUri,
            DeploymentDebugLogLevel = this.GetDeploymentDebugLogLevel(this.DeploymentDebugLogLevel),
            Tags = TagsHelper.ConvertToTagsDictionary(this.Tag)
        };

        protected override PSDeploymentWhatIfCmdletParameters BuildWhatIfParameters() => new PSDeploymentWhatIfCmdletParameters(
            DeploymentScopeType.Subscription,
            deploymentName: this.Name,
            location: this.Location,
            mode: DeploymentMode.Incremental,
            templateUri: TemplateUri ?? this.TryResolvePath(TemplateFile),
            templateObject: this.TemplateObject,
            templateSpecId: TemplateSpecId,
            queryString: QueryString,
            templateParametersUri: this.TemplateParameterUri,
            templateParametersObject: GetTemplateParameterObject(),
            resultFormat: this.WhatIfResultFormat,
            excludeChangeTypes: this.WhatIfExcludeChangeType,
            validationLevel: this.ValidationLevel);

        protected override bool ShouldSkipConfirmationIfNoChange() => this.ProceedIfNoChange;
    }
}
