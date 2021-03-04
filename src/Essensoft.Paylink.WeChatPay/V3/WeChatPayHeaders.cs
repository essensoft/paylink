namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// 微信支付的应答、通知Http头信息
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml
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
