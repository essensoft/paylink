using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectrulesModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectrulesModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
