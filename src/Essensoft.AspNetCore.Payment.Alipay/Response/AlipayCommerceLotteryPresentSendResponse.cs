using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLotteryPresentSendResponse.
    /// </summary>
    public class AlipayCommerceLotteryPresentSendResponse : AlipayResponse
    {
        /// <summary>
        /// 是否赠送成功
        /// </summary>
        [JsonPropertyName("send_result")]
        public bool SendResult { get; set; }
    }
}
