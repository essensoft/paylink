using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyInsturlQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyInsturlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 机构目标跳转链接地址
        /// </summary>
        [JsonPropertyName("target_url")]
        public string TargetUrl { get; set; }
    }
}
