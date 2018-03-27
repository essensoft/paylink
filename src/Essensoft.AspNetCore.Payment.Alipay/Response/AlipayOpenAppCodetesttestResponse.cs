using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppCodetesttestResponse.
    /// </summary>
    public class AlipayOpenAppCodetesttestResponse : AlipayResponse
    {
        /// <summary>
        /// 测试测试测试
        /// </summary>
        [JsonProperty("testtesttest")]
        public string Testtesttest { get; set; }
    }
}
