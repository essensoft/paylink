using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigSetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigSetResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleConfigResult Result { get; set; }
    }
}
