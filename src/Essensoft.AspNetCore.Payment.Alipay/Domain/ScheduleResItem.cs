using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleResItem Data Structure.
    /// </summary>
    public class ScheduleResItem : AlipayObject
    {
        /// <summary>
        /// 资源标志
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
