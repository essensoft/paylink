using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
