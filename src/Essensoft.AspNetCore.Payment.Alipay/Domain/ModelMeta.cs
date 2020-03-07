using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ModelMeta Data Structure.
    /// </summary>
    public class ModelMeta : AlipayObject
    {
        /// <summary>
        /// 模型描述
        /// </summary>
        [JsonPropertyName("model_desc")]
        public string ModelDesc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 模型唯一查询标识符
        /// </summary>
        [JsonPropertyName("model_uk")]
        public string ModelUk { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [JsonPropertyName("query_key")]
        public List<string> QueryKey { get; set; }
    }
}
