using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesGroupemployeeModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesGroupemployeeModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
