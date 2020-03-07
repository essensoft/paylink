using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseGroupQueryResponse.
    /// </summary>
    public class AlipaySocialBaseGroupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群的群成员总数
        /// </summary>
        [JsonPropertyName("group_member_count")]
        public long GroupMemberCount { get; set; }

        /// <summary>
        /// 群成员列表
        /// </summary>
        [JsonPropertyName("group_members")]
        public List<GroupMemberInfo> GroupMembers { get; set; }

        /// <summary>
        /// 群的名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }
    }
}
