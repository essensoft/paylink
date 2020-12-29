using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodLprQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodLprQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款利率基于LPR基准利率数据。 贷款利率为年利率为16.2%，LPR基准利率为3.85%，则为浮动利率上浮12.35%
        /// </summary>
        [JsonPropertyName("float_rate")]
        public string FloatRate { get; set; }

        /// <summary>
        /// 贷款利率给予LPR基准利率浮动情况。 1为上浮，0为持平，-1为下降
        /// </summary>
        [JsonPropertyName("loan_dir")]
        public string LoanDir { get; set; }

        /// <summary>
        /// 期数。 1年或者5年
        /// </summary>
        [JsonPropertyName("loan_tenor")]
        public string LoanTenor { get; set; }

        /// <summary>
        /// LPR基准利率。转换为百分比即为3.85%
        /// </summary>
        [JsonPropertyName("lpr_basic_rate")]
        public string LprBasicRate { get; set; }

        /// <summary>
        /// LPR基准利率时间。时间格式为：yyyyMMdd。
        /// </summary>
        [JsonPropertyName("lpr_date_str")]
        public string LprDateStr { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
