using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishSimplyInfo Data Structure.
    /// </summary>
    public class KbdishSimplyInfo : AlipayObject
    {
        /// <summary>
        /// 加购描述
        /// </summary>
        [JsonPropertyName("add_remark")]
        public string AddRemark { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 类目的排序值
        /// </summary>
        [JsonPropertyName("catetory_sort")]
        public string CatetorySort { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 商品图片，需要先调用素材的图片上传api得到图片id
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
        /// 起点份数，需要保证是数字类型
        /// </summary>
        [JsonPropertyName("min_serving")]
        public string MinServing { get; set; }

        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 如果此菜专属某个门店设置此值，和shop_id二选一
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
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<KbdishSkuSimplifyInfo> SkuList { get; set; }

        /// <summary>
        /// 菜品状态，open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [JsonPropertyName("sub_name")]
        public string SubName { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 菜品类型，口碑枚举定义 single:单品;packages：套餐
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
