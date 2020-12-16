using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionISVResponsePaymentInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVResponsePaymentInfoDTO : AlipayObject
    {
        /// <summary>
        /// 账户名
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("amount")]
        public TuitionMoneyDTO Amount { get; set; }

        /// <summary>
        /// bank_code
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [JsonPropertyName("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 付款人身份证
        /// </summary>
        [JsonPropertyName("payer_identity_card_number")]
        public string PayerIdentityCardNumber { get; set; }

        /// <summary>
        /// 付款手机号
        /// </summary>
        [JsonPropertyName("payer_phone_number")]
        public string PayerPhoneNumber { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [JsonPropertyName("post_script")]
        public string PostScript { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// swift code
        /// </summary>
        [JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
