using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandLogisticsorderCreateResponse.
    /// </summary>
    public class AntMerchantExpandLogisticsorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 物流单id
        /// </summary>
        [JsonPropertyName("logistics_order_id")]
        public string LogisticsOrderId { get; set; }
    }
}
