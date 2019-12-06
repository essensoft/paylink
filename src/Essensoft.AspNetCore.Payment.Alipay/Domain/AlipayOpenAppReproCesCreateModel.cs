using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppReproCesCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenAppReproCesCreateModel : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("comp")]
        public List<GavintestNewLeveaOne> Comp { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("nam")]
        public Gavinmed Nam { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("str")]
        public List<string> Str { get; set; }
    }
}
