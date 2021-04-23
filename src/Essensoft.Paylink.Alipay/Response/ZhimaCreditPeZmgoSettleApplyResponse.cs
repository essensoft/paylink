using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleApplyResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoSettleApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 根据商户传入的轻会员协议结算周期内累计消费数据与支付宝端轻会员协议结算周期内消费数据比对之后，若数据不一致，则会返回对应的异常数据比对结果。
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// Y("Y", "支付成功"), P("P", "支付中"), N("N", "支付失败"),
        /// </summary>
        [JsonPropertyName("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 芝麻GO结算时，需要传入的扣款单据号。来源于协议到期通知消息
        /// </summary>
        [JsonPropertyName("withhold_plan_no")]
        public string WithholdPlanNo { get; set; }
    }
}
