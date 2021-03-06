// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Frontend Port of application gateway
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayFrontendPort : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayFrontendPort
        /// class.
        /// </summary>
        public ApplicationGatewayFrontendPort() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayFrontendPort
        /// class.
        /// </summary>
        public ApplicationGatewayFrontendPort(string id = default(string), int? port = default(int?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Port = port;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Frontend port
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Provisioning state of the frontend port resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Name of the resource that is unique within a resource group. This
        /// name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
