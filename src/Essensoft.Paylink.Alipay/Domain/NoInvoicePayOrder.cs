using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// NoInvoicePayOrder Data Structure.
    /// </summary>
    public class NoInvoicePayOrder : AlipayObject
    {
        /// <summary>
        /// 账单单据号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
