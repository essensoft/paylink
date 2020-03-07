using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntforestPlantConsultResponse.
    /// </summary>
    public class AlipaySocialAntforestPlantConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 当前账户可用能量
        /// </summary>
        [JsonPropertyName("current_energy")]
        public long CurrentEnergy { get; set; }

        /// <summary>
        /// 项目是否可兑换
        /// </summary>
        [JsonPropertyName("project_alliable")]
        public bool ProjectAlliable { get; set; }
    }
}
