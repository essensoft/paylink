using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthSettleApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthSettleApplyModel : AlipayObject
    {
        /// <summary>
        /// 操作类型，默认为 MERCHANT_SETTLE（结算）。枚举值如下： *  MERCHANT_SETTLE：结算（需要主动退出在发起结算）; *  QUIT_SETTLE：退出协议（解约协议）; *  PERIOD_SETTLE：分阶段结算（不解约协议）。
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public ExtraParams ExtendParams { get; set; }

        /// <summary>
        /// 是否解约，该参数控制结算完成之后的操作，为空则表示结算后解约。枚举值如下： *  true：代表解约，默认为true。 *  false：代表不解约。
        /// </summary>
        [JsonPropertyName("need_terminated")]
        public string NeedTerminated { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 需要支付的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝商家ID，即商家账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 说明：若该值为空，则默认为商户签约账号对应的支付宝用户ID。
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
