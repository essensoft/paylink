using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtShopItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExtShopItem : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonProperty("brand_code")]
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonProperty("category_code")]
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 入数，必须为整数
        /// </summary>
        [JsonProperty("count")]
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [JsonProperty("country")]
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息
        /// </summary>
        [JsonProperty("ext_goods_info")]
        [XmlElement("ext_goods_info")]
        public string ExtGoodsInfo { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [JsonProperty("item_code")]
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonProperty("kb_shop_id")]
        [XmlElement("kb_shop_id")]
        public string KbShopId { get; set; }

        /// <summary>
        /// 商品图片url
        /// </summary>
        [JsonProperty("picture")]
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 参考价格
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonProperty("specification")]
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// ISV系统提供商
        /// </summary>
        [JsonProperty("system_provider_id")]
        [XmlElement("system_provider_id")]
        public string SystemProviderId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
