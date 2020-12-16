using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntidVirtualQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAntidVirtualQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务域场景，由提供方分配
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 识别因子内容，json格式内容。跟identification_factor_type一一对应。MOBILE_BIZ类型对应的key为mobile,bizType,bizId; THIRD_PARTY类型对应的key为partnerId,userId,bizId; CERTIFICATE类型对应的key为certType,certNo,certName。 会以不同识别因子类型的识别内容作为唯一条件查询虚拟账户AntID
        /// </summary>
        [JsonPropertyName("identification_factor_content")]
        public string IdentificationFactorContent { get; set; }

        /// <summary>
        /// 识别因子类型，有3种；分别为手机场景识别因子 MOBILE_BIZ，第三方识别因子 THIRD_PARTY和证件识别因子 CERTIFICATE
        /// </summary>
        [JsonPropertyName("identification_factor_type")]
        public string IdentificationFactorType { get; set; }
    }
}
