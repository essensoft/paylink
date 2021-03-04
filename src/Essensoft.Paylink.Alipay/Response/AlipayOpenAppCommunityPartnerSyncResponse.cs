using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerSyncResponse.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 目标对象数据
        /// </summary>
        [JsonPropertyName("target_list")]
        public List<CommunityPartnerRelationDataSyncDTO> TargetList { get; set; }
    }
}
