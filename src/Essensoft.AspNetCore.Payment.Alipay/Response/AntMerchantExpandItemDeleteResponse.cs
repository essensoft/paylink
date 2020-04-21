using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandItemDeleteResponse.
    /// </summary>
    public class AntMerchantExpandItemDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
