using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceReportCreateResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceReportCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonPropertyName("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 请求交易流水号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
