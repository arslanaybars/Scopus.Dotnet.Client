using Scopus.Api.Client.Abstract;
using Scopus.Api.Client.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Scopus.Api.Client
{
    public class ScopusSearchClient : ApiClient
    {
        private const string endpoint = "/content/search/scopus";

        public ScopusSearchClient(string apiUrl, string apiKey) : base(apiUrl, apiKey)
        {
        }

        public SearchResults<Models.Search.Scopus> Retrieve(string query)
        {
#if DEBUG
            query = "query=AFFILCITY(KARABUK)";
#endif
            return Get<SearchResults<Models.Search.Scopus>>(endpoint, query);
        }

        public async Task<SearchResults<Models.Search.Scopus>> RetrieveAsync(string query)
        {
#if DEBUG
            query = "query=AFFILCITY(KARABUK)";
#endif
            return await GetAsync<SearchResults<Models.Search.Scopus>>(endpoint, query);
        }
    }
}
