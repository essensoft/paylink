using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryResponse.
    /// </summary>
    public class AlipayIserviceIotIntentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// iot的响应类
        /// </summary>
        [JsonPropertyName("iot_response")]
        public IntentQueryResponse IotResponse { get; set; }
    }
}
