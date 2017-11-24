using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppPackagetestModel Data Structure.
    /// </summary>
    public class AlipayOpenAppPackagetestModel : AlipayObject
    {
        /// <summary>
        /// testtest
        /// </summary>
        [JsonProperty("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// testtest
        /// </summary>
        [JsonProperty("testtest")]
        public string Testtest { get; set; }
    }
}
