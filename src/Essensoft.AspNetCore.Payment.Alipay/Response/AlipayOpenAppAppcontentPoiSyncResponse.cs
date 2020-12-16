using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentPoiSyncResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentPoiSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝返回的唯一编码
        /// </summary>
        [JsonPropertyName("alipay_poi_id")]
        public string AlipayPoiId { get; set; }
    }
}
