using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public interface ILianLianPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request) where T : LianLianPayNotifyResponse;
    }
}
