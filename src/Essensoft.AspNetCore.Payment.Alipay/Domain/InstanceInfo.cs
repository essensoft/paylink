using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstanceInfo Data Structure.
    /// </summary>
    public class InstanceInfo : AlipayObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 券开始生效时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
