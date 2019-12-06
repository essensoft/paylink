using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementTransferResponse.
    /// </summary>
    public class AlipayUserAgreementTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 单次金额限制
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonPropertyName("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 总金额限制
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总支付次数
        /// </summary>
        [JsonPropertyName("total_payments")]
        public string TotalPayments { get; set; }
    }
}
