using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentCredential Data Structure.
    /// </summary>
    public class PaymentCredential : AlipayObject
    {
        /// <summary>
        /// 码过期时间。{UTC timestamp when the payment credential is no longer valid for payment. W3C’s definition of the ISO 8601 date and time format: yyyy-MM-dd'T'HH:mm:ss.SSSZ}
        /// </summary>
        [JsonPropertyName("expiration_timestamp")]
        public string ExpirationTimestamp { get; set; }

        /// <summary>
        /// 码的id。{Identifier for this credential}
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// 码类型。{To enable QR code and barcode functionality}
        /// </summary>
        [JsonPropertyName("payment_credential_type")]
        public string PaymentCredentialType { get; set; }

        /// <summary>
        /// 码值加密结果。{The encrypted credential value}
        /// </summary>
        [JsonPropertyName("value")]
        public EncryptedPaymentCredential Value { get; set; }
    }
}
