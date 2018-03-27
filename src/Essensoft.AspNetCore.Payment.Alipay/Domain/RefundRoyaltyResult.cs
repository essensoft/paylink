using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundRoyaltyResult Data Structure.
    /// </summary>
    public class RefundRoyaltyResult : AlipayObject
    {
        /// <summary>
        /// 退分润金额
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分润结果码
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID
        /// </summary>
        [JsonProperty("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号
        /// </summary>
        [JsonProperty("trans_in_email")]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID
        /// </summary>
        [JsonProperty("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号
        /// </summary>
        [JsonProperty("trans_out_email")]
        public string TransOutEmail { get; set; }
    }
}
