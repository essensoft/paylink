using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceViolationinfoShareResponse : AlipayResponse
    {
        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("body_num")]
        public string BodyNum { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("engine_num")]
        public string EngineNum { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [JsonPropertyName("vehicle_id")]
        public string VehicleId { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        [JsonPropertyName("vi_number")]
        public string ViNumber { get; set; }
    }
}
