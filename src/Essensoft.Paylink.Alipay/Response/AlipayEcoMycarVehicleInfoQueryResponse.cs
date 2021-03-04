using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
