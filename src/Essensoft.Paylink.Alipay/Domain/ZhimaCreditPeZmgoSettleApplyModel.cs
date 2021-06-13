using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoSettleApplyModel : AlipayObject
    {
        /// <summary>
        /// DEFAULT_SETTLE 默认结算模式;
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 需要支付的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 扩展的退出类型等信息
        /// </summary>
        [JsonPropertyName("settle_extend_params")]
        public SettleExtraParams SettleExtendParams { get; set; }

        /// <summary>
        /// 芝麻GO任务开始到到期过程中和任务相关享受的总优惠金额，单位为：元（人民币），精确到小数点后两位。
        /// </summary>
        [JsonPropertyName("total_discount_amount")]
        public string TotalDiscountAmount { get; set; }

        /// <summary>
        /// 芝麻GO任务开始到到期过程中和任务相关支付的总金额，单位为：元（人民币），精确到小数点后两位。
        /// </summary>
        [JsonPropertyName("total_real_pay_amount")]
        public string TotalRealPayAmount { get; set; }

        /// <summary>
        /// 芝麻GO任务开始到到期过程中和任务相关完成的任务次数
        /// </summary>
        [JsonPropertyName("total_task_count")]
        public string TotalTaskCount { get; set; }

        /// <summary>
        /// 芝麻GO结算时，需要传入的扣款单据号。来源于协议到期通知消息
        /// </summary>
        [JsonPropertyName("withhold_plan_no")]
        public string WithholdPlanNo { get; set; }
    }
}
