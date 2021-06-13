using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvPicvideoQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvPicvideoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 货柜每层视频展示信息
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
