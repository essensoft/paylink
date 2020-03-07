using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleTimeResult Result { get; set; }
    }
}
