namespace Essensoft.AspNetCore.Payment.WeChatPay.V3
{
    /// <summary>
    /// 微信Http头信息
    /// </summary>
    public class WeChatPayHeaders
    {
        /// <summary>
        /// 平台证书序列号
        /// Wechatpay-Serial
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// 时间戳
        /// Wechatpay-Timestamp
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// 随机串
        /// Wechatpay-Nonce
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// 签名串
        /// Wechatpay-Signature
        /// </summary>
        public string Signature { get; set; }
    }
}
