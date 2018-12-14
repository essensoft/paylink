using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 请求接口。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWeChatPayRequest<T>:IWeChatRequestBase where T : WeChatPayResponse
    {
    }
}
