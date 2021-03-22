using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// LogisticsShopStatusDTO Data Structure.
    /// </summary>
    public class LogisticsShopStatusDTO : AlipayObject
    {
        /// <summary>
        /// 商家在配送公司的账户的审核说明.
        /// </summary>
        [JsonPropertyName("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 配送公司物流编码。
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司名称。
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
