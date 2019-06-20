using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiShowstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPoiShowstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [JsonProperty("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 是否展示 0 不展示 1展示
        /// </summary>
        [JsonProperty("show_status")]
        public string ShowStatus { get; set; }
    }
}
