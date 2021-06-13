using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniResourceDeleteModel : AlipayObject
    {
        /// <summary>
        /// 流量位id，只能删除属于自己的流量位id
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }
    }
}
