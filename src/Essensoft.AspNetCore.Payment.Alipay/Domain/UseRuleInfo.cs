using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UseRuleInfo Data Structure.
    /// </summary>
    public class UseRuleInfo : AlipayObject
    {
        /// <summary>
        /// 适用门店列表
        /// </summary>
        [JsonPropertyName("suitable_shops")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [JsonPropertyName("use_mode")]
        public List<string> UseMode { get; set; }
    }
}
