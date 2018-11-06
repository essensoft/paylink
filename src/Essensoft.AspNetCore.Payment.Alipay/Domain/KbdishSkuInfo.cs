using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishSkuInfo : AlipayObject
    {
        /// <summary>
        /// 餐盒费用
        /// </summary>
        [JsonProperty("box_price")]
        [XmlElement("box_price")]
        public string BoxPrice { get; set; }

        /// <summary>
        /// 口碑的菜品id,新增的时候可以为空
        /// </summary>
        [JsonProperty("dish_id")]
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 套餐明细list
        /// </summary>
        [JsonProperty("dish_packages_detail_list")]
        [XmlArray("dish_packages_detail_list")]
        [XmlArrayItem("kbdish_packages_detail_info")]
        public List<KbdishPackagesDetailInfo> DishPackagesDetailList { get; set; }

        /// <summary>
        /// 商品的skuId
        /// </summary>
        [JsonProperty("goods_sku_id")]
        [XmlElement("goods_sku_id")]
        public string GoodsSkuId { get; set; }

        /// <summary>
        /// 会员价格
        /// </summary>
        [JsonProperty("member_price")]
        [XmlElement("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 外部的菜品skuId, isv自己的skuId
        /// </summary>
        [JsonProperty("out_sku_id")]
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [JsonProperty("sell_price")]
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// sku的扩展字典,json字符串
        /// </summary>
        [JsonProperty("sku_ext_content")]
        [XmlElement("sku_ext_content")]
        public string SkuExtContent { get; set; }

        /// <summary>
        /// sku的id 口碑生成
        /// </summary>
        [JsonProperty("sku_id")]
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku的排序字段
        /// </summary>
        [JsonProperty("sku_sort")]
        [XmlElement("sku_sort")]
        public string SkuSort { get; set; }

        /// <summary>
        /// 规则id1
        /// </summary>
        [JsonProperty("spec_code_01")]
        [XmlElement("spec_code_01")]
        public string SpecCode01 { get; set; }

        /// <summary>
        /// 规格2
        /// </summary>
        [JsonProperty("spec_code_02")]
        [XmlElement("spec_code_02")]
        public string SpecCode02 { get; set; }

        /// <summary>
        /// 规格3
        /// </summary>
        [JsonProperty("spec_code_03")]
        [XmlElement("spec_code_03")]
        public string SpecCode03 { get; set; }

        /// <summary>
        /// 规格4
        /// </summary>
        [JsonProperty("spec_code_04")]
        [XmlElement("spec_code_04")]
        public string SpecCode04 { get; set; }

        /// <summary>
        /// 规格5
        /// </summary>
        [JsonProperty("spec_code_05")]
        [XmlElement("spec_code_05")]
        public string SpecCode05 { get; set; }

        /// <summary>
        /// open 启动 stop 停用  变更状态的时候必输入.新增时候如果不设置默认设置启动
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
