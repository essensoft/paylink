using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerBlacklistQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerBlacklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 详细原因
        /// </summary>
        [JsonPropertyName("detail_reason")]
        public string DetailReason { get; set; }

        /// <summary>
        /// 黑名单过期时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 是否在黑名单中
        /// </summary>
        [JsonPropertyName("in_black_list")]
        public string InBlackList { get; set; }
    }
}
