using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateInfo Data Structure.
    /// </summary>
    public class TemplateInfo : AlipayObject
    {
        /// <summary>
        /// 模板填充项
        /// </summary>
        [JsonPropertyName("fill_contents")]
        public List<FillContent> FillContents { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签署区
        /// </summary>
        [JsonPropertyName("signfields")]
        public SignField Signfields { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
