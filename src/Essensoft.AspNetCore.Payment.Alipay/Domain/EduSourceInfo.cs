using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduSourceInfo Data Structure.
    /// </summary>
    public class EduSourceInfo : AlipayObject
    {
        /// <summary>
        /// 供应商的LOGO
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 供应商电话
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 供应商名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
