using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbItemInfo : AlipayObject
    {
        /// <summary>
        /// 店铺人气值，共4个等级,1,2,3,4
        /// </summary>
        [JsonProperty("avg_pop_value")]
        public string AvgPopValue { get; set; }

        /// <summary>
        /// 开卖时间
        /// </summary>
        [JsonProperty("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品logo图片
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 商品原价。
        /// </summary>
        [JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 当前库存
        /// </summary>
        [JsonProperty("quota")]
        public string Quota { get; set; }

        /// <summary>
        /// 优惠价
        /// </summary>
        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 商品所属店铺距离当前用户距离
        /// </summary>
        [JsonProperty("shop_distance")]
        public string ShopDistance { get; set; }

        /// <summary>
        /// 商品所属店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商品所属店铺名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商品状态，SOLD_OUT：售罄，SELL_ING：进行中
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 是否置顶，1：置顶，0:非置顶
        /// </summary>
        [JsonProperty("top")]
        public string Top { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [JsonProperty("total_quota")]
        public string TotalQuota { get; set; }

        /// <summary>
        /// 商品详情页地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
