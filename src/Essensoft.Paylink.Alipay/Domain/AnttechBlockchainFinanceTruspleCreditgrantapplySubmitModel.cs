using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleCreditgrantapplySubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleCreditgrantapplySubmitModel : AlipayObject
    {
        /// <summary>
        /// 资料附件列表
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<FinAttachment> Attachments { get; set; }

        /// <summary>
        /// 借款人类型
        /// </summary>
        [JsonPropertyName("borrower_type")]
        public string BorrowerType { get; set; }

        /// <summary>
        /// 关联的企业征信查询ID
        /// </summary>
        [JsonPropertyName("company_credit_inquiry_request_id")]
        public string CompanyCreditInquiryRequestId { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        [JsonPropertyName("company_info")]
        public CompanyInformation CompanyInfo { get; set; }

        /// <summary>
        /// 扩展字段JSON String，address，occupation等字段放入扩展字段中（备注：只涉及数据的接收，不涉及到蚂蚁数据的输出））
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部合作伙伴的授信申请编号
        /// </summary>
        [JsonPropertyName("external_credit_grant_id")]
        public string ExternalCreditGrantId { get; set; }

        /// <summary>
        /// 外部产品码
        /// </summary>
        [JsonPropertyName("external_product_code")]
        public string ExternalProductCode { get; set; }

        /// <summary>
        /// 被查用户的外部用户唯一标识
        /// </summary>
        [JsonPropertyName("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 法人信息
        /// </summary>
        [JsonPropertyName("legal_person_info")]
        public PersonInfo LegalPersonInfo { get; set; }

        /// <summary>
        /// 关联的个人征信查询ID
        /// </summary>
        [JsonPropertyName("personal_credit_inquiry_request_id")]
        public string PersonalCreditInquiryRequestId { get; set; }

        /// <summary>
        /// 额度分项明细
        /// </summary>
        [JsonPropertyName("quota_details")]
        public List<CreditQuotaDetail> QuotaDetails { get; set; }

        /// <summary>
        /// 风控变量（备注：只涉及数据的接收，不涉及到蚂蚁数据的输出）
        /// </summary>
        [JsonPropertyName("risk_info")]
        public string RiskInfo { get; set; }
    }
}
