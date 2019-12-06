using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarDataExternalSendResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalSendResponse : AlipayResponse
    {
        /// <summary>
        /// 20
        /// </summary>
        [JsonPropertyName("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// outter_response
        /// </summary>
        [JsonPropertyName("process_result")]
        public string ProcessResult { get; set; }
    }
}
