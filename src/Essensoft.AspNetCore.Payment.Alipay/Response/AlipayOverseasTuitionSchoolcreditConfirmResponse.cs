using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolcreditConfirmResponse.
    /// </summary>
    public class AlipayOverseasTuitionSchoolcreditConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 业务透传保留字段，json map格式
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
