using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RelationInfo Data Structure.
    /// </summary>
    public class RelationInfo : AlipayObject
    {
        /// <summary>
        /// 关系新鲜度，如V_CT_RL30D（最近30天有联系）详细描述见产品文档。
        /// </summary>
        [JsonPropertyName("recency")]
        public string Recency { get; set; }
    }
}
