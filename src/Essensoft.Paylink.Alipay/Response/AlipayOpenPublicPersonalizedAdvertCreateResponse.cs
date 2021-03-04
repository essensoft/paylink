using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedAdvertCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 轮播广告分组id
        /// </summary>
        [JsonPropertyName("advert_group")]
        public string AdvertGroup { get; set; }
    }
}
