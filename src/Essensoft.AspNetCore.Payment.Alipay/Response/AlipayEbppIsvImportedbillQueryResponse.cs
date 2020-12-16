using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIsvImportedbillQueryResponse.
    /// </summary>
    public class AlipayEbppIsvImportedbillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 解析失败数量
        /// </summary>
        [JsonPropertyName("analysis_fail_count")]
        public long AnalysisFailCount { get; set; }

        /// <summary>
        /// 解析成功数量
        /// </summary>
        [JsonPropertyName("analysis_suc_count")]
        public long AnalysisSucCount { get; set; }

        /// <summary>
        /// 写入失败数量
        /// </summary>
        [JsonPropertyName("import_fail_count")]
        public long ImportFailCount { get; set; }

        /// <summary>
        /// 写入成功数量
        /// </summary>
        [JsonPropertyName("import_suc_count")]
        public long ImportSucCount { get; set; }

        /// <summary>
        /// 导入账单总数量
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
