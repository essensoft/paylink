using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationCancelResponse.
    /// </summary>
    public class AlipayInsSceneApplicationCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }
    }
}
