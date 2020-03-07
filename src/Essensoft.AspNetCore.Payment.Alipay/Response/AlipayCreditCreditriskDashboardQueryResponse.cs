using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCreditCreditriskDashboardQueryResponse.
    /// </summary>
    public class AlipayCreditCreditriskDashboardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 信用贷款额度
        /// </summary>
        [JsonPropertyName("credit_loan")]
        public string CreditLoan { get; set; }

        /// <summary>
        /// 售后退款金额
        /// </summary>
        [JsonPropertyName("sale_refund")]
        public string SaleRefund { get; set; }

        /// <summary>
        /// 交易服务费
        /// </summary>
        [JsonPropertyName("service_charge")]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 收入总计
        /// </summary>
        [JsonPropertyName("total_income")]
        public string TotalIncome { get; set; }

        /// <summary>
        /// 支出总计
        /// </summary>
        [JsonPropertyName("total_payout")]
        public string TotalPayout { get; set; }

        /// <summary>
        /// 提前收款额度
        /// </summary>
        [JsonPropertyName("tqsk_loan")]
        public string TqskLoan { get; set; }

        /// <summary>
        /// 余利宝收益
        /// </summary>
        [JsonPropertyName("ylb_profit")]
        public string YlbProfit { get; set; }
    }
}
