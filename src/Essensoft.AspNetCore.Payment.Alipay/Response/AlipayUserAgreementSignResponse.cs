using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementSignResponse.
    /// </summary>
    public class AlipayUserAgreementSignResponse : AlipayResponse
    {
        /// <summary>
        /// 在无需用户确认且签约成功的场景下，会同步返回签约协议号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 返回脱敏的支付宝账号
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 签约申请成功的场景下，会同步返回用户签约的支付宝账号对应的支付宝唯一用户id。  以2088开头的16位纯数字组成。
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 签约申请token，其格式和内容，由支付宝定义。在需要签约确认的场景下，商户可根据申请操作成功时返回的申请token，进行后续的确认操作。  1. 不需要用户进行签约确认时，不返回本参数。  2. 需要用户进行签约确认时，本参数不为空。
        /// </summary>
        [JsonPropertyName("apply_token")]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，如果商户接口中未传，则不会返回
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 是否海外购汇身份
        /// </summary>
        [JsonPropertyName("forex_eligible")]
        public string ForexEligible { get; set; }
    }
}
