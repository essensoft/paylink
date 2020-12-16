using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppGongyiTestQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppGongyiTestQueryModel : AlipayObject
    {
        /// <summary>
        /// sadfsdaf
        /// </summary>
        [JsonPropertyName("asdf")]
        public AdvertItem Asdf { get; set; }

        /// <summary>
        /// count 不是唯一 取值范围（1-10）
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
