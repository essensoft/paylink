using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentAbilityPostbackResponse Data Structure.
    /// </summary>
    public class PaymentAbilityPostbackResponse : AlipayObject
    {
        /// <summary>
        /// 错误的订单信息
        /// </summary>
        [JsonPropertyName("error_order")]
        public string ErrorOrder { get; set; }

        /// <summary>
        /// 成功的订单列表,逗号分隔
        /// </summary>
        [JsonPropertyName("order_ids")]
        public string OrderIds { get; set; }
    }
}
