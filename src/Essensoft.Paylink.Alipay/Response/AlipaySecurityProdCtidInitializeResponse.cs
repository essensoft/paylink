using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdCtidInitializeResponse.
    /// </summary>
    public class AlipaySecurityProdCtidInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 随机数，用于生成authcode
        /// </summary>
        [JsonPropertyName("random_data")]
        public string RandomData { get; set; }

        /// <summary>
        /// 公安一所返回的流水号
        /// </summary>
        [JsonPropertyName("stream_number")]
        public string StreamNumber { get; set; }
    }
}
