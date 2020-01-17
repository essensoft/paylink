using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScenicFaceInfo Data Structure.
    /// </summary>
    public class ScenicFaceInfo : AlipayObject
    {
        /// <summary>
        /// 用户场景下唯一标示码
        /// </summary>
        [JsonPropertyName("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 人脸系统唯一身份标识
        /// </summary>
        [JsonPropertyName("zid")]
        public string Zid { get; set; }
    }
}
