using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTradeFundItem Data Structure.
    /// </summary>
    public class InvoiceTradeFundItem : AlipayObject
    {
        /// <summary>
        /// 当前支付工具支付的金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝支付工具描述
        /// </summary>
        [JsonPropertyName("payment_tool_name")]
        public string PaymentToolName { get; set; }

        /// <summary>
        /// 支付宝支付工具类型
        /// </summary>
        [JsonPropertyName("payment_tool_type")]
        public string PaymentToolType { get; set; }
    }
}
