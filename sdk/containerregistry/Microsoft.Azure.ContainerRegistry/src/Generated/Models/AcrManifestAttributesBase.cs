// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Manifest details
    /// </summary>
    public partial class AcrManifestAttributesBase
    {
        /// <summary>
        /// Initializes a new instance of the AcrManifestAttributesBase class.
        /// </summary>
        public AcrManifestAttributesBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AcrManifestAttributesBase class.
        /// </summary>
        /// <param name="digest">Manifest digest</param>
        /// <param name="createdTime">Created time</param>
        /// <param name="lastUpdateTime">Last update time</param>
        /// <param name="architecture">CPU architecture</param>
        /// <param name="os">Operating system</param>
        /// <param name="mediaType">Media type</param>
        /// <param name="tags">List of tags</param>
        /// <param name="changeableAttributes">Changeable attributes</param>
        public AcrManifestAttributesBase(string digest = default(string), string createdTime = default(string), string lastUpdateTime = default(string), string architecture = default(string), string os = default(string), string mediaType = default(string), IList<string> tags = default(IList<string>), ChangeableAttributes changeableAttributes = default(ChangeableAttributes))
        {
            Digest = digest;
            CreatedTime = createdTime;
            LastUpdateTime = lastUpdateTime;
            Architecture = architecture;
            Os = os;
            MediaType = mediaType;
            Tags = tags;
            ChangeableAttributes = changeableAttributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets manifest digest
        /// </summary>
        [JsonProperty(PropertyName = "digest")]
        public string Digest { get; set; }

        /// <summary>
        /// Gets or sets created time
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets last update time
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets CPU architecture
        /// </summary>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }

        /// <summary>
        /// Gets or sets operating system
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public string Os { get; set; }

        /// <summary>
        /// Gets or sets media type
        /// </summary>
        [JsonProperty(PropertyName = "mediaType")]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or sets list of tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets changeable attributes
        /// </summary>
        [JsonProperty(PropertyName = "changeableAttributes")]
        public ChangeableAttributes ChangeableAttributes { get; set; }

    }
}
