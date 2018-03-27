using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateAdviceAcceptModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateAdviceAcceptModel : AlipayObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [JsonProperty("advice")]
        public AdviceVO Advice { get; set; }
    }
}
