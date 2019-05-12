using Newtonsoft.Json;
using System;

namespace Scopus.Api.Client.Models.Common
{
    public class Link
    {
        [JsonProperty("@_fa")]
        public bool Fa { get; set; }

        [JsonProperty("@ref")]
        public string Ref { get; set; }

        [JsonProperty("@href")]
        public Uri Href { get; set; }

        [JsonProperty("@type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}
