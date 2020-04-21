using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthAgreementCloseModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthAgreementCloseModel : AlipayObject
    {
        /// <summary>
        /// 花芝协议号，支付宝系统中用以唯一标识用户签约记录的编号，即花芝协议号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户主动意愿退出：USER_CANCEL_QUIT; 商户结算退出：SETTLE_APPLY_QUIT; 默认值为SETTLE_APPLY_QUIT；这个字段会影响用户在芝麻信用合约的状态
        /// </summary>
        [JsonPropertyName("quit_type")]
        public string QuitType { get; set; }
    }
}
