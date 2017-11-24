using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// VoucherDescDetail Data Structure.
    /// </summary>
    public class VoucherDescDetail : AlipayObject
    {
        /// <summary>
        /// 具体描述信息列表
        /// </summary>
        [JsonProperty("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 图片描述信息
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 券说明的标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券外部详情描述
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
