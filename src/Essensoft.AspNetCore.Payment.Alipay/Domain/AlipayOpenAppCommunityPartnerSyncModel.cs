using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerSyncModel : AlipayObject
    {
        /// <summary>
        /// 操作类型(PUT/REMOVE)
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [JsonPropertyName("rela_type")]
        public string RelaType { get; set; }

        /// <summary>
        /// 关系来源
        /// </summary>
        [JsonPropertyName("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 源对象id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 目标对象列表
        /// </summary>
        [JsonPropertyName("target_list")]
        public List<CommunityPartnerRelationDataSyncDTO> TargetList { get; set; }
    }
}
