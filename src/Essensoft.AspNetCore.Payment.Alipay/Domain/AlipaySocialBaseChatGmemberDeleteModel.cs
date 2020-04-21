using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberDeleteModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGmemberDeleteModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 剔除的群成员用户id列表
        /// </summary>
        [JsonPropertyName("uids")]
        public List<string> Uids { get; set; }
    }
}
