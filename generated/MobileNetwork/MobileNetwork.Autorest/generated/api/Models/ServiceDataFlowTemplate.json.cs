// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Data flow template</summary>
    public partial class ServiceDataFlowTemplate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IServiceDataFlowTemplate.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IServiceDataFlowTemplate.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IServiceDataFlowTemplate FromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json ? new ServiceDataFlowTemplate(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject into a new instance of <see cref="ServiceDataFlowTemplate" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServiceDataFlowTemplate(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_templateName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("templateName"), out var __jsonTemplateName) ? (string)__jsonTemplateName : (string)_templateName;}
            {_direction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString>("direction"), out var __jsonDirection) ? (string)__jsonDirection : (string)_direction;}
            {_protocol = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray>("protocol"), out var __jsonProtocol) ? If( __jsonProtocol as Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _protocol;}
            {_remoteIPList = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray>("remoteIpList"), out var __jsonRemoteIPList) ? If( __jsonRemoteIPList as Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : _remoteIPList;}
            {_port = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray>("ports"), out var __jsonPorts) ? If( __jsonPorts as Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : _port;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServiceDataFlowTemplate" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServiceDataFlowTemplate" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._templateName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._templateName.ToString()) : null, "templateName" ,container.Add );
            AddIf( null != (((object)this._direction)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(this._direction.ToString()) : null, "direction" ,container.Add );
            if (null != this._protocol)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.XNodeArray();
                foreach( var __x in this._protocol )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("protocol",__w);
            }
            if (null != this._remoteIPList)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.XNodeArray();
                foreach( var __s in this._remoteIPList )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("remoteIpList",__r);
            }
            if (null != this._port)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.XNodeArray();
                foreach( var __n in this._port )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("ports",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}