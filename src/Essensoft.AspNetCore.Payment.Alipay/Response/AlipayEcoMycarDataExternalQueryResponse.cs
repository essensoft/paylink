using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 30
        /// </summary>
        [JsonPropertyName("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// outter_response
        /// </summary>
        [JsonPropertyName("query_result")]
        public string QueryResult { get; set; }
    }
}
