using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanBeikeaccountInterestfreeModifyResponse.
    /// </summary>
    public class AlipayPcreditLoanBeikeaccountInterestfreeModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 呗壳额度返回结果
        /// </summary>
        [JsonPropertyName("beike_account_response")]
        public BeikeAccountResponse BeikeAccountResponse { get; set; }
    }
}
