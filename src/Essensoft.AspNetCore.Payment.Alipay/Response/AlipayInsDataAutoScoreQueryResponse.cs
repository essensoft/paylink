using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataAutoScoreQueryResponse.
    /// </summary>
    public class AlipayInsDataAutoScoreQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 唯一流水号，调用方应持久化本字段
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 专属分分值，浮点数
        /// </summary>
        [JsonPropertyName("exclusive_score")]
        public string ExclusiveScore { get; set; }

        /// <summary>
        /// 扩展信息，标准JSON格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 车险分
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 请求发起时通过程序生成并传递UUID，调用方应持久化本字段
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }
    }
}
