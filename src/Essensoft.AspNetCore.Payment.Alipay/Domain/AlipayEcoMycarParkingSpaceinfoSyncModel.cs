using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingSpaceinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingSpaceinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 空闲充电桩车位数
        /// </summary>
        [JsonPropertyName("free_charging_pile")]
        public long FreeChargingPile { get; set; }

        /// <summary>
        /// 车场空闲可用的车位数
        /// </summary>
        [JsonPropertyName("free_parking_space")]
        public long FreeParkingSpace { get; set; }

        /// <summary>
        /// 停车场ID
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场实时状态: 0 拥堵,1 正常，2 空闲
        /// </summary>
        [JsonPropertyName("parking_space_status")]
        public string ParkingSpaceStatus { get; set; }
    }
}
