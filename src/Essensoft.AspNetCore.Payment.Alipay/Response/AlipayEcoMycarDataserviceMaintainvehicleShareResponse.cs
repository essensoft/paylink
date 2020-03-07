using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AlipayResponse
    {
        /// <summary>
        /// 车辆详细信息
        /// </summary>
        [JsonPropertyName("info")]
        public MaintainVehicleInfo Info { get; set; }
    }
}
