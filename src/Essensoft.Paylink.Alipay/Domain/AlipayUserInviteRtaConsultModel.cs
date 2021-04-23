using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteRtaConsultModel Data Structure.
    /// </summary>
    public class AlipayUserInviteRtaConsultModel : AlipayObject
    {
        /// <summary>
        /// 加密类型，空表示不加密
        /// </summary>
        [JsonPropertyName("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 设备标识信息，包括IMEI，IDFA，OAID。 注意：IMEI必须为MD5加密类型
        /// </summary>
        [JsonPropertyName("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 查询的设备类型（IMEI、IDFA、OAID）
        /// </summary>
        [JsonPropertyName("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 咨询策略组，包含一个或多个目标咨询策略的组合，由运营分配
        /// </summary>
        [JsonPropertyName("target_crowd_package_key")]
        public string TargetCrowdPackageKey { get; set; }
    }
}
