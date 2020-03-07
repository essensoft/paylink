using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeInvalidDeleteResponse.
    /// </summary>
    public class MybankCreditLoanapplyQrcodeInvalidDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// true:失效成功 false:失效失败
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }
    }
}
