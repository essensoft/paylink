using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinvSendModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGinvSendModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 邀请的好友id列表，最多50人
        /// </summary>
        [JsonPropertyName("uids")]
        public List<string> Uids { get; set; }
    }
}
