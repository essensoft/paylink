namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser
{
    public interface IWeChatPayResponseParser<T> where T : V2.WeChatPayResponse
    {
        T Parse(string body);
    }
}
