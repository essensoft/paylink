using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ServiceQueryByConditionRequest Data Structure.
    /// </summary>
    public class ServiceQueryByConditionRequest : AlipayObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }
    }
}
