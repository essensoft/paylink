using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayHighValueCustomerResult Data Structure.
    /// </summary>
    public class AlipayHighValueCustomerResult : AlipayObject
    {
        /// <summary>
        /// Z0-Z7
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }
    }
}
