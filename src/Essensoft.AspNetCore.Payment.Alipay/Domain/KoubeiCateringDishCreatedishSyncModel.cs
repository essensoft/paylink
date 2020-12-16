using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishCreatedishSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCreatedishSyncModel : AlipayObject
    {
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
        /// 单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
