using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EquityInfo Data Structure.
    /// </summary>
    public class EquityInfo : AlipayObject
    {
        /// <summary>
        /// ‘杰克琼斯’
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// ext_info
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 天猫优惠券
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// APPLIED：已申领；UNAPPLIED：未申领；DELETED：已过期
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 优惠价值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
