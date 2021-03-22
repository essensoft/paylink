using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DefiCustCompanyDTO Data Structure.
    /// </summary>
    public class DefiCustCompanyDTO : AlipayObject
    {
        /// <summary>
        /// 企业证件号码
        /// </summary>
        [JsonPropertyName("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业证件类型（2011-统一社会信用编码）
        /// </summary>
        [JsonPropertyName("company_cert_type")]
        public string CompanyCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [JsonPropertyName("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 法人证件类型（100-身份证，102-护照）
        /// </summary>
        [JsonPropertyName("legal_person_cert_type")]
        public string LegalPersonCertType { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonPropertyName("legal_person_name")]
        public string LegalPersonName { get; set; }
    }
}
