using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ModelQueryParam Data Structure.
    /// </summary>
    public class ModelQueryParam : AlipayObject
    {
        /// <summary>
        /// 条件查询参数
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 操作计算符，目前仅支持EQ
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 查询参数值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
