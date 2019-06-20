using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IcrowdUseContext Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseContext : AlipayObject
    {
        /// <summary>
        /// 是否开启debug模式
        /// </summary>
        [JsonProperty("debug")]
        public bool Debug { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 是否返回延迟信息
        /// </summary>
        [JsonProperty("show_delay")]
        public bool ShowDelay { get; set; }
    }
}
