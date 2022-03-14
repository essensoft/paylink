using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.JsonConverters;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 错误详情
    /// </summary>
    public class ErrorDetail : WeChatPayObject
    {
        /// <summary>
        /// 指示错误参数的位置。当错误参数位于请求body的JSON时，填写指向参数的JSON Pointer 。当错误参数位于请求的url或者querystring时，填写参数的变量名。
        /// </summary>
        [JsonPropertyName("field")]
        public string Field { get; set; }

        /// <summary>
        /// 错误的值
        /// </summary>
        [JsonPropertyName("value")]
        [JsonConverter(typeof(WeChatPayStringConverter))]
        public string Value { get; set; }

        /// <summary>
        /// 具体错误原因
        /// </summary>
        [JsonPropertyName("issue")]
        public string Issue { get; set; }

        /// <summary>
        /// 错误定位
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }
    }
}
