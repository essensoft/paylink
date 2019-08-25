using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstanceInfo : AlipayObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 券开始生效时间
        /// </summary>
        [JsonProperty("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonProperty("instance_name")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
