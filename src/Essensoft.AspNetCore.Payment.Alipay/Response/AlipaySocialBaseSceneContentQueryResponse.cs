using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseSceneContentQueryResponse.
    /// </summary>
    public class AlipaySocialBaseSceneContentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 内容中台场景页文章信息
        /// </summary>
        [JsonPropertyName("scene_content")]
        public List<SceneContent> SceneContent { get; set; }

        /// <summary>
        /// 场景详情信息
        /// </summary>
        [JsonPropertyName("scene_detail")]
        public SceneDetail SceneDetail { get; set; }

        /// <summary>
        /// 更多文章跳转链接
        /// </summary>
        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }
    }
}
