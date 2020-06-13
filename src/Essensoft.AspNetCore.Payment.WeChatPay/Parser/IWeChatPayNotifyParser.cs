#if NETCOREAPP3_1

namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public interface IWeChatPayNotifyParser<T> where T : WeChatPayNotify
    {
        T Parse(string body);

        T Parse(string body, string data);
    }
}

#endif
