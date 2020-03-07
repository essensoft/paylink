using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantOrderCreateandpayResponse.
    /// </summary>
    public class AlipayMerchantOrderCreateandpayResponse : AlipayResponse
    {
        /// <summary>
        /// alipay侧的订单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付成功或者失败，PAYMENT_SUCCESS、PAYMENT_FAIL、PAYMENT_INPROCESS等，只有整体返回Success并且这个字段存在、且等于PAYMENT_SUCCESS才代表支付/积分扣减成功。只有整体Success不代表支付成功！
        /// </summary>
        [JsonPropertyName("payment_status")]
        public string PaymentStatus { get; set; }
    }
}
