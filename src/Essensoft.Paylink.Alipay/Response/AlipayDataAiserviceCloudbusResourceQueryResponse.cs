using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
