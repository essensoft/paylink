using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CateInfoVO Data Structure.
    /// </summary>
    public class CateInfoVO : AlipayObject
    {
        /// <summary>
        /// 类目编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
