using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyersignCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBuyersignCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 签约失败原因，签约失败时返回
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// ipId
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// ipRoleId
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 是否签约成功：true/false
        /// </summary>
        [JsonPropertyName("sign_result")]
        public bool SignResult { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
