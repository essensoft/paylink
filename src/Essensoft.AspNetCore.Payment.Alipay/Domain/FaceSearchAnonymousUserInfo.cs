using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchAnonymousUserInfo Data Structure.
    /// </summary>
    public class FaceSearchAnonymousUserInfo : AlipayObject
    {
        /// <summary>
        /// 商户标识
        /// </summary>
        [JsonPropertyName("merchantid")]
        public string Merchantid { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        [JsonPropertyName("merchantuid")]
        public string Merchantuid { get; set; }
    }
}
