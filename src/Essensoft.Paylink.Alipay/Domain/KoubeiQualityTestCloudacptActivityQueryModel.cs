using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestCloudacptActivityQueryModel Data Structure.
    /// </summary>
    public class KoubeiQualityTestCloudacptActivityQueryModel : AlipayObject
    {
        /// <summary>
        /// partener id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
