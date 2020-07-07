namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Parser
{
    public interface IWeChatPayResponseJsonParser<T> where T : WeChatPayResponse
    {
        T Parse(string body, int statusCode);
    }
}
