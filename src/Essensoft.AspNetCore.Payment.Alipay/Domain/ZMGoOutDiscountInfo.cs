using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZMGoOutDiscountInfo Data Structure.
    /// </summary>
    public class ZMGoOutDiscountInfo : AlipayObject
    {
        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称
        /// </summary>
        [JsonPropertyName("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠信息的类型。为枚举值，商户可任意选择一个值作为入参传入。可取值： ("exclusiveBenefit","专享优惠"), ("exclusiveDiscount","专享折扣"), ("appreciationBenefit", "增值权益"), ("memberPoint", "会员积分")
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }
    }
}
