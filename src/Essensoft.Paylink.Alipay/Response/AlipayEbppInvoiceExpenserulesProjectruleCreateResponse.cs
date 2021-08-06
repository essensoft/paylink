using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }
    }
}
