using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApUserInvoiceInfoOpenApiResponse Data Structure.
    /// </summary>
    public class ApUserInvoiceInfoOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// (AR开票使用)是否接受电子票 true:是，false:否
        /// </summary>
        [JsonPropertyName("accept_electronic")]
        public string AcceptElectronic { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// (AR开票使用)是否自动申请开票 true:是，false:否
        /// </summary>
        [JsonPropertyName("auto")]
        public string Auto { get; set; }

        /// <summary>
        /// 银行账户
        /// </summary>
        [JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 营业执照地址
        /// </summary>
        [JsonPropertyName("business_licence_url")]
        public string BusinessLicenceUrl { get; set; }

        /// <summary>
        /// 资料创建人
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// (AR开票使用)是否暂停开票  true:暂停开票，false:可开票
        /// </summary>
        [JsonPropertyName("hold")]
        public string Hold { get; set; }

        /// <summary>
        /// 开票资料ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商户PID,  type=01时表示OU用户,填充的是InstId机构代码,例如Z50,  type=02时表示商户MID,  type=03时表示商户PID
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户MID,兼容老版本VO
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonPropertyName("last_modifier")]
        public string LastModifier { get; set; }

        /// <summary>
        /// 银行开户许可证地址
        /// </summary>
        [JsonPropertyName("open_account_permit_url")]
        public string OpenAccountPermitUrl { get; set; }

        /// <summary>
        /// 其它资质证明地址
        /// </summary>
        [JsonPropertyName("other_qualification_url")]
        public string OtherQualificationUrl { get; set; }

        /// <summary>
        /// 资料状态，01：待审，02：已审(有效)， 03：已作废
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 上一次任务执行时间(针对自动开票场景),格式:yyyyMMdd
        /// </summary>
        [JsonPropertyName("task_date")]
        public string TaskDate { get; set; }

        /// <summary>
        /// 纳税人识别号（购方税号）
        /// </summary>
        [JsonPropertyName("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人开票资格种类  01：一般纳税人，02：小规模纳税人
        /// </summary>
        [JsonPropertyName("tax_payer_qualification")]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 一般纳税人资格证书地址
        /// </summary>
        [JsonPropertyName("tax_qualification_url")]
        public string TaxQualificationUrl { get; set; }

        /// <summary>
        /// 税务登记证地址
        /// </summary>
        [JsonPropertyName("tax_reg_cert_url")]
        public string TaxRegCertUrl { get; set; }

        /// <summary>
        /// 纳税人资格开始时间 （时间戳）
        /// </summary>
        [JsonPropertyName("taxpayer_quali_valid")]
        public string TaxpayerQualiValid { get; set; }

        /// <summary>
        /// 公司注册电话
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 开票资料用户类型   01：OU，02：商户，03：C用户
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 收件人地址列表
        /// </summary>
        [JsonPropertyName("user_mail_info_list")]
        public List<ApUserMailInfoOpenApiResponse> UserMailInfoList { get; set; }
    }
}
