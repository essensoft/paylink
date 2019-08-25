using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StepcounterDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StepcounterDataInfo : AlipayObject
    {
        /// <summary>
        /// 用户的日计步值。为用户某个时区下某个日期的步数总值。
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 查询到的步数所在日期。
        /// </summary>
        [JsonProperty("count_date")]
        public string CountDate { get; set; }

        /// <summary>
        /// 返回的用户日计步数所在时区。若入参中时区不为空，则此返回与入参相同; 若入参中时区为空，则返回用户设备所在时区步数。
        /// </summary>
        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }
    }
}
