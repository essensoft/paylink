using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenDesCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenDesCreateModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("des")]
        public List<GavintestNewLeveaOne> Des { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [JsonPropertyName("test")]
        public List<bool> Test { get; set; }
    }
}
