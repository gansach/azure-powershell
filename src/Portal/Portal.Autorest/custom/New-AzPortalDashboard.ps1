
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------


function New-AzPortalDashboard {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.IDashboard])]
[CmdletBinding(SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateByFile', Mandatory)]
    [Alias('DashboardName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Path')]
    [System.String]
    # The name of the dashboard.
    ${Name},

    [Parameter(ParameterSetName='CreateByFile', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CreateByFile')]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The Azure subscription ID.
    # This is a GUID-formatted string (e.g.
    # 00000000-0000-0000-0000-000000000000)
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateByFile', HelpMessage='The Path to an existing dashboard template. Dashboard templates may be downloaded from the portal.', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Body')]
    [ValidateNotNullOrEmpty()]
    [System.String]
    # The Path to an existing dashboard template.
    # Dashboard templates may be downloaded from the portal.
    ${DashboardPath},


    [Parameter(ParameterSetName='CreateByFile')]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(ParameterSetName='CreateByFile', DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(ParameterSetName='CreateByFile', DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='CreateByFile', DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='CreateByFile', DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(ParameterSetName='CreateByFile', DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(ParameterSetName='CreateByFile', DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Portal.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        if (-not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('Az.Portal.private\New-AzPortalDashboard_Create', [System.Management.Automation.CommandTypes]::Cmdlet);
        $dashboardPath = ($PSBoundParameters['DashboardPath']) | Resolve-Path | Convert-Path
        if (Test-Path $dashboardPath)
        {
            $content = (Get-content -Path $dashboardPath)
            $deserializedContent = [Microsoft.Azure.PowerShell.Cmdlets.Portal.Models.Dashboard]::FromJsonString($content)
            $PSBoundParameters.Remove('DashboardPath') | Out-Null
            $PSBoundParameters.Add('Resource', $deserializedContent) | Out-Null
            $scriptCmd = {& $wrappedCmd @PSBoundParameters}
            $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
            $steppablePipeline.Begin($PSCmdlet)
        }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
