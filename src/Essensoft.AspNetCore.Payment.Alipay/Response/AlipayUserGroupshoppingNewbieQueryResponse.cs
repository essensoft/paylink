using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserGroupshoppingNewbieQueryResponse.
    /// </summary>
    public class AlipayUserGroupshoppingNewbieQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否可参与一元团
        /// </summary>
        [JsonPropertyName("access")]
        public bool Access { get; set; }

        /// <summary>
        /// 输出的文案信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 当前用户状态，未被邀请，未绑定手机号等
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 返回传入用户下的user_id列表，查询整个列表中的user_id是否有一元拼的记录。
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
