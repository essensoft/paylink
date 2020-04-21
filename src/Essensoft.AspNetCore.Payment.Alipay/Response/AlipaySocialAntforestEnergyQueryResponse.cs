using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntforestEnergyQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestEnergyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前用户可用能量值（单位是g)
        /// </summary>
        [JsonPropertyName("current_energy")]
        public long CurrentEnergy { get; set; }

        /// <summary>
        /// 用户当前总能量（单位是g)
        /// </summary>
        [JsonPropertyName("total_energy")]
        public long TotalEnergy { get; set; }
    }
}
