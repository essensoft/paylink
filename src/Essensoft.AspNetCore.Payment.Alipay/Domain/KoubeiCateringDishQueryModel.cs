using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishQueryModel : AlipayObject
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
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("dish_status")]
        public string DishStatus { get; set; }

        /// <summary>
        /// 拼音助记码
        /// </summary>
        [JsonProperty("en_remember_code")]
        public string EnRememberCode { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 数字助记码
        /// </summary>
        [JsonProperty("nb_remember_code")]
        public string NbRememberCode { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// sku的id 口碑生成
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
