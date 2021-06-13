using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RefundPaidDetail Data Structure.
    /// </summary>
    public class RefundPaidDetail : AlipayObject
    {
        /// <summary>
        /// 退已打款计划编号
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 退已打款金额，单位元，如果不传，就默认全退
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分账信息
        /// </summary>
        [JsonPropertyName("refund_royalty_info_list")]
        public List<TuitionRefundRoyaltyInfo> RefundRoyaltyInfoList { get; set; }
    }
}
