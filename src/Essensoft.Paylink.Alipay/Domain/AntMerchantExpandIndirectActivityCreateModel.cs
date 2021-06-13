using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动类型，间连商户报名的支付宝活动类型。 特殊行业优惠费率：INDUSTRY_SPECIAL
        /// </summary>
        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 商户简称，需和进件时简称保持一致。
        /// </summary>
        [JsonPropertyName("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 一般为商户同名银行账户信息，党费等特殊业务除外
        /// </summary>
        [JsonPropertyName("bank_account")]
        public BankCardInfo BankAccount { get; set; }

        /// <summary>
        /// 银行开户证明/银行开户回单/委托代收党费党支部红头文件，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("bank_account_prove")]
        public string BankAccountProve { get; set; }

        /// <summary>
        /// 机构跟银行的合作协议关键页/机构银行合作授权函，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key
        /// </summary>
        [JsonPropertyName("bank_cooperation_agreement")]
        public string BankCooperationAgreement { get; set; }

        /// <summary>
        /// 统一社会信用代码证（三证合一）、营业执照、事业单位法人证书、组织机构代码证，要求文本信息清晰可见，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 其他证明文件图片，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("certificate_file")]
        public string CertificateFile { get; set; }

        /// <summary>
        /// 收费样本，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("charge_sample")]
        public string ChargeSample { get; set; }

        /// <summary>
        /// 收银台照片 请上传照片OSSKey（参见应用场景说明）。 蓝海活动必须包含：①主扫：扫码支付场景需要展示具有支付宝logo和“推荐使用支付宝 或 支付就用支付宝”露出的二维码物料或立牌；②被 扫：展示具有支付宝logo和推荐使用支付宝 或 支付就用支付宝”的扫码机具（盒子 ） 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("checkstand_pic")]
        public string CheckstandPic { get; set; }

        /// <summary>
        /// 照会。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("diplomatic_note")]
        public string DiplomaticNote { get; set; }

        /// <summary>
        /// 店内环境照，具体可参见资质要求，要求照片清晰可见，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("indoor_pic")]
        public string IndoorPic { get; set; }

        /// <summary>
        /// 特殊费率资质表中对应的行业code
        /// </summary>
        [JsonPropertyName("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 商户行业资质图片，如《医疗机构执业许可证》、《党组织批复成立文件》等，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key
        /// </summary>
        [JsonPropertyName("industry_qualification_image")]
        public string IndustryQualificationImage { get; set; }

        /// <summary>
        /// 事业单位法人证书图片。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("institutional_organization_pic")]
        public string InstitutionalOrganizationPic { get; set; }

        /// <summary>
        /// 负责人授权函，如果上传代理人身份证，需补充法人授权函；上传党支部书记身份证，需补充党支部书记任命函或党组织授权函，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("legal_person_license_auth_pic")]
        public string LegalPersonLicenseAuthPic { get; set; }

        /// <summary>
        /// 负责人身份证图片正反面，可以上传法人身份证/代理人身份证/党支部书记身份证，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("legal_person_pic")]
        public string LegalPersonPic { get; set; }

        /// <summary>
        /// 法人登记证书图片。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("legal_person_registration_pic")]
        public string LegalPersonRegistrationPic { get; set; }

        /// <summary>
        /// 医疗执业许可证图片。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("medical_instrument_practice_license_pic")]
        public string MedicalInstrumentPracticeLicensePic { get; set; }

        /// <summary>
        /// 商户名称，注册登记证件上的名称，需和进件名称保持一致。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组织机构代码证图片。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("org_cert_pic")]
        public string OrgCertPic { get; set; }

        /// <summary>
        /// 民办非企业单位登记证书图片。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("private_nonenterprise_units")]
        public string PrivateNonenterpriseUnits { get; set; }

        /// <summary>
        /// 办学资质图片。 请上传照片OSSKey（参见应用场景说明）。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("run_school_license_pic")]
        public string RunSchoolLicensePic { get; set; }

        /// <summary>
        /// 主流餐饮平台入驻证明（任选一个即可）：大众点评、美团、饿了么、口碑、百度外卖餐饮平台商户展示页面。 请上传照片OSSKey（参见应用场景说明）。 蓝海活动必传。 特殊行业，请参见<a href="https://opendocs.alipay.com/p/01y6vi">间连特殊行业上传资质</a>
        /// </summary>
        [JsonPropertyName("settled_pic")]
        public string SettledPic { get; set; }

        /// <summary>
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("shop_entrance_pic")]
        public string ShopEntrancePic { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
