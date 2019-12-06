using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoItemInfo Data Structure.
    /// </summary>
    public class PromoItemInfo : AlipayObject
    {
        /// <summary>
        /// 商品购买限制
        /// </summary>
        [JsonPropertyName("constraint_info")]
        public ConstraintInfo ConstraintInfo { get; set; }

        /// <summary>
        /// 商品ID，用于领取时使用
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品售卖结束时间
        /// </summary>
        [JsonPropertyName("sale_end_time")]
        public string SaleEndTime { get; set; }

        /// <summary>
        /// 商品售卖的开始时间
        /// </summary>
        [JsonPropertyName("sale_start_time")]
        public string SaleStartTime { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [JsonPropertyName("total_inventory")]
        public string TotalInventory { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [JsonPropertyName("voucher")]
        public Voucher Voucher { get; set; }
    }
}
