using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadResponse.
    /// </summary>
    public class AlipayEcoRenthouseBillOrderDownloadResponse : AlipayResponse
    {
        /// <summary>
        /// 状态值（等级值、未授权、未知）
        /// </summary>
        [JsonPropertyName("status_value")]
        public string StatusValue { get; set; }
    }
}
