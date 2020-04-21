using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGroupsQueryResponse.
    /// </summary>
    public class AlipaySocialBaseChatGroupsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 群信息列表
        /// </summary>
        [JsonPropertyName("group_infos")]
        public List<GroupInfo> GroupInfos { get; set; }

        /// <summary>
        /// 是否有更多
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 同步的key，下一次分页获取使用
        /// </summary>
        [JsonPropertyName("last_key")]
        public long LastKey { get; set; }
    }
}
