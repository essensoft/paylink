using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniDeploypackageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDeploypackageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 包数据
        /// </summary>
        [JsonPropertyName("pack_json")]
        public string PackJson { get; set; }
    }
}
