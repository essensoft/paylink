using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasItapStatesSyncModel Data Structure.
    /// </summary>
    public class AlipayMsaasItapStatesSyncModel : AlipayObject
    {
        /// <summary>
        /// 状态同步消息体
        /// </summary>
        [JsonPropertyName("payload")]
        public List<StatesSyncPayload> Payload { get; set; }

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
