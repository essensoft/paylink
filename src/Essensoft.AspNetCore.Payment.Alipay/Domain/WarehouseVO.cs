using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WarehouseVO Data Structure.
    /// </summary>
    [Serializable]
    public class WarehouseVO : AlipayObject
    {
        /// <summary>
        /// 仓库详细地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("area_code")]
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("area_name")]
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 仓库的状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [JsonProperty("biz_status")]
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 菜鸟仓的编码
        /// </summary>
        [JsonProperty("cainiao_code")]
        [XmlElement("cainiao_code")]
        public string CainiaoCode { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市的名称
        /// </summary>
        [JsonProperty("city_name")]
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("contact")]
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [JsonProperty("lat")]
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("lon")]
        [XmlElement("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 归属人ID
        /// </summary>
        [JsonProperty("owner_id")]
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty("phone")]
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 省的编码
        /// </summary>
        [JsonProperty("province_code")]
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省的名称
        /// </summary>
        [JsonProperty("province_name")]
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 对应的门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("warehouse_name")]
        [XmlElement("warehouse_name")]
        public string WarehouseName { get; set; }

        /// <summary>
        /// 仓库类型，REAL：实仓
        /// </summary>
        [JsonProperty("warehouse_type")]
        [XmlElement("warehouse_type")]
        public string WarehouseType { get; set; }
    }
}
