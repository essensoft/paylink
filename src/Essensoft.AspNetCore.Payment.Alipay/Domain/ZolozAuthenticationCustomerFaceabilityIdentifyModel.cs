using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerFaceabilityIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 开放活体图片进行人脸识别的能力，包括extract(提取特征)、sex(检测性别)、rect(人脸矩形框检测)
        /// </summary>
        [JsonProperty("ability")]
        public string Ability { get; set; }

        /// <summary>
        /// 算法版本，人脸PD定向提供
        /// </summary>
        [JsonProperty("alg_ver")]
        public string AlgVer { get; set; }

        /// <summary>
        /// 活体图片encode base64 String
        /// </summary>
        [JsonProperty("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 业务唯一ID
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 使用人脸能力所需要等拓展参数信息
        /// </summary>
        [JsonProperty("ext_info")]
        public FaceAbilityExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 人脸定制分配的场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }
    }
}
