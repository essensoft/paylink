using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchUserInfo Data Structure.
    /// </summary>
    public class FaceSearchUserInfo : AlipayObject
    {
        /// <summary>
        /// 自定义用户标识
        /// </summary>
        [JsonPropertyName("customuserid")]
        public string Customuserid { get; set; }

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

        /// <summary>
        /// 分数
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }
    }
}
