using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StageInfo Data Structure.
    /// </summary>
    public class StageInfo : AlipayObject
    {
        /// <summary>
        /// 分组 1: A 2: B 以此类推
        /// </summary>
        [JsonPropertyName("group")]
        public long Group { get; set; }

        /// <summary>
        /// 阶段名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 轮次
        /// </summary>
        [JsonPropertyName("round")]
        public long Round { get; set; }

        /// <summary>
        /// 阶段类型 1: 积分赛 2: 淘汰赛
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
