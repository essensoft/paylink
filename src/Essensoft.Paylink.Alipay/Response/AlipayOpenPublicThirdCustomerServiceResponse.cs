using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicThirdCustomerServiceResponse.
    /// </summary>
    public class AlipayOpenPublicThirdCustomerServiceResponse : AlipayResponse
    {
        /// <summary>
        /// 授权给第三方渠道商的服务窗名称
        /// </summary>
        [JsonPropertyName("public_name")]
        public string PublicName { get; set; }
    }
}
