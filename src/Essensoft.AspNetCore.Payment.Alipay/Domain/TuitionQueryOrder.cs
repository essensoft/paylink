using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionQueryOrder Data Structure.
    /// </summary>
    public class TuitionQueryOrder : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("alipay_payment_id")]
        public string AlipayPaymentId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("isv_payment_id")]
        public string IsvPaymentId { get; set; }
    }
}
