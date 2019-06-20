using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneAgreementUseResponse.
    /// </summary>
    public class ZhimaCreditEpSceneAgreementUseResponse : AlipayResponse
    {
        /// <summary>
        /// 信用订单号
        /// </summary>
        [JsonProperty("credit_order_no")]
        public string CreditOrderNo { get; set; }
    }
}
