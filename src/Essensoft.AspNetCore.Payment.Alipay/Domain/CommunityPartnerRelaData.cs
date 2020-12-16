using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommunityPartnerRelaData Data Structure.
    /// </summary>
    public class CommunityPartnerRelaData : AlipayObject
    {
        /// <summary>
        /// 关系对象业务数据
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [JsonPropertyName("rela_type")]
        public string RelaType { get; set; }

        /// <summary>
        /// 来源对象id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 目标对象id
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }
    }
}
