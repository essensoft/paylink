using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateAuxiliaryItem Data Structure.
    /// </summary>
    public class PayForPrivilegeCardTemplateAuxiliaryItem : AlipayObject
    {
        /// <summary>
        /// 该辅助区域项目的唯一标识
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该辅助区域项目的展示文字
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 该辅助区域项目的类型，可选值包括 openWeb(跳转), text(文本)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 该辅助区域项目的跳转链接，当type为openweb的时候必填
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 该辅助区域项目的文字描述信息，出现在label的右侧，对label的辅助信息展示
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
