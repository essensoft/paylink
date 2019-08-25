using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReduceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceInfo : AlipayObject
    {
        /// <summary>
        /// 门店品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 消费金额（单位分）
        /// </summary>
        [JsonProperty("consume_amt")]
        public string ConsumeAmt { get; set; }

        /// <summary>
        /// 消费门店名称
        /// </summary>
        [JsonProperty("consume_store_name")]
        public string ConsumeStoreName { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        [JsonProperty("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 优惠金额（单位分）
        /// </summary>
        [JsonProperty("promo_amt")]
        public string PromoAmt { get; set; }

        /// <summary>
        /// 用户名（脱敏）
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
