using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishInfo : AlipayObject
    {
        /// <summary>
        /// 分类字典大类的id, 如果操作的是菜品，则比输入，如果操作的是sku信息，可不输入
        /// </summary>
        [JsonProperty("catetory_big_id")]
        [XmlElement("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 小类,商家自定义配置表例如 肉，酒水，素菜
        /// </summary>
        [JsonProperty("catetory_small_id")]
        [XmlElement("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("create_user")]
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 是否是价 Y:是 N否
        /// </summary>
        [JsonProperty("cur_price_flag")]
        [XmlElement("cur_price_flag")]
        public string CurPriceFlag { get; set; }

        /// <summary>
        /// 是否开台必点菜 Y是  N否，默认否；暂废弃，后续针对开台菜提供新api
        /// </summary>
        [JsonProperty("default_in_carts")]
        [XmlElement("default_in_carts")]
        public string DefaultInCarts { get; set; }

        /// <summary>
        /// 开台菜点餐方式:如果是按数量点,直接输入数量例如2,；如果是按照就餐人数点，则输入countOnDiner这个固定的字符串  暂废弃，后续针对开台菜提供新api
        /// </summary>
        [JsonProperty("default_in_carts_detail")]
        [XmlElement("default_in_carts_detail")]
        public string DefaultInCartsDetail { get; set; }

        /// <summary>
        /// 菜系,商家自定义
        /// </summary>
        [JsonProperty("dish_cuisine")]
        [XmlElement("dish_cuisine")]
        public string DishCuisine { get; set; }

        /// <summary>
        /// 口碑的菜品id, 新增操作可以为空,修改的时候必传
        /// </summary>
        [JsonProperty("dish_id")]
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 商品图片，需要先调用素材的图片上传api得到图片id
        /// </summary>
        [JsonProperty("dish_img")]
        [XmlElement("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名称
        /// </summary>
        [JsonProperty("dish_name")]
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 做法加价列表
        /// </summary>
        [JsonProperty("dish_practice_list")]
        [XmlArray("dish_practice_list")]
        [XmlArrayItem("kbdish_practice_info")]
        public List<KbdishPracticeInfo> DishPracticeList { get; set; }

        /// <summary>
        /// 菜品sku列表
        /// </summary>
        [JsonProperty("dish_sku_list")]
        [XmlArray("dish_sku_list")]
        [XmlArrayItem("kbdish_sku_info")]
        public List<KbdishSkuInfo> DishSkuList { get; set; }

        /// <summary>
        /// 版本号 就是一个数据操作的时间戳
        /// </summary>
        [JsonProperty("dish_version")]
        [XmlElement("dish_version")]
        public string DishVersion { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [JsonProperty("en_remember_code")]
        [XmlElement("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 扩展字段,json串
        /// </summary>
        [JsonProperty("ext_content")]
        [XmlElement("ext_content")]
        public string ExtContent { get; set; }

        /// <summary>
        /// 口碑的商品id,用于营销透传,可不传
        /// </summary>
        [JsonProperty("goods_id")]
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 菜品加料信息
        /// </summary>
        [JsonProperty("material_binding_info_list")]
        [XmlArray("material_binding_info_list")]
        [XmlArrayItem("kbdish_material_binding_info")]
        public List<KbdishMaterialBindingInfo> MaterialBindingInfoList { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("merchant_id")]
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 起点份数
        /// </summary>
        [JsonProperty("min_serving")]
        [XmlElement("min_serving")]
        public string MinServing { get; set; }

        /// <summary>
        /// 最小点菜数量, 用户点餐一次加多少,不填默认为1
        /// </summary>
        [JsonProperty("mini_add_num")]
        [XmlElement("mini_add_num")]
        public string MiniAddNum { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [JsonProperty("nb_remember_code")]
        [XmlElement("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// Y：不参与优惠计算  N: 参与优惠,不设置默认为N
        /// </summary>
        [JsonProperty("not_count_threshold")]
        [XmlElement("not_count_threshold")]
        public string NotCountThreshold { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonProperty("out_dish_id")]
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 菜品销售属性，如辣度、加冰等，最多四个
        /// </summary>
        [JsonProperty("property_info_list")]
        [XmlArray("property_info_list")]
        [XmlArrayItem("kbdish_property_info")]
        public List<KbdishPropertyInfo> PropertyInfoList { get; set; }

        /// <summary>
        /// 菜品的描述
        /// </summary>
        [JsonProperty("remarks")]
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店菜品id. 如果存门店菜品库，设置此值
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 菜品标签json串，key =spicy标示辣度, value=0标示不辣；1微辣；2中辣;3中辣。  key=recommend标示推荐指数,value=0标示不设定;1标示推荐;2十分推荐;3强烈推荐。key=special标识特色标签；value=0标示不设定;1招牌；2新品
        /// </summary>
        [JsonProperty("tags")]
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 口碑枚举定义 single:单品;packages：套餐
        /// </summary>
        [JsonProperty("type_big")]
        [XmlElement("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 小类,口碑枚举定义 fixed：固定套餐;choose:选N套餐 几选几
        /// </summary>
        [JsonProperty("type_small")]
        [XmlElement("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 单位id 字典的id
        /// </summary>
        [JsonProperty("unit_id")]
        [XmlElement("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 修改操作小二
        /// </summary>
        [JsonProperty("update_user")]
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
