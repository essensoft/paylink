using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ParkingOutScene Data Structure.
    /// </summary>
    public class ParkingOutScene : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 停车费用
        /// </summary>
        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 出场时间
        /// </summary>
        [JsonPropertyName("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 停车场id
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [JsonPropertyName("parking_name")]
        public string ParkingName { get; set; }
    }
}
