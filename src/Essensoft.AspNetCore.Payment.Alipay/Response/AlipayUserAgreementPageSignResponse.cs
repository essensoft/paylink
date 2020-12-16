using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementPageSignResponse.
    /// </summary>
    public class AlipayUserAgreementPageSignResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。（只有签约成功时才会返回）
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 返回脱敏的支付宝账号，如需要返回不脱敏的支付宝用户账号，需要用户在签约页面上授权
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 用户签约的支付宝账号对应的支付宝唯一用户号。  以2088开头的16位纯数字组成。(只有签约成功时才会返回)
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授信模式，取值：DEDUCT_HUAZHI-花芝GO。
        /// </summary>
        [JsonPropertyName("credit_auth_mode")]
        public string CreditAuthMode { get; set; }

        /// <summary>
        /// 代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。
        /// </summary>
        [JsonPropertyName("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，如果商户接口中未传，则不会返回
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 是否海外购汇身份。值：T/F（只有在签约成功时才会返回）
        /// </summary>
        [JsonPropertyName("forex_eligible")]
        public string ForexEligible { get; set; }

        /// <summary>
        /// 用户代扣协议的失效时间，格式为yyyy-MM-dd HH:mm:ss。（只有签约成功才会返回）
        /// </summary>
        [JsonPropertyName("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        [JsonPropertyName("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 当前签约的协议场景。
        /// </summary>
        [JsonPropertyName("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 支付宝代扣协议的实际签约时间，格式为yyyy-MM-dd HH:mm:ss。(只有签约成功才会返回)
        /// </summary>
        [JsonPropertyName("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 用户选择的首扣渠道列表。其中list元素是一个map，包含tail - 银行卡尾号、bank_card_type - 银行卡类型。
        /// </summary>
        [JsonPropertyName("specified_sort_assets")]
        public string SpecifiedSortAssets { get; set; }

        /// <summary>
        /// 协议的当前状态。  1. TEMP：暂存，协议未生效过；  2. NORMAL：正常；  3. STOP：暂停。    （只有签约成功才会返回）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户代扣协议的实际生效时间，格式为yyyy-MM-dd HH:mm:ss。（只有签约成功才会返回）
        /// </summary>
        [JsonPropertyName("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 用户的芝麻信用openId，供商户查询用户芝麻信用使用。（只有签约成功时才返回）
        /// </summary>
        [JsonPropertyName("zm_open_id")]
        public string ZmOpenId { get; set; }
    }
}
