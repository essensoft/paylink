using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserCharityForestQueryResponse.
    /// </summary>
    public class AlipayUserCharityForestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否开通了蚂蚁森林
        /// </summary>
        [JsonPropertyName("forest_user")]
        public bool ForestUser { get; set; }
    }
}
