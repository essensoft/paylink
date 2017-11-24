using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateModel : AlipayObject
    {
        /// <summary>
        /// 对于场景ID的描述，商户自己定义
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 短链接对应的场景ID，该ID由商户自己定义
        /// </summary>
        [JsonProperty("scene_id")]
        public string SceneId { get; set; }
    }
}
