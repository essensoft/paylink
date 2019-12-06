using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktFactorDTO Data Structure.
    /// </summary>
    public class InsMktFactorDTO : AlipayObject
    {
        /// <summary>
        /// 规则因子
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 规则因子值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
