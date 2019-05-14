using Newtonsoft.Json;
using Scopus.Api.Client.Models.Common;
using System;
using System.Collections.Generic;

namespace Scopus.Api.Client.Models.Search
{
    public class Scopus
    {
        [JsonProperty("@_fa")]
        public bool Fa { get; set; }

        [JsonProperty("link")]
        public List<Link> Link { get; set; }

        [JsonProperty("prism:url")]
        public Uri PrismUrl { get; set; }

        [JsonProperty("dc:identifier")]
        public string DcIdentifier { get; set; }

        [JsonProperty("eid")]
        public string Eid { get; set; }

        [JsonProperty("dc:title")]
        public string DcTitle { get; set; }

        [JsonProperty("dc:creator")]
        public string DcCreator { get; set; }

        [JsonProperty("prism:publicationName")]
        public string PrismPublicationName { get; set; }

        [JsonProperty("prism:issn")]
        public string PrismIssn { get; set; }

        [JsonProperty("prism:volume")]
        public string PrismVolume { get; set; }

        [JsonProperty("prism:issueIdentifier")]
        public string PrismIssueIdentifier { get; set; }

        [JsonProperty("prism:pageRange")]
        public string PrismPageRange { get; set; }

        [JsonProperty("prism:coverDate")]
        public DateTimeOffset PrismCoverDate { get; set; }

        [JsonProperty("prism:coverDisplayDate")]
        public string PrismCoverDisplayDate { get; set; }

        [JsonProperty("prism:doi")]
        public string PrismDoi { get; set; }

        [JsonProperty("citedby-count")]
        public int CitedbyCount { get; set; }

        [JsonProperty("affiliation")]
        public List<Affiliation> Affiliation { get; set; }

        [JsonProperty("prism:aggregationType")]
        public string PrismAggregationType { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("subtypeDescription")]
        public string SubtypeDescription { get; set; }

        [JsonProperty("source-id")]
        public long SourceId { get; set; }

        [JsonProperty("openaccess")]
        public int Openaccess { get; set; }

        [JsonProperty("openaccessFlag")]
        public bool OpenaccessFlag { get; set; }
    }

    public class Affiliation
    {
        [JsonProperty("@_fa")]
        public bool Fa { get; set; }

        [JsonProperty("affilname")]
        public string Affilname { get; set; }

        [JsonProperty("affiliation-city")]
        public string AffiliationCity { get; set; }

        [JsonProperty("affiliation-country")]
        public string AffiliationCountry { get; set; }
    }

}
