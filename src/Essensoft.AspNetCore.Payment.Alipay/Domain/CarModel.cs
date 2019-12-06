using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CarModel Data Structure.
    /// </summary>
    public class CarModel : AlipayObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [JsonPropertyName("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [JsonPropertyName("engine_desc")]
        public string EngineDesc { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [JsonPropertyName("family_short_name")]
        public string FamilyShortName { get; set; }

        /// <summary>
        /// 车辆驾驶类型
        /// </summary>
        [JsonPropertyName("gear_box_type")]
        public string GearBoxType { get; set; }

        /// <summary>
        /// 新车购置价
        /// </summary>
        [JsonPropertyName("purchase_price")]
        public string PurchasePrice { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [JsonPropertyName("seat")]
        public string Seat { get; set; }

        /// <summary>
        /// 最大额定座位数
        /// </summary>
        [JsonPropertyName("seat_max")]
        public string SeatMax { get; set; }

        /// <summary>
        /// 最小额定座位数
        /// </summary>
        [JsonPropertyName("seat_min")]
        public string SeatMin { get; set; }

        /// <summary>
        /// 车辆类型编码
        /// </summary>
        [JsonPropertyName("vehicle_class_code")]
        public string VehicleClassCode { get; set; }

        /// <summary>
        /// 车型代码
        /// </summary>
        [JsonPropertyName("vehicle_code")]
        public string VehicleCode { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [JsonPropertyName("vehicle_name")]
        public string VehicleName { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        [JsonPropertyName("year_pattern")]
        public string YearPattern { get; set; }
    }
}
