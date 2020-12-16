using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRebateBalanceSendResponse.
    /// </summary>
    public class AlipayEcoRebateBalanceSendResponse : AlipayResponse
    {
        /// <summary>
        /// 给用户发放集分宝的数量
        /// </summary>
        [JsonPropertyName("jfb_amount")]
        public string JfbAmount { get; set; }
    }
}
