using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceJunengLoanQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceJunengLoanQueryModel : AlipayObject
    {
        /// <summary>
        /// 额外的信息，以 json 字符串的方式组织
        /// </summary>
        [JsonPropertyName("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 借款人身份证号的md5
        /// </summary>
        [JsonPropertyName("hashed_cert_no")]
        public string HashedCertNo { get; set; }

        /// <summary>
        /// 机构代码，区别调用的外部机构
        /// </summary>
        [JsonPropertyName("institution_uuid")]
        public string InstitutionUuid { get; set; }

        /// <summary>
        /// 单次请求的 uuid
        /// </summary>
        [JsonPropertyName("request_uuid")]
        public string RequestUuid { get; set; }

        /// <summary>
        /// 用户属性，包含隐私保护数据和原始数据。
        /// </summary>
        [JsonPropertyName("user_feature")]
        public string UserFeature { get; set; }
    }
}
