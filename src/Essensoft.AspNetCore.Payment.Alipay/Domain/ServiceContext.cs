using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceContext Data Structure.
    /// </summary>
    public class ServiceContext : AlipayObject
    {
        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonPropertyName("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端UMID
        /// </summary>
        [JsonPropertyName("client_pcidguid")]
        public string ClientPcidguid { get; set; }

        /// <summary>
        /// 服务器名
        /// </summary>
        [JsonPropertyName("server_name")]
        public string ServerName { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
