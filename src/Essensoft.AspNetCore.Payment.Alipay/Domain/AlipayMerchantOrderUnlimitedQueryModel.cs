using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderUnlimitedQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderUnlimitedQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务号（目前仅支持交易号）    注：order_id、biz_no两者必选其一，若用biz_no查询，必须传入buyer_id
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 买家支付宝用户id    注：若用biz_no查询，必须传入buyer_id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 支付宝订单号（优先传入）  order_id、biz_no，两者必选其一；
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
