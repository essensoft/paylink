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
        /// 权益icon图片Id（目前用于开卡授权页使用），通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [JsonPropertyName("logo_id")]
        public string LogoId { get; set; }

        /// <summary>
        /// 权益内容标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
