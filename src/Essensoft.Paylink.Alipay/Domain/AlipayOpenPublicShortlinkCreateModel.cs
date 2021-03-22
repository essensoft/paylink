using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateModel : AlipayObject
    {
        /// <summary>
        /// 对于场景ID的描述，由商户自定义。
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 短链接对应的场景ID。由商户自定义，仅支持数字、字母及下划线。
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }
    }
}
