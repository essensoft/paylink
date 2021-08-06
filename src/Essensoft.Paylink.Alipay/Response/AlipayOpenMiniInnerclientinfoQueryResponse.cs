using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 端bundleId
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 端的名称
        /// </summary>
        [JsonPropertyName("bundle_name")]
        public string BundleName { get; set; }

        /// <summary>
        /// 端ID
        /// </summary>
        [JsonPropertyName("client_id")]
        public long ClientId { get; set; }
    }
}
