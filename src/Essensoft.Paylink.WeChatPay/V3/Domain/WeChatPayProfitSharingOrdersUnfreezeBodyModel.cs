using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 资金应用 - 分账 - 解冻剩余资金 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_5.shtml">分账 - 解冻剩余资金API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_5.shtml">分账(服务商) - 解冻剩余资金API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingOrdersUnfreezeResponse : WeChatPayObject
    {
        /// <summary>
        /// 子商户号 
        /// </summary>
        /// <remarks>
        /// 微信支付分配的子商户号，即分账的出资商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号
        /// <para>示例值：4208450740201411110007820472</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户分账单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部的分账单号，在商户系统内部唯一，同一分账单号多次请求等同一次。 取值范围：[0-9a-zA-Z_*@-]
        /// <para>示例值：P20150806125346</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        /// <remarks>
        /// 分账的原因描述，分账账单中需要体现
        /// <para>示例值：解冻全部剩余资金</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
