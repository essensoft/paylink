using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialDetail Data Structure.
    /// </summary>
    public class MaterialDetail : AlipayObject
    {
        /// <summary>
        /// 广告投放平台生成的物料ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 创意元素C端渲染关联位置key值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 物料元素类型，IMG-图片；VIDEO-视频
        /// </summary>
        [JsonPropertyName("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 创意图片/视频物料元素URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
