using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedLabelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedLabelInfo : AlipayObject
    {
        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为谓语
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// label行的跳转链接
        /// </summary>
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// 根据主谓宾的格式生成动态的标题，此字段为宾语
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }
    }
}
