using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicContactFollowListResponse.
    /// </summary>
    public class AlipayMobilePublicContactFollowListResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 联系人关注者列表
        /// </summary>
        [JsonPropertyName("contact_follow_list")]
        public List<string> ContactFollowList { get; set; }
    }
}
