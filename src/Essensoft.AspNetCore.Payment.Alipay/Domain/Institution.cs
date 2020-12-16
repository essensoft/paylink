using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Institution Data Structure.
    /// </summary>
    public class Institution : AlipayObject
    {
        /// <summary>
        /// 机构编码（如：人行联行号）
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 机构全称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级机构编码
        /// </summary>
        [JsonPropertyName("root_code")]
        public string RootCode { get; set; }

        /// <summary>
        /// 父级机构全称
        /// </summary>
        [JsonPropertyName("root_name")]
        public string RootName { get; set; }
    }
}
