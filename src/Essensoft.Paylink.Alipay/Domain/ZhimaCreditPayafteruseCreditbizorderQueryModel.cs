using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 先享后付记账单号，out_order_no与credit_biz_order_id至少传一个
        /// </summary>
        [JsonPropertyName("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 商户外部单号，out_order_no与credit_biz_order_id至少传一个
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
