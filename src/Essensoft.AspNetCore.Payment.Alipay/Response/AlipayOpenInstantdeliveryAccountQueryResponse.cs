using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountQueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账户余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 企业营业执照图片正反面
        /// </summary>
        [JsonPropertyName("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonPropertyName("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonPropertyName("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        [JsonPropertyName("enterprise_address")]
        public string EnterpriseAddress { get; set; }

        /// <summary>
        /// 企业所在地，市编码
        /// </summary>
        [JsonPropertyName("enterprise_city")]
        public string EnterpriseCity { get; set; }

        /// <summary>
        /// 企业所在地，区编码
        /// </summary>
        [JsonPropertyName("enterprise_district")]
        public string EnterpriseDistrict { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [JsonPropertyName("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业所在地，省编码
        /// </summary>
        [JsonPropertyName("enterprise_province")]
        public string EnterpriseProvince { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [JsonPropertyName("enterprise_type")]
        public string EnterpriseType { get; set; }

        /// <summary>
        /// 在配送公司的账户状态信息
        /// </summary>
        [JsonPropertyName("logistics_account_status")]
        public List<LogisticsAccountStatusDTO> LogisticsAccountStatus { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
