using System.Threading.Tasks;

namespace Scopus.Api.Client.Interfaces
{
    public interface IApiClient
    {
        T Get<T>(string endpoint, string parameters = null);

        Task<T> GetAsync<T>(string endpoint, string parameters = null);
    }
}
