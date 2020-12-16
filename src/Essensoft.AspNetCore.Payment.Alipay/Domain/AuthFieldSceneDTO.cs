using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthFieldSceneDTO Data Structure.
    /// </summary>
    public class AuthFieldSceneDTO : AlipayObject
    {
        /// <summary>
        /// 场景CODE
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景code描述
        /// </summary>
        [JsonPropertyName("scene_desc")]
        public string SceneDesc { get; set; }
    }
}
