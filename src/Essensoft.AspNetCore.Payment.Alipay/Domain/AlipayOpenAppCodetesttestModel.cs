using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    public class AlipayOpenAppCodetesttestModel : AlipayObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [JsonPropertyName("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [JsonPropertyName("testtestparam")]
        public string Testtestparam { get; set; }
    }
}
