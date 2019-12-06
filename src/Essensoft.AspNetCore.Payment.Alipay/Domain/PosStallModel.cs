using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosStallModel Data Structure.
    /// </summary>
    public class PosStallModel : AlipayObject
    {
        /// <summary>
        /// 菜品下档口的排序号
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 档口ID
        /// </summary>
        [JsonPropertyName("stall_id")]
        public string StallId { get; set; }

        /// <summary>
        /// 档口名字
        /// </summary>
        [JsonPropertyName("stall_name")]
        public string StallName { get; set; }
    }
}
