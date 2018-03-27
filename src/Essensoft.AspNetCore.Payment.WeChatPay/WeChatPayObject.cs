namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// 基础对象。
    /// </summary>
    public abstract class WeChatPayObject
    {
        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 响应原始参数
        /// </summary>
        public WeChatPayDictionary Parameters { get; private set; } = new WeChatPayDictionary();
    }
}
