using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryResponse.
    /// </summary>
    public class AlipaySocialBaseChatGinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 群信息
        /// </summary>
        [JsonPropertyName("group_info")]
        public GroupInfo GroupInfo { get; set; }

        /// <summary>
        /// 群成员信息列表
        /// </summary>
        [JsonPropertyName("member_infos")]
        public List<MemberInfo> MemberInfos { get; set; }
    }
}
