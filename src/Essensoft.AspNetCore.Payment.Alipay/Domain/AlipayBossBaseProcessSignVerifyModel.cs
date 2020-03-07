using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessSignVerifyModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessSignVerifyModel : AlipayObject
    {
        /// <summary>
        /// 流程唯一ID
        /// </summary>
        [JsonPropertyName("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// mnotify签名直接回传
        /// </summary>
        [JsonPropertyName("sign_content")]
        public string SignContent { get; set; }
    }
}
