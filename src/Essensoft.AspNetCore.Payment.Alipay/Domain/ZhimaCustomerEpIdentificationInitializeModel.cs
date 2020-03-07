using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationInitializeModel Data Structure.
    /// </summary>
    public class ZhimaCustomerEpIdentificationInitializeModel : AlipayObject
    {
        /// <summary>
        /// 认证模式。 枚举值：法人认证——EP_LEGAL_PERSON_CERTIFY。
        /// </summary>
        [JsonPropertyName("certify_mode")]
        public string CertifyMode { get; set; }

        /// <summary>
        /// 值为json串，必须指定身份类型identity_type，不同的身份类型对应的身份信息不同。 当前支持的identity_type=EP_CERT_INFO ，身份信息为法人证件三要素与企业证件三要素，如 {"identity_type": "EP_CERT_INFO", "legal_person_cert_type": "IDENTITY_CARD", "legal_person_cert_name": "收委", "legal_person_cert_no":"260104197909275964", "ep_cert_type": "NATIONAL_LEGAL_MERGE", "ep_cert_name": "xxx有限公司", "ep_cert_no":"91330000327827106L"}。                   备注：（1）目前法人证件类型仅支持IDENTITY_CARD（身份证），企业证件类型仅支持 NATIONAL_LEGAL（工商注册号）和 NATIONAL_LEGAL_MERGE （ 社会统一信用代码）。   （2）企业信息可以不填，但是填的话必须填入企业名、企业证件号、企业证件类型。
        /// </summary>
        [JsonPropertyName("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 认证结束后的商户回调地址。
        /// </summary>
        [JsonPropertyName("merchant_url")]
        public string MerchantUrl { get; set; }

        /// <summary>
        /// 产品码，直接使用［示例］给出的值。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，表示商户在什么场景使用企业认证产品。
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，商户要保证其唯一性。值为32位长度的字母数字下划线组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段日期，结尾可以使用一个序列号。
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
