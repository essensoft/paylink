using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneAgreementCancelResponse.
    /// </summary>
    public class ZhimaCreditEpSceneAgreementCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 信用订单号
        /// </summary>
        [JsonPropertyName("credit_order_no")]
        public string CreditOrderNo { get; set; }
    }
}
