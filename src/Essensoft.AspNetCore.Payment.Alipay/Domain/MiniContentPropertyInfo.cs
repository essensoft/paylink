using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniContentPropertyInfo Data Structure.
    /// </summary>
    public class MiniContentPropertyInfo : AlipayObject
    {
        /// <summary>
        /// 属性key，必须是平台预先定义的，否则不允许录入
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonPropertyName("value_list")]
        public List<string> ValueList { get; set; }
    }
}
