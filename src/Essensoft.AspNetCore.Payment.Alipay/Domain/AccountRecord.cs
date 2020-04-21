using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccountRecord Data Structure.
    /// </summary>
    public class AccountRecord : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 当时账户的余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 收入金额
        /// </summary>
        [JsonPropertyName("in_amount")]
        public string InAmount { get; set; }

        /// <summary>
        /// 账务备注说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 对方支付宝账户ID
        /// </summary>
        [JsonPropertyName("opt_user_id")]
        public string OptUserId { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        [JsonPropertyName("out_amount")]
        public string OutAmount { get; set; }

        /// <summary>
        /// 本方支付宝账户ID
        /// </summary>
        [JsonPropertyName("self_user_id")]
        public string SelfUserId { get; set; }

        /// <summary>
        /// 账务类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
