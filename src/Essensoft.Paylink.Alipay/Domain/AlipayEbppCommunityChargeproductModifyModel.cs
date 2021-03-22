using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityChargeproductModifyModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityChargeproductModifyModel : AlipayObject
    {
        /// <summary>
        /// 小区编码
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 维护结束时间
        /// </summary>
        [JsonPropertyName("maintaining_end")]
        public string MaintainingEnd { get; set; }

        /// <summary>
        /// 维护开始时间
        /// </summary>
        [JsonPropertyName("maintaining_start")]
        public string MaintainingStart { get; set; }
    }
}
