using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceJunengLoanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceJunengLoanQueryModel : AlipayObject
    {
        /// <summary>
        /// 额外的信息，以 json 字符串的方式组织
        /// </summary>
        [JsonProperty("extension_info")]
        public string ExtensionInfo { get; set; }

        /// <summary>
        /// 借款人身份证号的md5
        /// </summary>
        [JsonProperty("hashed_cert_no")]
        public string HashedCertNo { get; set; }

        /// <summary>
        /// 机构代码，区别调用的外部机构
        /// </summary>
        [JsonProperty("institution_uuid")]
        public string InstitutionUuid { get; set; }

        /// <summary>
        /// 单次请求的 uuid
        /// </summary>
        [JsonProperty("request_uuid")]
        public string RequestUuid { get; set; }

        /// <summary>
        /// 用户属性，包含隐私保护数据和原始数据。
        /// </summary>
        [JsonProperty("user_feature")]
        public string UserFeature { get; set; }
    }
}
