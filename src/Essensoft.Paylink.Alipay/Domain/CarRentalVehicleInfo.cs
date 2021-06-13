using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CarRentalVehicleInfo Data Structure.
    /// </summary>
    public class CarRentalVehicleInfo : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [JsonPropertyName("vehicle_capacity")]
        public string VehicleCapacity { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        [JsonPropertyName("vehicle_color")]
        public string VehicleColor { get; set; }

        /// <summary>
        /// 车辆型号
        /// </summary>
        [JsonPropertyName("vehicle_models")]
        public string VehicleModels { get; set; }

        /// <summary>
        /// 厢数
        /// </summary>
        [JsonPropertyName("vehicle_number")]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// 操作类型 手动挡/自动挡
        /// </summary>
        [JsonPropertyName("vehicle_operation_type")]
        public string VehicleOperationType { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [JsonPropertyName("vehicle_seats")]
        public string VehicleSeats { get; set; }

        /// <summary>
        /// 车辆分类 经济型/舒适型/豪华型
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
