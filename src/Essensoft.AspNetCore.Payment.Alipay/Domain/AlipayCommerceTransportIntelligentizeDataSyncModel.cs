using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeDataSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 待同步的数据，json字符串，每种类型的数据格式由双方约定
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据类型枚举code
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 数据同步操作（CREATE_OR_UPDATE、CREATE、UPDATE、DELETE）
        /// </summary>
        [JsonPropertyName("sync_type")]
        public string SyncType { get; set; }
    }
}
