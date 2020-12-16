using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GrouponRule Data Structure.
    /// </summary>
    public class GrouponRule : AlipayObject
    {
        /// <summary>
        /// 拼团成团人数
        /// </summary>
        [JsonPropertyName("group_size")]
        public string GroupSize { get; set; }

        /// <summary>
        /// 拼团价格，单位元
        /// </summary>
        [JsonPropertyName("groupon_price")]
        public string GrouponPrice { get; set; }
    }
}
