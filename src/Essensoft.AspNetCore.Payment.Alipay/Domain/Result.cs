using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Result Data Structure.
    /// </summary>
    public class Result : AlipayObject
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果详细信息
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 结果状态，包含： S 成功 F 失败 U 未知异常
        /// </summary>
        [JsonPropertyName("result_status")]
        public string ResultStatus { get; set; }
    }
}
