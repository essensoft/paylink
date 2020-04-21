using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvPicvideoQueryModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvPicvideoQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求Id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 交易Id
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 捞取类型: images, videos, video_info
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 只对videos类型有效, 例：  {"layers": "0", "segments": "0"}  {"layers": "1,2,3,4,5", "segments": "1,2"}  注：layers 为 "0"为全部层，segments 为 "0"为全部 段
        /// </summary>
        [JsonPropertyName("video_detail")]
        public string VideoDetail { get; set; }
    }
}
