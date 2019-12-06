using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicThirdCustomerServiceModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicThirdCustomerServiceModel : AlipayObject
    {
        /// <summary>
        /// 服务窗商户在渠道商处对应的用户id
        /// </summary>
        [JsonPropertyName("channel_uid")]
        public string ChannelUid { get; set; }
    }
}
