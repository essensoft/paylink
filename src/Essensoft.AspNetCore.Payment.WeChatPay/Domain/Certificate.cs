using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Domain
{
    public class Certificate : WeChatPayObject
    {
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; }

        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        [JsonPropertyName("encrypt_certificate")]
        public EncryptCertificate EncryptCertificate { get; set; }
    }
}
