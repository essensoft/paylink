using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvmodeCreateModel Data Structure.
    /// </summary>
    public class AlipayBossFncInvmodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 所属ou
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票模式 01：实收开票（先款后票） 02：应收开票（先票后款）
        /// </summary>
        [JsonPropertyName("invoice_mode")]
        public string InvoiceMode { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
