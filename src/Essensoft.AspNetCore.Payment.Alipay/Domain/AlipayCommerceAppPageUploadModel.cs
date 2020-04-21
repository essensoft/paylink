using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAppPageUploadModel Data Structure.
    /// </summary>
    public class AlipayCommerceAppPageUploadModel : AlipayObject
    {
        /// <summary>
        /// 租户应用服务数据
        /// </summary>
        [JsonPropertyName("content")]
        public CommerceAppUploadRequestContent Content { get; set; }

        /// <summary>
        /// 租户应用服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }
    }
}
