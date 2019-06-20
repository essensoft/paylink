using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosStallModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosStallModel : AlipayObject
    {
        /// <summary>
        /// 菜品下档口的排序号
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 档口ID
        /// </summary>
        [JsonProperty("stall_id")]
        public string StallId { get; set; }

        /// <summary>
        /// 档口名字
        /// </summary>
        [JsonProperty("stall_name")]
        public string StallName { get; set; }
    }
}
