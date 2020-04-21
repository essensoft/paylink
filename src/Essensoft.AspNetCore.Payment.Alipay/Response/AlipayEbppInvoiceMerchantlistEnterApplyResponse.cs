using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantlistEnterApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantlistEnterApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 工单流水号，支付开票PID模式当前不会返回流水号。
        /// </summary>
        [JsonPropertyName("process_id")]
        public string ProcessId { get; set; }
    }
}
