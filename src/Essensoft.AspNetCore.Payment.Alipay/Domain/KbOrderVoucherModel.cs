using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbOrderVoucherModel Data Structure.
    /// </summary>
    public class KbOrderVoucherModel : AlipayObject
    {
        /// <summary>
        /// 商品凭证过期时间
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 商品凭证核销／退款对应的资金流水号
        /// </summary>
        [JsonPropertyName("funds_voucher_no")]
        public string FundsVoucherNo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 退款理由，由消费者选择或填写内容，系统退款可以为空。
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款类型，ROLE_DAEMON（超期未使用），ROLE_USER（消费者主动）；
        /// </summary>
        [JsonPropertyName("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 商品凭证核销门店ID,核销后会存在该字段
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品凭证核销门店外部ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 凭证剩余可核销次数(次卡场景)
        /// </summary>
        [JsonPropertyName("ticket_effect_count")]
        public string TicketEffectCount { get; set; }

        /// <summary>
        /// 凭证已退款次数(次卡场景)
        /// </summary>
        [JsonPropertyName("ticket_refunded_count")]
        public string TicketRefundedCount { get; set; }

        /// <summary>
        /// 凭证已使用次数(次卡场景)
        /// </summary>
        [JsonPropertyName("ticket_used_count")]
        public string TicketUsedCount { get; set; }

        /// <summary>
        /// 商品凭证ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
