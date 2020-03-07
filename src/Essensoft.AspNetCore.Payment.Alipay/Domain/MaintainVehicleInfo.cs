using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaintainVehicleInfo Data Structure.
    /// </summary>
    public class MaintainVehicleInfo : AlipayObject
    {
        /// <summary>
        /// 背景图片
        /// </summary>
        [JsonPropertyName("bg_url")]
        public string BgUrl { get; set; }

        /// <summary>
        /// 发动机编号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 发动机类型
        /// </summary>
        [JsonPropertyName("engine_type")]
        public string EngineType { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 车主平台车型id
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 生产年份
        /// </summary>
        [JsonPropertyName("production_year")]
        public string ProductionYear { get; set; }

        /// <summary>
        /// 发动机排量
        /// </summary>
        [JsonPropertyName("swept_volume")]
        public List<string> SweptVolume { get; set; }

        /// <summary>
        /// 品牌Logo
        /// </summary>
        [JsonPropertyName("vi_brand_logo")]
        public string ViBrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("vi_brand_name")]
        public string ViBrandName { get; set; }

        /// <summary>
        /// 车辆归属地id
        /// </summary>
        [JsonPropertyName("vi_city_id")]
        public string ViCityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("vi_city_name")]
        public string ViCityName { get; set; }

        /// <summary>
        /// 车辆图标URL
        /// </summary>
        [JsonPropertyName("vi_logo_url")]
        public string ViLogoUrl { get; set; }

        /// <summary>
        /// 行驶里程
        /// </summary>
        [JsonPropertyName("vi_mileage")]
        public string ViMileage { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [JsonPropertyName("vi_model_name")]
        public string ViModelName { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [JsonPropertyName("vi_series_name")]
        public string ViSeriesName { get; set; }

        /// <summary>
        /// 上路日期
        /// </summary>
        [JsonPropertyName("vi_start_time")]
        public string ViStartTime { get; set; }

        /// <summary>
        /// 年款
        /// </summary>
        [JsonPropertyName("vi_style_name")]
        public string ViStyleName { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("vi_vin")]
        public List<string> ViVin { get; set; }

        /// <summary>
        /// 行驶证注册时间
        /// </summary>
        [JsonPropertyName("vl_start_time")]
        public string VlStartTime { get; set; }
    }
}
