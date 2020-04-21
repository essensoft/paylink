using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageQueryModel : AlipayObject
    {
        /// <summary>
        /// 消息id集，限制最多传入20个message_id。message_id在调用群发、组发消息接口时会返回，需调用方保存
        /// </summary>
        [JsonPropertyName("message_ids")]
        public List<string> MessageIds { get; set; }
    }
}
