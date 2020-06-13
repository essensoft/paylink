namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public interface IWeChatPayObjectJsonParser<T> where T : WeChatPayObject
    {
        T Parse(string body);
    }
}
