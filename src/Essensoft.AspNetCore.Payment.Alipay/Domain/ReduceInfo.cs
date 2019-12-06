using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReduceInfo Data Structure.
    /// </summary>
    public class ReduceInfo : AlipayObject
    {
        /// <summary>
        /// 门店品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 消费金额（单位分）
        /// </summary>
        [JsonPropertyName("consume_amt")]
        public string ConsumeAmt { get; set; }

        /// <summary>
        /// 消费门店名称
        /// </summary>
        [JsonPropertyName("consume_store_name")]
        public string ConsumeStoreName { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        [JsonPropertyName("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 优惠金额（单位分）
        /// </summary>
        [JsonPropertyName("promo_amt")]
        public string PromoAmt { get; set; }

        /// <summary>
        /// 用户名（脱敏）
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
