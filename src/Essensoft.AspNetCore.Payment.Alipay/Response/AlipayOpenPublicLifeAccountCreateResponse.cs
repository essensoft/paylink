using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAccountCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAccountCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 过期时间，在过期时间之前需要拿refresh_token重新换取新的token使用
        /// </summary>
        [JsonProperty("expire_time")]
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 生活号id，用于表示此生活号唯一性
        /// </summary>
        [JsonProperty("public_id")]
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 刷新令牌，当返回值中过期时间快到了，可以通过此令牌来重新刷新令牌，时间自动延长一年
        /// </summary>
        [JsonProperty("refresh_token")]
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 授权token，通过授权token可以代替已生成的生活号id进行代理操作，例如发送广播等
        /// </summary>
        [JsonProperty("token")]
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
