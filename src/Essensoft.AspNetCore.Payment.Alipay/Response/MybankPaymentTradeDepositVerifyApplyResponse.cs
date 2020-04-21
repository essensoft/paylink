using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyApplyResponse.
    /// </summary>
    public class MybankPaymentTradeDepositVerifyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 请求流水号，与入参一致
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 打款验证ID 打款验证受理后生成的一个唯一标识，用于金额校验接口
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
