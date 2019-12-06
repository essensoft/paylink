using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsProdTag Data Structure.
    /// </summary>
    public class InsProdTag : AlipayObject
    {
        /// <summary>
        /// 业务标记代码
        /// </summary>
        [JsonPropertyName("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 业务标记值
        /// </summary>
        [JsonPropertyName("tag_value")]
        public string TagValue { get; set; }
    }
}
