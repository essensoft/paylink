using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceFundFundprodQueryResponse.
    /// </summary>
    public class AlipayFinanceFundFundprodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 成立日期，格式为YYYYMMDD
        /// </summary>
        [JsonPropertyName("establishment_date")]
        public string EstablishmentDate { get; set; }

        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 基金全称
        /// </summary>
        [JsonPropertyName("fund_name")]
        public string FundName { get; set; }

        /// <summary>
        /// 基金简称
        /// </summary>
        [JsonPropertyName("fund_name_abbr")]
        public string FundNameAbbr { get; set; }

        /// <summary>
        /// 基金单位净值，含4位小数
        /// </summary>
        [JsonPropertyName("net_value")]
        public string NetValue { get; set; }

        /// <summary>
        /// 净值日期
        /// </summary>
        [JsonPropertyName("net_value_date")]
        public string NetValueDate { get; set; }

        /// <summary>
        /// 七日年化收益率，含5位小数，可以为负
        /// </summary>
        [JsonPropertyName("profit_seven_days")]
        public string ProfitSevenDays { get; set; }

        /// <summary>
        /// 万份收益，含5位小数，可以为负
        /// </summary>
        [JsonPropertyName("profit_ten_thousand")]
        public string ProfitTenThousand { get; set; }

        /// <summary>
        /// 风险等级，分五级：L-低风险; ML-中低风险; M-中风险; MH-中高风险; H-高风险
        /// </summary>
        [JsonPropertyName("risk_evaluation")]
        public string RiskEvaluation { get; set; }
    }
}
