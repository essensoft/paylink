using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FamilyArchiveDetail Data Structure.
    /// </summary>
    public class FamilyArchiveDetail : AlipayObject
    {
        /// <summary>
        /// 家庭档案中用户填写的详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 家人档案ID
        /// </summary>
        [JsonPropertyName("archive_id")]
        public string ArchiveId { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的区县名称
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的生日
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的市名称
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 脱敏的家人支付宝登录号
        /// </summary>
        [JsonPropertyName("desensitized_logon_id")]
        public string DesensitizedLogonId { get; set; }

        /// <summary>
        /// 脱敏的家人真实姓名
        /// </summary>
        [JsonPropertyName("desensitized_real_name")]
        public string DesensitizedRealName { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的邮箱地址
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的性别（F：女性；M：男性）
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的职业
        /// </summary>
        [JsonPropertyName("profession")]
        public string Profession { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的省份名称
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 家庭用户档案中填写的真实姓名
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的家庭角色名称
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的邮政编码
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
