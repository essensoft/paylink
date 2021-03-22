using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceOperateParam Data Structure.
    /// </summary>
    public class InvoiceOperateParam : AlipayObject
    {
        /// <summary>
        /// 发票ID
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// INVALID-发票作废
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }
    }
}
