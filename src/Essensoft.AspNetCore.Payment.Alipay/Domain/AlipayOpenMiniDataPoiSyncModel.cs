using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataPoiSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDataPoiSyncModel : AlipayObject
    {
        /// <summary>
        /// poi回流数据
        /// </summary>
        [JsonPropertyName("poi_data")]
        public PoiSyncData PoiData { get; set; }
    }
}
