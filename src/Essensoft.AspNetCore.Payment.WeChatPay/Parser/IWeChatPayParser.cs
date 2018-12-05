namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    /// <summary>
    /// WeChatPay 解析。
    /// </summary>
    public interface IWeChatPayParser<T> where T : WeChatPayObject
    {
        T Parse(string body);

        T Parse(string body, string data);
    }
}
