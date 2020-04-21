using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MedicalSvTpCardBodyInfo Data Structure.
    /// </summary>
    public class MedicalSvTpCardBodyInfo : AlipayObject
    {
        /// <summary>
        /// 模板消息主体主要内容题,开发者自定义  备注：根据模板样式编码来确认是否可空
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 模板消息主体内同图标URL  图片大小（长*宽,单位px）328*328  备注：根据模板样式编码来确认是否可空
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 模板消息主体内容的URL链接  备注：根据模板样式编码来确认是否可空
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 模板消息主体内容的备注  备注：根据模板样式编码来确认是否可空
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 模板消息主体内容的副内容  备注：根据模板样式编码来确认是否可空
        /// </summary>
        [JsonPropertyName("sub_contenet")]
        public string SubContenet { get; set; }

        /// <summary>
        /// 模板消息主体内容的副标题  备注：根据模板样式编码来确认是否可空
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 主体内容中的标题,开发者自定义  备注：根据模板类型确定属性是否可空
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
