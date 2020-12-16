using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAraterRatestatusModifyResponse.
    /// </summary>
    public class AlipayOpenAppAraterRatestatusModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否更惨成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
