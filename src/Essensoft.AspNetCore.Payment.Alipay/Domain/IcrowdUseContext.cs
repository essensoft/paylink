using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IcrowdUseContext Data Structure.
    /// </summary>
    public class IcrowdUseContext : AlipayObject
    {
        /// <summary>
        /// 是否开启debug模式
        /// </summary>
        [JsonPropertyName("debug")]
        public bool Debug { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 是否返回延迟信息
        /// </summary>
        [JsonPropertyName("show_delay")]
        public bool ShowDelay { get; set; }
    }
}
