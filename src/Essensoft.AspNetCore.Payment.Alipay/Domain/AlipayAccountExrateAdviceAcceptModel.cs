using System.Text.Json.Serialization;

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
        [JsonPropertyName("advice")]
        public AdviceVO Advice { get; set; }
    }
}
