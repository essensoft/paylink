using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDialogonlineVehicleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 生产年份，格式：yyyy
        /// </summary>
        [JsonPropertyName("factory_date")]
        public string FactoryDate { get; set; }

        /// <summary>
        /// 车型库ID
        /// </summary>
        [JsonPropertyName("lib_id")]
        public string LibId { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 常驻城市的编码
        /// </summary>
        [JsonPropertyName("resident_city")]
        public string ResidentCity { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [JsonPropertyName("vi_brand")]
        public string ViBrand { get; set; }

        /// <summary>
        /// 发动机排量
        /// </summary>
        [JsonPropertyName("vi_cc")]
        public string ViCc { get; set; }

        /// <summary>
        /// 车辆ID
        /// </summary>
        [JsonPropertyName("vi_id")]
        public string ViId { get; set; }

        /// <summary>
        /// 行驶里程
        /// </summary>
        [JsonPropertyName("vi_mileage")]
        public string ViMileage { get; set; }

        /// <summary>
        /// 车型
        /// </summary>
        [JsonPropertyName("vi_model")]
        public string ViModel { get; set; }

        /// <summary>
        /// 车系
        /// </summary>
        [JsonPropertyName("vi_series")]
        public string ViSeries { get; set; }

        /// <summary>
        /// 上路时间，格式：yyyy-mm-dd
        /// </summary>
        [JsonPropertyName("vi_time")]
        public string ViTime { get; set; }
    }
}
