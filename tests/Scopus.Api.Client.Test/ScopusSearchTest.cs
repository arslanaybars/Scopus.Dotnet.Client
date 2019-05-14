using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scopus.Api.Client.Models.Common;
using System.Threading.Tasks;

namespace Scopus.Api.Client.Test
{
    [TestClass]
    public class ScopusSearchTest
    {
        private ScopusSearchClient apiClient = new ScopusSearchClient("https://api.elsevier.com/", "7f59af901d2d86f78a1fd60c1bf9426a");

        [TestMethod]
        public void Shold_Test_Scopus_Search()
        {
            var scopusSearchResult = apiClient.Get<SearchResults<Models.Search.Scopus>>("content/search/scopus", "query=AFFILCITY(KARABUK)AUTHOR-NAME(TURKER I)");
            Assert.IsNotNull(scopusSearchResult);
            Assert.IsTrue(scopusSearchResult.IsSuccessStatusCode);
            Assert.IsTrue((int)scopusSearchResult.StatusCode >= 200 && ((int)scopusSearchResult.StatusCode <= 299));
        }

        [TestMethod]
        public async Task Shold_Test_Scopus_Search_Async()
        {
            var scopusSearchResult = await apiClient.GetAsync<SearchResults<Models.Search.Scopus>>("content/search/scopus", "query=AFFILCITY(KARABUK)AUTHOR-NAME(TURKER I)");
            Assert.IsNotNull(scopusSearchResult);
            Assert.IsTrue(scopusSearchResult.IsSuccessStatusCode);
            Assert.IsTrue((int)scopusSearchResult.StatusCode >= 200 && ((int)scopusSearchResult.StatusCode <= 299));
        }
    }
}
