using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ServiceContext Data Structure.
    /// </summary>
    public class ServiceContext : AlipayObject
    {
        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonProperty("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端UMID
        /// </summary>
        [JsonProperty("client_pcidguid")]
        public string ClientPcidguid { get; set; }

        /// <summary>
        /// 服务器名
        /// </summary>
        [JsonProperty("server_name")]
        public string ServerName { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
