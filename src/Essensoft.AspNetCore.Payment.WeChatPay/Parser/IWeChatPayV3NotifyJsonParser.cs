namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public interface IWeChatPayV3NotifyJsonParser<T> where T : WeChatPayV3Notify
    {
        T Parse(string body, string v3key);
    }
}
