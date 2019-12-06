using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundRoyaltyResult Data Structure.
    /// </summary>
    public class RefundRoyaltyResult : AlipayObject
    {
        /// <summary>
        /// 退分账金额
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分账结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 分账类型.  普通分账为：transfer;  补差为：replenish;  为空默认为分账transfer;
        /// </summary>
        [JsonPropertyName("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID
        /// </summary>
        [JsonPropertyName("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号
        /// </summary>
        [JsonPropertyName("trans_in_email")]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID
        /// </summary>
        [JsonPropertyName("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号
        /// </summary>
        [JsonPropertyName("trans_out_email")]
        public string TransOutEmail { get; set; }
    }
}
