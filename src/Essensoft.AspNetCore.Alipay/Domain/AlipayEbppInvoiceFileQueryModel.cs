using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFileQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceFileQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝端生成的发票id，该字段可从发票详情查询接口获得
        /// </summary>
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
