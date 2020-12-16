using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntidVirtualQueryResponse.
    /// </summary>
    public class AlipayUserAntidVirtualQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁通行证ID
        /// </summary>
        [JsonPropertyName("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 额外附加信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 蚂蚁虚拟账户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
