using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAmlAnalyzeSubmitModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskAmlAnalyzeSubmitModel : AlipayObject
    {
        /// <summary>
        /// 唯一事件码，区分事件
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务扩展字段，将业务需要扫描的参数配置在此，hash表的json字符串形式
        /// </summary>
        [JsonPropertyName("extend_data")]
        public string ExtendData { get; set; }

        /// <summary>
        /// 事件发生时间，日期的毫秒数
        /// </summary>
        [JsonPropertyName("gmt_occur")]
        public string GmtOccur { get; set; }

        /// <summary>
        /// 请求的唯一编号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 租户编号
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// sofaid
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
