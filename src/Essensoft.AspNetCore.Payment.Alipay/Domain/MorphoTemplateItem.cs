using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoTemplateItem Data Structure.
    /// </summary>
    public class MorphoTemplateItem : AlipayObject
    {
        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模板开发者
        /// </summary>
        [JsonPropertyName("owner")]
        public MorphoUser Owner { get; set; }

        /// <summary>
        /// 模板截图
        /// </summary>
        [JsonPropertyName("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [JsonPropertyName("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 模板标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
