using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// FengdieActivityPage Data Structure.
    /// </summary>
    public class FengdieActivityPage : AlipayObject
    {
        /// <summary>
        /// H5页面唯一id，创建H5应用时自动生成
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// H5页面名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// H5页面schema数据
        /// </summary>
        [JsonProperty("schema")]
        public List<FengdieActivitySchemaData> Schema { get; set; }

        /// <summary>
        /// H5页面预览图
        /// </summary>
        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// H5页面中文标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// H5页面访问地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
