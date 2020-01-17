using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignFlowCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoSignFlowCreateModel : AlipayObject
    {
        /// <summary>
        /// 附件信息
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// 流程主题
        /// </summary>
        [JsonPropertyName("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 流程配置信息
        /// </summary>
        [JsonPropertyName("config_info")]
        public ConfigInfo ConfigInfo { get; set; }

        /// <summary>
        /// 模板信息
        /// </summary>
        [JsonPropertyName("template_infos")]
        public List<TemplateInfo> TemplateInfos { get; set; }
    }
}
