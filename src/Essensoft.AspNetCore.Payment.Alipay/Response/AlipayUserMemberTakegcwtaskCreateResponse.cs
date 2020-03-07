using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserMemberTakegcwtaskCreateResponse.
    /// </summary>
    public class AlipayUserMemberTakegcwtaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 任务流水id，唯一值，用于双方幂等控制
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// true领取成功，false领取失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
