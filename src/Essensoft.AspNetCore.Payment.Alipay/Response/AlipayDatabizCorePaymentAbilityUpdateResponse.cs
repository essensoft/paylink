using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDatabizCorePaymentAbilityUpdateResponse.
    /// </summary>
    public class AlipayDatabizCorePaymentAbilityUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付能力回传信息结果信息
        /// </summary>
        [JsonPropertyName("payment_ability_postback_response")]
        public PaymentAbilityPostbackResponse PaymentAbilityPostbackResponse { get; set; }
    }
}
