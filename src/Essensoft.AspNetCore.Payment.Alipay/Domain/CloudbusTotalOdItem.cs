using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusTotalOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusTotalOdItem : AlipayObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 消息提示
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 客流总量值(日均)
        /// </summary>
        [JsonProperty("totalod")]
        public long Totalod { get; set; }

        /// <summary>
        /// 周末客流总量(日均)
        /// </summary>
        [JsonProperty("weekend_od")]
        public long WeekendOd { get; set; }

        /// <summary>
        /// 工作日客流总量(日均)
        /// </summary>
        [JsonProperty("workday_od")]
        public long WorkdayOd { get; set; }
    }
}
