using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdAduserqualificationCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 资质id+ 用户资质id，唯一标识用户的创建的一个资质
        /// </summary>
        [JsonPropertyName("qualification_id")]
        public long QualificationId { get; set; }
    }
}
