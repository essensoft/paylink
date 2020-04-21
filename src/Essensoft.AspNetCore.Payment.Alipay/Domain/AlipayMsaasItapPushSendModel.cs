using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasItapPushSendModel Data Structure.
    /// </summary>
    public class AlipayMsaasItapPushSendModel : AlipayObject
    {
        /// <summary>
        /// 设备消息通知消息体
        /// </summary>
        [JsonPropertyName("payload")]
        public List<DevicePushPayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 对外使用的唯一用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
