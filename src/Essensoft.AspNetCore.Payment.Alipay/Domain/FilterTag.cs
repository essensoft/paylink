using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FilterTag Data Structure.
    /// </summary>
    public class FilterTag : AlipayObject
    {
        /// <summary>
        /// 过滤条件的标签code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 分组过滤条件  注意：这个是JSON数组，必须以[开头，以]结尾，[]外层不能加双引号"",正确案例[{"operate": "EQ","value": "1" }]，错误案例："[{"operate": "EQ","value": "1" }]"
        /// </summary>
        [JsonPropertyName("filter_items")]
        public string FilterItems { get; set; }
    }
}
