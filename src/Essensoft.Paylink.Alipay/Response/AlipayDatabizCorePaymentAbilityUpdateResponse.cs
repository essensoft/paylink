using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
