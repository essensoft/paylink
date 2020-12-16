using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginservicePublishResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappPluginservicePublishResponse : AlipayResponse
    {
        /// <summary>
        /// PL2012211102012056
        /// </summary>
        [JsonPropertyName("ability_id")]
        public string AbilityId { get; set; }
    }
}
