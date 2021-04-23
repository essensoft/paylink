using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CouponTemplateConsumeInfo Data Structure.
    /// </summary>
    public class CouponTemplateConsumeInfo : AlipayObject
    {
        /// <summary>
        /// 该活动上已领取红包金额，分为单位 999代表已领取9.99元  请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [JsonPropertyName("receive_amount")]
        public long ReceiveAmount { get; set; }

        /// <summary>
        /// 该活动上已领取红包数量 比如:999代表该活上已被领取999个红包 请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [JsonPropertyName("receive_count")]
        public long ReceiveCount { get; set; }

        /// <summary>
        /// 该活动上已退款的红包总金额，分为单位 999代表总共退款9.99元  请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 该活动上已领取红包金额，分为单位 888代表已领取8.88元  请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [JsonPropertyName("used_amount")]
        public long UsedAmount { get; set; }

        /// <summary>
        /// 该活动上已核销红包数量 比如:888代表该活上所有领取的红包中已核销了888个红包 请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [JsonPropertyName("used_count")]
        public long UsedCount { get; set; }
    }
}
