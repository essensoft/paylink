using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public interface IUnionPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : UnionPayNotifyResponse;
    }
}
