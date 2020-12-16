using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmServiceBuyResponse.
    /// </summary>
    public class AlipayIserviceCcmServiceBuyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务实例id
        /// </summary>
        [JsonPropertyName("service_instance_id")]
        public long ServiceInstanceId { get; set; }

        /// <summary>
        /// 商户在CCM的租户id
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }
    }
}
