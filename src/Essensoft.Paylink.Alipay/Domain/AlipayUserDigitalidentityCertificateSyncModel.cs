using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDigitalidentityCertificateSyncModel Data Structure.
    /// </summary>
    public class AlipayUserDigitalidentityCertificateSyncModel : AlipayObject
    {
        /// <summary>
        /// 用户申领信息核验模式，该字段值与传入的用户姓名及证件号相关联。例如PLAIN模式下原文对比传入的用户申领信息与支付宝侧信息是否一致。
        /// </summary>
        [JsonPropertyName("apply_info_verify_mode")]
        public string ApplyInfoVerifyMode { get; set; }

        /// <summary>
        /// 用户领取的凭证唯一ID（由机构生成表达唯一性的标识，同一自然人多次申领时要求该ID唯一且幂等相同）
        /// </summary>
        [JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证实例标识（标识某个具体的凭证类型，比如上海身份码，该字段值由支付宝分配）
        /// </summary>
        [JsonPropertyName("certificate_instance_code")]
        public string CertificateInstanceCode { get; set; }

        /// <summary>
        /// 拓展字段，JSON格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 凭证状态（表达新增/修改/删除状态）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户申领时证件号，当前仅支持身份证号（用于已领取卡面脱敏展示）。在PLAIN模式下需传入证件号明文；MD5模式下需传入证件号MD5摘要
        /// </summary>
        [JsonPropertyName("user_apply_cert_no")]
        public string UserApplyCertNo { get; set; }

        /// <summary>
        /// 用户申领时证件类型，当前仅支持身份证类型（IDENTITY_CARD）
        /// </summary>
        [JsonPropertyName("user_apply_cert_type")]
        public string UserApplyCertType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名（用于已领取卡面脱敏展示）。在PLAIN模式下需传入姓名明文；MD5模式下需传入姓名MD5摘要
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
