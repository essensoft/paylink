using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTaxNeworderStatusSyncResponse.
    /// </summary>
    public class AlipayOverseasTaxNeworderStatusSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 纸质退税单号
        /// </summary>
        [JsonPropertyName("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 支付宝退税单号
        /// </summary>
        [JsonPropertyName("tax_order_no")]
        public string TaxOrderNo { get; set; }
    }
}
