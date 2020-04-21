using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderFreezeResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthOrderFreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议状态。Y表示状态有效，N表示状态失效
        /// </summary>
        [JsonPropertyName("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝侧花呗冻结解冻操作单据id
        /// </summary>
        [JsonPropertyName("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 花呗冻结金额
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 冻结成功时间
        /// </summary>
        [JsonPropertyName("gmt_trans")]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 完成本次操作时，用户资金池余额快照。仅作提示用，请勿用于核对，并发情况下数值有可能不准确。两位小数，单位元。
        /// </summary>
        [JsonPropertyName("rest_freeze_amount")]
        public string RestFreezeAmount { get; set; }

        /// <summary>
        /// 商户的支付宝用户id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 业务操作状态，Y表示成功；N表示失败
        /// </summary>
        [JsonPropertyName("trans_status")]
        public string TransStatus { get; set; }
    }
}
