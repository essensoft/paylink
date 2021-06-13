using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeRefundApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeRefundApplyModel : AlipayObject
    {
        /// <summary>
        /// 外部商户的订单编号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退已打款计划明细： 当退款类型为2时必填
        /// </summary>
        [JsonPropertyName("refund_paid_detail_list")]
        public List<RefundPaidDetail> RefundPaidDetailList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款类型： 1-退未打款 2-退已打款 3-全部
        /// </summary>
        [JsonPropertyName("refund_type")]
        public long RefundType { get; set; }

        /// <summary>
        /// 部分退款时：外部幂等号，长度不能超过32位
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 二级商户
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
