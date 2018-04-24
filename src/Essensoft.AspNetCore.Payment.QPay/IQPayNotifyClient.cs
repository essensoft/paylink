using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public interface IQPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : QPayNotifyResponse;
    }
}
