using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureInfoSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureInfoSendModel : AlipayObject
    {
        /// <summary>
        /// 人脸算法版本
        /// </summary>
        [JsonPropertyName("alg_version")]
        public string AlgVersion { get; set; }

        /// <summary>
        /// 人脸特征场景码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，默认为1. 1:居民身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 扩展信息，json串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// isv英文简称
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 国家统一分配的学校社会信用代码(institution_id)
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 支付宝用户id集合,最大条数500
        /// </summary>
        [JsonPropertyName("user_ids")]
        public List<string> UserIds { get; set; }
    }
}
