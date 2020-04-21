using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMessagetestCesSendModel Data Structure.
    /// </summary>
    public class AlipayOpenMessagetestCesSendModel : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("cop")]
        public List<GavintestNewLeveaOne> Cop { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("str")]
        public List<string> Str { get; set; }
    }
}
