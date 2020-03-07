using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Institution Data Structure.
    /// </summary>
    public class Institution : AlipayObject
    {
        /// <summary>
        /// 人行联行号
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 银行全称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
