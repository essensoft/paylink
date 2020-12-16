using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentIdentityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询用户所在大学，查询商户需要商务层面申请此字段，且支付宝模型中存在此字段才能返回。
        /// </summary>
        [JsonPropertyName("college_name")]
        public string CollegeName { get; set; }

        /// <summary>
        /// 查询用户是否目前是大学生
        /// </summary>
        [JsonPropertyName("college_online_tag")]
        public string CollegeOnlineTag { get; set; }
    }
}
