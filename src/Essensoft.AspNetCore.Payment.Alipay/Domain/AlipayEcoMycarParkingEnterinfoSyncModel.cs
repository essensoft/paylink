using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingEnterinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 支付宝停车场ID ，系统唯一
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}
