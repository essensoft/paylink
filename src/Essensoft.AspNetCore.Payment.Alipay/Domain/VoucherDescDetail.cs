using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherDescDetail Data Structure.
    /// </summary>
    [Serializable]
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
