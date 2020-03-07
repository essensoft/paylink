using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInviteRtaConsultResponse.
    /// </summary>
    public class AlipayUserInviteRtaConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 人群标签
        /// </summary>
        [JsonPropertyName("principal_label")]
        public string PrincipalLabel { get; set; }

        /// <summary>
        /// 是否需要的流量
        /// </summary>
        [JsonPropertyName("required_flow")]
        public bool RequiredFlow { get; set; }

        /// <summary>
        /// rta咨询结果列表
        /// </summary>
        [JsonPropertyName("rta_info_list")]
        public List<RtaInfo> RtaInfoList { get; set; }
    }
}
