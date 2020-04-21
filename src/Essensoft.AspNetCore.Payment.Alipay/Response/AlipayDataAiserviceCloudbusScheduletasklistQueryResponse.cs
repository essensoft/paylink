using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletasklistQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletasklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleListResult Result { get; set; }
    }
}
