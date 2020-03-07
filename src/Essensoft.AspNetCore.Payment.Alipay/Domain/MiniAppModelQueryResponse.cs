using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppModelQueryResponse Data Structure.
    /// </summary>
    public class MiniAppModelQueryResponse : AlipayObject
    {
        /// <summary>
        /// 模型查询类型
        /// </summary>
        [JsonPropertyName("model_type")]
        public string ModelType { get; set; }

        /// <summary>
        /// 小程序核心模型的json化字符串
        /// </summary>
        [JsonPropertyName("records")]
        public List<string> Records { get; set; }
    }
}
