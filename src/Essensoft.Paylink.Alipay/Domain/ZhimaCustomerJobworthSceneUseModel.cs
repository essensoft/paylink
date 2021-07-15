using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthSceneUseModel Data Structure.
    /// </summary>
    public class ZhimaCustomerJobworthSceneUseModel : AlipayObject
    {
        /// <summary>
        /// 针对不同的场景类型，使用不同的字段
        /// </summary>
        [JsonPropertyName("extra_info")]
        public SceneInfo ExtraInfo { get; set; }

        /// <summary>
        /// 候选人列表
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }
    }
}
