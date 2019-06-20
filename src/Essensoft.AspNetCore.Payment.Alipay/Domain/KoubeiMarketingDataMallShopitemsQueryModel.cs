using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallShopitemsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallShopitemsQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询内容范围
        /// </summary>
        [JsonProperty("collect_type")]
        public string CollectType { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 最多优惠券个数
        /// </summary>
        [JsonProperty("max_coupons_num")]
        public string MaxCouponsNum { get; set; }

        /// <summary>
        /// 最多商品个数
        /// </summary>
        [JsonProperty("max_items_num")]
        public string MaxItemsNum { get; set; }

        /// <summary>
        /// 分页码
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页个数
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 设备版本号
        /// </summary>
        [JsonProperty("product_version")]
        public string ProductVersion { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
