using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandTradeorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询结果中是否需要包含指定订单下商品订单，默认false，即不包含指定订单下的商品订单
        /// </summary>
        [JsonPropertyName("contain_item_order")]
        public bool ContainItemOrder { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
