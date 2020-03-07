using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceFileQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝端生成的发票id，该字段可从发票详情查询接口获得
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
