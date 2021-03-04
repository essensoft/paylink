using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 主体资料
    /// </summary>
    public class SubjectInfo : WeChatPayObject
    {
        /// <summary>
        /// 主体类型
        /// </summary>
        /// <remarks>
        /// 主体类型需与营业执照/登记证书上一致，可参考《选择主体指引》
        /// SUBJECT_TYPE_INDIVIDUAL（个体户）：营业执照上的主体类型一般为个体户、个体工商户、个体经营；
        /// SUBJECT_TYPE_ENTERPRISE（企业）：营业执照上的主体类型一般为有限公司、有限责任公司；
        /// SUBJECT_TYPE_INSTITUTIONS（党政、机关及事业单位）：包括国内各级、各类政府机构、事业单位等（如：公安、党团、司法、交通、旅游、工商税务、市政、医疗、教育、学校等机构）；
        /// SUBJECT_TYPE_OTHERS（其他组织）：不属于企业、政府/事业单位的组织机构（如社会团体、民办非企业、基金会），要求机构已办理组织机构代码证。
        /// <para>示例值：SUBJECT_TYPE_ENTERPRISE</para>
        /// </remarks>
        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        /// <remarks>
        /// 1、主体为个体户/企业，必填。
        /// 2、请上传“营业执照”，需年检章齐全，当年注册除外。
        /// </remarks>
        [JsonPropertyName("business_license_info")]
        public BusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// 登记证书
        /// </summary>
        /// <remarks>
        /// 主体为党政、机关及事业单位/其他组织，必填。
        /// 1、党政、机关及事业单位：请上传相关部门颁发的证书，如：事业单位法人证书、统一社会信用代码证书。
        /// 2、其他组织：请上传相关部门颁发的证书，如：社会团体法人登记证书、民办非企业单位登记证书、基金会法人登记证书。
        /// </remarks>
        [JsonPropertyName("certificate_info")]
        public CertificateInfo CertificateInfo { get; set; }

        /// <summary>
        /// 组织机构代码证
        /// </summary>
        /// <remarks>
        /// 主体为企业/党政、机关及事业单位/其他组织，且证件号码不是18位时必填。
        /// </remarks>
        [JsonPropertyName("organization_info")]
        public OrganizationInfo OrganizationInfo { get; set; }

        /// <summary>
        /// 单位证明函照片
        /// </summary>
        /// <remarks>
        /// 1、主体类型为党政、机关及事业单位选传;
        /// （1）若上传，则审核通过后即可签约，无需汇款验证。
        /// （2）若未上传，则审核通过后，需汇款验证。
        /// 2、主体为个体户、企业、其他组织等，不需要上传本字段。
        /// 3、请参照示例图打印单位证明函，全部信息需打印，不支持手写商户信息，并加盖公章。
        /// 4、可上传1张图片，请填写通过《图片上传API》预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny__Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("certificate_letter_copy")]
        public string CertificateLetterCopy { get; set; }

        /// <summary>
        /// 经营者/法人身份证件
        /// </summary>
        /// <remarks>
        /// 1、个体户：请上传经营者的身份证件。
        /// 2、企业/党政、机关及事业单位/其他组织：请上传法人的身份证件。
        /// </remarks>
        [JsonPropertyName("identity_info")]
        public IdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// 最终受益人信息(UBO]
        /// </summary>
        /// <remarks>
        /// 若经营者/法人不是最终受益所有人，则需提填写受益所有人信息。
        /// 根据国家相关法律法规，需要提供公司受益所有人信息，受益所有人需符合至少以下条件之一：
        /// 1、直接或者间接拥有超过25%公司股权或者表决权的自然人。
        /// 2、通过人事、财务等其他方式对公司进行控制的自然人。
        /// 3、公司的高级管理人员，包括公司的经理、副经理、财务负责人、上市公司董事会秘书和公司章程规定的其他人员。
        /// </remarks>
        [JsonPropertyName("ubo_info")]
        public UboInfo UboInfo { get; set; }
    }
}
