#if NETCOREAPP3_1

using Essensoft.AspNetCore.Payment.WeChatPay.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public interface IWeChatPayV3NotifyJsonParser<T> where T : WeChatPayV3Notify
    {
        T Parse(string body, string v3key, int statusCode);
    }
}

#endif
