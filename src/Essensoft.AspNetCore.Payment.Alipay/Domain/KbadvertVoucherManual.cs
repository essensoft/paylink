using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertVoucherManual Data Structure.
    /// </summary>
    public class KbadvertVoucherManual : AlipayObject
    {
        /// <summary>
        /// 说明
        /// </summary>
        [JsonProperty("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
