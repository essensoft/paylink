using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicComptestCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicComptestCreateModel : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("string")]
        public List<GavintestNewLeveaOne> String { get; set; }
    }
}
