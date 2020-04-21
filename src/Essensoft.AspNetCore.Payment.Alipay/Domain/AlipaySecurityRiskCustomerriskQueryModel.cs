using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskCustomerriskQueryModel : AlipayObject
    {
        /// <summary>
        /// 用于查询银行卡号是否有风险
        /// </summary>
        [JsonPropertyName("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 用于查询营业执照是否来自风险商户
        /// </summary>
        [JsonPropertyName("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 用于境外银行卡号的查询（预留）
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用于传递需查询风险的身份证号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用于查询公司名称是否来自风险公司
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 间连交易场景下，银行类合作伙伴记录的风险商户ID
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 用于查询手机号是否来自风险用户
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 查询商户风险类型时：支持以下三种：riskinfo_cert_no（身份证风险查询）,riskinfo_bank_card_no（银行卡风险查询），riskinfo_business_license_no（营业执照风险查询）  查询ISV风险类型时：支持以下二种：riskinfo_cert_no_isv（服务商法人身份证风险查询），riskinfo_business_license_no_isv（营业执照风险查询）。  营销作弊风险场景：riskinfo_marketing  先享后付保障风险场景：riskinfo_nsf  使用服务时指定查询风险类型，且一次调用可以传递多个风险类型，用英文逗号隔开。
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }
    }
}
