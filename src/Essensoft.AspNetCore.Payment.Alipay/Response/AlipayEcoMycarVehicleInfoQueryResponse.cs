using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarVehicleInfoQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehicleInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 车辆信息列表
        /// </summary>
        [JsonPropertyName("vehicle_list")]
        public List<VehicleInfoDto> VehicleList { get; set; }
    }
}
