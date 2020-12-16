using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommunityPartnerRelationDataSyncDTO Data Structure.
    /// </summary>
    public class CommunityPartnerRelationDataSyncDTO : AlipayObject
    {
        /// <summary>
        /// 关系业务数据
        /// </summary>
        [JsonPropertyName("rela_data")]
        public string RelaData { get; set; }

        /// <summary>
        /// 2020-06-06 06:06:06
        /// </summary>
        [JsonPropertyName("rela_expire")]
        public string RelaExpire { get; set; }

        /// <summary>
        /// 关系状态
        /// </summary>
        [JsonPropertyName("rela_status")]
        public string RelaStatus { get; set; }

        /// <summary>
        /// 目标对象id
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }
    }
}
