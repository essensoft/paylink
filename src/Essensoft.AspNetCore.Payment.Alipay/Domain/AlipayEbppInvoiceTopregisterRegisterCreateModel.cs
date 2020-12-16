using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterRegisterCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterRegisterCreateModel : AlipayObject
    {
        /// <summary>
        /// 创建工单请求
        /// </summary>
        [JsonPropertyName("create_request")]
        public InvoiceRegisterCreateDTO CreateRequest { get; set; }
    }
}
