using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scopus.Api.Client.Models.Common;
using System.Threading.Tasks;

namespace Scopus.Api.Client.Test
{
    [TestClass]
    public class ScopusSearchTest
    {
        private ScopusSearchClient apiClient = new ScopusSearchClient("https://api.elsevier.com/", "786e3d57b12aaa2cf97882516d26b2bd");

        [TestMethod]
        public async Task Shold_Test_Scopus_Search_Async()
        {
            var scopusSearchResult = await apiClient.GetAsync<SearchResults<Models.Search.Scopus>>("content/search/scopus", "query=AFFILCITY(KARABUK)AUTHOR-NAME(TURKER I)");
            Assert.IsNotNull(scopusSearchResult);
        }
    }
}
