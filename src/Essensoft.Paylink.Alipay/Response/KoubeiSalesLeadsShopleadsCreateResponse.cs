using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsShopleadsCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 导入成功的LeadsId
        /// </summary>
        [JsonPropertyName("leads_id")]
        public string LeadsId { get; set; }
    }
}
