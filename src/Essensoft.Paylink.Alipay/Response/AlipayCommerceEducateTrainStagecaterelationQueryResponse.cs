using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainStagecaterelationQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainStagecaterelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学段分组信息
        /// </summary>
        [JsonPropertyName("stage_group_infos")]
        public List<StageGroupInfoVO> StageGroupInfos { get; set; }
    }
}
