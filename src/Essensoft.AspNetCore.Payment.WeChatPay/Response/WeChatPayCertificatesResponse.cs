using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayCertificatesResponse : WeChatPayV3Response
    {
        [JsonPropertyName("data")]
        public List<Certificate> Certificates { get; set; }
    }
}
