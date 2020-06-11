namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public interface IWeChatPayV3ResponseJsonParser<T> where T : WeChatPayV3Response
    {
        T Parse(string body);
    }
}
