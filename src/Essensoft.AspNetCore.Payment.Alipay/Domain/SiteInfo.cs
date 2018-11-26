using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SiteInfo : AlipayObject
    {
        /// <summary>
        /// 测试账号
        /// </summary>
        [JsonProperty("account")]
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 测试密码
        /// </summary>
        [JsonProperty("password")]
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("site_name")]
        [XmlElement("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 网站：01  APP  : 02  服务窗:03  公众号:04  其他:05  支付宝小程序:06
        /// </summary>
        [JsonProperty("site_type")]
        [XmlElement("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点地址
        /// </summary>
        [JsonProperty("site_url")]
        [XmlElement("site_url")]
        public string SiteUrl { get; set; }
    }
}
