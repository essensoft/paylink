using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTaxbillSigncodeCreateModel Data Structure.
    /// </summary>
    public class AlipayFundTaxbillSigncodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 回跳url
        /// </summary>
        [JsonPropertyName("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 场景码，固定值：SIGN
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 税筹ISV入驻平台后，平台提供的企业编码
        /// </summary>
        [JsonPropertyName("contractor_code")]
        public string ContractorCode { get; set; }

        /// <summary>
        /// 用户的支付宝账号，可选传递。如传递，则只有登录号匹配的用户才能进行签约
        /// </summary>
        [JsonPropertyName("employee_alipay_logon_id")]
        public string EmployeeAlipayLogonId { get; set; }

        /// <summary>
        /// 用工企业入驻后平台后，平台提供的企业编码
        /// </summary>
        [JsonPropertyName("employer_code")]
        public string EmployerCode { get; set; }

        /// <summary>
        /// 用户在用工企业的唯一性身份标识
        /// </summary>
        [JsonPropertyName("identification_in_belonging_employer")]
        public string IdentificationInBelongingEmployer { get; set; }

        /// <summary>
        /// 产品码，固定值：TAX_BILL_PLATFORM
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 税优模式，有限枚举。1.TEMPORARY_TAX_REGISTRATION（临时税务登记 ）2. NATURAL_PERSON_LEVIED（自然人代征）
        /// </summary>
        [JsonPropertyName("tax_optimization_mode")]
        public string TaxOptimizationMode { get; set; }
    }
}
