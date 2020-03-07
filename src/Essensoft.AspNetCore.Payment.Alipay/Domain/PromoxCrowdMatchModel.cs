using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoxCrowdMatchModel Data Structure.
    /// </summary>
    public class PromoxCrowdMatchModel : AlipayObject
    {
        /// <summary>
        /// 客群码
        /// </summary>
        [JsonPropertyName("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 是否匹配
        /// </summary>
        [JsonPropertyName("is_match")]
        public bool IsMatch { get; set; }
    }
}
