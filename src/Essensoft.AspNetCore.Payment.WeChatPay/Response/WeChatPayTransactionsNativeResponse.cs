using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayTransactionsNativeResponse : WeChatPayV3Response
    {
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
