using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserInviteRtaConsultResponse.
    /// </summary>
    public class AlipayUserInviteRtaConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 一个或多个咨询策略标签，若返回多个标签，中间用“-”分隔
        /// </summary>
        [JsonPropertyName("principal_label")]
        public string PrincipalLabel { get; set; }

        /// <summary>
        /// 是否需要的流量，结果可为true和false
        /// </summary>
        [JsonPropertyName("required_flow")]
        public bool RequiredFlow { get; set; }

        /// <summary>
        /// rta咨询结果列表。最终结果形如：[{"accountId":"11111"},{"accountId":"22222"}]
        /// </summary>
        [JsonPropertyName("rta_info_list")]
        public List<RtaInfo> RtaInfoList { get; set; }
    }
}
