using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CarModel Data Structure.
    /// </summary>
    [Serializable]
    public class CarModel : AlipayObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [JsonProperty("config_name")]
        [XmlElement("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [JsonProperty("engine_desc")]
        [XmlElement("engine_desc")]
        public string EngineDesc { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [JsonProperty("family_short_name")]
        [XmlElement("family_short_name")]
        public string FamilyShortName { get; set; }

        /// <summary>
        /// 车辆驾驶类型
        /// </summary>
        [JsonProperty("gear_box_type")]
        [XmlElement("gear_box_type")]
        public string GearBoxType { get; set; }

        /// <summary>
        /// 新车购置价
        /// </summary>
        [JsonProperty("purchase_price")]
        [XmlElement("purchase_price")]
        public string PurchasePrice { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [JsonProperty("seat")]
        [XmlElement("seat")]
        public string Seat { get; set; }

        /// <summary>
        /// 车辆类型编码
        /// </summary>
        [JsonProperty("vehicle_class_code")]
        [XmlElement("vehicle_class_code")]
        public string VehicleClassCode { get; set; }

        /// <summary>
        /// 车型代码
        /// </summary>
        [JsonProperty("vehicle_code")]
        [XmlElement("vehicle_code")]
        public string VehicleCode { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [JsonProperty("vehicle_name")]
        [XmlElement("vehicle_name")]
        public string VehicleName { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        [JsonProperty("year_pattern")]
        [XmlElement("year_pattern")]
        public string YearPattern { get; set; }
    }
}
