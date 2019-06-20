using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessItemExternalSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessItemExternalSyncModel : AlipayObject
    {
        /// <summary>
        /// 商品失效时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商品扩展金额
        /// </summary>
        [JsonProperty("ext_price_info")]
        public List<PriceInfo> ExtPriceInfo { get; set; }

        /// <summary>
        /// 商品扩展属性
        /// </summary>
        [JsonProperty("ext_prop")]
        public string ExtProp { get; set; }

        /// <summary>
        /// 商品外部类目信息
        /// </summary>
        [JsonProperty("external_category_info")]
        public ItemCategoryInfo ExternalCategoryInfo { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 商品库存数量
        /// </summary>
        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品类型：  COMMON_ITEM 普通商品
        /// </summary>
        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品图片信息
        /// </summary>
        [JsonProperty("picture_info")]
        public string PictureInfo { get; set; }

        /// <summary>
        /// 商品活动类型  GROUP_BUYING 拼团  FLASH_SALE 秒杀  DISCOUNT_SEVEN 七折抢新  NINE_BY_NINE 九块九
        /// </summary>
        [JsonProperty("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 请求ID，支持英文字母和数字，由调用者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 商品生效时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 商品状态  EFFECTIVE 上架  INVALID 下架
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
