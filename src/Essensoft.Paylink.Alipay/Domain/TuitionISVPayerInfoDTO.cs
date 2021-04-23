using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TuitionISVPayerInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVPayerInfoDTO : AlipayObject
    {
        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 付款人身份证号
        /// </summary>
        [JsonPropertyName("payer_identity_card_number")]
        public string PayerIdentityCardNumber { get; set; }

        /// <summary>
        /// 付款人支付宝绑定的手机号
        /// </summary>
        [JsonPropertyName("payer_phone_number")]
        public string PayerPhoneNumber { get; set; }
    }
}
