using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundInfo Data Structure.
    /// </summary>
    public class RefundInfo : AlipayObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商品单ID
        /// </summary>
        [JsonPropertyName("item_order_no")]
        public string ItemOrderNo { get; set; }
    }
}
