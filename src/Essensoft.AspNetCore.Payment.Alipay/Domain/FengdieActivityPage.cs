using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivityPage Data Structure.
    /// </summary>
    public class FengdieActivityPage : AlipayObject
    {
        /// <summary>
        /// H5页面唯一id，创建H5应用时自动生成
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// H5页面名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// H5页面schema数据
        /// </summary>
        [JsonPropertyName("schema")]
        public List<FengdieActivitySchemaData> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [JsonPropertyName("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// H5页面中文标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// H5页面访问地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
