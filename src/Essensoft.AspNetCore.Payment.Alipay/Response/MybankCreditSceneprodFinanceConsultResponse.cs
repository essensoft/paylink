using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodFinanceConsultResponse.
    /// </summary>
    public class MybankCreditSceneprodFinanceConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 资方编码
        /// </summary>
        [JsonPropertyName("finance_inst_code")]
        public string FinanceInstCode { get; set; }

        /// <summary>
        /// 资方名称
        /// </summary>
        [JsonPropertyName("finance_inst_name")]
        public string FinanceInstName { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 资方申请编号，用于在mybank.credit.sceneprod.loan.apply 接口申请贷款时，填充finance_inst_iprole_id 字段的值
        /// </summary>
        [JsonPropertyName("route_no")]
        public string RouteNo { get; set; }

        /// <summary>
        /// 路由查询状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
