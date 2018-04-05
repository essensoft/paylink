using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishInfo Data Structure.
    /// </summary>
    public class KbdishInfo : AlipayObject
    {
        /// <summary>
        /// 分类字典大类的id
        /// </summary>
        [JsonProperty("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 小类,商家自定义配置表例如 肉，酒水，素菜
        /// </summary>
        [JsonProperty("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 是否是价 Y:是 N否
        /// </summary>
        [JsonProperty("cur_price_flag")]
        public string CurPriceFlag { get; set; }

        /// <summary>
        /// 菜系,商家自定义
        /// </summary>
        [JsonProperty("dish_cuisine")]
        public string DishCuisine { get; set; }

        /// <summary>
        /// 口碑的菜品id,新增的时候可以为空
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 商品图片，需要先调用素材的图片上传api得到图片id
        /// </summary>
        [JsonProperty("dish_img")]
        public string DishImg { get; set; }

        /// <summary>
        /// 菜品的名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 做法加价列表
        /// </summary>
        [JsonProperty("dish_practice_list")]
        public List<KbdishPracticeInfo> DishPracticeList { get; set; }

        /// <summary>
        /// 菜品sku列表
        /// </summary>
        [JsonProperty("dish_sku_list")]
        public List<KbdishSkuInfo> DishSkuList { get; set; }

        /// <summary>
        /// 版本号 就是一个数据操作的时间戳
        /// </summary>
        [JsonProperty("dish_version")]
        public string DishVersion { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [JsonProperty("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 扩展字段,json串
        /// </summary>
        [JsonProperty("ext_content")]
        public string ExtContent { get; set; }

        /// <summary>
        /// 口碑的商品id,用于营销透传
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 起点分数
        /// </summary>
        [JsonProperty("min_serving")]
        public string MinServing { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [JsonProperty("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// 菜品的描述
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 口碑枚举定义 single:单品;packages：套餐
        /// </summary>
        [JsonProperty("type_big")]
        public string TypeBig { get; set; }

        /// <summary>
        /// 小类,口碑枚举定义 fixed：固定套餐;choose:选N套餐 几选几
        /// </summary>
        [JsonProperty("type_small")]
        public string TypeSmall { get; set; }

        /// <summary>
        /// 单位id 字典的id
        /// </summary>
        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 修改操作小二
        /// </summary>
        [JsonProperty("update_user")]
        public string UpdateUser { get; set; }
    }
}
