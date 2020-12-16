using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleResResult Result { get; set; }
    }
}
