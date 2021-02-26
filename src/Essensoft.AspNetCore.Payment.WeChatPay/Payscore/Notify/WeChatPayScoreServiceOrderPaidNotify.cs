using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Notify
{
    /// <summary>
    /// 支付成功回调通知
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_22.shtml">支付成功回调通知API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderPaidNotify : WeChatPayScoreNotifyBase
    {
        /// <summary>
        /// 商户回调地址
        /// </summary>
        /// <remarks>
        /// 商户接收用户确认订单和付款成功回调通知的地址。
        /// 示例值：https://api.test.com
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }


        /// <summary>
        /// 收款信息，非0元完结后返回
        /// </summary>
        [JsonPropertyName("collection")]
        public Collection Collection { get; set; }
    }
}
