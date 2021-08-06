using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderOrderResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderOrderResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻后付订单号
        /// </summary>
        [JsonPropertyName("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 商户传入的外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
