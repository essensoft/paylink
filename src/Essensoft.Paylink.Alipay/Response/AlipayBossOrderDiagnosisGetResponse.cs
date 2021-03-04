using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossOrderDiagnosisGetResponse.
    /// </summary>
    public class AlipayBossOrderDiagnosisGetResponse : AlipayResponse
    {
        /// <summary>
        /// 诊断模型
        /// </summary>
        [JsonPropertyName("diagnosis_result")]
        public List<DiagnosisInfo> DiagnosisResult { get; set; }
    }
}
