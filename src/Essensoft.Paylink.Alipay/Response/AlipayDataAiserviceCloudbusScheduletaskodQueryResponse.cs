using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleOdResult Result { get; set; }
    }
}
