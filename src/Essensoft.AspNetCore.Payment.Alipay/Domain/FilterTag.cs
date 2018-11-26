using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FilterTag Data Structure.
    /// </summary>
    [Serializable]
    public class FilterTag : AlipayObject
    {
        /// <summary>
        /// 过滤条件的标签code
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 分组过滤条件  注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例[{"operate": "EQ","value": "1" }]，错误案例："[{"operate": "EQ","value": "1" }]"
        /// </summary>
        [JsonProperty("filter_items")]
        [XmlElement("filter_items")]
        public string FilterItems { get; set; }
    }
}
