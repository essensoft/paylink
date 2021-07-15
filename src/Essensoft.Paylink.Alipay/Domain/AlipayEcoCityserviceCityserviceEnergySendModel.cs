using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceCityserviceEnergySendModel Data Structure.
    /// </summary>
    public class AlipayEcoCityserviceCityserviceEnergySendModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<EnergyExtRequest> ExtInfo { get; set; }

        /// <summary>
        /// 外部业务号，用作幂等。同一场景下，一条外部业务号只可消费一次。
        /// </summary>
        [JsonPropertyName("outer_no")]
        public string OuterNo { get; set; }

        /// <summary>
        /// 能量发放场景，如：医院-挂号
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
