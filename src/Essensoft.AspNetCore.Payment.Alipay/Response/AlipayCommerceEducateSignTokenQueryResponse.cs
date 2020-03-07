using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSignTokenQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务场景类型标识
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 需要将该字段返回给学校
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型（"1","居民身份证"）
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [JsonPropertyName("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
