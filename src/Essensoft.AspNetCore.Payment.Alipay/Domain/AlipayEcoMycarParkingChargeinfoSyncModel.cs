using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingChargeinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingChargeinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 营业时间
        /// </summary>
        [JsonPropertyName("business_hours")]
        public string BusinessHours { get; set; }

        /// <summary>
        /// 小车-白天 非首个计费单元价格
        /// </summary>
        [JsonPropertyName("car_daylight_advanced_price")]
        public string CarDaylightAdvancedPrice { get; set; }

        /// <summary>
        /// 小车-白天 首个计费单元价格
        /// </summary>
        [JsonPropertyName("car_daylight_base_price")]
        public string CarDaylightBasePrice { get; set; }

        /// <summary>
        /// 小车-夜间 非首个计费单元价格
        /// </summary>
        [JsonPropertyName("car_night_advanced_price")]
        public string CarNightAdvancedPrice { get; set; }

        /// <summary>
        /// 小车-夜间 首个计费单元价格
        /// </summary>
        [JsonPropertyName("car_night_base_price")]
        public string CarNightBasePrice { get; set; }

        /// <summary>
        /// 小车 计次收费价格  xx元 / 次，按次收费的车场填写
        /// </summary>
        [JsonPropertyName("car_onetime_price")]
        public string CarOnetimePrice { get; set; }

        /// <summary>
        /// 单日停车封顶价格：具体值或“不封顶”
        /// </summary>
        [JsonPropertyName("daily_price_upperbound")]
        public string DailyPriceUpperbound { get; set; }

        /// <summary>
        /// 车场白天（收费）营业时间段
        /// </summary>
        [JsonPropertyName("daylight_business_hours")]
        public string DaylightBusinessHours { get; set; }

        /// <summary>
        /// 单次停车免费时长
        /// </summary>
        [JsonPropertyName("free_period")]
        public string FreePeriod { get; set; }

        /// <summary>
        /// 是否有充电桩: -1 未知,0 否,1 是
        /// </summary>
        [JsonPropertyName("has_charging_pile")]
        public string HasChargingPile { get; set; }

        /// <summary>
        /// 是否收费：-1 未知,0 否,1 是
        /// </summary>
        [JsonPropertyName("is_charge")]
        public string IsCharge { get; set; }

        /// <summary>
        /// 车场夜间（收费）营业时间段
        /// </summary>
        [JsonPropertyName("night_business_hours")]
        public string NightBusinessHours { get; set; }

        /// <summary>
        /// 停车场ID
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 总车位数
        /// </summary>
        [JsonPropertyName("parking_space_count")]
        public long ParkingSpaceCount { get; set; }

        /// <summary>
        /// 复杂计费补充描述  收费复杂无法格式化的车场填写，以文本形式表述
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 大车-白天 非首个计费单元价格
        /// </summary>
        [JsonPropertyName("truck_daylight_advanced_price")]
        public string TruckDaylightAdvancedPrice { get; set; }

        /// <summary>
        /// 大车-白天 首个计费单元价格
        /// </summary>
        [JsonPropertyName("truck_daylight_base_price")]
        public string TruckDaylightBasePrice { get; set; }

        /// <summary>
        /// 大车-夜间 非首个计费单元价格
        /// </summary>
        [JsonPropertyName("truck_night_advanced_price")]
        public string TruckNightAdvancedPrice { get; set; }

        /// <summary>
        /// 大车-夜间 首个计费单元价格
        /// </summary>
        [JsonPropertyName("truck_night_base_price")]
        public string TruckNightBasePrice { get; set; }

        /// <summary>
        /// 大车 计次收费价格  xx元 / 次，按次收费的车场填写
        /// </summary>
        [JsonPropertyName("truck_onetime_price")]
        public string TruckOnetimePrice { get; set; }
    }
}
