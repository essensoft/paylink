using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceSearchResult Data Structure.
    /// </summary>
    public class FaceSearchResult : AlipayObject
    {
        /// <summary>
        /// faceType
        /// </summary>
        [JsonPropertyName("face_type")]
        public string FaceType { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
