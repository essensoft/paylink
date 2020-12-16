using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoSignflowsCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoSignflowsCreateModel : AlipayObject
    {
        /// <summary>
        /// 附件信息（附件可作为合同的辅助证明材料，无需签署。需通过文件直传接口上传附件，获取文件id后添加）
        /// </summary>
        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }

        /// <summary>
        /// 流程主题（简要概括合同的签署内容）
        /// </summary>
        [JsonPropertyName("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 流程配置信息（可配置回调地址、物流单号等信息）
        /// </summary>
        [JsonPropertyName("config_info")]
        public ConfigInfoBean ConfigInfo { get; set; }

        /// <summary>
        /// 模板信息（基于合同模板填充内容生成待签文件，并指定签署人）
        /// </summary>
        [JsonPropertyName("template_infos")]
        public TemplateInfoBean TemplateInfos { get; set; }
    }
}
