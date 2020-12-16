using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacepayCloseModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateFacepayCloseModel : AlipayObject
    {
        /// <summary>
        /// 采集人脸学生uid
        /// </summary>
        [JsonPropertyName("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 场景码: K12 COLLEGE
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 学生所在学校外标
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
