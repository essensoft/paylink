using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTrusplePersoncreditinquirySubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceTrusplePersoncreditinquirySubmitModel : AlipayObject
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
        /// 被查人证件类型，RESIDENT 居民身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 被查人姓名
        /// </summary>
        [JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

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
        /// 合作伙伴个人征信查询id，业务幂等字段
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
