using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleCompanycreditinquirySubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleCompanycreditinquirySubmitModel : AlipayObject
    {
        /// <summary>
        /// 资料附件列表
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<FinAttachment> Attachments { get; set; }

        /// <summary>
        /// 被查人证件号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 被查企业证件类型,NATIONAL_LEGAL 全国法人营业执照; NATIONAL_LEGAL_MERGE 全国法人营业执照-多证合一
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 被查企业英文名
        /// </summary>
        [JsonPropertyName("company_english_name")]
        public string CompanyEnglishName { get; set; }

        /// <summary>
        /// 被查企业名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

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
        /// 查询原因
        /// </summary>
        [JsonPropertyName("inquiry_reason")]
        public string InquiryReason { get; set; }

        /// <summary>
        /// 查询模板
        /// </summary>
        [JsonPropertyName("inquiry_template")]
        public string InquiryTemplate { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 查询请求唯一标识
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
