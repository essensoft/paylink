using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CompanyInformation Data Structure.
    /// </summary>
    public class CompanyInformation : AlipayObject
    {
        /// <summary>
        /// 行业分类代码默认为F51-5193
        /// </summary>
        [JsonPropertyName("business_category_code")]
        public string BusinessCategoryCode { get; set; }

        /// <summary>
        /// 营业许可证有效期开始,格式（yyyy-MM-dd）
        /// </summary>
        [JsonPropertyName("company_cert_effective_date")]
        public string CompanyCertEffectiveDate { get; set; }

        /// <summary>
        /// 营业许可证有效期结束,格式（yyyy-MM-dd）
        /// </summary>
        [JsonPropertyName("company_cert_expiration_date")]
        public string CompanyCertExpirationDate { get; set; }

        /// <summary>
        /// 企业身份标识号码
        /// </summary>
        [JsonPropertyName("company_cert_no")]
        public string CompanyCertNo { get; set; }

        /// <summary>
        /// 企业证件类型,NATIONAL_LEGAL-传统工商注册类型;NATIONAL_LEGAL_MERGE-统一社会信用代码
        /// </summary>
        [JsonPropertyName("company_cert_type")]
        public string CompanyCertType { get; set; }

        /// <summary>
        /// Jiangsu zhuo'ao energy saving equipment installation engineering Co., Ltd
        /// </summary>
        [JsonPropertyName("company_english_name")]
        public string CompanyEnglishName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 企业登记地址
        /// </summary>
        [JsonPropertyName("company_registered_address")]
        public string CompanyRegisteredAddress { get; set; }

        /// <summary>
        /// 注册资本，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [JsonPropertyName("company_registered_capital_amount")]
        public string CompanyRegisteredCapitalAmount { get; set; }

        /// <summary>
        /// 注册资本，币种
        /// </summary>
        [JsonPropertyName("company_registered_capital_amount_currency")]
        public string CompanyRegisteredCapitalAmountCurrency { get; set; }

        /// <summary>
        /// 企业登记国别代码默认为CN
        /// </summary>
        [JsonPropertyName("company_registered_country")]
        public string CompanyRegisteredCountry { get; set; }

        /// <summary>
        /// 企业规模默认为小型企业
        /// </summary>
        [JsonPropertyName("company_size")]
        public string CompanySize { get; set; }

        /// <summary>
        /// 经济类型代码默认为175 - 个体经营
        /// </summary>
        [JsonPropertyName("economic_category_code")]
        public string EconomicCategoryCode { get; set; }
    }
}
