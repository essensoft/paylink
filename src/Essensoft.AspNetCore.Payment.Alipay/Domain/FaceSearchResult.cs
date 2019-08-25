using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchResult Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchResult : AlipayObject
    {
        /// <summary>
        /// faceType
        /// </summary>
        [JsonProperty("face_type")]
        public string FaceType { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
