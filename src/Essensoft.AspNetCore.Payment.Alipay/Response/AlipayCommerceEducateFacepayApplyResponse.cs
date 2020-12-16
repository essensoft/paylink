using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacepayApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateFacepayApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 申请token
        /// </summary>
        [JsonPropertyName("apply_token")]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 采集人脸学生uid
        /// </summary>
        [JsonPropertyName("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 学生所在学校外标(国标码)
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
