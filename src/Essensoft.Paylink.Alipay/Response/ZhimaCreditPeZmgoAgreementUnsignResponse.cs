using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoAgreementUnsignResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoAgreementUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 调用芝麻GO结算受理接口时，需要传入该值
        /// </summary>
        [JsonPropertyName("withhold_plan_no")]
        public string WithholdPlanNo { get; set; }
    }
}
