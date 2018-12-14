using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 证书请求接口。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWeChatPayCertificateRequest<T>:IWeChatRequestBase where T : WeChatPayResponse
    {
    }
}
