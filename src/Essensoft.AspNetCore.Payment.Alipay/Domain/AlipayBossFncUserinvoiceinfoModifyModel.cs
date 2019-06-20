using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncUserinvoiceinfoModifyModel : AlipayObject
    {
        /// <summary>
        /// 是否接受电子票 true:是，false:否
        /// </summary>
        [JsonProperty("accept_electronic")]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 公司注册地址，公司营业执照上登记的住址，一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否自动申请开票 true:是；false:否
        /// </summary>
        [JsonProperty("auto")]
        public bool Auto { get; set; }

        /// <summary>
        /// 银行账户，公司银行账号  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行，办理银行开户手续的营业网点  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 营业执照地址，营业执照上传oss上的地址
        /// </summary>
        [JsonProperty("business_licence_url")]
        public string BusinessLicenceUrl { get; set; }

        /// <summary>
        /// 是否暂停开票，商户修改无效，如果要暂停开票，只能去结算中台处理。
        /// </summary>
        [JsonProperty("hold")]
        public bool Hold { get; set; }

        /// <summary>
        /// 开票资料ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 银行开户许可证附件，银行开户许可证上传oss上的地址
        /// </summary>
        [JsonProperty("open_account_permit_url")]
        public string OpenAccountPermitUrl { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 当前操作人类型,01:商户；02:管理员(小二)
        /// </summary>
        [JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 其它资质证明地址，其他资质证明附件上传oss上的地址
        /// </summary>
        [JsonProperty("other_qualification_url")]
        public string OtherQualificationUrl { get; set; }

        /// <summary>
        /// 纳税人识别号，税务登记证上的号码。一般纳税人必须填写，小规模纳税人如果是商户也必须填写，个人无需填写
        /// </summary>
        [JsonProperty("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格开始时间 （格式：时间戳）  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        [JsonProperty("tax_payer_quali_valid")]
        public string TaxPayerQualiValid { get; set; }

        /// <summary>
        /// 纳税人资格种类，01：一般纳税人；02：小规模纳税人；03：国际商户
        /// </summary>
        [JsonProperty("tax_payer_qualification")]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 一般纳税人资格证书地址，一般纳税人资格证书上传oss上的地址
        /// </summary>
        [JsonProperty("tax_qualification_url")]
        public string TaxQualificationUrl { get; set; }

        /// <summary>
        /// 税务登记证地址，税务登记证上传oss上的地址
        /// </summary>
        [JsonProperty("tax_reg_cert_url")]
        public string TaxRegCertUrl { get; set; }

        /// <summary>
        /// 公司注册电话  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头，票面信息上的抬头信息
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 收件人列表,若不修改此项可以不填  选择非电子票时，邮寄信息必填，且保证邮寄信息的ipRoleId和开票资料的ipRoleId相等
        /// </summary>
        [JsonProperty("user_mail_info_order_list")]
        public List<UserMailInfoOrder> UserMailInfoOrderList { get; set; }
    }
}
