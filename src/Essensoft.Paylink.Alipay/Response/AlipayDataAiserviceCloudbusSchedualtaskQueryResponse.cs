using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtaskQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleWorkResult Result { get; set; }
    }
}
