using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Notify
{
    /// <summary>
    /// 资金应用 - 分账 - 分账动账通知
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_10.shtml">分账 - 分账动账通知</a> - 最新更新时间：2020.11.03</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_10.shtml">分账(服务商) - 分账动账通知</a> - 最新更新时间：2020.11.03</para>
    /// </remarks>
    public class WeChatPayProfitSharingNotify : WeChatPayNotify
    {
        /// <summary>
        /// 服务商商户号
        /// </summary>
        /// <remarks>
        /// 服务商模式分账发起商户。
        /// <para>示例值: 1900000100</para>
        /// </remarks>
        [JsonPropertyName("sp_mchid")]
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 服务商模式分账出资商户。
        /// <para>示例值: 1900000100</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 直连商户号
        /// </summary>
        /// <remarks>
        /// 直连模式分账发起和出资商户
        /// <para>示例值: 1900000100</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号
        /// <para>示例值: 4200000000000000000000000000</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 微信分账/回退单号
        /// </summary>
        /// <remarks>
        /// 微信分账/回退单号
        /// <para>示例值: 1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户分账/回退单号
        /// </summary>
        /// <remarks>
        /// 分账方系统内部的分账/回退单号
        /// <para>示例值: P20150806125346</para>
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
        /// <para>示例值: 2018-06-08T10:34:56+08:00</para>
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }
    }
}
