using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldCardscriptQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldCardscriptQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询脚本的时间
        /// </summary>
        [JsonPropertyName("current_time")]
        public string CurrentTime { get; set; }

        /// <summary>
        /// 基础的rpc响应信息
        /// </summary>
        [JsonPropertyName("offlinepay_base_rpc_response_info")]
        public OfflinepayBaseRPCResponseInfo OfflinepayBaseRpcResponseInfo { get; set; }

        /// <summary>
        /// 生码脚本
        /// </summary>
        [JsonPropertyName("script_code")]
        public string ScriptCode { get; set; }

        /// <summary>
        /// 脚本签名
        /// </summary>
        [JsonPropertyName("script_mac")]
        public string ScriptMac { get; set; }
    }
}
