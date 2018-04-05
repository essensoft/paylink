namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    /// <summary>
    /// 微信支付结果解析
    /// </summary>
    public interface IWeChatPayParser<T> where T : WeChatPayResponse
    {
        T Parse(string body);

        T Parse(string body, string data);
    }
}
