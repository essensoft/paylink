using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataTag Data Structure.
    /// </summary>
    public class DataTag : AlipayObject
    {
        /// <summary>
        /// 聚合方式NONE,COUNT,COUNT_DISTINCT,DISTINCT,MIN,MAX,SUM
        /// </summary>
        [JsonPropertyName("aggregate")]
        public string Aggregate { get; set; }

        /// <summary>
        /// 列别名
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 标签CODE
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
