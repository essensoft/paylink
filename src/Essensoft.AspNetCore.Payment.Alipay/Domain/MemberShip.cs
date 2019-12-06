using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberShip Data Structure.
    /// </summary>
    public class MemberShip : AlipayObject
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonPropertyName("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 会员二代身份证号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 邮箱号码
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// MAC地址
        /// </summary>
        [JsonPropertyName("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 11位手机号码
        /// </summary>
        [JsonPropertyName("mobile_phone_no")]
        public string MobilePhoneNo { get; set; }
    }
}
