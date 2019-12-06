using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PoiSyncData Data Structure.
    /// </summary>
    public class PoiSyncData : AlipayObject
    {
        /// <summary>
        /// 小程序appId
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// poi的id
        /// </summary>
        [JsonPropertyName("poi_codes")]
        public List<string> PoiCodes { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
