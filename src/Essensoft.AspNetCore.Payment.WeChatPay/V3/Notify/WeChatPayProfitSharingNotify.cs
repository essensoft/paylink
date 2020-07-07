using System;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Notify
{
    /// <summary>
    /// 分账动账通知 (普通商户)
    /// https://pay.weixin.qq.com/wiki/doc/api/allocation.php?chapter=27_9&index=9
    /// </summary>
    public class WeChatPayProfitSharingNotify : WeChatPayNotify
    {
        /// <summary>
        /// 直连商户号
        /// 直连模式分账发起和出资商户
        /// </summary>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// 微信支付订单号
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 微信分账/回退单号
        /// 微信分账/回退单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户分账/回退单号
        /// 分账方系统内部的分账/回退单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 分账接收方
        /// 分账接收方对象
        /// </summary>
        [JsonPropertyName("receiver")]
        public Receiver Receiver { get; set; }

        /// <summary>
        /// 成功时间
        /// 成功时间，Rfc3339标准
        /// </summary>
        [JsonPropertyName("success_time")]
        public DateTimeOffset SuccessTime { get; set; }
    }
}
