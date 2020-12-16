using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TreeDetailData Data Structure.
    /// </summary>
    public class TreeDetailData : AlipayObject
    {
        /// <summary>
        /// 证书申请时间
        /// </summary>
        [JsonPropertyName("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 兑换树种获得的证书id
        /// </summary>
        [JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 是否合种。true：是合种，false：不是合种
        /// </summary>
        [JsonPropertyName("cooperation")]
        public bool Cooperation { get; set; }

        /// <summary>
        /// 树种别名
        /// </summary>
        [JsonPropertyName("tree_alias")]
        public string TreeAlias { get; set; }

        /// <summary>
        /// 树种类型，保护地【RESERVE】还是树苗【TREE】
        /// </summary>
        [JsonPropertyName("tree_type")]
        public string TreeType { get; set; }
    }
}
