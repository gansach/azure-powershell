
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
create a topic in the specified namespace.
.Description
create a topic in the specified namespace.
.Example
New-AzServiceBusTopic -ResourceGroupName myResourceGroup -NamespaceName myNamespace -Name myTopic -DefaultMessageTimeToLive (New-TimeSpan -Days 18) -EnableBatchedOperations

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IServiceBusIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IServiceBusIdentity>: Identity Parameter
  [Alias <String>]: The Disaster Recovery configuration name
  [AuthorizationRuleName <String>]: The authorization rule name.
  [ConfigName <String>]: The configuration name. Should always be "$default".
  [Id <String>]: Resource identity path
  [NamespaceName <String>]: The namespace name
  [PrivateEndpointConnectionName <String>]: The PrivateEndpointConnection name
  [QueueName <String>]: The queue name.
  [ResourceGroupName <String>]: Name of the Resource group within the Azure subscription.
  [RuleName <String>]: The rule name.
  [SubscriptionId <String>]: Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
  [SubscriptionName <String>]: The subscription name.
  [TopicName <String>]: The topic name.

PARAMETER <ISbTopic>: Description of topic resource.
  [AutoDeleteOnIdle <TimeSpan?>]: ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
  [DefaultMessageTimeToLive <TimeSpan?>]: ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
  [DuplicateDetectionHistoryTimeWindow <TimeSpan?>]: ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
  [EnableBatchedOperations <Boolean?>]: Value that indicates whether server-side batched operations are enabled.
  [EnableExpress <Boolean?>]: Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.
  [EnablePartitioning <Boolean?>]: Value that indicates whether the topic to be partitioned across multiple message brokers is enabled.
  [MaxMessageSizeInKilobytes <Int64?>]: Maximum size (in KB) of the message payload that can be accepted by the topic. This property is only used in Premium today and default is 1024.
  [MaxSizeInMegabytes <Int32?>]: Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024.
  [RequiresDuplicateDetection <Boolean?>]: Value indicating if this topic requires duplicate detection.
  [Status <String>]: Enumerates the possible values for the status of a messaging entity.
  [SupportOrdering <Boolean?>]: Value that indicates whether the topic supports ordering.
.Link
https://learn.microsoft.com/powershell/module/az.servicebus/new-azservicebustopic
.Link
https://msdn.microsoft.com/en-us/library/azure/mt639409.aspx
#>
function New-AzServiceBusTopic {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IServiceBusIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ISbTopic]
    # Description of topic resource.
    ${Parameter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            CreateViaIdentity = 'Az.ServiceBus.private\New-AzServiceBusTopic_CreateViaIdentity';
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
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
