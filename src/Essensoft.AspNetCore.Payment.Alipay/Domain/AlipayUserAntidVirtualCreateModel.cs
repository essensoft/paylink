using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntidVirtualCreateModel Data Structure.
    /// </summary>
    public class AlipayUserAntidVirtualCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务域场景，由提供方分配
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 额外附加信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 识别因子内容，json格式内容。跟identification_factor_type一一对应。MOBILE_BIZ类型对应的key为mobile,bizType,bizId; THIRD_PARTY类型对应的key为partnerId,userId,bizId; CERTIFICATE类型对应的key为certType,certNo,certName。 会以不同识别因子类型的识别内容作为幂等条件。
        /// </summary>
        [JsonPropertyName("identification_factor_content")]
        public string IdentificationFactorContent { get; set; }

        /// <summary>
        /// 识别因子类型，有3种；分别为手机场景识别因子 MOBILE_BIZ，第三方识别因子 THIRD_PARTY和证件识别因子 CERTIFICATE
        /// </summary>
        [JsonPropertyName("identification_factor_type")]
        public string IdentificationFactorType { get; set; }

        /// <summary>
        /// 注册来源，由提供方分配
        /// </summary>
        [JsonPropertyName("register_from")]
        public string RegisterFrom { get; set; }

        /// <summary>
        /// 用户类型，1-个人  2-企业
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}
