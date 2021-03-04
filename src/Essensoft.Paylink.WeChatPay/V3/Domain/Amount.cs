using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 订单金额
    /// </summary>
    public class Amount : WeChatPayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        /// <remarks>
        /// 订单总金额，单位为分。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 用户支付金额
        /// </summary>
        /// <remarks>
        /// 用户支付金额，单位为分。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("payer_total")]
        public int? PayerTotal { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        /// <remarks>
        /// CNY：人民币，境内商户号仅支持人民币。
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 用户支付币种
        /// </summary>
        /// <remarks>
        /// 用户支付币种
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("payer_currency")]
        public string PayerCurrency { get; set; }
    }
}
