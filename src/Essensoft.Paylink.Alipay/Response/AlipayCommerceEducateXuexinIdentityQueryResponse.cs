using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateXuexinIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateXuexinIdentityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 0表示非学生,1表示学生
        /// </summary>
        [JsonPropertyName("college_online_tag")]
        public string CollegeOnlineTag { get; set; }

        /// <summary>
        /// 预计毕业时间 yyyyMM
        /// </summary>
        [JsonPropertyName("graduate_time")]
        public string GraduateTime { get; set; }
    }
}
