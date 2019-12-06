using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyzhubInitializeModel Data Structure.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyzhubInitializeModel : AlipayObject
    {
        /// <summary>
        /// 设备token
        /// </summary>
        [JsonPropertyName("apdidtoken")]
        public string Apdidtoken { get; set; }

        /// <summary>
        /// 应用名字
        /// </summary>
        [JsonPropertyName("appname")]
        public string Appname { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [JsonPropertyName("appversion")]
        public string Appversion { get; set; }

        /// <summary>
        /// 人脸sdk元信息
        /// </summary>
        [JsonPropertyName("biometainfo")]
        public string Biometainfo { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景名字
        /// </summary>
        [JsonPropertyName("biz_scene_name")]
        public string BizSceneName { get; set; }

        /// <summary>
        /// 用于区分不同的业务场景，默认情况下不用填写，目前定义biz_type=3代表实人认证小程序
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 实人信息：证件名字
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 实人信息：证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 实人信息：证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        [JsonPropertyName("devicemodel")]
        public string Devicemodel { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("devicetype")]
        public string Devicetype { get; set; }

        /// <summary>
        /// 0：匿名注册  1：匿名认证   2：实名认证
        /// </summary>
        [JsonPropertyName("face_type")]
        public long FaceType { get; set; }

        /// <summary>
        /// 人脸引导页是否显示
        /// </summary>
        [JsonPropertyName("has_welcome_page")]
        public bool HasWelcomePage { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [JsonPropertyName("osversion")]
        public string Osversion { get; set; }

        /// <summary>
        /// 商户的用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
