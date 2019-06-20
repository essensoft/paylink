using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchUserInfo : AlipayObject
    {
        /// <summary>
        /// 自定义用户标识
        /// </summary>
        [JsonProperty("customuserid")]
        public string Customuserid { get; set; }

        /// <summary>
        /// 商户标识
        /// </summary>
        [JsonProperty("merchantid")]
        public string Merchantid { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        [JsonProperty("merchantuid")]
        public string Merchantuid { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }
    }
}
