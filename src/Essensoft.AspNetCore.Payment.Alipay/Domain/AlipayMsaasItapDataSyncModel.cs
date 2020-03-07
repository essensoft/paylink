using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasItapDataSyncModel Data Structure.
    /// </summary>
    public class AlipayMsaasItapDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 设备数据同步通知消息体
        /// </summary>
        [JsonPropertyName("payload")]
        public DataSyncPayload Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
