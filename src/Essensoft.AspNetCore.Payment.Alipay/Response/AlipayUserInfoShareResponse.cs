using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInfoShareResponse.
    /// </summary>
    public class AlipayUserInfoShareResponse : AlipayResponse
    {
        /// <summary>
        /// 详细地址。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区县名称。
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 用户头像地址
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 经营/业务范围（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 【证件号码】结合证件类型使用. 【注意】只有is_certified为T的时候才有意义，否则不保证准确性.
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 【证件类型】 0:身份证 1:护照 2:军官证 3:士兵证 4:回乡证 5:临时身份证 6:户口簿 7:警官证 8:台胞证 9:营业执照 10:其它证件 11:港澳居民来往内地通行证 12:台湾居民来往大陆通行证 【注意】只有is_certified为T的时候才有意义，否则不保证准确性.
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 市名称。
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 学信网返回的学校名称，有可能为空。
        /// </summary>
        [JsonPropertyName("college_name")]
        public string CollegeName { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 学信网返回的学历/学位信息，数据质量一般，请谨慎使用，取值包括：博士研究生、硕士研究生、高升本、专科、博士、硕士、本科、夜大电大函大普通班、专科(高职)、第二学士学位。
        /// </summary>
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 收货地址列表
        /// </summary>
        [JsonPropertyName("deliver_addresses")]
        public List<AlipayUserDeliverAddress> DeliverAddresses { get; set; }

        /// <summary>
        /// 优先获取email登录名，如果不存在，则返回mobile登录名
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 入学时间，yyyy-mm-dd格式
        /// </summary>
        [JsonPropertyName("enrollment_time")]
        public string EnrollmentTime { get; set; }

        /// <summary>
        /// 企业代理人证件有效期（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_agent_person_cert_expiry_date")]
        public string FirmAgentPersonCertExpiryDate { get; set; }

        /// <summary>
        /// 企业代理人证件号码（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_agent_person_cert_no")]
        public string FirmAgentPersonCertNo { get; set; }

        /// <summary>
        /// 企业代理人证件类型, 返回值参考cert_type字段（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_agent_person_cert_type")]
        public string FirmAgentPersonCertType { get; set; }

        /// <summary>
        /// 企业代理人姓名（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_agent_person_name")]
        public string FirmAgentPersonName { get; set; }

        /// <summary>
        /// 企业法人证件有效期（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_legal_person_cert_expiry_date")]
        public string FirmLegalPersonCertExpiryDate { get; set; }

        /// <summary>
        /// 法人证件号码（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_legal_person_cert_no")]
        public string FirmLegalPersonCertNo { get; set; }

        /// <summary>
        /// 企业法人证件类型, 返回值参考cert_type字段（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_legal_person_cert_type")]
        public string FirmLegalPersonCertType { get; set; }

        /// <summary>
        /// 企业法人名称（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_legal_person_name")]
        public string FirmLegalPersonName { get; set; }

        /// <summary>
        /// 企业法人证件图片（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_legal_person_pictures")]
        public List<AlipayUserPicture> FirmLegalPersonPictures { get; set; }

        /// <summary>
        /// 企业相关证件图片，包含图片地址（目前需要调用alipay.user.certify.image.fetch转换一下）及类型（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("firm_pictures")]
        public List<AlipayUserPicture> FirmPictures { get; set; }

        /// <summary>
        /// 公司类型，包括（用户类型是公司类型时才有此字段）：  CO(公司)  INST(事业单位),  COMM(社会团体),  NGO(民办非企业组织),  STATEORGAN(党政国家机关)
        /// </summary>
        [JsonPropertyName("firm_type")]
        public string FirmType { get; set; }

        /// <summary>
        /// 【注意】只有is_certified为T的时候才有意义，否则不保证准确性.  性别（F：女性；M：男性）。
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 预期毕业时间，不保证准确性，yyyy-mm-dd格式。
        /// </summary>
        [JsonPropertyName("graduation_time")]
        public string GraduationTime { get; set; }

        /// <summary>
        /// 余额账户是否被冻结。  T--被冻结；F--未冻结
        /// </summary>
        [JsonPropertyName("is_balance_frozen")]
        public string IsBalanceFrozen { get; set; }

        /// <summary>
        /// 是否通过实名认证。T是通过 F是没有实名认证。
        /// </summary>
        [JsonPropertyName("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        [JsonPropertyName("is_student_certified")]
        public string IsStudentCertified { get; set; }

        /// <summary>
        /// 营业执照有效期，yyyyMMdd或长期，（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("license_expiry_date")]
        public string LicenseExpiryDate { get; set; }

        /// <summary>
        /// 企业执照号码（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 支付宝会员等级
        /// </summary>
        [JsonPropertyName("member_grade")]
        public string MemberGrade { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 组织机构代码（用户类型是公司类型时才有此字段）。
        /// </summary>
        [JsonPropertyName("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 个人用户生日。
        /// </summary>
        [JsonPropertyName("person_birthday")]
        public string PersonBirthday { get; set; }

        /// <summary>
        /// 生日。不包含具体年份，格式MMdd
        /// </summary>
        [JsonPropertyName("person_birthday_without_year")]
        public string PersonBirthdayWithoutYear { get; set; }

        /// <summary>
        /// 证件有效期（用户类型是个人的时候才有此字段）。
        /// </summary>
        [JsonPropertyName("person_cert_expiry_date")]
        public string PersonCertExpiryDate { get; set; }

        /// <summary>
        /// 个人证件图片（用户类型是个人的时候才有此字段）。
        /// </summary>
        [JsonPropertyName("person_pictures")]
        public List<AlipayUserPicture> PersonPictures { get; set; }

        /// <summary>
        /// 电话号码。
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        [JsonPropertyName("profession")]
        public string Profession { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 淘宝id
        /// </summary>
        [JsonPropertyName("taobao_id")]
        public string TaobaoId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 若用户是个人用户，则是用户的真实姓名；若是企业用户，则是企业名称。 【注意】只有is_certified为T的时候才有意义，否则不保证准确性.
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户状态（Q/T/B/W）。 Q代表快速注册用户 T代表正常用户 B代表被冻结账户 W代表已注册，未激活的账户
        /// </summary>
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户类型（1/2）  1代表公司账户2代表个人账户
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 邮政编码。
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }
    }
}
