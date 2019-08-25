using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialDetail : AlipayObject
    {
        /// <summary>
        /// 广告投放平台生成的物料ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 创意元素C端渲染关联位置key值
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 物料元素类型，IMG-图片；VIDEO-视频
        /// </summary>
        [JsonProperty("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 创意图片/视频物料元素URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
