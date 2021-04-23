using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenBpaasContractQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenBpaasContractQueryModel : AlipayObject
    {
        /// <summary>
        /// bpaas 应用ID
        /// </summary>
        [JsonPropertyName("bpaas_app_id")]
        public string BpaasAppId { get; set; }

        /// <summary>
        /// bpaas服务ID；注意：同一个服务不同版本ID不同
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
