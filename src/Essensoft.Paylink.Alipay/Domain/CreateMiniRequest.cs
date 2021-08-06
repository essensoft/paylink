using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CreateMiniRequest Data Structure.
    /// </summary>
    public class CreateMiniRequest : AlipayObject
    {
        /// <summary>
        /// 商家登录支付宝的邮箱帐号或手机号，当前仅支持企业支付宝帐号
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 营业执照企业名称
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 营业执照编码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商家联系人名称
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 商家联系人手机电话
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 商家法人名称
        /// </summary>
        [JsonPropertyName("legal_personal_name")]
        public string LegalPersonalName { get; set; }

        /// <summary>
        /// 开发者外部订单号，通过开发者账号+outOrderNo做业务幂等
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
