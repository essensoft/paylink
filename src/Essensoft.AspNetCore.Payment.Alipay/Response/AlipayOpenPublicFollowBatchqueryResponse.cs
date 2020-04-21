using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicFollowBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicFollowBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次调用获取的userId个数，最大值为10000
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        [JsonPropertyName("next_user_id")]
        public string NextUserId { get; set; }

        /// <summary>
        /// 用户的userId列表
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
