namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser
{
    public interface IWeChatPayObjectJsonParser<T> where T : WeChatPayObject
    {
        T Parse(string body);
    }
}
