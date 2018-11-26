using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbExtItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbExtItemInfo : AlipayObject
    {
        /// <summary>
        /// 品牌信息（目前支持3级品牌）
        /// </summary>
        [JsonProperty("brand_level_info_list")]
        [XmlArray("brand_level_info_list")]
        [XmlArrayItem("brand_level_info")]
        public List<BrandLevelInfo> BrandLevelInfoList { get; set; }

        /// <summary>
        /// 商品简述：对商品的简要说明，吸引顾客的描述（非必填）
        /// </summary>
        [JsonProperty("brief")]
        [XmlElement("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 品类列表信息（目前支持5级品类）
        /// </summary>
        [JsonProperty("category_level_info_list")]
        [XmlArray("category_level_info_list")]
        [XmlArrayItem("category_level_info")]
        public List<CategoryLevelInfo> CategoryLevelInfoList { get; set; }

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
        /// 币种，采用ISO 4217 Currency Codes编码，表示该商品售价对应的货币种类：CNY/USD 等
        /// </summary>
        [JsonProperty("currency")]
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品编码
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
        /// 店内货号：商户店铺内自行对商品的编码
        /// </summary>
        [JsonProperty("inner_goods_id")]
        [XmlElement("inner_goods_id")]
        public string InnerGoodsId { get; set; }

        /// <summary>
        /// 商品规格:900ml/500克/12瓶装
        /// </summary>
        [JsonProperty("item_format")]
        [XmlElement("item_format")]
        public string ItemFormat { get; set; }

        /// <summary>
        /// 包装：描述该商品的包装形式：盒装/瓶装/袋装/散装
        /// </summary>
        [JsonProperty("pack")]
        [XmlElement("pack")]
        public string Pack { get; set; }

        /// <summary>
        /// 商品图片file_id列表（最多30张）
        /// </summary>
        [JsonProperty("picture_id_list")]
        [XmlArray("picture_id_list")]
        [XmlArrayItem("string")]
        public List<string> PictureIdList { get; set; }

        /// <summary>
        /// 参考价格，单位（分），必须为整数
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("specification")]
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 表示该商品的售卖单位，对单价的补充说明个/箱/盒/克/公斤 等
        /// </summary>
        [JsonProperty("unit")]
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
