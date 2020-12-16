using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RechargeOrderTuitionDTO Data Structure.
    /// </summary>
    public class RechargeOrderTuitionDTO : AlipayObject
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 已完成的打款数
        /// </summary>
        [JsonPropertyName("finished_periods")]
        public long FinishedPeriods { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 总的分期数
        /// </summary>
        [JsonPropertyName("periods")]
        public long Periods { get; set; }

        /// <summary>
        /// 分期扣款任务列表，未付款状态，打款任务为空
        /// </summary>
        [JsonPropertyName("plans")]
        public List<InstalmentPlanTuitionDTO> Plans { get; set; }

        /// <summary>
        /// 学费码分期付款扣款计划
        /// </summary>
        [JsonPropertyName("recharge_config")]
        public RechargeConfigTuitionDTO RechargeConfig { get; set; }

        /// <summary>
        /// 退款类型 1, "全部退款" 2, "未到账资金退款"
        /// </summary>
        [JsonPropertyName("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 二级商户
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 订单状态 0, "待付款"  1, "打款流程中"  2, "打款完成"  3, "退款中"  4, "退款完成"  5, "冻结中"
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 充值总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// 缴费用户的支付宝pid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
