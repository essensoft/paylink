using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbtestabcQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("testabc")]
        public string Testabc { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
