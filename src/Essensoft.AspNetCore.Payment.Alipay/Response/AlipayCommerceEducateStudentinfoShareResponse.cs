using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentinfoShareResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentinfoShareResponse : AlipayResponse
    {
        /// <summary>
        /// 学生信息
        /// </summary>
        [JsonProperty("student_info_share_result")]
        public EduStudentInfoShareResult StudentInfoShareResult { get; set; }
    }
}
