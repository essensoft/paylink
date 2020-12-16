using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyLocallifeBlacklistQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyLocallifeBlacklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是黑名单 true：是 false：否
        /// </summary>
        [JsonPropertyName("is_black")]
        public bool IsBlack { get; set; }
    }
}
