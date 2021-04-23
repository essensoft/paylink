using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderFinishResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderFinishResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻后付记账单号
        /// </summary>
        [JsonPropertyName("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
