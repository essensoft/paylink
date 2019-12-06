using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DxVerifyResultItem Data Structure.
    /// </summary>
    public class DxVerifyResultItem : AlipayObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 验证的输入参数，map的json格式序列化传递
        /// </summary>
        [JsonPropertyName("input")]
        public string Input { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        [JsonPropertyName("line")]
        public long Line { get; set; }

        /// <summary>
        /// 输出值，map的json格式序列化传递
        /// </summary>
        [JsonPropertyName("output")]
        public string Output { get; set; }

        /// <summary>
        /// 预测的结果值，map的json 格式序列化传递
        /// </summary>
        [JsonPropertyName("predict")]
        public string Predict { get; set; }

        /// <summary>
        /// 验证是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 验证路径
        /// </summary>
        [JsonPropertyName("trace")]
        public string Trace { get; set; }
    }
}
