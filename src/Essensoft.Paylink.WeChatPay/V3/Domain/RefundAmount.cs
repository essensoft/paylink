using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 退款金额信息
    /// </summary>
    public class RefundAmount : WeChatPayObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        /// <remarks>
        /// 退款金额，币种的最小单位，只能为整数，不能超过原订单支付金额。
        /// <para>示例值：888</para>
        /// </remarks>
        [JsonPropertyName("refund")]
        public int Refund { get; set; }

        /// <summary>
        /// 原订单金额
        /// </summary>
        /// <remarks>
        /// 原支付交易的订单总金额，币种的最小单位，只能为整数。
        /// <para>示例值：888</para>
        /// </remarks>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 退款币种
        /// </summary>
        /// <remarks>
        /// 符合ISO 4217标准的三位字母代码，目前只支持人民币：CNY。
        /// <para>示例值：CNY</para>
        /// </remarks>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
