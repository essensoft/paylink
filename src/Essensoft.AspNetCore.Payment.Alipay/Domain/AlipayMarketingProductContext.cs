using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingProductContext Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingProductContext : AlipayObject
    {
        /// <summary>
        /// 客户端client_id
        /// </summary>
        [JsonProperty("client_id")]
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// product需要接入的时候和支付宝码平台约定。  目前仅支持建行app使用ccb_wallet
        /// </summary>
        [JsonProperty("product")]
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("product_version")]
        [XmlElement("product_version")]
        public string ProductVersion { get; set; }
    }
}
