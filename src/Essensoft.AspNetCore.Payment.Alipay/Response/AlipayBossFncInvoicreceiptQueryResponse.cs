using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncInvoicreceiptQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoicreceiptQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开票单据返回对象
        /// </summary>
        [JsonPropertyName("result_set")]
        public ArInvoiceReceiptQueryOpenApiDTO ResultSet { get; set; }
    }
}
