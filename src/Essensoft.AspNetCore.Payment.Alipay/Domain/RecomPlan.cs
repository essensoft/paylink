using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecomPlan Data Structure.
    /// </summary>
    public class RecomPlan : AlipayObject
    {
        /// <summary>
        /// 投保key关键字
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 方案名称，展示用
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户选择后投保带的对象
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
