using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ReportBasicInfo Data Structure.
    /// </summary>
    public class ReportBasicInfo : AlipayObject
    {
        /// <summary>
        /// 出险时间
        /// </summary>
        [JsonPropertyName("accident_date")]
        public string AccidentDate { get; set; }

        /// <summary>
        /// 投保请求的交易流水号
        /// </summary>
        [JsonPropertyName("apply_trade_no")]
        public string ApplyTradeNo { get; set; }

        /// <summary>
        /// 索赔金额
        /// </summary>
        [JsonPropertyName("estimate_amount")]
        public string EstimateAmount { get; set; }

        /// <summary>
        /// 申请理赔的保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 关联业务订单号（理赔唯一标识/LP订单号）
        /// </summary>
        [JsonPropertyName("related_order_no")]
        public string RelatedOrderNo { get; set; }

        /// <summary>
        /// 报案时间
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报案人联系方式
        /// </summary>
        [JsonPropertyName("reporter_contact_info")]
        public string ReporterContactInfo { get; set; }

        /// <summary>
        /// 申请报案人的名称
        /// </summary>
        [JsonPropertyName("reporter_name")]
        public string ReporterName { get; set; }

        /// <summary>
        /// 工单号
        /// </summary>
        [JsonPropertyName("ticket_no")]
        public string TicketNo { get; set; }
    }
}
