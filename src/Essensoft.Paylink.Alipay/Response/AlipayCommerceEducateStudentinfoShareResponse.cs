using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentinfoShareResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentinfoShareResponse : AlipayResponse
    {
        /// <summary>
        /// 学生信息
        /// </summary>
        [JsonPropertyName("student_info_share_result")]
        public EduStudentInfoShareResult StudentInfoShareResult { get; set; }
    }
}
