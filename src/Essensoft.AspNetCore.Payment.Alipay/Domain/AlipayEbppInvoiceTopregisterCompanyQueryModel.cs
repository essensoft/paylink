using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterCompanyQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterCompanyQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务平台Code,由发票中台分配
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 入驻工单ID
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }
    }
}
