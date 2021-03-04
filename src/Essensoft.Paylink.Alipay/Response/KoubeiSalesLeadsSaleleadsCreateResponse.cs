using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesLeadsSaleleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsSaleleadsCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成的销售LeadsId
        /// </summary>
        [JsonPropertyName("leads_id")]
        public string LeadsId { get; set; }
    }
}
