using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("contact_follow_list")]
        public List<ContactFollower> ContactFollowList { get; set; }
    }
}
