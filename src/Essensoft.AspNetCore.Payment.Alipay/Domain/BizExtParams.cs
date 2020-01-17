using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizExtParams Data Structure.
    /// </summary>
    public class BizExtParams : AlipayObject
    {
        /// <summary>
        /// 拼团场景下，所有参团人userid列表
        /// </summary>
        [JsonPropertyName("groupon_partners")]
        public List<string> GrouponPartners { get; set; }
    }
}
