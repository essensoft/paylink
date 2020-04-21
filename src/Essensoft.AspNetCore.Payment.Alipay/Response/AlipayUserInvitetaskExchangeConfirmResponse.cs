using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConfirmResponse.
    /// </summary>
    public class AlipayUserInvitetaskExchangeConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// true-确认成功，可以进行下一步的代扣、发货  false-确认失败，不要进行下一步代扣
        /// </summary>
        [JsonPropertyName("confirm_result")]
        public bool ConfirmResult { get; set; }
    }
}
