using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterShopDO Data Structure.
    /// </summary>
    [Serializable]
    public class OuterShopDO : AlipayObject
    {
        /// <summary>
        /// 合作商户ID
        /// </summary>
        [JsonProperty("outer_id")]
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 支付宝店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 合作商户类型 （mike、_2dFire）  iSV自己定义自己的类型，推荐使用自己的域名
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
