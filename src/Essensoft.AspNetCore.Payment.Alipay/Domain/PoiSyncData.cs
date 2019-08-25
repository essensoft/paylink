using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PoiSyncData Data Structure.
    /// </summary>
    [Serializable]
    public class PoiSyncData : AlipayObject
    {
        /// <summary>
        /// 小程序appId
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// poi的id
        /// </summary>
        [JsonProperty("poi_codes")]
        public List<string> PoiCodes { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
