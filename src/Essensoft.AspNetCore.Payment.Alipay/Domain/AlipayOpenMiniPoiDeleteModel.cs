using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPoiDeleteModel : AlipayObject
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [JsonProperty("poi_id")]
        public string PoiId { get; set; }
    }
}
