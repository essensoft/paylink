using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopPosSchedule Data Structure.
    /// </summary>
    [Serializable]
    public class ShopPosSchedule : AlipayObject
    {
        /// <summary>
        /// 早班结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 班次ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 班次名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用于标识班次顺序
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 早班开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
