using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsAccountInfo Data Structure.
    /// </summary>
    public class LogisticsAccountInfo : AlipayObject
    {
        /// <summary>
        /// 商家在配送公司的账户的审核说明
        /// </summary>
        [JsonPropertyName("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 商家在配送公司的账户id。
        /// </summary>
        [JsonPropertyName("logistics_account_id")]
        public string LogisticsAccountId { get; set; }

        /// <summary>
        /// 商家在配送公司的账户状态
        /// </summary>
        [JsonPropertyName("logistics_account_status")]
        public string LogisticsAccountStatus { get; set; }

        /// <summary>
        /// 商家的pid。
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
