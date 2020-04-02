using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishInfo Data Structure.
    /// </summary>
    public class KbdishInfo : AlipayObject
    {
        /// <summary>
        /// 分类字典大类的id, 如果操作的是菜品，则比输入，如果操作的是sku信息，可不输入
        /// </summary>
        [JsonPropertyName("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 小类,商家自定义配置表例如 肉，酒水，素菜
        /// </summary>
        [JsonPropertyName("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 是否时价 Y:是 N否 目前口碑点餐暂不支持时价菜
        /// </summary>
        [JsonPropertyName("cur_price_flag")]
        public string CurPriceFlag { get; set; }

        /// <summary>
        /// 是否开台必点菜 Y是  N否，默认否；暂废弃，后续针对开台菜提供新api
        /// </summary>
        [JsonPropertyName("default_in_carts")]
        public string DefaultInCarts { get; set; }

        /// <summary>
        /// 开台菜点餐方式:如果是按数量点,直接输入数量例如2,；如果是按照就餐人数点，则输入countOnDiner这个固定的字符串  暂废弃，后续针对开台菜提供新api
        /// </summary>
        [JsonPropertyName("default_in_carts_detail")]
        public string DefaultInCartsDetail { get; set; }

        /// <summary>
        /// 菜系,商家自定义
        /// </summary>
        [JsonPropertyName("dish_cuisine")]
        public string DishCuisine { get; set; }

        /// <summary>
        /// 菜品详情页图片id，展示在菜品详情页中；最多支持10张图片
        /// </summary>
        [JsonPropertyName("dish_detail_img_list")]
        public List<string> DishDetailImgList { get; set; }

        /// <summary>
        /// 口碑的菜品id, 新增操作可以为空,修改的时候必传
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 商品图片，需要先调用素材的图片上传api得到图片id
        /// </summary>
        [JsonPropertyName("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名称
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 做法加价列表
        /// </summary>
        [JsonPropertyName("dish_practice_list")]
        public List<KbdishPracticeInfo> DishPracticeList { get; set; }

        /// <summary>
        /// 菜品sku列表
        /// </summary>
        [JsonPropertyName("dish_sku_list")]
        public List<KbdishSkuInfo> DishSkuList { get; set; }

        /// <summary>
        /// 版本号 就是一个数据操作的时间戳
        /// </summary>
        [JsonPropertyName("dish_version")]
        public string DishVersion { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [JsonPropertyName("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 扩展字段,json串
        /// </summary>
        [JsonPropertyName("ext_content")]
        public string ExtContent { get; set; }

        /// <summary>
        /// 口碑的商品id,用于营销透传,可不传
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 菜品加料信息
        /// </summary>
        [JsonPropertyName("material_binding_info_list")]
        public List<KbdishMaterialBindingInfo> MaterialBindingInfoList { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 起点份数
        /// </summary>
        [JsonPropertyName("min_serving")]
        public string MinServing { get; set; }

        /// <summary>
        /// 最小点菜数量, 用户点餐一次加多少,不填默认为1
        /// </summary>
        [JsonPropertyName("mini_add_num")]
        public string MiniAddNum { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [JsonPropertyName("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// Y：不参与优惠计算  N: 参与优惠,不设置默认为N
        /// </summary>
        [JsonPropertyName("not_count_threshold")]
        public string NotCountThreshold { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 菜品销售属性，如辣度、加冰等，最多四个
        /// </summary>
        [JsonPropertyName("property_info_list")]
        public List<KbdishPropertyInfo> PropertyInfoList { get; set; }

        /// <summary>
        /// 菜品的描述
        /// </summary>
        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店菜品id. 如果存门店菜品库，设置此值
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 菜品标签json串，key =spicy标示辣度, value=0标示不辣；1微辣；2中辣;3重辣。  key=special标识特色标签；value=0标示不设定;1招牌；2新品
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 口碑枚举定义 single:单品;packages：套餐
        /// </summary>
        [JsonPropertyName("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 小类,口碑枚举定义 fixed：固定套餐;choose:选N套餐 几选几
        /// </summary>
        [JsonPropertyName("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 单位id 字典的id，数据来源接口为口碑菜品字典查询koubei.catering.dish.dictionary.query
        /// </summary>
        [JsonPropertyName("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 修改操作小二
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
