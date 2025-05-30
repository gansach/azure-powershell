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

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions.Interfaces;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Azure.Commands.TestFx.Mocks
{
    public class MockCertificateAuthenticationFactory : IAuthenticationFactory
    {
        public X509Certificate2 Certificate { get; set; }

        public MockCertificateAuthenticationFactory()
        {
            byte[] emptyCertificateData = Array.Empty<byte>();
            Certificate = new X509Certificate2(emptyCertificateData);
        }

        public MockCertificateAuthenticationFactory(string userId, X509Certificate2 certificate)
        {
            Certificate = certificate;
        }

        public IAccessToken Authenticate(
            IAzureAccount account,
            IAzureEnvironment environment,
            string tenant,
            SecureString password,
            string promptBehavior,
            Action<string> promptAction,
            IAzureTokenCache tokenCache,
            string resourceId = AzureEnvironment.Endpoint.ActiveDirectoryServiceEndpointResourceId)
        {
            if (account.Id == null)
            {
                account.Id = "test";
            }

            var token = new MockAccessToken
            {
                UserId = account.Id,
                LoginType = LoginType.OrgId,
                AccessToken = "123"
            };

            return token;
        }

        public IAccessToken Authenticate(
            IAzureAccount account,
            IAzureEnvironment environment,
            string tenant,
            SecureString password,
            string promptBehavior,
            Action<string> promptAction,
            string resourceId = AzureEnvironment.Endpoint.ActiveDirectoryServiceEndpointResourceId)
        {
            return Authenticate(account, environment, tenant, password, promptBehavior, promptAction, AzureSession.Instance.TokenCache, resourceId);
        }

        public SubscriptionCloudCredentials GetSubscriptionCloudCredentials(IAzureContext context)
        {
            return new CertificateCloudCredentials(context.Subscription.Id.ToString(), Certificate);
        }

        public SubscriptionCloudCredentials GetSubscriptionCloudCredentials(IAzureContext context, string targetEndpoint)
        {
            return new CertificateCloudCredentials(context.Subscription.Id.ToString(), Certificate);
        }

        public ServiceClientCredentials GetServiceClientCredentials(IAzureContext context, ICmdletContext cmdletContext)
        {
            throw new NotImplementedException();
        }

        public ServiceClientCredentials GetServiceClientCredentials(IAzureContext context, string targetEndpoint, ICmdletContext cmdletContext)
        {
            throw new NotImplementedException();
        }

        public ServiceClientCredentials GetServiceClientCredentials(string accessToken, Func<string> renew = null)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(IAzureAccount account, IAzureTokenCache tokenCache)
        {
            throw new NotImplementedException();
        }

        public AuthenticationTelemetryData GetDataForTelemetry(string requestId)
        {
            throw new NotImplementedException();
        }

        public ServiceClientCredentials GetServiceClientCredentials(IAzureContext context)
        {
            return GetServiceClientCredentials(context, AzureCmdletContext.CmdletNone);
        }

        public ServiceClientCredentials GetServiceClientCredentials(IAzureContext context, string targetEndpoint)
        {
            return GetServiceClientCredentials(context, targetEndpoint, AzureCmdletContext.CmdletNone); ;
        }

        public IAccessToken Authenticate(IAzureAccount account, IAzureEnvironment environment, string tenant, SecureString password, string promptBehavior, Action<string> promptAction, IDictionary<string, object> optionalParameters)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(IAzureAccount account, IAzureEnvironment environment)
        {
            throw new NotImplementedException();
        }
    }
}
