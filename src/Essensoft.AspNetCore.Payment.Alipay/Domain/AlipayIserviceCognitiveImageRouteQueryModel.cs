using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveImageRouteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveImageRouteQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务请求详细内容
        /// </summary>
        [JsonProperty("ctx")]
        public List<string> Ctx { get; set; }

        /// <summary>
        /// 业务pv唯一id
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }
    }
}
