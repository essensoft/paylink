using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Notify
{
    /// <summary>
    /// 普通直连分账 - 分账动账通知
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/api/allocation.php?chapter=27_9&index=9">普通直连分账 - 支付通知API</a></para>
    /// </summary>
    public class WeChatPayProfitSharingNotify : WeChatPayNotify
    {
        /// <summary>
        /// 直连商户号
        /// </summary>
        /// <remarks>
        /// 直连模式分账发起和出资商户
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 微信分账/回退单号
        /// </summary>
        /// <remarks>
        /// 微信分账/回退单号
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户分账/回退单号
        /// </summary>
        /// <remarks>
        /// 分账方系统内部的分账/回退单号
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 分账接收方
        /// </summary>
        /// <remarks>
        /// 分账接收方对象
        /// </remarks>
        [JsonPropertyName("receiver")]
        public Receiver Receiver { get; set; }

        /// <summary>
        /// 成功时间
        /// </summary>
        /// <remarks>
        /// 成功时间，Rfc3339标准
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }
    }
}
