using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryAddress Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryAddress : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [JsonProperty("contact_name")]
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("contact_phone")]
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 区信息
        /// </summary>
        [JsonProperty("district")]
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("province")]
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("warehouse_id")]
        [XmlElement("warehouse_id")]
        public string WarehouseId { get; set; }

        /// <summary>
        /// 供应商的仓库名称
        /// </summary>
        [JsonProperty("warehouse_name")]
        [XmlElement("warehouse_name")]
        public string WarehouseName { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonProperty("zip_code")]
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
