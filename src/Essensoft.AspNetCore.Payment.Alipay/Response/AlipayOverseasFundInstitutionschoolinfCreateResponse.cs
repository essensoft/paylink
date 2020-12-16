using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasFundInstitutionschoolinfCreateResponse.
    /// </summary>
    public class AlipayOverseasFundInstitutionschoolinfCreateResponse : AlipayResponse
    {
        /// <summary>
        /// ISV入驻签约PID
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// isv原始请求编号，同创建接口的 isv_request_no字段
        /// </summary>
        [JsonPropertyName("isv_request_no")]
        public string IsvRequestNo { get; set; }

        /// <summary>
        /// 透传保留字段，json map格式
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 学校PID
        /// </summary>
        [JsonPropertyName("school_pid")]
        public string SchoolPid { get; set; }
    }
}
