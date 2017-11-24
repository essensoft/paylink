namespace Essensoft.AspNetCore.WeChatPay.Parser
{
    /// <summary>
    /// 微信支付结果解析
    /// </summary>
    public interface IWeChatPayParser<T> where T : WeChatPayObject
    {
        T Parse(string body);
    }
}
