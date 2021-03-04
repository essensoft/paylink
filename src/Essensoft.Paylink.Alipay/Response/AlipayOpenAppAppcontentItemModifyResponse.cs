using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemModifyResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
