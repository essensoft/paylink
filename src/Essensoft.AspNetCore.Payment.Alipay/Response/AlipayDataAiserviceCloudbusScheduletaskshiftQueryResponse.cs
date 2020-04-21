using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleShiftResult Result { get; set; }
    }
}
