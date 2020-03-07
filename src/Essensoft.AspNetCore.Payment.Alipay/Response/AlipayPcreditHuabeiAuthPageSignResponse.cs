using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthPageSignResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthPageSignResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号。只有签约成功时才会返回。后续涉及到用户已冻结额度的操作，都需要传入该协议号。请妥善保存，并在系统内建立好如下关联关系：(商户自有用户id, 支付宝用户alipay_user_id, 花呗先享协议号)
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
        /// 花呗先享签约场景
        /// </summary>
        [JsonPropertyName("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示。由商户传入，最终返回给商户。返回结果会做内容脱敏。
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 签约过程中期望进行冻结的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 花呗先享协议实际签约时间，格式为yyyy-MM-dd HH:mm:ss。(只有签约成功才会返回)
        /// </summary>
        [JsonPropertyName("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 业务成功时间
        /// </summary>
        [JsonPropertyName("gmt_trans")]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标识请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。由商户传入，最终返回给商户。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 外部签约号，由商户提供，花呗先享协议中标识用户的唯一签约号（确保在商户系统中唯一）。由商户传入，最终返回给商户。
        /// </summary>
        [JsonPropertyName("out_sign_no")]
        public string OutSignNo { get; set; }

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
        /// 业务操作状态，Y表示成功结束；N表示失败结束；I表示进行中。
        /// </summary>
        [JsonPropertyName("trans_status")]
        public string TransStatus { get; set; }
    }
}
