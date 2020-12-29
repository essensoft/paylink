using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BrandBoxDetail Data Structure.
    /// </summary>
    public class BrandBoxDetail : AlipayObject
    {
        /// <summary>
        /// 品牌box提报信息
        /// </summary>
        [JsonPropertyName("detail")]
        public BoxDetail Detail { get; set; }

        /// <summary>
        /// 品牌box提报key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
