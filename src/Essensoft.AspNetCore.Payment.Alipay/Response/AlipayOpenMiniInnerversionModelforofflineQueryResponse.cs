using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionModelforofflineQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionModelforofflineQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 线上版本包数据
        /// </summary>
        [JsonPropertyName("model_json")]
        public string ModelJson { get; set; }

        /// <summary>
        /// 同步ID，同步失败时便于去线上追溯
        /// </summary>
        [JsonPropertyName("sync_id")]
        public string SyncId { get; set; }
    }
}
