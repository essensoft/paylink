using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Domain
{
    public class EncryptCertificate : WeChatPayObject
    {
        [JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }

        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        [JsonPropertyName("associated_data")]
        public string AssociatedData { get; set; }

        [JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }
    }
}
