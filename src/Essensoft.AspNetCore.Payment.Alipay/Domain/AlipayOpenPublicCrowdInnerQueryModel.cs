using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicCrowdInnerQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicCrowdInnerQueryModel : AlipayObject
    {
        /// <summary>
        /// 人群来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 人群id
        /// </summary>
        [JsonPropertyName("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 外部人群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
