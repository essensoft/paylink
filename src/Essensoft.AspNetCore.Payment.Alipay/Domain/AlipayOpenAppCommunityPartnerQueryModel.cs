using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerQueryModel : AlipayObject
    {
        /// <summary>
        /// 关系类型
        /// </summary>
        [JsonPropertyName("rela_type")]
        public string RelaType { get; set; }

        /// <summary>
        /// 源对象id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 对象类型id（例如支付宝user_id）
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }
    }
}
