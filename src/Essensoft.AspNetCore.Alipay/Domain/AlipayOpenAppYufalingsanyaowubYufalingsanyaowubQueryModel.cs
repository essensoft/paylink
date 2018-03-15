using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel : AlipayObject
    {
        /// <summary>
        /// yufaa
        /// </summary>
        [JsonProperty("yufaa")]
        public string Yufaa { get; set; }
    }
}
