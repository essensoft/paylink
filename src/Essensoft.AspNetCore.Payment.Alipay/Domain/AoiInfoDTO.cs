using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AoiInfoDTO Data Structure.
    /// </summary>
    public class AoiInfoDTO : AlipayObject
    {
        /// <summary>
        /// 生活圈名称
        /// </summary>
        [JsonPropertyName("aoi_name")]
        public string AoiName { get; set; }

        /// <summary>
        /// 生活圈标签； 1.aoi类型为非社区：AOI名称； 2.aoi类型为社区：AOI名称/店铺所在的街道路名+离当前主AOI的距离
        /// </summary>
        [JsonPropertyName("aoi_tag")]
        public string AoiTag { get; set; }

        /// <summary>
        /// 生活圈小程序URL链接
        /// </summary>
        [JsonPropertyName("circle_detail_url")]
        public string CircleDetailUrl { get; set; }

        /// <summary>
        /// 生活圈ID
        /// </summary>
        [JsonPropertyName("tribe_id")]
        public string TribeId { get; set; }
    }
}
