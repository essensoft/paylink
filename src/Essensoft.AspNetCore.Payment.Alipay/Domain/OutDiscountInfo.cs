using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OutDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutDiscountInfo : AlipayObject
    {
        /// <summary>
        /// 优惠金额，单位：分
        /// </summary>
        [JsonProperty("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [JsonProperty("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠类型，必须是以下类型：  EXCLUSIVE_BENEFIT("专享优惠"),  EXCLUSIVE_DISCOUNT("专享折扣"),  APPRECIATION_BENEFIT("增值权益"),  MEMBER_POINT("会员积分");
        /// </summary>
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }
    }
}
