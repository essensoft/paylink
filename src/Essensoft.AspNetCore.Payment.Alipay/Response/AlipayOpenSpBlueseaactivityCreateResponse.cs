using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityCreateResponse.
    /// </summary>
    public class AlipayOpenSpBlueseaactivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单Id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
