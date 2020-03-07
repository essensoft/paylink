using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
