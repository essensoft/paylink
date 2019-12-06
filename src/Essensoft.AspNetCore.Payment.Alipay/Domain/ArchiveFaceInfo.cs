using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArchiveFaceInfo Data Structure.
    /// </summary>
    public class ArchiveFaceInfo : AlipayObject
    {
        /// <summary>
        /// 人脸图片BASE64转换后字符串,大小限制为2M
        /// </summary>
        [JsonPropertyName("face_image")]
        public string FaceImage { get; set; }

        /// <summary>
        /// 人脸图片类型,取值范围:  COMMERCIAL_PS_WITH_MASK 商业公安网带网纹人脸图片  HMT_PS 港澳台公安网
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [JsonPropertyName("usable")]
        public bool Usable { get; set; }
    }
}
