using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbtstabcQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xwbaa")]
        public string Xwbaa { get; set; }
    }
}
