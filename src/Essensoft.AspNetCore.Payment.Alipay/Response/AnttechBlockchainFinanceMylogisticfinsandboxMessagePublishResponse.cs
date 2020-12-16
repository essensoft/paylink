using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsandboxMessagePublishResponse.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsandboxMessagePublishResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 额外信息，非json形式
        /// </summary>
        [JsonPropertyName("extra_info")]
        public string ExtraInfo { get; set; }
    }
}
