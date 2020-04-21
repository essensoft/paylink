using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdCreativeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创意ID：广告创意ID，投放广告唯一标识，可使用该ID进行广告详情查询
        /// </summary>
        [JsonPropertyName("ad_id")]
        public long AdId { get; set; }
    }
}
