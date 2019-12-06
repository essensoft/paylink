using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPlatformUseridGetModel Data Structure.
    /// </summary>
    public class AlipayPlatformUseridGetModel : AlipayObject
    {
        /// <summary>
        /// openId的列表
        /// </summary>
        [JsonPropertyName("open_ids")]
        public List<string> OpenIds { get; set; }
    }
}
