using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SinglePayDetail Data Structure.
    /// </summary>
    public class SinglePayDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝冻结订单号
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 本次支付金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonPropertyName("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 本次支付url地址
        /// </summary>
        [JsonPropertyName("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 收款人的userId
        /// </summary>
        [JsonPropertyName("receive_user_id")]
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 本次支付的支付宝流水号
        /// </summary>
        [JsonPropertyName("transfer_order_no")]
        public string TransferOrderNo { get; set; }

        /// <summary>
        /// 本次支付的外部单据号
        /// </summary>
        [JsonPropertyName("transfer_out_order_no")]
        public string TransferOutOrderNo { get; set; }
    }
}
