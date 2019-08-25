using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaintainVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainVehicleInfo : AlipayObject
    {
        /// <summary>
        /// 背景图片
        /// </summary>
        [JsonProperty("bg_url")]
        public string BgUrl { get; set; }

        /// <summary>
        /// 发动机编号
        /// </summary>
        [JsonProperty("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 发动机类型
        /// </summary>
        [JsonProperty("engine_type")]
        public string EngineType { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 车主平台车型id
        /// </summary>
        [JsonProperty("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 生产年份
        /// </summary>
        [JsonProperty("production_year")]
        public string ProductionYear { get; set; }

        /// <summary>
        /// 发动机排量
        /// </summary>
        [JsonProperty("swept_volume")]
        public List<string> SweptVolume { get; set; }

        /// <summary>
        /// 品牌Logo
        /// </summary>
        [JsonProperty("vi_brand_logo")]
        public string ViBrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("vi_brand_name")]
        public string ViBrandName { get; set; }

        /// <summary>
        /// 车辆归属地id
        /// </summary>
        [JsonProperty("vi_city_id")]
        public string ViCityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonProperty("vi_city_name")]
        public string ViCityName { get; set; }

        /// <summary>
        /// 车辆图标URL
        /// </summary>
        [JsonProperty("vi_logo_url")]
        public string ViLogoUrl { get; set; }

        /// <summary>
        /// 行驶里程
        /// </summary>
        [JsonProperty("vi_mileage")]
        public string ViMileage { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [JsonProperty("vi_model_name")]
        public string ViModelName { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [JsonProperty("vi_series_name")]
        public string ViSeriesName { get; set; }

        /// <summary>
        /// 上路日期
        /// </summary>
        [JsonProperty("vi_start_time")]
        public string ViStartTime { get; set; }

        /// <summary>
        /// 年款
        /// </summary>
        [JsonProperty("vi_style_name")]
        public string ViStyleName { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("vi_vin")]
        public List<string> ViVin { get; set; }

        /// <summary>
        /// 行驶证注册时间
        /// </summary>
        [JsonProperty("vl_start_time")]
        public string VlStartTime { get; set; }
    }
}
