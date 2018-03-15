using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ModelMeta Data Structure.
    /// </summary>
    public class ModelMeta : AlipayObject
    {
        /// <summary>
        /// 模型描述
        /// </summary>
        [JsonProperty("model_desc")]
        public string ModelDesc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 模型唯一查询标识符
        /// </summary>
        [JsonProperty("model_uk")]
        public string ModelUk { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [JsonProperty("query_key")]
        public List<string> QueryKey { get; set; }
    }
}
