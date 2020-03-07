using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoRenthouseCommunityInfoSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseCommunityInfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 小区同步请求号
        /// </summary>
        [JsonPropertyName("comm_req_id")]
        public string CommReqId { get; set; }

        /// <summary>
        /// 小区同步状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
