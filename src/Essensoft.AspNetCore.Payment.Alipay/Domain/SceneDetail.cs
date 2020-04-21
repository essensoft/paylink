using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDetail Data Structure.
    /// </summary>
    public class SceneDetail : AlipayObject
    {
        /// <summary>
        /// 场景描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 场景配置的图片
        /// </summary>
        [JsonPropertyName("scene_image")]
        public string SceneImage { get; set; }

        /// <summary>
        /// 小蚂答场景标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
