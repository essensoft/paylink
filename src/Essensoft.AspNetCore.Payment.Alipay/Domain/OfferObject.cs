using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OfferObject Data Structure.
    /// </summary>
    [Serializable]
    public class OfferObject : AlipayObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonProperty("app_code")]
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 分类编码
        /// </summary>
        [JsonProperty("category_code")]
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 展台ID，这个是唯一主键，这个最重要，作为我方的source_offer_id存在表里，而且是唯一的
        /// </summary>
        [JsonProperty("displayapp_id")]
        [XmlElement("displayapp_id")]
        public string DisplayappId { get; set; }

        /// <summary>
        /// 展台操作备注
        /// </summary>
        [JsonProperty("displayapp_memo")]
        [XmlElement("displayapp_memo")]
        public string DisplayappMemo { get; set; }

        /// <summary>
        /// 展台名称
        /// </summary>
        [JsonProperty("displayapp_name")]
        [XmlElement("displayapp_name")]
        public string DisplayappName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("displayapp_status")]
        [XmlElement("displayapp_status")]
        public string DisplayappStatus { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("displayapp_url")]
        [XmlElement("displayapp_url")]
        public string DisplayappUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonProperty("logo_url")]
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 实际的URL
        /// </summary>
        [JsonProperty("service_url")]
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
