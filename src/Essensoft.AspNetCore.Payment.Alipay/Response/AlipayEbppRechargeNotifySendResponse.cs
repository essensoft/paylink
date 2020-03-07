using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendResponse.
    /// </summary>
    public class AlipayEbppRechargeNotifySendResponse : AlipayResponse
    {
        /// <summary>
        /// 操作状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
