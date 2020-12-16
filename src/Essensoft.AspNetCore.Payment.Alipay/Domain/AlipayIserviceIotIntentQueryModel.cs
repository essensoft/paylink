using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceIotIntentQueryModel : AlipayObject
    {
        /// <summary>
        /// iot入参
        /// </summary>
        [JsonPropertyName("iot_request")]
        public IntentQueryRequest IotRequest { get; set; }
    }
}
