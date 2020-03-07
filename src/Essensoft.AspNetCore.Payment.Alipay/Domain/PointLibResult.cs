using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PointLibResult Data Structure.
    /// </summary>
    public class PointLibResult : AlipayObject
    {
        /// <summary>
        /// 仓库剩余积分数
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 积分库ID
        /// </summary>
        [JsonPropertyName("library_id")]
        public string LibraryId { get; set; }

        /// <summary>
        /// 积分库名称
        /// </summary>
        [JsonPropertyName("library_name")]
        public string LibraryName { get; set; }

        /// <summary>
        /// 积分库状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库积分总数
        /// </summary>
        [JsonPropertyName("sum_point")]
        public string SumPoint { get; set; }
    }
}
