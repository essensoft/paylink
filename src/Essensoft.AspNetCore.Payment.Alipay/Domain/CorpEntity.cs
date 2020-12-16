using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CorpEntity Data Structure.
    /// </summary>
    public class CorpEntity : AlipayObject
    {
        /// <summary>
        /// 经办人真实姓名
        /// </summary>
        [JsonPropertyName("agent_cert_name")]
        public string AgentCertName { get; set; }

        /// <summary>
        /// 经办人证件号(支持身份证号、护照号)
        /// </summary>
        [JsonPropertyName("agent_cert_no")]
        public string AgentCertNo { get; set; }

        /// <summary>
        /// 企业支付宝登录账号(邮箱或手机号)
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 企业统一社会信用编码
        /// </summary>
        [JsonPropertyName("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// xxx测试公司
        /// </summary>
        [JsonPropertyName("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 公司类型(MAIN:我方公司,作为签约方中我方的蚂蚁相关公司; RELA:对方公司)
        /// </summary>
        [JsonPropertyName("corp_type")]
        public string CorpType { get; set; }

        /// <summary>
        /// 法人真实姓名
        /// </summary>
        [JsonPropertyName("legal_cert_name")]
        public string LegalCertName { get; set; }

        /// <summary>
        /// 法人证件号(支持身份证号、护照号)
        /// </summary>
        [JsonPropertyName("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 签约通知邮箱
        /// </summary>
        [JsonPropertyName("notify_email")]
        public string NotifyEmail { get; set; }

        /// <summary>
        /// 签约通知人姓名
        /// </summary>
        [JsonPropertyName("notify_name")]
        public string NotifyName { get; set; }

        /// <summary>
        /// 2088支付宝账号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
