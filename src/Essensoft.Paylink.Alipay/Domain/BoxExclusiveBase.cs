using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxExclusiveBase Data Structure.
    /// </summary>
    public class BoxExclusiveBase : AlipayObject
    {
        /// <summary>
        /// box基础工单信息
        /// </summary>
        [JsonPropertyName("base_order_info")]
        public BoxOrderStatusInfo BaseOrderInfo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// box描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 2020111621000215527749
        /// </summary>
        [JsonPropertyName("main_id")]
        public string MainId { get; set; }

        /// <summary>
        /// box关联的服务类型
        /// </summary>
        [JsonPropertyName("main_type")]
        public string MainType { get; set; }

        /// <summary>
        /// 素材类型（图片/视频）
        /// </summary>
        [JsonPropertyName("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 素材地址
        /// </summary>
        [JsonPropertyName("material_url")]
        public string MaterialUrl { get; set; }

        /// <summary>
        /// box关联的pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
