using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementSignConfirmResponse.
    /// </summary>
    public class AlipayUserAgreementSignConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 是否海外购汇身份。值：T/F
        /// </summary>
        [JsonPropertyName("forex_eligible")]
        public string ForexEligible { get; set; }

        /// <summary>
        /// 协议的当前状态。  1. TEMP：暂存，协议未生效过；  2. NORMAL：正常；  3. STOP：暂停。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
