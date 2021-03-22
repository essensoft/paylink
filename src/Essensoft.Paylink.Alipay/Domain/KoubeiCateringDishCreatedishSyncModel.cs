using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCreatedishSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCreatedishSyncModel : AlipayObject
    {
        /// <summary>
        /// 菜品活动信息，属于isv外部活动信息
        /// </summary>
        [JsonPropertyName("activity_info")]
        public KbdishBaseActivityInfo ActivityInfo { get; set; }

        /// <summary>
        /// 类目的名称，需要保证pid+分类名称唯一
        /// </summary>
        [JsonPropertyName("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 分类自身的排序值，只支持数字类型，不传默认为1
        /// </summary>
        [JsonPropertyName("catetory_sort")]
        public string CatetorySort { get; set; }

        /// <summary>
        /// 菜品背景图片(非C端菜谱中的商品主图)，如combo加购页的顶层背景图，主图、附图、背景图尺寸不一
        /// </summary>
        [JsonPropertyName("dish_background_img")]
        public string DishBackgroundImg { get; set; }

        /// <summary>
        /// 多图菜品的附图列表
        /// </summary>
        [JsonPropertyName("dish_detail_img_list")]
        public List<string> DishDetailImgList { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonPropertyName("dmg_img")]
        public string DmgImg { get; set; }

        /// <summary>
        /// 套餐组列表
        /// </summary>
        [JsonPropertyName("group_list")]
        public List<KbdishGroupSimplifyInfo> GroupList { get; set; }

        /// <summary>
        /// 加料组列表
        /// </summary>
        [JsonPropertyName("material_group_list")]
        public List<KbdishMaterialSimplifyInfo> MaterialGroupList { get; set; }

        /// <summary>
        /// 起点份数，只支持数字
        /// </summary>
        [JsonPropertyName("min_serving")]
        public string MinServing { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 菜品是否不参与整单优惠，true(不参与)，false(参与)，不传默认为false
        /// </summary>
        [JsonPropertyName("non_whole_order_discount")]
        public string NonWholeOrderDiscount { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部门店id，如果当前菜品是门店菜， 口碑门店id和外部门店id二者必须有一必填
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 时间规则
        /// </summary>
        [JsonPropertyName("period")]
        public KbdishPeriodExtendInfo Period { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<KbdishPropertySimplifyInfo> PropertyList { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 规格列表
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<KbdishSkuSimplifyInfo> SkuList { get; set; }

        /// <summary>
        /// 状态，open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [JsonPropertyName("sub_name")]
        public string SubName { get; set; }

        /// <summary>
        /// 菜品标签，格式为json串：key =spicy标示辣度, value标示辣度值，0不辣；1微辣；2中辣；3重辣。 key=special标示特色标签；value标示特色标签值，0标示不设定；1招牌；2新品
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 口碑枚举定义 single:单品;packages：套餐
        /// </summary>
        [JsonPropertyName("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 菜品子类型，在type_small基础上拓展出来的第三级，如packages/choosen/combo，表示combo类型可选套餐，不传则默认为非combo菜品
        /// </summary>
        [JsonPropertyName("type_sub")]
        public string TypeSub { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
