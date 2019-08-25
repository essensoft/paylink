using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoItemInfo : AlipayObject
    {
        /// <summary>
        /// 商品购买限制
        /// </summary>
        [JsonProperty("constraint_info")]
        public ConstraintInfo ConstraintInfo { get; set; }

        /// <summary>
        /// 商品ID，用于领取时使用
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品售卖结束时间
        /// </summary>
        [JsonProperty("sale_end_time")]
        public string SaleEndTime { get; set; }

        /// <summary>
        /// 商品售卖的开始时间
        /// </summary>
        [JsonProperty("sale_start_time")]
        public string SaleStartTime { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [JsonProperty("total_inventory")]
        public string TotalInventory { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [JsonProperty("voucher")]
        public Voucher Voucher { get; set; }
    }
}
