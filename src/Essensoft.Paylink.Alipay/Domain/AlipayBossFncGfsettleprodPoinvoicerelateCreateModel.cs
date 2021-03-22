using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPoinvoicerelateCreateModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettleprodPoinvoicerelateCreateModel : AlipayObject
    {
        /// <summary>
        /// 发票创建关联请求
        /// </summary>
        [JsonPropertyName("input_invoice_order_request")]
        public InputInvoiceOrderRequest InputInvoiceOrderRequest { get; set; }
    }
}
