using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromoAccessBaseCatalogVO Data Structure.
    /// </summary>
    public class PromoAccessBaseCatalogVO : AlipayObject
    {
        /// <summary>
        /// 类目节点描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 类目节点名称
        /// </summary>
        [JsonPropertyName("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 类目节点ID
        /// </summary>
        [JsonPropertyName("nodei_d")]
        public string NodeiD { get; set; }
    }
}
