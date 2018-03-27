using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryModel : AlipayObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonProperty("rucan")]
        public string Rucan { get; set; }
    }
}
