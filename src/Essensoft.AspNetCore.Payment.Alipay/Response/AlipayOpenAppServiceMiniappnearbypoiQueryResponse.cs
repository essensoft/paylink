using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbypoiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务poi信息列表
        /// </summary>
        [JsonPropertyName("addresses")]
        public AddressDTO Addresses { get; set; }
    }
}
