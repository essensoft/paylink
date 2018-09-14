using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public interface ILianLianPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : LianLianPayNotifyResponse;
    }
}
