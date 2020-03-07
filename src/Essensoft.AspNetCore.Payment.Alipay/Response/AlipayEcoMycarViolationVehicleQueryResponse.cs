using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarViolationVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarViolationVehicleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户车辆发动机号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 用户车辆ID,支付宝系统唯一
        /// </summary>
        [JsonPropertyName("vi_id")]
        public string ViId { get; set; }

        /// <summary>
        /// 用户车辆车牌号
        /// </summary>
        [JsonPropertyName("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 用户车辆识别码
        /// </summary>
        [JsonPropertyName("vin_no")]
        public string VinNo { get; set; }
    }
}
