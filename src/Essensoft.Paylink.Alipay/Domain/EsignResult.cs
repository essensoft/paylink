using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// EsignResult Data Structure.
    /// </summary>
    public class EsignResult : AlipayObject
    {
        /// <summary>
        /// 用工企业和用户以及税筹ISV签订的三方协议的协议链接
        /// </summary>
        [JsonPropertyName("agreement_url")]
        public string AgreementUrl { get; set; }

        /// <summary>
        /// 报税模式，有限枚举。 SUMMARY_DECLARATION（汇总申报）
        /// </summary>
        [JsonPropertyName("apply_dutiable_mode_enum")]
        public string ApplyDutiableModeEnum { get; set; }

        /// <summary>
        /// 税筹ISV入驻平台后，平台提供的企业编码
        /// </summary>
        [JsonPropertyName("contractor_code")]
        public string ContractorCode { get; set; }

        /// <summary>
        /// 税筹ISV公司名称
        /// </summary>
        [JsonPropertyName("contractor_name")]
        public string ContractorName { get; set; }

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
        /// 发薪模式，有限枚举。 DIRECT_PAYMENT（直接发薪）
        /// </summary>
        [JsonPropertyName("pay_salary_mode_enum")]
        public string PaySalaryModeEnum { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 三方协议状态 1.SIGNED（已签约 2.TERMINATING(解约中) 3.TERMINATED(已解约)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 税优模式，有限枚举。1.TEMPORARY_TAX_REGISTRATION（临时税务登记 ）2. NATURAL_PERSON_LEVIED（自然人代征）
        /// </summary>
        [JsonPropertyName("tax_optimization_mode")]
        public string TaxOptimizationMode { get; set; }

        /// <summary>
        /// 解约时间
        /// </summary>
        [JsonPropertyName("termination_time")]
        public string TerminationTime { get; set; }
    }
}
