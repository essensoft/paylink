using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
