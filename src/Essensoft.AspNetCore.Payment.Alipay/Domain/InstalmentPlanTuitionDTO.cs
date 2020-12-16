using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstalmentPlanTuitionDTO Data Structure.
    /// </summary>
    public class InstalmentPlanTuitionDTO : AlipayObject
    {
        /// <summary>
        /// 扣款金额， 类似11.12格式
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易完成信息
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 订单ID，关联充值订单主键
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 扣款调度时间
        /// </summary>
        [JsonPropertyName("schedule_time")]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 扣款序号
        /// </summary>
        [JsonPropertyName("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 二级商户pid
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 扣款状态  1, "打款调度中" 2, "打款完成" 3, "退款中" 4, "退款完成"
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 代扣交易订单ID
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户pid
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
