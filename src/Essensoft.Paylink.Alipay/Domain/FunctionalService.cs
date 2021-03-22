using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FunctionalService Data Structure.
    /// </summary>
    public class FunctionalService : AlipayObject
    {
        /// <summary>
        /// 功能内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 功能码 支持的功能码请与产品或对应技术确认
        /// </summary>
        [JsonPropertyName("function_code")]
        public string FunctionCode { get; set; }

        /// <summary>
        /// 功能名称
        /// </summary>
        [JsonPropertyName("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 功能类型
        /// </summary>
        [JsonPropertyName("function_type")]
        public string FunctionType { get; set; }

        /// <summary>
        /// 功能入口
        /// </summary>
        [JsonPropertyName("function_url")]
        public string FunctionUrl { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }
    }
}
