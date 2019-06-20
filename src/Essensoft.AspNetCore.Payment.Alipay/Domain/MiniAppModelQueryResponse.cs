using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppModelQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppModelQueryResponse : AlipayObject
    {
        /// <summary>
        /// 模型查询类型
        /// </summary>
        [JsonProperty("model_type")]
        public string ModelType { get; set; }

        /// <summary>
        /// 小程序核心模型的json化字符串
        /// </summary>
        [JsonProperty("records")]
        public List<string> Records { get; set; }
    }
}
