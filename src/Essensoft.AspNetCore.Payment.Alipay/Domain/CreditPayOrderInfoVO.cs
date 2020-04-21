using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayOrderInfoVO Data Structure.
    /// </summary>
    public class CreditPayOrderInfoVO : AlipayObject
    {
        /// <summary>
        /// 外部平台订单号，如果传给支付宝收单时带着前缀，此处也需要
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 卖家支付宝账户ID
        /// </summary>
        [JsonPropertyName("seller_user_id")]
        public string SellerUserId { get; set; }
    }
}
