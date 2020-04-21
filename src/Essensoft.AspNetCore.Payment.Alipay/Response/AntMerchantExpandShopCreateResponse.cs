using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandShopCreateResponse.
    /// </summary>
    public class AntMerchantExpandShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
