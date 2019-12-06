using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MMemberLevel Data Structure.
    /// </summary>
    public class MMemberLevel : AlipayObject
    {
        /// <summary>
        /// 会员等级code码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 会员等级值
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员等级名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
