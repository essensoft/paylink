using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CatalogNodeData Data Structure.
    /// </summary>
    public class CatalogNodeData : AlipayObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("node_nm")]
        public string NodeNm { get; set; }
    }
}
