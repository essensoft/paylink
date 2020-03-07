using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSceneprodPrepaymentApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodPrepaymentApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否可以提前还款  提前还款试算时必须先判断accept_repay="Y",如果="N"金额字段为空
        /// </summary>
        [JsonPropertyName("accept_repay")]
        public string AcceptRepay { get; set; }

        /// <summary>
        /// 交易失败明细提示  提前还款结果查询时，如果tradeStatus=FAIL，failReason字段显示提前还款失败原因。
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 提前还款总金额（单位分）
        /// </summary>
        [JsonPropertyName("prepayment_amt")]
        public string PrepaymentAmt { get; set; }

        /// <summary>
        /// 提前还款申请单号  提前还款申请后，如受理成功会返回。其余场景无返回值。
        /// </summary>
        [JsonPropertyName("prepayment_apply_no")]
        public string PrepaymentApplyNo { get; set; }

        /// <summary>
        /// 提前还款利息（单位分）
        /// </summary>
        [JsonPropertyName("prepayment_int_amt")]
        public string PrepaymentIntAmt { get; set; }

        /// <summary>
        /// 提前还款罚金（单位分）
        /// </summary>
        [JsonPropertyName("prepayment_pen_amt")]
        public string PrepaymentPenAmt { get; set; }

        /// <summary>
        /// 提前还款本金(单位分)
        /// </summary>
        [JsonPropertyName("prepayment_prin_amt")]
        public string PrepaymentPrinAmt { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [JsonPropertyName("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// tradeStatus为提前还款结果查询时返回
        /// </summary>
        [JsonPropertyName("trade_status")]
        public string TradeStatus { get; set; }
    }
}
