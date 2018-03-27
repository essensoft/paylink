using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestCloudacptActivityQueryModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestCloudacptActivityQueryModel : AlipayObject
    {
        /// <summary>
        /// partener id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
