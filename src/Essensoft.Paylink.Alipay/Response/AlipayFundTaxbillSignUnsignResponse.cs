﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundTaxbillSignUnsignResponse.
    /// </summary>
    public class AlipayFundTaxbillSignUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 解约受理结果
        /// </summary>
        [JsonPropertyName("accept")]
        public bool Accept { get; set; }

        /// <summary>
        /// 用工企业和用户以及税筹ISV签订的三方协议的协议ID
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 三方协议状态 1.REGISTERED（已签约） 2.TERMINATED（已解约）
        /// </summary>
        [JsonPropertyName("agreement_status")]
        public string AgreementStatus { get; set; }

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
        /// 解约受理失败错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 解约受理失败原因
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

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

        /// <summary>
        /// 解约时间
        /// </summary>
        [JsonPropertyName("terminated_time")]
        public string TerminatedTime { get; set; }

        /// <summary>
        /// 用户在平台的会员状态 1. TAX_REGISTERED（完成税务注册）  2.CONTRACT_TERMINATED（用户已解约）
        /// </summary>
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; }
    }
}
