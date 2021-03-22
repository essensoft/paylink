using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单下单订单金额信息
    /// </summary>
    public class CombineAmount : WeChatPayObject
    {
        /// <summary>
        /// 标价金额
        /// </summary>
        /// <remarks>
        /// 子单金额，单位为分
        /// 境外场景下，标价金额要超过商户结算币种的最小单位金额，例如结算币种为美元，则标价金额必须大于1美分
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 标价币种
        /// </summary>
        /// <remarks>
        /// 符合ISO 4217标准的三位字母代码，人民币：CNY 。
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 现金支付金额
        /// </summary>
        /// <remarks>
        /// 订单现金支付金额。
        /// <para>示例值：10</para>
        /// </remarks>
        [JsonPropertyName("payer_amount")]
        public long? PayerAmount { get; set; }

        /// <summary>
        /// 现金支付币种
        /// </summary>
        /// <remarks>
        /// 货币类型，符合ISO 4217标准的三位字母代码，默认人民币：CNY。
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("payer_currency")]
        public string PayerCurrency { get; set; }
    }
}
