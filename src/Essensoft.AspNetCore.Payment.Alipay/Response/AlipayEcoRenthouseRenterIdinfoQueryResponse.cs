using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseRenterIdinfoQueryResponse.
    /// </summary>
    public class AlipayEcoRenthouseRenterIdinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 状态值（已授权、未授权、未知）
        /// </summary>
        [JsonPropertyName("status_value")]
        public string StatusValue { get; set; }
    }
}
