
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
Create an in-memory object for TopItemsSummaryReportQueryFilter.
.Description
Create an in-memory object for TopItemsSummaryReportQueryFilter.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter
.Link
https://learn.microsoft.com/powershell/module/Az.Carbon/new-azcarbontopitemssummaryreportqueryfilterobject
#>
function New-AzCarbonTopItemsSummaryReportQueryFilterObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Carbon.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Specifies the category type for which to retrieve top-emitting items. See supported values defined in CategoryTypeEnum.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.PSArgumentCompleterAttribute("Subscription", "ResourceGroup", "Location", "Resource", "ResourceType")]
        [string]
        $CategoryType,
        [Parameter(Mandatory, HelpMessage="The number of top items to return, based on emissions. This value must be between 1 and 10.")]
        [int]
        $TopItem,
        [Parameter(Mandatory, HelpMessage="List of carbon emission scopes. Required. Accepts one or more values from EmissionScopeEnum (e.g., Scope1, Scope2, Scope3) in list form. The output will include the total emissions for the specified scopes.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.PSArgumentCompleterAttribute("Scope1", "Scope2", "Scope3")]
        [string[]]
        $CarbonScopeList,
        [Parameter(Mandatory, HelpMessage="End date parameter in yyyy-MM-01 format. Only the first day of each month is accepted.")]
        [System.DateTime]
        $DateRangeEnd,
        [Parameter(Mandatory, HelpMessage="Start date parameter in yyyy-MM-01 format. Only the first day of each month is accepted.")]
        [System.DateTime]
        $DateRangeStart,
        [Parameter(HelpMessage="List of locations(Azure Region Display Name) for carbon emissions data, with each location specified in lowercase (e.g., 'east us'). Optional. You can use the command 'az account list-locations -o table' to find Azure Region Display Names.")]
        [string[]]
        $LocationList,
        [Parameter(HelpMessage="List of resource group URLs for carbon emissions data. Optional. Each URL must follow the format '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroup}', and should be in all lowercase.")]
        [string[]]
        $ResourceGroupUrlList,
        [Parameter(HelpMessage="List of resource types for carbon emissions data. Optional. Each resource type should be specified in lowercase, following the format 'microsoft.{service}/{resourceType}', e.g., 'microsoft.storage/storageaccounts'.")]
        [string[]]
        $ResourceTypeList,
        [Parameter(Mandatory, HelpMessage="List of subscription IDs for which carbon emissions data is requested. Required. Each subscription ID should be in lowercase format. The max length of list is 100.")]
        [string[]]
        $SubscriptionList
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter]::New()

        if ($PSBoundParameters.ContainsKey('CategoryType')) {
            $Object.CategoryType = $CategoryType
        }
        if ($PSBoundParameters.ContainsKey('TopItem')) {
            $Object.TopItem = $TopItem
        }
        if ($PSBoundParameters.ContainsKey('CarbonScopeList')) {
            $Object.CarbonScopeList = $CarbonScopeList
        }
        if ($PSBoundParameters.ContainsKey('DateRangeEnd')) {
            $Object.DateRangeEnd = $DateRangeEnd
        }
        if ($PSBoundParameters.ContainsKey('DateRangeStart')) {
            $Object.DateRangeStart = $DateRangeStart
        }
        if ($PSBoundParameters.ContainsKey('LocationList')) {
            $Object.LocationList = $LocationList
        }
        if ($PSBoundParameters.ContainsKey('ResourceGroupUrlList')) {
            $Object.ResourceGroupUrlList = $ResourceGroupUrlList
        }
        if ($PSBoundParameters.ContainsKey('ResourceTypeList')) {
            $Object.ResourceTypeList = $ResourceTypeList
        }
        if ($PSBoundParameters.ContainsKey('SubscriptionList')) {
            $Object.SubscriptionList = $SubscriptionList
        }
        return $Object
    }
}

