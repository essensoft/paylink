using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateRightsContentDTO Data Structure.
    /// </summary>
    public class TemplateRightsContentDTO : AlipayObject
    {
        /// <summary>
        /// 权益内容详情
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 权益内容标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
