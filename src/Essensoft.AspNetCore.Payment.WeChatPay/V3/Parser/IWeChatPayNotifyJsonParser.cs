namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Parser
{
    public interface IWeChatPayNotifyJsonParser<T> where T : WeChatPayNotify
    {
        T Parse(string body, string v3key);
    }
}
