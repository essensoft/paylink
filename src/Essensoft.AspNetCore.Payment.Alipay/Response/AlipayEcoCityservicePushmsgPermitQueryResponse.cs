using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCityservicePushmsgPermitQueryResponse.
    /// </summary>
    public class AlipayEcoCityservicePushmsgPermitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据查询条件返回匹配用户列表,包含用户id以及消息推送授权状态
        /// </summary>
        [JsonPropertyName("user_permit_list")]
        public List<UserPermit> UserPermitList { get; set; }
    }
}
