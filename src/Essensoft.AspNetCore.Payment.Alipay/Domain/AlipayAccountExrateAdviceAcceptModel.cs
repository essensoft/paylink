using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateAdviceAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateAdviceAcceptModel : AlipayObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [JsonProperty("advice")]
        public AdviceVO Advice { get; set; }
    }
}
