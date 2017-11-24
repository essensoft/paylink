using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MoreInfoDTO Data Structure.
    /// </summary>
    public class MoreInfoDTO : AlipayObject
    {
        /// <summary>
        /// 选择opennative的时候必须填写descs的内容
        /// </summary>
        [JsonProperty("descs")]
        public List<string> Descs { get; set; }

        /// <summary>
        /// 扩展参数，需要URL地址回带的值，JSON格式(openweb时填)
        /// </summary>
        [JsonProperty("params")]
        public string Params { get; set; }

        /// <summary>
        /// 二级页面标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 超链接(选择openweb的时候必须填写url参数内容)
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
