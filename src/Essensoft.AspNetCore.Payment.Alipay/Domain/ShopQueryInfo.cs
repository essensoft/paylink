using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopQueryInfo : AlipayObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否包含同mid下的其他pid的店铺
        /// </summary>
        [JsonProperty("is_include_cognate")]
        [XmlElement("is_include_cognate")]
        public bool IsIncludeCognate { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonProperty("pid")]
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 内部门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店类型
        /// </summary>
        [JsonProperty("shop_type")]
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        [JsonProperty("store_id")]
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
