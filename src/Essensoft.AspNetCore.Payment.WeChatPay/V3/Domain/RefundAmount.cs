using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 退款金额信息
    /// </summary>
    public class RefundAmount : WeChatPayObject
    {
        /// <summary>
        /// 退款金额
        /// 退款金额，币种的最小单位，只能为整数，不能超过原订单支付金额。
        /// 示例值：888
        /// </summary>
        [JsonPropertyName("refund")]
        public int Refund { get; set; }

        /// <summary>
        /// 原订单金额
        /// 原支付交易的订单总金额，币种的最小单位，只能为整数。
        /// 示例值：888
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 退款币种
        /// 符合ISO 4217标准的三位字母代码，目前只支持人民币：CNY。
        /// 示例值：CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
