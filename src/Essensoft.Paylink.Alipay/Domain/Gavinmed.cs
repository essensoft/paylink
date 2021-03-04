using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Gavinmed Data Structure.
    /// </summary>
    public class Gavinmed : AlipayObject
    {
        /// <summary>
        /// 复杂类型嵌入
        /// </summary>
        [JsonPropertyName("meds")]
        public List<GavintestNewLeveaOne> Meds { get; set; }

        /// <summary>
        /// 退换货
        /// </summary>
        [JsonPropertyName("str")]
        public string Str { get; set; }
    }
}
