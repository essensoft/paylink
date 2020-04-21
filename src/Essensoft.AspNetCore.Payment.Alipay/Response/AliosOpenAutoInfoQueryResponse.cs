using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AliosOpenAutoInfoQueryResponse.
    /// </summary>
    public class AliosOpenAutoInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别号码
        /// </summary>
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
    }
}
