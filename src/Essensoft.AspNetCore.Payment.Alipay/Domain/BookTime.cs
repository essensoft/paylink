using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BookTime Data Structure.
    /// </summary>
    [Serializable]
    public class BookTime : AlipayObject
    {
        /// <summary>
        /// 可预定时间段。格式： HH:mm:ss
        /// </summary>
        [JsonProperty("time")]
        public List<string> Time { get; set; }

        /// <summary>
        /// 可预订周几。如1表示周一；2：周二；3：周三；4：周四；5：周五；6：周六；7：周日
        /// </summary>
        [JsonProperty("week")]
        public long Week { get; set; }
    }
}
