using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DiscountInfoConfig Data Structure.
    /// </summary>
    public class DiscountInfoConfig : AlipayObject
    {
        /// <summary>
        /// 优惠立减门槛金额 以分为单位 比如：99代表0.99元
        /// </summary>
        [JsonPropertyName("discount_threshold_amt")]
        public string DiscountThresholdAmt { get; set; }

        /// <summary>
        /// 立减类型 reduce:满立减(满5元减3元) random:随机立减(满10元随机立减1元到3元
        /// </summary>
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 优惠立减值, 分为单位 如果discount_type=reduce，那么就是具体的优惠立减额，比如：999代表满足一定金额减9.99元；  如果discount_type=random，那么就是”最小额-最大额“，比如:99-990，代表立减范围从0.99元到9.99元随机决策
        /// </summary>
        [JsonPropertyName("discount_value")]
        public string DiscountValue { get; set; }
    }
}
