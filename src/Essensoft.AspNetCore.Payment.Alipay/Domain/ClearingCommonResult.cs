using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ClearingCommonResult Data Structure.
    /// </summary>
    public class ClearingCommonResult : AlipayObject
    {
        /// <summary>
        /// 返回结果code
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果中文描述 EXECUTE_SUCCESS UNKNOWN_EXCEPTION DATABASE_EXCEPTION
        /// </summary>
        [JsonPropertyName("result_description")]
        public string ResultDescription { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
