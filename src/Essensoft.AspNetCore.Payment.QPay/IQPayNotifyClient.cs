using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public interface IQPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : QPayNotifyResponse;
    }
}
