using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandItemOpenCreateResponse.
    /// </summary>
    public class AntMerchantExpandItemOpenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
