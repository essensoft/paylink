using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenCreateResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁通行证id
        /// </summary>
        [JsonPropertyName("ant_id")]
        public string AntId { get; set; }
    }
}
