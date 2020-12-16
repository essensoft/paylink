using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfIouQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfIouQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 借据Id
        /// </summary>
        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; }

        /// <summary>
        /// 发放金额
        /// </summary>
        [JsonPropertyName("issued_amount")]
        public string IssuedAmount { get; set; }

        /// <summary>
        /// 贷款入账账号
        /// </summary>
        [JsonPropertyName("pay_in_account")]
        public string PayInAccount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 还款账号
        /// </summary>
        [JsonPropertyName("repay_account")]
        public string RepayAccount { get; set; }
    }
}
