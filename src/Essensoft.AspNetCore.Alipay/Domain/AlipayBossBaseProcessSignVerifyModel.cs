using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessSignVerifyModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessSignVerifyModel : AlipayObject
    {
        /// <summary>
        /// 流程唯一ID
        /// </summary>
        [JsonProperty("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// mnotify签名直接回传
        /// </summary>
        [JsonProperty("sign_content")]
        public string SignContent { get; set; }
    }
}
