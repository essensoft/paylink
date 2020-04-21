using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TBMiniShopBo Data Structure.
    /// </summary>
    public class TBMiniShopBo : AlipayObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// json 字符串
        /// </summary>
        [JsonPropertyName("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 优惠券信息
        /// </summary>
        [JsonPropertyName("coupons")]
        public List<ItemBo> Coupons { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<ItemBo> Items { get; set; }

        /// <summary>
        /// 门店图片url
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 轻店铺id
        /// </summary>
        [JsonPropertyName("mini_shop_id")]
        public string MiniShopId { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [JsonPropertyName("shop_head_name")]
        public string ShopHeadName { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }
    }
}
