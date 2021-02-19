using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicUserExpressQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicUserExpressQueryModel : AlipayObject
    {
        /// <summary>
        /// 银行机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }
    }
}
