using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdSeAppletQueryResponse.
    /// </summary>
    public class AlipaySecurityProdSeAppletQueryResponse : AlipayResponse
    {
        /// <summary>
        /// apdu_commands:apdu指令列表，逗号分隔，根据该值确定硬件端对applet的具体操作
        /// </summary>
        [JsonPropertyName("apdu_commands")]
        public string ApduCommands { get; set; }

        /// <summary>
        /// 操作类型，唯一，传递tsm的具体操作，厂测程序提供
        /// </summary>
        [JsonPropertyName("opt_type")]
        public long OptType { get; set; }

        /// <summary>
        /// result_code:调用tsm返回的结果码，根据该字段可以知道本次调用的状态
        /// </summary>
        [JsonPropertyName("result_code")]
        public long ResultCode { get; set; }

        /// <summary>
        /// step:表示调用tsm过程中的步骤数
        /// </summary>
        [JsonPropertyName("step")]
        public long Step { get; set; }

        /// <summary>
        /// step_code:tsm返回的步骤编码，供多语使用
        /// </summary>
        [JsonPropertyName("step_code")]
        public long StepCode { get; set; }

        /// <summary>
        /// sub_opt_type:子操作类型，tsm返回给厂测程序
        /// </summary>
        [JsonPropertyName("sub_opt_type")]
        public long SubOptType { get; set; }

        /// <summary>
        /// total_step:表示调用tsm的总步骤数
        /// </summary>
        [JsonPropertyName("total_step")]
        public long TotalStep { get; set; }
    }
}
