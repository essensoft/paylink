using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPicture Data Structure.
    /// </summary>
    public class AlipayUserPicture : AlipayObject
    {
        /// <summary>
        /// 图片类型，包括身份证正反面、营业执照等
        /// </summary>
        [JsonPropertyName("picture_type")]
        public string PictureType { get; set; }

        /// <summary>
        /// 用于调用alipay.user.certify.image.fetch接口，获取图片资源
        /// </summary>
        [JsonPropertyName("picture_url")]
        public string PictureUrl { get; set; }
    }
}
