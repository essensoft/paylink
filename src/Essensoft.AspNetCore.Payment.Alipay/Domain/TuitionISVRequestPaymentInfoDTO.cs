using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionISVRequestPaymentInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVRequestPaymentInfoDTO : AlipayObject
    {
        /// <summary>
        /// 170
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 留学金额
        /// </summary>
        [JsonPropertyName("amount")]
        public TuitionMoneyDTO Amount { get; set; }

        /// <summary>
        /// 证书列表
        /// </summary>
        [JsonPropertyName("certificate_list")]
        public string CertificateList { get; set; }

        /// <summary>
        /// 缴费截止日期
        /// </summary>
        [JsonPropertyName("deadline")]
        public string Deadline { get; set; }

        /// <summary>
        /// 付款人身份证号
        /// </summary>
        [JsonPropertyName("payer_identity_card_number")]
        public string PayerIdentityCardNumber { get; set; }

        /// <summary>
        /// 缴费手机号
        /// </summary>
        [JsonPropertyName("payer_phone_number")]
        public string PayerPhoneNumber { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [JsonPropertyName("post_script")]
        public string PostScript { get; set; }

        /// <summary>
        /// 学校id
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }
    }
}
