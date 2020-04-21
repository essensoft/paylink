using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateRateSyncResponse.
    /// </summary>
    public class AlipayAccountExrateRateSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 主站openapi通用接口操作返回结果
        /// </summary>
        [JsonPropertyName("result_context")]
        public string ResultContext { get; set; }
    }
}
