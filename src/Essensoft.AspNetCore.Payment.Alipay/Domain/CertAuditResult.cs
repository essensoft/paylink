using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class CertAuditResult : AlipayObject
    {
        /// <summary>
        /// 官方渠道信息比对结果返回码。  0：通过，  1：参数未输入，  2：参数不合法，   3：查询不到信息，   4：参数无法验证，   5：参数不匹配，  6：服务异常
        /// </summary>
        [JsonProperty("authority_check_retcode")]
        public string AuthorityCheckRetcode { get; set; }

        /// <summary>
        /// 官方渠道信息比对结果返回信息
        /// </summary>
        [JsonProperty("authority_check_retmessage")]
        public string AuthorityCheckRetmessage { get; set; }

        /// <summary>
        /// 官方渠道信息比对结果，通过Y，不通过N，待定U
        /// </summary>
        [JsonProperty("authority_check_suggest")]
        public string AuthorityCheckSuggest { get; set; }

        /// <summary>
        /// 证件上人脸比对结果，通过Y，不通过N，待定U
        /// </summary>
        [JsonProperty("cert_face_suggest")]
        public string CertFaceSuggest { get; set; }

        /// <summary>
        /// 合规结果，通过Y，不通过N，待定U
        /// </summary>
        [JsonProperty("compliance_suggest")]
        public string ComplianceSuggest { get; set; }

        /// <summary>
        /// ocr结果
        /// </summary>
        [JsonProperty("ocr")]
        public CertFields Ocr { get; set; }

        /// <summary>
        /// ocr比对结果，通过Y，不通过N，待定U
        /// </summary>
        [JsonProperty("ocr_check_suggest")]
        public string OcrCheckSuggest { get; set; }
    }
}
