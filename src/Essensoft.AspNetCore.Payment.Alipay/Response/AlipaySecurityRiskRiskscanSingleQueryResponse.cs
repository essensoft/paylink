using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskRiskscanSingleQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskRiskscanSingleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务返回数据，这是一个JsonString，Json中的key根据业务不同而不同，接入时商定。
        /// </summary>
        [JsonPropertyName("scan_result_data")]
        public string ScanResultData { get; set; }
    }
}
