using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// StandardFacePutInfo Data Structure.
    /// </summary>
    public class StandardFacePutInfo : AlipayObject
    {
        /// <summary>
        /// 入库失败错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 人脸用户ID
        /// </summary>
        [JsonPropertyName("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 入库结果，SUCCESS： 入库成功 ; FAIL ：入库失败，可重试; ERROR：  入库失败，不可重试
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
