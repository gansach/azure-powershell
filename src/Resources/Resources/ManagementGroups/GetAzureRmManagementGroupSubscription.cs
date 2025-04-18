// ----------------------------------------------------------------------------------
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

using System;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Resources.ManagementGroups.Common;
using Microsoft.Azure.Commands.Resources.Models.ManagementGroups;
using Microsoft.Azure.Management.ManagementGroups;
using Microsoft.Azure.Management.ManagementGroups.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Resources.ManagementGroups
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ManagementGroupSubscription", DefaultParameterSetName = Constants.ParameterSetNames.GroupOperationsParameterSet, SupportsShouldProcess = true), OutputType(typeof(PSManagementGroupSubscription))]
    public class GetAzureRmManagementGroupSubscription : AzureManagementGroupsCmdletBase
    {
        [Alias("GroupId")]
        [Parameter(ParameterSetName = Constants.ParameterSetNames.GroupOperationsParameterSet, Mandatory = true,
           HelpMessage = Constants.HelpMessages.GroupName, Position = 0)]
        [ValidateNotNullOrEmpty]
        public string GroupName { get; set; } = null;

        [Parameter(ParameterSetName = Constants.ParameterSetNames.GroupOperationsParameterSet, Mandatory = false,
            HelpMessage = Constants.HelpMessages.SubscriptionId, Position = 1)]
        [ValidateNotNullOrEmpty]
        public string SubscriptionId { get; set; }

        [Parameter(ParameterSetName = Constants.ParameterSetNames.GroupOperationsParameterSet, Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            try
            {
                if (!string.IsNullOrEmpty(SubscriptionId) && ShouldProcess(
                    string.Format(Resource.NewManagementGroupSubShouldProcessTarget, SubscriptionId, GroupName),
                    string.Format(Resource.NewManagementGroupSubShouldProcessAction, SubscriptionId, GroupName)))
                {
                    PreregisterSubscription();
                    PreregisterSubscription(SubscriptionId.ToString());

                    var response = ManagementGroupsApiClient.ManagementGroupSubscriptions.GetSubscription(GroupName, SubscriptionId);
                    
                    WriteObject(new PSManagementGroupSubscription(response));
                }

                else if(ShouldProcess(
                        string.Format(Resource.NewManagementGroupShouldProcessTarget, GroupName),
                        string.Format(Resource.NewManagementGroupShouldProcessAction, GroupName)))
                {
                    PreregisterSubscription();

                    var responses = ManagementGroupsApiClient.ManagementGroupSubscriptions.GetSubscriptionsUnderManagementGroup(GroupName);

                    var items = responses.Select(item => new PSManagementGroupSubscription(item)).ToList();

                    WriteObject(items, true);
                }
            }
            
            catch (ErrorResponseException ex)
            {
                Utility.HandleErrorResponseException(ex);
            }
        }
    }
}
