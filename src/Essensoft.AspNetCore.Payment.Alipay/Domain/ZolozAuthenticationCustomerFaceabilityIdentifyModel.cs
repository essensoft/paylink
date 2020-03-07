using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceabilityIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 开放活体图片进行人脸识别的能力，包括extract(提取特征)、sex(检测性别)、rect(人脸矩形框检测)
        /// </summary>
        [JsonPropertyName("ability")]
        public string Ability { get; set; }

        /// <summary>
        /// 算法版本，人脸PD定向提供
        /// </summary>
        [JsonPropertyName("alg_ver")]
        public string AlgVer { get; set; }

        /// <summary>
        /// 活体图片encode base64 String
        /// </summary>
        [JsonPropertyName("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 业务唯一ID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 使用人脸能力所需要等拓展参数信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public FaceAbilityExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 人脸定制分配的场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
