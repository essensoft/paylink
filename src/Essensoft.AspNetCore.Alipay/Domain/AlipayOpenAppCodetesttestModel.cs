using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    public class AlipayOpenAppCodetesttestModel : AlipayObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [JsonProperty("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [JsonProperty("testtestparam")]
        public string Testtestparam { get; set; }
    }
}
