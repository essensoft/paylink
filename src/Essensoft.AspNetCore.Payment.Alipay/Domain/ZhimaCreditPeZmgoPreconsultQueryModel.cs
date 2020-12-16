using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreconsultQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoPreconsultQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务来源：阿里集团内传ALIBABA_INNER
        /// </summary>
        [JsonPropertyName("biz_src")]
        public string BizSrc { get; set; }

        /// <summary>
        /// 业务类型：淘宝特价版传LITE_TAO
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
