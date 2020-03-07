using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialGiftStockUploadResponse.
    /// </summary>
    public class AlipaySocialGiftStockUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 重复条数
        /// </summary>
        [JsonPropertyName("duplicate_count")]
        public long DuplicateCount { get; set; }

        /// <summary>
        /// 失败条数
        /// </summary>
        [JsonPropertyName("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 成功条数
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
