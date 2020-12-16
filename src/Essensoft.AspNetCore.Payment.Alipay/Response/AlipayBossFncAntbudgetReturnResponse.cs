using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetReturnResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetReturnResponse : AlipayResponse
    {
        /// <summary>
        /// 退回成功后的记录id
        /// </summary>
        [JsonPropertyName("result_data")]
        public BizActionLogDTO ResultData { get; set; }

        /// <summary>
        /// 错误的详细信息，用于具体描述错误信息
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
