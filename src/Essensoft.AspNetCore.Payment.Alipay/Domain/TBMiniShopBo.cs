using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TBMiniShopBo Data Structure.
    /// </summary>
    [Serializable]
    public class TBMiniShopBo : AlipayObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// json 字符串
        /// </summary>
        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 优惠券信息
        /// </summary>
        [JsonProperty("coupons")]
        public List<ItemBo> Coupons { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("items")]
        public List<ItemBo> Items { get; set; }

        /// <summary>
        /// 门店图片url
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 轻店铺id
        /// </summary>
        [JsonProperty("mini_shop_id")]
        public string MiniShopId { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [JsonProperty("shop_head_name")]
        public string ShopHeadName { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }
    }
}
