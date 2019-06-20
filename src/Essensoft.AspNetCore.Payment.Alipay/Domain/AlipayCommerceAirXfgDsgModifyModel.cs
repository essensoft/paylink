using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAirXfgDsgModifyModel : AlipayObject
    {
        /// <summary>
        /// 用户年龄
        /// </summary>
        [JsonProperty("age")]
        public string Age { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("nam")]
        public string Nam { get; set; }

        /// <summary>
        /// 男
        /// </summary>
        [JsonProperty("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xbw")]
        public string Xbw { get; set; }
    }
}
