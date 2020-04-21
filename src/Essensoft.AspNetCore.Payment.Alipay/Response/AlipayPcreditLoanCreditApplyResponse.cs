using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanCreditApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanCreditApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 授信申请受理单号
        /// </summary>
        [JsonPropertyName("credit_receipt_no")]
        public string CreditReceiptNo { get; set; }

        /// <summary>
        /// 支付宝授权成功后跳转至借呗服务的地址
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
