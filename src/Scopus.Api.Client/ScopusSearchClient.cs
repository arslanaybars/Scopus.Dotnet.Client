using Scopus.Api.Client.Abstract;
using Scopus.Api.Client.Models.Common;
using System.Threading.Tasks;

namespace Scopus.Api.Client
{
    public class ScopusSearchClient : ApiClient
    {
        private const string endpoint = "/content/search/scopus";

        public ScopusSearchClient(string apiUrl, string apiKey) : base(apiUrl, apiKey)
        {
        }

        /// <summary>
        /// Scopus search
        /// </summary>
        /// <param name="query">Pass scopus search query by using scopus query syntax
        ///     See: https://dev.elsevier.com/tips/ScopusSearchTips.htm
        /// </param>
        /// <returns></returns>
        public SearchResults<Models.Search.Scopus> Retrieve(string query)
        {
            return Get<SearchResults<Models.Search.Scopus>>(endpoint, query);
        }

        /// <summary>
        /// Scopus search async
        /// </summary>
        /// <param name="query">Pass scopus search query by using scopus query syntax
        ///     See: https://dev.elsevier.com/tips/ScopusSearchTips.htm
        /// </param>
        /// <returns></returns>
        public async Task<SearchResults<Models.Search.Scopus>> RetrieveAsync(string query)
        {
            return await GetAsync<SearchResults<Models.Search.Scopus>>(endpoint, query);
        }
    }
}
