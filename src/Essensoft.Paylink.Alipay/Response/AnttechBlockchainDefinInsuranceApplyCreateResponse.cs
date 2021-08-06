using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceApplyCreateResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceApplyCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 保额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 投保单号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [JsonPropertyName("insure_end_date")]
        public string InsureEndDate { get; set; }

        /// <summary>
        /// 保险起期
        /// </summary>
        [JsonPropertyName("insure_start_date")]
        public string InsureStartDate { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [JsonPropertyName("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 请求交易流水号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
