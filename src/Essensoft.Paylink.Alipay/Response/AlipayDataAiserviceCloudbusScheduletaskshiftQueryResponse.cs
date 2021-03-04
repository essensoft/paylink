using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
