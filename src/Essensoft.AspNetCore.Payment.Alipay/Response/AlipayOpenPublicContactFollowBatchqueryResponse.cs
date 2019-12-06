using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicContactFollowBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicContactFollowBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 联系人关注者列表
        /// </summary>
        [JsonPropertyName("contact_follow_list")]
        public List<ContactFollower> ContactFollowList { get; set; }
    }
}
