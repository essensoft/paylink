namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public interface IWeChatPayResponseParser<T> where T : WeChatPayResponse
    {
        T Parse(string body);
    }
}
