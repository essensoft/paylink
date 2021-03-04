using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemCreateResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
