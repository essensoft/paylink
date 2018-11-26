using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecItemInfo : AlipayObject
    {
        /// <summary>
        /// 归属地区
        /// </summary>
        [JsonProperty("area_code")]
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 业务分类
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息,JSONSTRING格式
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        [JsonProperty("icon")]
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Item编码
        /// </summary>
        [JsonProperty("item_code")]
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 推荐Item名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonProperty("service_code")]
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// Item分类
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// Item地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
