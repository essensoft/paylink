using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTradeGoodsItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTradeGoodsItem : AlipayObject
    {
        /// <summary>
        /// 商品类目
        /// </summary>
        [JsonProperty("category")]
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商户设置的商品编号
        /// </summary>
        [JsonProperty("goods_no")]
        [XmlElement("goods_no")]
        public string GoodsNo { get; set; }

        /// <summary>
        /// 商品项支付金额
        /// </summary>
        [JsonProperty("goods_sum_amount")]
        [XmlElement("goods_sum_amount")]
        public string GoodsSumAmount { get; set; }

        /// <summary>
        /// 商品单价，单位元，精确到小数点后两位
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [JsonProperty("quantity")]
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 购买商品规格型号描述
        /// </summary>
        [JsonProperty("specification")]
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 购买商品单位描述
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
