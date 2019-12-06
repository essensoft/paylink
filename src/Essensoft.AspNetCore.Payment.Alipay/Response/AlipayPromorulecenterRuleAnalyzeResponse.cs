using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPromorulecenterRuleAnalyzeResponse.
    /// </summary>
    public class AlipayPromorulecenterRuleAnalyzeResponse : AlipayResponse
    {
        /// <summary>
        /// 未通过条件描述信息
        /// </summary>
        [JsonPropertyName("fail_condition_msg")]
        public string FailConditionMsg { get; set; }

        /// <summary>
        /// 未通过的条件
        /// </summary>
        [JsonPropertyName("fail_condition_name")]
        public string FailConditionName { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// 规则是否通过
        /// </summary>
        [JsonPropertyName("triggered")]
        public string Triggered { get; set; }
    }
}
