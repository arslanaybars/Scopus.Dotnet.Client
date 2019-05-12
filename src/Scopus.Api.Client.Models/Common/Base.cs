﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scopus.Api.Client.Models.Common
{
    public partial class SearchResults<T>
    {
        [JsonProperty("opensearch:totalResults")]
        public long OpensearchTotalResults { get; set; }

        [JsonProperty("opensearch:startIndex")]
        public long OpensearchStartIndex { get; set; }

        [JsonProperty("opensearch:itemsPerPage")]
        public long OpensearchItemsPerPage { get; set; }

        [JsonProperty("opensearch:Query")]
        public OpensearchQuery OpensearchQuery { get; set; }

        [JsonProperty("link")]
        public List<Link> Link { get; set; }

        [JsonProperty("entry")]
        public List<T> Entry { get; set; }
    }

    public partial class OpensearchQuery
    {
        [JsonProperty("@role")]
        public string Role { get; set; }

        [JsonProperty("@searchTerms")]
        public string SearchTerms { get; set; }

        [JsonProperty("@startPage")]
        public long StartPage { get; set; }
    }
}
