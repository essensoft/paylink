using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcodeTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateSchoolcodeTokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 学生信息凭证，在用户信息授权时使用，作为授权url中state的参数值，创建token接口返回
        /// </summary>
        [JsonPropertyName("school_code_token")]
        public string SchoolCodeToken { get; set; }
    }
}
