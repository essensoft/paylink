using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CodeResInfo Data Structure.
    /// </summary>
    public class CodeResInfo : AlipayObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [JsonPropertyName("code_id")]
        public string CodeId { get; set; }

        /// <summary>
        /// 二维码url地址
        /// </summary>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
