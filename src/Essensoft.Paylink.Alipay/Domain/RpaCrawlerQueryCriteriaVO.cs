using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RpaCrawlerQueryCriteriaVO Data Structure.
    /// </summary>
    public class RpaCrawlerQueryCriteriaVO : AlipayObject
    {
        /// <summary>
        /// 比较符
        /// </summary>
        [JsonPropertyName("comparison")]
        public string Comparison { get; set; }

        /// <summary>
        /// 查询字段
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// eq,gt,lt生效,查询值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// between类型生效,结束值
        /// </summary>
        [JsonPropertyName("value_end")]
        public string ValueEnd { get; set; }

        /// <summary>
        /// between类型生效,起始值
        /// </summary>
        [JsonPropertyName("value_start")]
        public string ValueStart { get; set; }

        /// <summary>
        /// 目标值
        /// </summary>
        [JsonPropertyName("values")]
        public string Values { get; set; }
    }
}
