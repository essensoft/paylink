using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝定义的统一商品编号
        /// </summary>
        [JsonProperty("alipay_goods_id")]
        [XmlElement("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        [JsonProperty("body")]
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonProperty("goods_category")]
        [XmlElement("goods_category")]
        public string GoodsCategory { get; set; }

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
        /// 商品单价，单位为元
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [JsonProperty("show_url")]
        [XmlElement("show_url")]
        public string ShowUrl { get; set; }
    }
}
