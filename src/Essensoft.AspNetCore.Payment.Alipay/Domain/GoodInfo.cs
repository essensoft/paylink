using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GoodInfo : AlipayObject
    {
        /// <summary>
        /// 商品的编号
        /// </summary>
        [JsonProperty("goods_id")]
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 设备中该商品的剩余数量
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 商品重量,单位克
        /// </summary>
        [JsonProperty("weight")]
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
