using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmlAssetRecord Data Structure.
    /// </summary>
    public class AmlAssetRecord : AlipayObject
    {
        /// <summary>
        /// 数据生效时间
        /// </summary>
        [JsonPropertyName("active_date")]
        public string ActiveDate { get; set; }

        /// <summary>
        /// 名单或风险标签ID
        /// </summary>
        [JsonPropertyName("lid")]
        public string Lid { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 风险资产标签值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
