using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoOuQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoOuQueryModel : AlipayObject
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }
    }
}
