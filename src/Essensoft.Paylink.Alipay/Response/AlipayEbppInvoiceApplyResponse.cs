using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝返回的发票申请id,该id具有唯一性
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
