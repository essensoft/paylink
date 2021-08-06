using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreConsultModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoPreConsultModel : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
