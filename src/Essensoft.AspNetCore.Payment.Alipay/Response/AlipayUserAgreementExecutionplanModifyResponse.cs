using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyResponse.
    /// </summary>
    public class AlipayUserAgreementExecutionplanModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        [JsonProperty("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间
        /// </summary>
        [JsonProperty("deduct_time")]
        public string DeductTime { get; set; }
    }
}
