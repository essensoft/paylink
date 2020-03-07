using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysMessagePublishResponse.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsysMessagePublishResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 额外信息，非json形式，如
        /// </summary>
        [JsonPropertyName("extra_info")]
        public string ExtraInfo { get; set; }
    }
}
