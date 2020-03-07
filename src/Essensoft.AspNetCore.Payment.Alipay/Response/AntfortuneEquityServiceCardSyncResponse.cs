using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneEquityServiceCardSyncResponse.
    /// </summary>
    public class AntfortuneEquityServiceCardSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 是否同步成功
        /// </summary>
        [JsonPropertyName("syn_result")]
        public bool SynResult { get; set; }
    }
}
